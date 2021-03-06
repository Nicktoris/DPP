﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MilSpace.DataAccess.DataTransfer;
using System.Text.RegularExpressions;

namespace MilSpace.Profile.SurfaceProfileChartControl
{
    public partial class SurfaceProfileChart : UserControl
    {
        private SurfaceProfileChartController _controller;
        private int _profileId;
        private bool _isCommentDisplay = false;
        private double _defaultChartHeight;
        private int _maxObserverHeightIndex = 0;
        private CheckBox _checkBoxHeader;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<ProfileProperties> ProfilesProperties { get; set; }
        public bool Current { get; set; }
        public int SelectedProfileIndex { get; set; }
        public List<double> ObserversHeights { get; set; }

        public SurfaceProfileChart(SurfaceProfileChartController controller)
        {
            Current = false;
            SelectedProfileIndex = -1;

            _controller = controller;
            ProfilesProperties = new List<ProfileProperties>();
            ObserversHeights = new List<double>();

            InitializeComponent();

            SetDetailsView();

            profilePropertiesTable.RowTemplate.Height = 18;
            profileChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        #region Initialization

        internal void InitializeGraph()
        {
            _controller.LoadSeries();
            _controller.SetProfilesProperties();

            foreach (var serie in profileChart.Series)
            {
                ObserversHeights.Add(0);
            }

            var fullHeights = new List<double>();

            for (int i = 0; i < ObserversHeights.Count; i++)
            {
                fullHeights.Add(GetObserverPointFullHeight(i));
            }

            _controller.AddInvisibleZones(fullHeights);
            _controller.AddExtremePoints();

            FillPropertiesTable();
            AddCheckBoxHeader();

            if (ProfilesProperties.Count == 1)
            {
                SelectProfile("1");
            }
        }

        internal void InitializeProfile(ProfileSession profileSession)
        {
            profileChart.Series.Clear();

            foreach (var line in profileSession.ProfileLines)
            {
                var profileSurface =
                    profileSession.ProfileSurfaces.First(surface => surface.LineId == line.Id);

                AddSerie(profileSurface);
            }

            _profileId = profileSession.SessionId;
        }

        internal void AddSerie(ProfileSurface profileSurface)
        {
            profileChart.Series.Add(new Series
            {
                ChartType = SeriesChartType.Line,
                Color = Color.ForestGreen,
                BackSecondaryColor = Color.Red,
                Name = profileSurface.LineId.ToString(),
                YValuesPerPoint = 1,
                IsVisibleInLegend = false,
                //TODO: Create  a local var to store profileSurface
                Tag = profileSurface
            });


            foreach (var point in profileSurface.ProfileSurfacePoints)
            {
                profileChart.Series.Last().Points.AddXY(point.Distance, point.Z);
            }
        }

        internal void AddInvisibleLine(ProfileSurface surface)
        {
            foreach (var point in surface.ProfileSurfacePoints)
            {
                profileChart.Series[surface.LineId.ToString()]
                        .Points
                        .FirstOrDefault(linePoint => (linePoint.XValue.Equals(point.Distance)))
                        .Color = profileChart.Series[surface.LineId.ToString()].BackSecondaryColor;
            }
        }

        internal void SetExtremePoints(List<ProfileSurfacePoint> extremePoints)
        {
            for (var i = 1; i < extremePoints.Count; i++)
            {
                AddExtremePoint(extremePoints[0], extremePoints[i], i);
            }
        }

        internal void AddExtremePoint(ProfileSurfacePoint observerPoint, ProfileSurfacePoint observationPoint, int order)
        {
            profileChart.Series.Add(new Series
            {
                ChartType = SeriesChartType.Line,
                Color = Color.DarkGray,
                Name = $"ExtremePointsLine{order}",
                YValuesPerPoint = 1,
                IsVisibleInLegend = false
            });

            profileChart.Series[$"ExtremePointsLine{order}"].BorderDashStyle = ChartDashStyle.Dash;

            profileChart.Series[$"ExtremePointsLine{order}"].Points.AddXY(observerPoint.Distance, observerPoint.Z);
            profileChart.Series[$"ExtremePointsLine{order}"].Points[0].MarkerStyle = MarkerStyle.Circle;

            profileChart.Series[$"ExtremePointsLine{order}"].Points.AddXY(observationPoint.Distance, observationPoint.Z);

            if (profileChart.Series[$"{order}"].Points.Last().Color == profileChart.Series[$"{order}"].BackSecondaryColor)
            {
                profileChart.Series[$"ExtremePointsLine{order}"].Points[1].MarkerColor = Color.Red;
            }
            profileChart.Series[$"ExtremePointsLine{order}"].Points[1].MarkerStyle = MarkerStyle.Circle;
        }

        private void FillPropertiesTable(List<ProfileProperties> properties = null)
        {
            if (properties == null)
            {
                properties = ProfilesProperties;
            }

            profilePropertiesTable.Rows.Clear();

            foreach (var profilesProperties in properties)
            {
                profilePropertiesTable.Rows.Add(
                            profileChart.Series[profilesProperties.LineId - 1].Enabled,
                            profilesProperties.LineId,
                            Math.Round(profilesProperties.Azimuth, 0),
                            Math.Round(ObserversHeights[profilesProperties.LineId - 1], 0),
                            Math.Round(profilesProperties.PathLength, 0),
                            Math.Round(profilesProperties.MinHeight, 0),
                            Math.Round(profilesProperties.MaxHeight, 0),
                            Math.Round(profilesProperties.MaxHeight - profilesProperties.MinHeight, 0),
                            Math.Round(profilesProperties.MinAngle, 0),
                            Math.Round(profilesProperties.MaxAngle, 0),
                            Math.Round(profilesProperties.VisiblePercent, 0));
            }
        }

        private void ShowDetails()
        {
            var surface = (ProfileSurface)profileChart.Series[SelectedProfileIndex].Tag;

            profileDetailsListView.Items.Clear();

            profileDetailsListView.Items.Add(CreateNewItem($"Состояние: ", ""));
            profileDetailsListView.Items.Add(CreateNewItem($"Номер: ", $"{SelectedProfileIndex + 1}"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Начало/конец: ",
                                        $"{Math.Round(surface.ProfileSurfacePoints[0].X, 5)};"
                                        + $"{Math.Round(surface.ProfileSurfacePoints[0].Y, 5)}"
                                        + $" - {Math.Round(surface.ProfileSurfacePoints.Last().X, 5)};"
                                        + $"{Math.Round(surface.ProfileSurfacePoints.Last().Y, 5)}"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Азимут:",
                                         $"{Math.Round(ProfilesProperties[SelectedProfileIndex].Azimuth, 1)}"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Длина:",
                                            $"{Math.Round(ProfilesProperties[SelectedProfileIndex].PathLength, 0)}м"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Высота:",
                                            $"{Math.Round(ProfilesProperties[SelectedProfileIndex].MinHeight, 0)}м"
                                            + $"-{Math.Round(ProfilesProperties[SelectedProfileIndex].MaxHeight, 0)}м"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Max угол подъема:",
                                        $"{Math.Round(ProfilesProperties[SelectedProfileIndex].MaxAngle, 1)}"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Max угол спуска: ",
                                        $"{Math.Round(ProfilesProperties[SelectedProfileIndex].MinAngle, 1)}"));
            profileDetailsListView.Items
                                    .Add(CreateNewItem($"Видимые зоны: ",
                                            $"{Math.Round(ProfilesProperties[SelectedProfileIndex].VisiblePercent, 2)}%"));
        }

        #endregion

        #region SetComponentsView

        internal void SetControlSize()
        {
            graphPanel.Width = Width - propertiesPanel.Width;
            graphPanel.Height = Height;

            profileChart.Width = graphPanel.Width - graphPanel.Padding.Right;
            profileChart.Height = graphPanel.Height - graphToolBar.Height;
        }

        private void AddCheckBoxHeader()
        {
            Rectangle checkBoxColumnRectangle = profilePropertiesTable.GetCellDisplayRectangle(0, -1, true);

            _checkBoxHeader = new CheckBox();

            _checkBoxHeader.Name = "checkBoxHeader";
            _checkBoxHeader.BackColor = profilePropertiesTable.ColumnHeadersDefaultCellStyle.BackColor;
            _checkBoxHeader.Size = new Size(15, 15);
            _checkBoxHeader.CheckState = CheckState.Checked;

            _checkBoxHeader.Location = new Point(checkBoxColumnRectangle.X + 4, checkBoxColumnRectangle.Y + 4);

            _checkBoxHeader.CheckedChanged += new EventHandler(CheckBoxHeader_CheckedChanged);

            profilePropertiesTable.Controls.Add(_checkBoxHeader);
        }

        private void SetProfileView()
        {
            profileChart.ChartAreas["Default"].AxisX.LabelStyle.Format = "#";
            profileChart.ChartAreas["Default"].AxisY.LabelStyle.Format = "#";

            profileChart.ChartAreas["Default"].Position = new ElementPosition(0, 4, 95, 90);
            profileChart.ChartAreas["Default"].InnerPlotPosition = new ElementPosition(6, 0, 94, 95);

            profileChart.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            profileChart.Size = this.Size;

            SetAxisView();
        }

        private void SetDetailsView()
        {
            profileDetailsListView.View = View.Details;

            profileDetailsListView.Columns.Add("Attribute", (int)(profileDetailsListView.Width * 0.3));
            profileDetailsListView.Columns.Add("Value", (profileDetailsListView.Width - profileDetailsListView.Columns[0].Width - 25));

            profileDetailsListView.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void SetAxisView()
        {
            SetAxisSizes();

            SetAxisInterval(profileChart.ChartAreas["Default"].AxisY);
            SetAxisInterval(profileChart.ChartAreas["Default"].AxisX);
        }

        private void SetAxisSizes()
        {
            if (ProfilesProperties.Count == 1)
            {
                profileChart.ChartAreas["Default"].AxisY.Maximum = ProfilesProperties[0].MaxHeight
                    + ProfilesProperties[0].MaxHeight / 10;
                profileChart.ChartAreas["Default"].AxisY.Minimum = ProfilesProperties[0].MinHeight
                    - ProfilesProperties[0].MaxHeight / 10;

                profileChart.ChartAreas["Default"].AxisX.Maximum = profileChart.Series[0].Points.Last().XValue
                  + profileChart.Series[0].Points.Last().XValue / 10;
            }
            else
            {
                double maxHeight = ProfilesProperties.Max(profileProperties => profileProperties.MaxHeight);
                double minHeight = ProfilesProperties.Min(profileProperties => profileProperties.MinHeight);
                double absHeight = maxHeight - minHeight;

                profileChart.ChartAreas["Default"].AxisY.Maximum = maxHeight + absHeight / 10;
                profileChart.ChartAreas["Default"].AxisY.Minimum = minHeight - absHeight / 10;


                double maxWidth = profileChart.Series.Max(serie => serie.Points.Last().XValue);

                profileChart.ChartAreas["Default"].AxisX.Maximum = maxWidth + maxWidth / 30;
            }

            SetAxisYMinValue();

            _defaultChartHeight = profileChart.ChartAreas["Default"].AxisY.Maximum;
        }

        private void SetAxisYMinValue()
        {
            var size = profileChart.ChartAreas["Default"].AxisY.Maximum
                             - profileChart.ChartAreas["Default"].AxisY.Minimum;

            if (size < 10)
            {
                profileChart.ChartAreas["Default"].AxisY.Minimum -=
               (profileChart.ChartAreas["Default"].AxisY.Minimum % 2);

                return;
            }

            if (profileChart.ChartAreas["Default"].AxisY.Minimum % 10 > 5)
            {
                profileChart.ChartAreas["Default"].AxisY.Minimum -=
               (profileChart.ChartAreas["Default"].AxisY.Minimum % 5);
            }
            else
            {
                profileChart.ChartAreas["Default"].AxisY.Minimum -=
               (profileChart.ChartAreas["Default"].AxisY.Minimum % 10);
            }
        }

        private void SetAxisInterval(Axis axis)
        {
            var axisSize = Math.Truncate(axis.Maximum - axis.Minimum);
            int intervalSize;

            if (axisSize <= 5)
            {
                axis.Interval = 1;
                return;
            }

            if (axisSize <= 10)
            {
                axis.Interval = 2;
                return;
            }

            if (axisSize <= 20)
            {
                axis.Interval = 5;
                return;
            }

            if (axisSize <= 50)
            {
                intervalSize = (int)Math.Truncate(axisSize / (axisSize / 10));
            }
            else
            {
                intervalSize = (int)Math.Truncate(axisSize / 5);
            }

            int intervalKoef;

            if (intervalSize <= 50)
            {
                intervalKoef = 10;
            }
            else if (intervalSize <= 250)
            {
                intervalKoef = 50;
            }
            else if (intervalSize <= 500)
            {
                intervalKoef = 100;
            }
            else if (intervalSize <= 1000)
            {
                intervalKoef = 200;
            }
            else if (intervalSize <= 2500)
            {
                intervalKoef = 500;
            }
            else
            {
                intervalKoef = 1000;
            }

            axis.Interval = intervalSize - (intervalSize % intervalKoef);
        }

        #endregion

        #region Updates

        private void UpdateExtremePoins(SeriesCollection series)
        {
            for (int i = 1; i < GetProfiles().Count() + 1; i++)
            {
                UpdateProfileExtremePoints(i);
            }
        }

        private void UpdateProfileExtremePoints(int index)
        {
            profileChart.Series[$"ExtremePointsLine{index}"].Points[0].SetValueY(GetObserverPointFullHeight(index - 1));

            double diff = GetObserverPointFullHeight(index - 1) - profileChart.ChartAreas["Default"].AxisY.Maximum;

            if (diff > 0)
            {
                double newHeight = profileChart.ChartAreas["Default"].AxisY.Maximum + diff;
                profileChart.ChartAreas["Default"].AxisY.Maximum =
                                        newHeight + (newHeight - profileChart.ChartAreas["Default"].AxisY.Minimum) / 10;

                SetAxisInterval(profileChart.ChartAreas["Default"].AxisY);

                _maxObserverHeightIndex = index - 1;
            }
            else
            {
                var fullHeights = new List<double>();
                int newMaxIndex = _maxObserverHeightIndex;

                for (int i = 0; i < ObserversHeights.Count; i++)
                {
                    fullHeights.Add(GetObserverPointFullHeight(i));

                    if (ObserversHeights[i] == ObserversHeights.Max())
                    {
                        newMaxIndex = i;
                    }
                }

                if (index - 1 == _maxObserverHeightIndex)
                {
                    profileChart.ChartAreas["Default"].AxisY.Maximum =
                                       fullHeights.Max() + (fullHeights.Max() - profileChart.ChartAreas["Default"].AxisY.Minimum) / 10;

                    _maxObserverHeightIndex = newMaxIndex;
                }

                if (fullHeights.Max() < _defaultChartHeight)
                {
                    profileChart.ChartAreas["Default"].AxisY.Maximum = _defaultChartHeight;
                }
            }

            SetAxisInterval(profileChart.ChartAreas["Default"].AxisY);

            if (profileChart.Series[$"{index}"].Points.Last().Color == profileChart.Series[$"{index}"].BackSecondaryColor)
            {
                profileChart.Series[$"ExtremePointsLine{index}"].Points[1].MarkerColor = Color.Red;
            }
            else
            {
                profileChart.Series[$"ExtremePointsLine{index}"].Points[1].MarkerColor = Color.DarkGray;
            }
        }

        private void UpdateProfiles(SeriesCollection series)
        {
            for (int i = 1; i < GetProfiles().Count() + 1; i++)
            {
                UpdateProfile(i);
            }
        }

        private void UpdateProfile(int index)
        {
            foreach (var point in profileChart.Series[$"{index}"].Points)
            {
                point.Color = profileChart.Series[$"{index}"].Color;
            }
        }

        private void UpdateProfileWithNewColor()
        {
            foreach (var point in profileChart.Series[SelectedProfileIndex].Points)
            {
                if (point.Color != profileChart.Series[SelectedProfileIndex].BackSecondaryColor)
                {
                    point.Color = profileChart.Series[SelectedProfileIndex].Color;
                }
            }
        }

        private void UpdateTableWithNewObserverHeigth(DataGridViewRowCollection rows)
        {
            for (int i = 0; i < profilePropertiesTable.Rows.Count; i++)
            {
                UpdateSelectedRowWithNewObserverHeigth(i);
            }
        }

        private void UpdateSelectedRowWithNewObserverHeigth(int index)
        {
            profilePropertiesTable.Rows[index].Cells["ObserverHeightCol"].Value
                                         = Math.Round(ObserversHeights[SelectedProfileIndex], 0);

            profilePropertiesTable.Rows[index].Cells["VisiblePercentCol"].Value
                                         = Math.Round(ProfilesProperties[(int)profilePropertiesTable
                                                                                .Rows[index]
                                                                                .Cells["ProfileNumberCol"]
                                                                                .Value - 1]
                                                        .VisiblePercent, 0);
        }

        #endregion

        #region ChangeObserverHeight

        private void ChangeAllProfilesObserverPointHeights(double height)
        {
            for (int i = 0; i < ObserversHeights.Count; i++)
            {
                ObserversHeights[i] = height;
            }

            UpdateProfiles(profileChart.Series);

            var fullHeights = new List<double>();

            for (int i = 0; i < ObserversHeights.Count; i++)
            {
                fullHeights.Add(GetObserverPointFullHeight(i));
            }

            _controller.AddInvisibleZones(fullHeights, GetSurfacesFromChart());
            UpdateExtremePoins(profileChart.Series);
            UpdateTableWithNewObserverHeigth(profilePropertiesTable.Rows);
        }

        private void ChangeOnlySelectedProfileObserverHeight(double height)
        {
            ObserversHeights[SelectedProfileIndex] = height;

            ProfileSurface[] profileSurfaces = GetSurfacesFromChart();

            UpdateProfile(SelectedProfileIndex + 1);
            _controller.AddInvisibleZone(GetObserverPointFullHeight(SelectedProfileIndex)
                                            , profileSurfaces[SelectedProfileIndex]);
            UpdateProfileExtremePoints(SelectedProfileIndex + 1);
            UpdateSelectedRowWithNewObserverHeigth(GetSelectedProfileRowIndex());
        }

        private bool ChangeObseverPointHeight(bool changeAll = false)
        {
            if (Regex.IsMatch(observerHeightTextBox.Text, @"^\d+[,|\.]?\d*$"))
            {
                if (SelectedProfileIndex != -1 && !changeAll)
                {
                    ChangeOnlySelectedProfileObserverHeight(Convert.ToDouble(observerHeightTextBox.Text.Replace('.', ',')));
                }
                else
                {
                    ChangeAllProfilesObserverPointHeights(Convert.ToDouble(observerHeightTextBox.Text.Replace('.', ',')));
                }

                return true;
            }

            return false;
        }

        #endregion

        #region Helpers

        private ProfileSurface[] GetSurfacesFromChart()
        {
            ProfileSurface[] profileSurfaces = new ProfileSurface[profileChart.Series.Count / 2];

            for (int i = 0; i < GetProfiles().Count(); i++)
            {
                profileSurfaces[i] = (ProfileSurface)profileChart.Series[i].Tag;
            }

            return profileSurfaces;
        }

        private List<Series> GetProfiles()
        {
            var profiles = new List<Series>();

            for (int i = 0; i < profileChart.Series.Count / 2; i++)
            {
                profiles.Add(profileChart.Series[i]);
            }

            return profiles;
        }

        private int GetSelectedProfileRowIndex()
        {
            foreach (DataGridViewRow row in profilePropertiesTable.Rows)
            {
                if ((int)row.Cells["ProfileNumberCol"].Value == (SelectedProfileIndex + 1))
                {
                    return row.Index;
                }
            }

            return -1;
        }

        private ListViewItem CreateNewItem(string mainText, string subText)
        {
            var newItem = new ListViewItem(mainText);
            newItem.SubItems.Add(subText);

            return newItem;
        }

        private double GetObserverPointFullHeight(int index)
        {
            return ObserversHeights[index] + profileChart.Series[index].Points[0].YValues[0];
        }

        #endregion

        #region Events

        private void SurfaceProfileChart_Load(object sender, EventArgs e)
        {
            SetProfileView();
        }

        private void CheckBoxHeader_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in profilePropertiesTable.Rows)
            {
                row.Cells["IsVisibleCol"].Value = _checkBoxHeader.Checked;
            }

            profilePropertiesTable.Rows[GetSelectedProfileRowIndex()].Cells["IsVisibleCol"].Value = true;
        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            var selectedPoint = profileChart.HitTest(e.X, e.Y);

            if (selectedPoint.ChartElementType == ChartElementType.DataPoint &&
                Regex.IsMatch(selectedPoint.Series.Name, @"^\d+$"))
            {
                //TODO:: Create a list outside the graph
                SelectProfile(selectedPoint.Series.Name);
            }
        }

        private void ProfileChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedPoint = profileChart.HitTest(e.X, e.Y);

            if (selectedPoint.ChartElementType == ChartElementType.DataPoint &&
                Regex.IsMatch(selectedPoint.Series.Name, @"^\d+$"))
            {
                if (selectedPoint.Series.Tag is ProfileSurface profileData)
                {
                    var point = profileData.ProfileSurfacePoints[selectedPoint.PointIndex];
                    _controller.InvokeOnProfileGraphClicked(point.X, point.Y);
                }
            }
        }

        private void SurfaceProfileChart_Resize(object sender, EventArgs e)
        {
            SetControlSize();
        }

        private void ObserverHeightTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ChangeObseverPointHeight())
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void PropertiesToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            //switch (e.Button.Name)
            //{
            //    case "changeAllProfilesObserverHeightToolBarBtn":
            //        ChangeProfileObserverHeight();
            //        break;
            //}
        }

        private void VisibleLineColorButton_Click(object sender, EventArgs e)
        {
            lineColorDialog.Color = profileChart.Series[SelectedProfileIndex].Color;

            if (lineColorDialog.ShowDialog() == DialogResult.OK)
            {
                profileChart.Series[SelectedProfileIndex].Color = lineColorDialog.Color;

                UpdateProfileWithNewColor();
                visibleLineColorButton.BackColor = lineColorDialog.Color;
            }
        }

        private void InvisibleLineColorButton_Click(object sender, EventArgs e)
        {
            lineColorDialog.Color = profileChart.Series[SelectedProfileIndex].BackSecondaryColor;

            if (lineColorDialog.ShowDialog() == DialogResult.OK)
            {
                profileChart.Series[SelectedProfileIndex].BackSecondaryColor = lineColorDialog.Color;
                invisibleLineColorButton.BackColor = lineColorDialog.Color;

                ProfileSurface[] profileSurfaces = GetSurfacesFromChart();

                UpdateProfile(SelectedProfileIndex + 1);
                _controller.AddInvisibleZone(GetObserverPointFullHeight(SelectedProfileIndex), profileSurfaces[SelectedProfileIndex]);
                UpdateProfileExtremePoints(SelectedProfileIndex + 1);
            }
        }

        private void GraphToolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            Axis axis = profileChart.ChartAreas["Default"].AxisX;

            switch (e.Button.Name)
            {
                case "displayProfileSignatureGraphToolBarBtn":

                    if (_isCommentDisplay == true)
                    {
                        foreach (var serie in GetProfiles())
                        {
                            serie.Points[(int)(serie.Points.Count / 2)].Label = String.Empty;
                        }
                    }
                    else
                    {
                        foreach (var serie in GetProfiles())
                        {
                            serie.Points[(int)(serie.Points.Count / 2)].Label = $"{serie.Name}";
                        }
                    }

                    _isCommentDisplay = !_isCommentDisplay;

                    break;

                case "deleteSelectedProfileGraphToolBarBtn":

                    DeleteSelectedProfile();

                    break;

                case "showAllProfilesGraphToolBarBtn":

                    axis.ScaleView.Position = 0;
                    axis.ScaleView.Size = axis.Maximum;

                    SetAxisInterval(axis);

                    break;

                case "zoomInGraphToolBarBtn":

                    if (double.IsNaN(axis.ScaleView.Size))
                    {
                        axis.ScaleView.Size = (axis.Maximum - axis.Minimum) / 2;
                    }
                    else
                    {
                        axis.ScaleView.Size /= 2;
                    }

                    if (axis.Interval > 2)
                    {
                        axis.Interval /= 2;
                        axis.Tag = axis.ScaleView.Size;
                    }

                    break;

                case "zoomOutGraphToolBarBtn":

                    if (axis.ScaleView.Size == axis.Maximum - axis.Minimum)
                    {
                        axis.ScaleView.Size = axis.Maximum;
                        axis.ScaleView.Position = 0;
                        break;
                    }

                    if (double.IsNaN(axis.ScaleView.Size))
                    {
                        axis.ScaleView.Size = axis.Maximum;
                    }
                    else
                    {
                        axis.ScaleView.Size *= 2;
                    }

                    if (axis.ScaleView.Size >= (double)axis.Tag)
                    {
                        axis.Interval *= 2;
                    }

                    break;

                case "deletePageGraphToolBarBtn":

                    _controller.RemoveCurrentTab();

                    break;

                case "saveGraphToolBarBtn":

                    SaveGraph();

                    break;
            }
        }

        private void ProfilePropertiesTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (profilePropertiesTable.Columns[e.ColumnIndex].Name == "IsVisibleCol")
            {
                var id = profilePropertiesTable.Rows[e.RowIndex].Cells["ProfileNumberCol"].Value.ToString();
                profileChart.Series[id].Enabled
                        = (Boolean)profilePropertiesTable.Rows[e.RowIndex].Cells["IsVisibleCol"].Value;

                profileChart.Series[$"ExtremePointsLine{id}"].Enabled =
                                     (Boolean)profilePropertiesTable.Rows[e.RowIndex].Cells["IsVisibleCol"].Value;
            }
        }

        private void ProfilePropertiesTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (profilePropertiesTable.IsCurrentCellDirty)
            {
                profilePropertiesTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ObserverHeightTextBox_Leave(object sender, EventArgs e)
        {
            ChangeObseverPointHeight();
        }

        private void ProfilePropertiesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (profilePropertiesTable.SelectedRows.Count > 0)
            {
                SelectProfile(profilePropertiesTable.SelectedRows[0].Cells["ProfileNumberCol"].Value.ToString());
            }
        }

        private void ProfileChart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            SetAxisInterval(e.Axis);
        }

        private void ChangeAllObserversHeightsButton_Click(object sender, EventArgs e)
        {
            ChangeObseverPointHeight(true);
        }

        private void ProfilePropertiesTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == profilePropertiesTable.Columns["AzimuthCol"].Index)
            {
                List<double> azimuths = ProfilesProperties.Select(profile => profile.Azimuth).ToList();
                azimuths.Sort();

                if (profilePropertiesTable.Columns["AzimuthCol"].Tag == "ASC")
                {
                    azimuths.Reverse();
                    profilePropertiesTable.Columns["AzimuthCol"].Tag = "DESC";
                }
                else
                {
                    profilePropertiesTable.Columns["AzimuthCol"].Tag = "ASC";
                }

                var sortedProperties = new List<ProfileProperties>();

                for (int i = 0; i < azimuths.Count; i++)
                {
                    var properties = ProfilesProperties.Where(profile => profile.Azimuth == azimuths[i]).ToList();

                    if (properties.Count() > 1)
                    {
                        foreach (var property in properties)
                        {
                            sortedProperties.Add(property);
                        }

                        i += (properties.Count() - 1);
                    }
                    else
                    {
                        sortedProperties.Add(properties[0]);
                    }
                }

                FillPropertiesTable(sortedProperties);
            }
        }

        private void ProfilePropertiesTable_Resize(object sender, EventArgs e)
        {
            propertiesPanel.Width = profilePropertiesTable.PreferredSize.Width
                                        + propertiesPanel.Padding.Right
                                        + propertiesPanel.Padding.Left;
        }

        #endregion

        private void SelectProfile(string serieName)
        {
            if (SelectedProfileIndex == profileChart.Series.IndexOf(serieName))
            {
                return;
            }

            if (SelectedProfileIndex != -1 && profileChart.Series.Count > 2)
            {
                profileChart.Series[SelectedProfileIndex].BorderWidth -= 2;
                profileChart.Series[SelectedProfileIndex].Font =
                                   new Font(profileChart.Series[SelectedProfileIndex].Font, FontStyle.Regular);
            }

            profileNameLabel.Text = $"Профиль: {_profileId}";
            SelectedProfileIndex = profileChart.Series.IndexOf(serieName);

            observerHeightTextBox.Text = ObserversHeights[SelectedProfileIndex].ToString();

            if (profileChart.Series.Count > 2)
            {
                profileChart.Series[SelectedProfileIndex].BorderWidth += 2;
                profileChart.Series[SelectedProfileIndex].Font =
                                    new Font(profileChart.Series[SelectedProfileIndex].Font, FontStyle.Bold);

                profilePropertiesTable.Rows[GetSelectedProfileRowIndex()].Selected = true;
            }

            ShowDetails();
            ShowColors();

            propertiesToolBar.Buttons[1].Enabled = true;
            propertiesToolBar.Buttons[2].Enabled = true;
            propertiesToolBar.Buttons[3].Enabled = true;

            invisibleLineColorButton.Enabled = true;
            visibleLineColorButton.Enabled = true;
        }

        private void ShowColors()
        {
            visibleLineColorButton.BackColor = profileChart.Series[SelectedProfileIndex].Color;
            invisibleLineColorButton.BackColor = profileChart.Series[SelectedProfileIndex].BackSecondaryColor;
        }

        private void DeleteSelectedProfile()
        {
            if (SelectedProfileIndex == -1)
            {
                return;
            }

            profileChart.Series.RemoveAt(SelectedProfileIndex);
            profileChart.Series.Remove(profileChart.Series[$"ExtremePointsLine{SelectedProfileIndex + 1}"]);

            profilePropertiesTable.Rows.RemoveAt(SelectedProfileIndex);

            SelectedProfileIndex = -1;
            SelectProfile("1");
        }

        private void SaveGraph()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "|*.png";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                profileChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }
        }
    }
}
