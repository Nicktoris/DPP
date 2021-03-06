﻿namespace MilSpace.Profile.SurfaceProfileChartControl
{
    partial class SurfaceProfileChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurfaceProfileChart));
            this.profileChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.profilePropertiesTable = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.propertiesToolBar = new System.Windows.Forms.ToolBar();
            this.leftPaddingSeparator = new System.Windows.Forms.ToolBarButton();
            this.panToProfileToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.dataExportToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.separateSelectedHandlerSeparator = new System.Windows.Forms.ToolBarButton();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.propertiesSettingsPanel = new System.Windows.Forms.Panel();
            this.changeAllObserversHeightsButton = new System.Windows.Forms.Button();
            this.observerHeightTextBox = new System.Windows.Forms.TextBox();
            this.observerHeightLabel = new System.Windows.Forms.Label();
            this.visibleLineColorButton = new System.Windows.Forms.Button();
            this.invisibleLineColorButton = new System.Windows.Forms.Button();
            this.visibleLineColorLabel = new System.Windows.Forms.Label();
            this.InvisibleLineColorLabel = new System.Windows.Forms.Label();
            this.profileDetailsListView = new System.Windows.Forms.ListView();
            this.graphToolBar = new System.Windows.Forms.ToolBar();
            this.leftGraphPaddingToolBarSpr = new System.Windows.Forms.ToolBarButton();
            this.displayProfileSignatureGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.deleteSelectedProfileGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.graphToolBarSpr1 = new System.Windows.Forms.ToolBarButton();
            this.panGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.graphToolBarSpr2 = new System.Windows.Forms.ToolBarButton();
            this.showAllProfilesGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.zoomInGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.zoomOutGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.graphToolBarSpr3 = new System.Windows.Forms.ToolBarButton();
            this.addPageGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.deletePageGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.toolBarSeparator19 = new System.Windows.Forms.ToolBarButton();
            this.saveGraphToolBarBtn = new System.Windows.Forms.ToolBarButton();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.IsVisibleCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProfileNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzimuthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObserverHeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileLengthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinHeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightDifferenceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinAngleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAngleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisiblePercentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.profileChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePropertiesTable)).BeginInit();
            this.propertiesPanel.SuspendLayout();
            this.propertiesSettingsPanel.SuspendLayout();
            this.graphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileChart
            // 
            chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            chartArea4.Name = "Default";
            this.profileChart.ChartAreas.Add(chartArea4);
            this.profileChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileChart.Location = new System.Drawing.Point(0, 0);
            this.profileChart.Name = "profileChart";
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.profileChart.Series.Add(series4);
            this.profileChart.Size = new System.Drawing.Size(498, 300);
            this.profileChart.TabIndex = 0;
            this.profileChart.Text = "chart1";
            this.profileChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProfileChart_MouseDoubleClick);
            this.profileChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profile_MouseDown);
            // 
            // profilePropertiesTable
            // 
            this.profilePropertiesTable.AllowUserToAddRows = false;
            this.profilePropertiesTable.AllowUserToDeleteRows = false;
            this.profilePropertiesTable.AllowUserToResizeRows = false;
            this.profilePropertiesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.profilePropertiesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profilePropertiesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.profilePropertiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profilePropertiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsVisibleCol,
            this.ProfileNumberCol,
            this.AzimuthCol,
            this.ObserverHeightCol,
            this.ProfileLengthCol,
            this.MinHeightCol,
            this.MaxHeightCol,
            this.HeightDifferenceCol,
            this.MinAngleCol,
            this.MaxAngleCol,
            this.VisiblePercentCol});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profilePropertiesTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.profilePropertiesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePropertiesTable.Location = new System.Drawing.Point(10, 0);
            this.profilePropertiesTable.MultiSelect = false;
            this.profilePropertiesTable.Name = "profilePropertiesTable";
            this.profilePropertiesTable.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.profilePropertiesTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.profilePropertiesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profilePropertiesTable.Size = new System.Drawing.Size(400, 127);
            this.profilePropertiesTable.TabIndex = 1;
            this.profilePropertiesTable.TabStop = false;
            this.profilePropertiesTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfilePropertiesTable_CellValueChanged);
            this.profilePropertiesTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProfilePropertiesTable_ColumnHeaderMouseClick);
            this.profilePropertiesTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.ProfilePropertiesTable_CurrentCellDirtyStateChanged);
            this.profilePropertiesTable.SelectionChanged += new System.EventHandler(this.ProfilePropertiesTable_SelectionChanged);
            this.profilePropertiesTable.Resize += new System.EventHandler(this.ProfilePropertiesTable_Resize);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "Alarme.png");
            this.imageList1.Images.SetKeyName(11, "Ampersand.png");
            this.imageList1.Images.SetKeyName(12, "Application.png");
            this.imageList1.Images.SetKeyName(13, "Applications.png");
            this.imageList1.Images.SetKeyName(14, "Arrow1 Down.png");
            this.imageList1.Images.SetKeyName(15, "Arrow1 DownLeft.png");
            this.imageList1.Images.SetKeyName(16, "Arrow1 DownRight.png");
            this.imageList1.Images.SetKeyName(17, "Arrow1 Left.png");
            this.imageList1.Images.SetKeyName(18, "Arrow1 Right.png");
            this.imageList1.Images.SetKeyName(19, "Arrow1 Up.png");
            this.imageList1.Images.SetKeyName(20, "Arrow1 UpLeft.png");
            this.imageList1.Images.SetKeyName(21, "Arrow1 UpRight.png");
            this.imageList1.Images.SetKeyName(22, "Arrow2 Down.png");
            this.imageList1.Images.SetKeyName(23, "Arrow2 DownLeft.png");
            this.imageList1.Images.SetKeyName(24, "Arrow2 DownRight.png");
            this.imageList1.Images.SetKeyName(25, "Arrow2 Left.png");
            this.imageList1.Images.SetKeyName(26, "Arrow2 Right.png");
            this.imageList1.Images.SetKeyName(27, "Arrow2 Up.png");
            this.imageList1.Images.SetKeyName(28, "Arrow2 UpLeft.png");
            this.imageList1.Images.SetKeyName(29, "Arrow2 UpRight.png");
            this.imageList1.Images.SetKeyName(30, "Arrow3 Down.png");
            this.imageList1.Images.SetKeyName(31, "Arrow3 Left.png");
            this.imageList1.Images.SetKeyName(32, "Arrow3 Right.png");
            this.imageList1.Images.SetKeyName(33, "Arrow3 Up.png");
            this.imageList1.Images.SetKeyName(34, "Attach.png");
            this.imageList1.Images.SetKeyName(35, "Audio Message.png");
            this.imageList1.Images.SetKeyName(36, "Back Top.png");
            this.imageList1.Images.SetKeyName(37, "Back.png");
            this.imageList1.Images.SetKeyName(38, "Bubble 1.png");
            this.imageList1.Images.SetKeyName(39, "Bubble 3.png");
            this.imageList1.Images.SetKeyName(40, "Burn.png");
            this.imageList1.Images.SetKeyName(41, "Calc.png");
            this.imageList1.Images.SetKeyName(42, "Calendar.png");
            this.imageList1.Images.SetKeyName(43, "Cancel.png");
            this.imageList1.Images.SetKeyName(44, "Car.png");
            this.imageList1.Images.SetKeyName(45, "Card1.png");
            this.imageList1.Images.SetKeyName(46, "Card2.png");
            this.imageList1.Images.SetKeyName(47, "Card3.png");
            this.imageList1.Images.SetKeyName(48, "Card4.png");
            this.imageList1.Images.SetKeyName(49, "Cart.png");
            this.imageList1.Images.SetKeyName(50, "Cart2.png");
            this.imageList1.Images.SetKeyName(51, "Cd.png");
            this.imageList1.Images.SetKeyName(52, "Clipboard Copy.png");
            this.imageList1.Images.SetKeyName(53, "Clipboard Cut.png");
            this.imageList1.Images.SetKeyName(54, "Clipboard Paste.png");
            this.imageList1.Images.SetKeyName(55, "Clock.png");
            this.imageList1.Images.SetKeyName(56, "Computer.png");
            this.imageList1.Images.SetKeyName(57, "Contact.png");
            this.imageList1.Images.SetKeyName(58, "Copyright.png");
            this.imageList1.Images.SetKeyName(59, "Cube.png");
            this.imageList1.Images.SetKeyName(60, "Currency Dollar.png");
            this.imageList1.Images.SetKeyName(61, "Currency Euro.png");
            this.imageList1.Images.SetKeyName(62, "Currency Pound.png");
            this.imageList1.Images.SetKeyName(63, "Database.png");
            this.imageList1.Images.SetKeyName(64, "Direction Diag1.png");
            this.imageList1.Images.SetKeyName(65, "Direction Diag2.png");
            this.imageList1.Images.SetKeyName(66, "Direction Horz.png");
            this.imageList1.Images.SetKeyName(67, "Direction Vert.png");
            this.imageList1.Images.SetKeyName(68, "Directions.png");
            this.imageList1.Images.SetKeyName(69, "Discuss.png");
            this.imageList1.Images.SetKeyName(70, "Document New.png");
            this.imageList1.Images.SetKeyName(71, "Document.png");
            this.imageList1.Images.SetKeyName(72, "Document2.png");
            this.imageList1.Images.SetKeyName(73, "Dots Down.png");
            this.imageList1.Images.SetKeyName(74, "Dots Up.png");
            this.imageList1.Images.SetKeyName(75, "Dots.png");
            this.imageList1.Images.SetKeyName(76, "Download.png");
            this.imageList1.Images.SetKeyName(77, "Email.png");
            this.imageList1.Images.SetKeyName(78, "Exclamation.png");
            this.imageList1.Images.SetKeyName(79, "Fbook.png");
            this.imageList1.Images.SetKeyName(80, "Flag.png");
            this.imageList1.Images.SetKeyName(81, "Folder.png");
            this.imageList1.Images.SetKeyName(82, "Folder2.png");
            this.imageList1.Images.SetKeyName(83, "Folder3.png");
            this.imageList1.Images.SetKeyName(84, "Footprint.png");
            this.imageList1.Images.SetKeyName(85, "Forbidden.png");
            this.imageList1.Images.SetKeyName(86, "Full Screen.png");
            this.imageList1.Images.SetKeyName(87, "Full Size.png");
            this.imageList1.Images.SetKeyName(88, "Game.png");
            this.imageList1.Images.SetKeyName(89, "Gear.png");
            this.imageList1.Images.SetKeyName(90, "Globe.png");
            this.imageList1.Images.SetKeyName(91, "Go In.png");
            this.imageList1.Images.SetKeyName(92, "Go Out.png");
            this.imageList1.Images.SetKeyName(93, "Graph.png");
            this.imageList1.Images.SetKeyName(94, "Hand.png");
            this.imageList1.Images.SetKeyName(95, "Hdd Network.png");
            this.imageList1.Images.SetKeyName(96, "Hdd.png");
            this.imageList1.Images.SetKeyName(97, "Health.png");
            this.imageList1.Images.SetKeyName(98, "Heart.png");
            this.imageList1.Images.SetKeyName(99, "Home.png");
            this.imageList1.Images.SetKeyName(100, "Home2.png");
            this.imageList1.Images.SetKeyName(101, "Info.png");
            this.imageList1.Images.SetKeyName(102, "Info2.png");
            this.imageList1.Images.SetKeyName(103, "Ipod.png");
            this.imageList1.Images.SetKeyName(104, "Key.png");
            this.imageList1.Images.SetKeyName(105, "Light.png");
            this.imageList1.Images.SetKeyName(106, "Link.png");
            this.imageList1.Images.SetKeyName(107, "Lock Open.png");
            this.imageList1.Images.SetKeyName(108, "Lock.png");
            this.imageList1.Images.SetKeyName(109, "Loop.png");
            this.imageList1.Images.SetKeyName(110, "Luggage.png");
            this.imageList1.Images.SetKeyName(111, "Mail.png");
            this.imageList1.Images.SetKeyName(112, "Man.png");
            this.imageList1.Images.SetKeyName(113, "Microphone.png");
            this.imageList1.Images.SetKeyName(114, "Minus.png");
            this.imageList1.Images.SetKeyName(115, "Mobile.png");
            this.imageList1.Images.SetKeyName(116, "Mouse.png");
            this.imageList1.Images.SetKeyName(117, "Movie.png");
            this.imageList1.Images.SetKeyName(118, "Music.png");
            this.imageList1.Images.SetKeyName(119, "Music2.png");
            this.imageList1.Images.SetKeyName(120, "Nuke.png");
            this.imageList1.Images.SetKeyName(121, "Ok.png");
            this.imageList1.Images.SetKeyName(122, "Paragraph.png");
            this.imageList1.Images.SetKeyName(123, "Percent.png");
            this.imageList1.Images.SetKeyName(124, "Phone.png");
            this.imageList1.Images.SetKeyName(125, "Photo.png");
            this.imageList1.Images.SetKeyName(126, "Picture.png");
            this.imageList1.Images.SetKeyName(127, "Player Eject.png");
            this.imageList1.Images.SetKeyName(128, "Player FastFwd.png");
            this.imageList1.Images.SetKeyName(129, "Player FastRev.png");
            this.imageList1.Images.SetKeyName(130, "Player Next.png");
            this.imageList1.Images.SetKeyName(131, "Player Pause.png");
            this.imageList1.Images.SetKeyName(132, "Player Play.png");
            this.imageList1.Images.SetKeyName(133, "Player Previous.png");
            this.imageList1.Images.SetKeyName(134, "Player Record.png");
            this.imageList1.Images.SetKeyName(135, "Player Stop.png");
            this.imageList1.Images.SetKeyName(136, "Plus.png");
            this.imageList1.Images.SetKeyName(137, "Podcast.png");
            this.imageList1.Images.SetKeyName(138, "Pointer.png");
            this.imageList1.Images.SetKeyName(139, "Poll.png");
            this.imageList1.Images.SetKeyName(140, "Printer.png");
            this.imageList1.Images.SetKeyName(141, "Puzzle.png");
            this.imageList1.Images.SetKeyName(142, "Question.png");
            this.imageList1.Images.SetKeyName(143, "Reduced Size.png");
            this.imageList1.Images.SetKeyName(144, "Refresh.png");
            this.imageList1.Images.SetKeyName(145, "Rss 1.png");
            this.imageList1.Images.SetKeyName(146, "Rss 2.png");
            this.imageList1.Images.SetKeyName(147, "Save.png");
            this.imageList1.Images.SetKeyName(148, "Screen.png");
            this.imageList1.Images.SetKeyName(149, "Search.png");
            this.imageList1.Images.SetKeyName(150, "Security.png");
            this.imageList1.Images.SetKeyName(151, "Sitemap.png");
            this.imageList1.Images.SetKeyName(152, "Size Diag1.png");
            this.imageList1.Images.SetKeyName(153, "Size Diag2.png");
            this.imageList1.Images.SetKeyName(154, "Size Horz.png");
            this.imageList1.Images.SetKeyName(155, "Size Vert.png");
            this.imageList1.Images.SetKeyName(156, "Sleep.png");
            this.imageList1.Images.SetKeyName(157, "Smiley1.png");
            this.imageList1.Images.SetKeyName(158, "Smiley2.png");
            this.imageList1.Images.SetKeyName(159, "Smiley3.png");
            this.imageList1.Images.SetKeyName(160, "Sound Minus.png");
            this.imageList1.Images.SetKeyName(161, "Sound Off.png");
            this.imageList1.Images.SetKeyName(162, "Sound On.png");
            this.imageList1.Images.SetKeyName(163, "Sound Plus.png");
            this.imageList1.Images.SetKeyName(164, "Standby.png");
            this.imageList1.Images.SetKeyName(165, "Star.png");
            this.imageList1.Images.SetKeyName(166, "Start.png");
            this.imageList1.Images.SetKeyName(167, "Stats 3.png");
            this.imageList1.Images.SetKeyName(168, "Stats.png");
            this.imageList1.Images.SetKeyName(169, "Stats2.png");
            this.imageList1.Images.SetKeyName(170, "Table.png");
            this.imageList1.Images.SetKeyName(171, "Tag.png");
            this.imageList1.Images.SetKeyName(172, "Tape.png");
            this.imageList1.Images.SetKeyName(173, "Target.png");
            this.imageList1.Images.SetKeyName(174, "Text Large.png");
            this.imageList1.Images.SetKeyName(175, "Text Meduim.png");
            this.imageList1.Images.SetKeyName(176, "Text Minus.png");
            this.imageList1.Images.SetKeyName(177, "Text Plus.png");
            this.imageList1.Images.SetKeyName(178, "Text Small.png");
            this.imageList1.Images.SetKeyName(179, "Thumb Down.png");
            this.imageList1.Images.SetKeyName(180, "Thumb Up.png");
            this.imageList1.Images.SetKeyName(181, "Tool.png");
            this.imageList1.Images.SetKeyName(182, "Tool2.png");
            this.imageList1.Images.SetKeyName(183, "Trackback.png");
            this.imageList1.Images.SetKeyName(184, "Trash.png");
            this.imageList1.Images.SetKeyName(185, "Travel.png");
            this.imageList1.Images.SetKeyName(186, "Tree.png");
            this.imageList1.Images.SetKeyName(187, "Tv.png");
            this.imageList1.Images.SetKeyName(188, "User.png");
            this.imageList1.Images.SetKeyName(189, "Video.png");
            this.imageList1.Images.SetKeyName(190, "Wait.png");
            this.imageList1.Images.SetKeyName(191, "Warning.png");
            this.imageList1.Images.SetKeyName(192, "Weather Cloud.png");
            this.imageList1.Images.SetKeyName(193, "Weather Could Sun.png");
            this.imageList1.Images.SetKeyName(194, "Weather Rain.png");
            this.imageList1.Images.SetKeyName(195, "Weather Snow.png");
            this.imageList1.Images.SetKeyName(196, "Weather Sun.png");
            this.imageList1.Images.SetKeyName(197, "Wizard.png");
            this.imageList1.Images.SetKeyName(198, "Woman.png");
            this.imageList1.Images.SetKeyName(199, "Wordpress.png");
            this.imageList1.Images.SetKeyName(200, "Write.png");
            this.imageList1.Images.SetKeyName(201, "Write2.png");
            this.imageList1.Images.SetKeyName(202, "Write3.png");
            this.imageList1.Images.SetKeyName(203, "Zoom In.png");
            this.imageList1.Images.SetKeyName(204, "Zoom Out.png");
            this.imageList1.Images.SetKeyName(205, "vector-path-line.png");
            this.imageList1.Images.SetKeyName(206, "Editing-Line-icon2.png");
            this.imageList1.Images.SetKeyName(207, "Icons8-Windows-8-Editing-Rectangle-Stroked.ico");
            this.imageList1.Images.SetKeyName(208, "Editing-Line-icon3.png");
            this.imageList1.Images.SetKeyName(209, "vector-polygon.png");
            this.imageList1.Images.SetKeyName(210, "load.png");
            this.imageList1.Images.SetKeyName(211, "Download.png");
            // 
            // propertiesToolBar
            // 
            this.propertiesToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.leftPaddingSeparator,
            this.panToProfileToolBarBtn,
            this.dataExportToolBarBtn,
            this.separateSelectedHandlerSeparator});
            this.propertiesToolBar.ButtonSize = new System.Drawing.Size(18, 18);
            this.propertiesToolBar.Divider = false;
            this.propertiesToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertiesToolBar.DropDownArrows = true;
            this.propertiesToolBar.ImageList = this.imageList1;
            this.propertiesToolBar.Location = new System.Drawing.Point(10, 301);
            this.propertiesToolBar.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesToolBar.Name = "propertiesToolBar";
            this.propertiesToolBar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.propertiesToolBar.ShowToolTips = true;
            this.propertiesToolBar.Size = new System.Drawing.Size(400, 26);
            this.propertiesToolBar.TabIndex = 43;
            this.propertiesToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.PropertiesToolBar_ButtonClick);
            // 
            // leftPaddingSeparator
            // 
            this.leftPaddingSeparator.Name = "leftPaddingSeparator";
            this.leftPaddingSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // panToProfileToolBarBtn
            // 
            this.panToProfileToolBarBtn.Enabled = false;
            this.panToProfileToolBarBtn.ImageKey = "Wizard.png";
            this.panToProfileToolBarBtn.Name = "panToProfileToolBarBtn";
            this.panToProfileToolBarBtn.ToolTipText = "Позиционирование на карте на выбраный профиль";
            // 
            // dataExportToolBarBtn
            // 
            this.dataExportToolBarBtn.Enabled = false;
            this.dataExportToolBarBtn.ImageKey = "Go Out.png";
            this.dataExportToolBarBtn.Name = "dataExportToolBarBtn";
            this.dataExportToolBarBtn.ToolTipText = "Экспорт данных выбранного профиля";
            // 
            // separateSelectedHandlerSeparator
            // 
            this.separateSelectedHandlerSeparator.Name = "separateSelectedHandlerSeparator";
            this.separateSelectedHandlerSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // lineColorDialog
            // 
            this.lineColorDialog.ShowHelp = true;
            this.lineColorDialog.SolidColorOnly = true;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.propertiesPanel.Controls.Add(this.profileNameLabel);
            this.propertiesPanel.Controls.Add(this.propertiesSettingsPanel);
            this.propertiesPanel.Controls.Add(this.profilePropertiesTable);
            this.propertiesPanel.Controls.Add(this.profileDetailsListView);
            this.propertiesPanel.Controls.Add(this.propertiesToolBar);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertiesPanel.Location = new System.Drawing.Point(524, 0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.propertiesPanel.Size = new System.Drawing.Size(420, 327);
            this.propertiesPanel.TabIndex = 49;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileNameLabel.Location = new System.Drawing.Point(13, 127);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.profileNameLabel.TabIndex = 49;
            // 
            // propertiesSettingsPanel
            // 
            this.propertiesSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesSettingsPanel.Controls.Add(this.changeAllObserversHeightsButton);
            this.propertiesSettingsPanel.Controls.Add(this.observerHeightTextBox);
            this.propertiesSettingsPanel.Controls.Add(this.observerHeightLabel);
            this.propertiesSettingsPanel.Controls.Add(this.visibleLineColorButton);
            this.propertiesSettingsPanel.Controls.Add(this.invisibleLineColorButton);
            this.propertiesSettingsPanel.Controls.Add(this.visibleLineColorLabel);
            this.propertiesSettingsPanel.Controls.Add(this.InvisibleLineColorLabel);
            this.propertiesSettingsPanel.Location = new System.Drawing.Point(10, 141);
            this.propertiesSettingsPanel.Name = "propertiesSettingsPanel";
            this.propertiesSettingsPanel.Padding = new System.Windows.Forms.Padding(2);
            this.propertiesSettingsPanel.Size = new System.Drawing.Size(400, 25);
            this.propertiesSettingsPanel.TabIndex = 52;
            // 
            // changeAllObserversHeightsButton
            // 
            this.changeAllObserversHeightsButton.ImageKey = "Direction Vert.png";
            this.changeAllObserversHeightsButton.ImageList = this.imageList1;
            this.changeAllObserversHeightsButton.Location = new System.Drawing.Point(183, 2);
            this.changeAllObserversHeightsButton.Name = "changeAllObserversHeightsButton";
            this.changeAllObserversHeightsButton.Size = new System.Drawing.Size(20, 20);
            this.changeAllObserversHeightsButton.TabIndex = 49;
            this.toolTip.SetToolTip(this.changeAllObserversHeightsButton, "Изменить высоту всех пунктов наблюдения");
            this.changeAllObserversHeightsButton.UseVisualStyleBackColor = true;
            this.changeAllObserversHeightsButton.Click += new System.EventHandler(this.ChangeAllObserversHeightsButton_Click);
            // 
            // observerHeightTextBox
            // 
            this.observerHeightTextBox.Location = new System.Drawing.Point(128, 2);
            this.observerHeightTextBox.Name = "observerHeightTextBox";
            this.observerHeightTextBox.Size = new System.Drawing.Size(50, 20);
            this.observerHeightTextBox.TabIndex = 39;
            this.observerHeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObserverHeightTextBox_KeyDown);
            this.observerHeightTextBox.Leave += new System.EventHandler(this.ObserverHeightTextBox_Leave);
            // 
            // observerHeightLabel
            // 
            this.observerHeightLabel.AutoSize = true;
            this.observerHeightLabel.Location = new System.Drawing.Point(3, 5);
            this.observerHeightLabel.Name = "observerHeightLabel";
            this.observerHeightLabel.Size = new System.Drawing.Size(119, 13);
            this.observerHeightLabel.TabIndex = 38;
            this.observerHeightLabel.Text = "Пункт наблюдения (м)";
            // 
            // visibleLineColorButton
            // 
            this.visibleLineColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visibleLineColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.visibleLineColorButton.Enabled = false;
            this.visibleLineColorButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.visibleLineColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibleLineColorButton.Location = new System.Drawing.Point(220, 8);
            this.visibleLineColorButton.Name = "visibleLineColorButton";
            this.visibleLineColorButton.Size = new System.Drawing.Size(30, 8);
            this.visibleLineColorButton.TabIndex = 47;
            this.visibleLineColorButton.UseVisualStyleBackColor = false;
            this.visibleLineColorButton.Click += new System.EventHandler(this.VisibleLineColorButton_Click);
            // 
            // invisibleLineColorButton
            // 
            this.invisibleLineColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invisibleLineColorButton.BackColor = System.Drawing.SystemColors.Control;
            this.invisibleLineColorButton.Enabled = false;
            this.invisibleLineColorButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.invisibleLineColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invisibleLineColorButton.Location = new System.Drawing.Point(311, 8);
            this.invisibleLineColorButton.Name = "invisibleLineColorButton";
            this.invisibleLineColorButton.Size = new System.Drawing.Size(30, 8);
            this.invisibleLineColorButton.TabIndex = 48;
            this.invisibleLineColorButton.UseVisualStyleBackColor = false;
            this.invisibleLineColorButton.Click += new System.EventHandler(this.InvisibleLineColorButton_Click);
            // 
            // visibleLineColorLabel
            // 
            this.visibleLineColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visibleLineColorLabel.AutoSize = true;
            this.visibleLineColorLabel.Location = new System.Drawing.Point(344, 5);
            this.visibleLineColorLabel.Name = "visibleLineColorLabel";
            this.visibleLineColorLabel.Size = new System.Drawing.Size(52, 13);
            this.visibleLineColorLabel.TabIndex = 44;
            this.visibleLineColorLabel.Text = "не видно";
            // 
            // InvisibleLineColorLabel
            // 
            this.InvisibleLineColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvisibleLineColorLabel.AutoSize = true;
            this.InvisibleLineColorLabel.Location = new System.Drawing.Point(256, 5);
            this.InvisibleLineColorLabel.Name = "InvisibleLineColorLabel";
            this.InvisibleLineColorLabel.Size = new System.Drawing.Size(37, 13);
            this.InvisibleLineColorLabel.TabIndex = 45;
            this.InvisibleLineColorLabel.Text = "видно";
            // 
            // profileDetailsListView
            // 
            this.profileDetailsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileDetailsListView.Location = new System.Drawing.Point(10, 166);
            this.profileDetailsListView.Name = "profileDetailsListView";
            this.profileDetailsListView.Size = new System.Drawing.Size(400, 135);
            this.profileDetailsListView.TabIndex = 50;
            this.profileDetailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // graphToolBar
            // 
            this.graphToolBar.AutoSize = false;
            this.graphToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.leftGraphPaddingToolBarSpr,
            this.displayProfileSignatureGraphToolBarBtn,
            this.deleteSelectedProfileGraphToolBarBtn,
            this.graphToolBarSpr1,
            this.panGraphToolBarBtn,
            this.graphToolBarSpr2,
            this.showAllProfilesGraphToolBarBtn,
            this.zoomInGraphToolBarBtn,
            this.zoomOutGraphToolBarBtn,
            this.graphToolBarSpr3,
            this.addPageGraphToolBarBtn,
            this.deletePageGraphToolBarBtn,
            this.toolBarSeparator19,
            this.saveGraphToolBarBtn});
            this.graphToolBar.ButtonSize = new System.Drawing.Size(18, 18);
            this.graphToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphToolBar.DropDownArrows = true;
            this.graphToolBar.ImageList = this.imageList1;
            this.graphToolBar.Location = new System.Drawing.Point(0, 296);
            this.graphToolBar.Name = "graphToolBar";
            this.graphToolBar.ShowToolTips = true;
            this.graphToolBar.Size = new System.Drawing.Size(498, 31);
            this.graphToolBar.TabIndex = 50;
            this.graphToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.GraphToolBar_ButtonClick);
            // 
            // leftGraphPaddingToolBarSpr
            // 
            this.leftGraphPaddingToolBarSpr.Name = "leftGraphPaddingToolBarSpr";
            this.leftGraphPaddingToolBarSpr.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // displayProfileSignatureGraphToolBarBtn
            // 
            this.displayProfileSignatureGraphToolBarBtn.ImageKey = "Bubble 3.png";
            this.displayProfileSignatureGraphToolBarBtn.Name = "displayProfileSignatureGraphToolBarBtn";
            this.displayProfileSignatureGraphToolBarBtn.ToolTipText = "Отобразить подписи профилей на графике";
            // 
            // deleteSelectedProfileGraphToolBarBtn
            // 
            this.deleteSelectedProfileGraphToolBarBtn.ImageKey = "Cancel.png";
            this.deleteSelectedProfileGraphToolBarBtn.Name = "deleteSelectedProfileGraphToolBarBtn";
            this.deleteSelectedProfileGraphToolBarBtn.ToolTipText = "Удалить выбраный профиль из отображения";
            // 
            // graphToolBarSpr1
            // 
            this.graphToolBarSpr1.Name = "graphToolBarSpr1";
            this.graphToolBarSpr1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // panGraphToolBarBtn
            // 
            this.panGraphToolBarBtn.ImageKey = "Wizard.png";
            this.panGraphToolBarBtn.Name = "panGraphToolBarBtn";
            this.panGraphToolBarBtn.ToolTipText = "Включение режима синхронизации положения, при котором указание точки на выбранном" +
    " профиле подсвечивает соответствующую точку на карте";
            // 
            // graphToolBarSpr2
            // 
            this.graphToolBarSpr2.Name = "graphToolBarSpr2";
            this.graphToolBarSpr2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // showAllProfilesGraphToolBarBtn
            // 
            this.showAllProfilesGraphToolBarBtn.ImageKey = "Full Screen.png";
            this.showAllProfilesGraphToolBarBtn.Name = "showAllProfilesGraphToolBarBtn";
            this.showAllProfilesGraphToolBarBtn.ToolTipText = "Показать все профили на графике полностью";
            // 
            // zoomInGraphToolBarBtn
            // 
            this.zoomInGraphToolBarBtn.ImageKey = "Zoom In.png";
            this.zoomInGraphToolBarBtn.Name = "zoomInGraphToolBarBtn";
            this.zoomInGraphToolBarBtn.ToolTipText = "Уменьшить масштаб по расстоянию";
            // 
            // zoomOutGraphToolBarBtn
            // 
            this.zoomOutGraphToolBarBtn.ImageKey = "Zoom Out.png";
            this.zoomOutGraphToolBarBtn.Name = "zoomOutGraphToolBarBtn";
            this.zoomOutGraphToolBarBtn.ToolTipText = "Увеличить масштаб по расстоянию";
            // 
            // graphToolBarSpr3
            // 
            this.graphToolBarSpr3.Name = "graphToolBarSpr3";
            this.graphToolBarSpr3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // addPageGraphToolBarBtn
            // 
            this.addPageGraphToolBarBtn.ImageKey = "Plus.png";
            this.addPageGraphToolBarBtn.Name = "addPageGraphToolBarBtn";
            this.addPageGraphToolBarBtn.ToolTipText = "Добавить страницу графиков профилей";
            // 
            // deletePageGraphToolBarBtn
            // 
            this.deletePageGraphToolBarBtn.ImageKey = "Trash.png";
            this.deletePageGraphToolBarBtn.Name = "deletePageGraphToolBarBtn";
            this.deletePageGraphToolBarBtn.ToolTipText = "Удалить вкладку";
            // 
            // toolBarSeparator19
            // 
            this.toolBarSeparator19.Name = "toolBarSeparator19";
            this.toolBarSeparator19.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // saveGraphToolBarBtn
            // 
            this.saveGraphToolBarBtn.ImageKey = "Save.png";
            this.saveGraphToolBarBtn.Name = "saveGraphToolBarBtn";
            this.saveGraphToolBarBtn.ToolTipText = "Сохранить изображения графа и данные";
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.profileChart);
            this.graphPanel.Controls.Add(this.graphToolBar);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.graphPanel.Location = new System.Drawing.Point(0, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(498, 327);
            this.graphPanel.TabIndex = 51;
            // 
            // IsVisibleCol
            // 
            this.IsVisibleCol.HeaderText = "IV";
            this.IsVisibleCol.Name = "IsVisibleCol";
            this.IsVisibleCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsVisibleCol.ToolTipText = "Показать/скрыть профиль";
            this.IsVisibleCol.Width = 20;
            // 
            // ProfileNumberCol
            // 
            this.ProfileNumberCol.HeaderText = "N";
            this.ProfileNumberCol.Name = "ProfileNumberCol";
            this.ProfileNumberCol.ReadOnly = true;
            this.ProfileNumberCol.ToolTipText = "Номер профиля";
            this.ProfileNumberCol.Width = 30;
            // 
            // AzimuthCol
            // 
            this.AzimuthCol.HeaderText = "AZ";
            this.AzimuthCol.Name = "AzimuthCol";
            this.AzimuthCol.ReadOnly = true;
            this.AzimuthCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.AzimuthCol.ToolTipText = "Азимут направления от пункта наблюдения к последней точке профиля";
            this.AzimuthCol.Width = 40;
            // 
            // ObserverHeightCol
            // 
            this.ObserverHeightCol.HeaderText = "OH";
            this.ObserverHeightCol.Name = "ObserverHeightCol";
            this.ObserverHeightCol.ReadOnly = true;
            this.ObserverHeightCol.ToolTipText = "Высота пункта наблюдения (м)";
            this.ObserverHeightCol.Width = 40;
            // 
            // ProfileLengthCol
            // 
            this.ProfileLengthCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProfileLengthCol.HeaderText = "L";
            this.ProfileLengthCol.Name = "ProfileLengthCol";
            this.ProfileLengthCol.ReadOnly = true;
            this.ProfileLengthCol.ToolTipText = "Длина профиля (м)";
            // 
            // MinHeightCol
            // 
            this.MinHeightCol.HeaderText = "MnH";
            this.MinHeightCol.Name = "MinHeightCol";
            this.MinHeightCol.ReadOnly = true;
            this.MinHeightCol.ToolTipText = "Минимальная высота (м)";
            this.MinHeightCol.Width = 35;
            // 
            // MaxHeightCol
            // 
            this.MaxHeightCol.HeaderText = "MxH";
            this.MaxHeightCol.Name = "MaxHeightCol";
            this.MaxHeightCol.ReadOnly = true;
            this.MaxHeightCol.ToolTipText = "Максимальная высота (м)";
            this.MaxHeightCol.Width = 35;
            // 
            // HeightDifferenceCol
            // 
            this.HeightDifferenceCol.HeaderText = "DH";
            this.HeightDifferenceCol.Name = "HeightDifferenceCol";
            this.HeightDifferenceCol.ReadOnly = true;
            this.HeightDifferenceCol.ToolTipText = "Разница высот (м)";
            this.HeightDifferenceCol.Width = 35;
            // 
            // MinAngleCol
            // 
            this.MinAngleCol.HeaderText = "MnA";
            this.MinAngleCol.Name = "MinAngleCol";
            this.MinAngleCol.ReadOnly = true;
            this.MinAngleCol.ToolTipText = "Максимальный угол спуска (градусы)";
            this.MinAngleCol.Width = 35;
            // 
            // MaxAngleCol
            // 
            this.MaxAngleCol.HeaderText = "MxA";
            this.MaxAngleCol.Name = "MaxAngleCol";
            this.MaxAngleCol.ReadOnly = true;
            this.MaxAngleCol.ToolTipText = "Максимальный угол подъема (графусы)";
            this.MaxAngleCol.Width = 35;
            // 
            // VisiblePercentCol
            // 
            this.VisiblePercentCol.HeaderText = "VP";
            this.VisiblePercentCol.Name = "VisiblePercentCol";
            this.VisiblePercentCol.ReadOnly = true;
            this.VisiblePercentCol.ToolTipText = "Процент видимых участков";
            this.VisiblePercentCol.Width = 35;
            // 
            // SurfaceProfileChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.propertiesPanel);
            this.Name = "SurfaceProfileChart";
            this.Size = new System.Drawing.Size(944, 327);
            this.Load += new System.EventHandler(this.SurfaceProfileChart_Load);
            this.Resize += new System.EventHandler(this.SurfaceProfileChart_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.profileChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePropertiesTable)).EndInit();
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            this.propertiesSettingsPanel.ResumeLayout(false);
            this.propertiesSettingsPanel.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart profileChart;
        private System.Windows.Forms.DataGridView profilePropertiesTable;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar propertiesToolBar;
        private System.Windows.Forms.ToolBarButton changeObserverHeightToolBarBtn;
        private System.Windows.Forms.ToolBarButton panToProfileToolBarBtn;
        private System.Windows.Forms.ToolBarButton dataExportToolBarBtn;
        private System.Windows.Forms.ToolBarButton changeOnlySelectedObserverHeightToolBarBtn;
        private System.Windows.Forms.ColorDialog lineColorDialog;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.ToolBarButton separateSelectedHandlerSeparator;
        private System.Windows.Forms.ToolBar graphToolBar;
        private System.Windows.Forms.ToolBarButton leftPaddingGraphSeparator;
        private System.Windows.Forms.ToolBarButton selectProfileToolBarBtn;
        private System.Windows.Forms.ToolBarButton displayProfilesSignaturesToolBarBtn;
        private System.Windows.Forms.ToolBarButton removeSelectedProfileToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSeparator1;
        private System.Windows.Forms.ToolBarButton synchronizationToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSeparator3;
        private System.Windows.Forms.ToolBarButton updateGraphDisplayToolBarBtn;
        private System.Windows.Forms.ToolBarButton profilesFullDisplayToolBarBtn;
        private System.Windows.Forms.ToolBarButton zoomInToolBarBtn;
        private System.Windows.Forms.ToolBarButton zoomOutToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSeparator2;
        private System.Windows.Forms.ToolBarButton addGraphPageToolBarBtn;
        private System.Windows.Forms.ToolBarButton deletePageToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSeparator4;
        private System.Windows.Forms.ToolBarButton createReportToolBarBtn;
        private System.Windows.Forms.ToolBarButton saveGraphAsImageToolBarBtn;
        private System.Windows.Forms.ToolBarButton leftPaddingSeparator;
        private System.Windows.Forms.ToolBarButton leftGraphPaddingToolBarSpr;
        private System.Windows.Forms.ToolBarButton displayProfileSignatureGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton deleteSelectedProfileGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSpr1;
        private System.Windows.Forms.ToolBarButton panGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSpr2;
        private System.Windows.Forms.ToolBarButton showAllProfilesGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton zoomInGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton zoomOutGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSpr3;
        private System.Windows.Forms.ToolBarButton addPageGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton deletePageGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton graphToolBarSpr4;
        private System.Windows.Forms.ToolBarButton saveGraphToolBarBtn;
        private System.Windows.Forms.ToolBarButton toolBarSeparator19;
        private System.Windows.Forms.ListView profileDetailsListView;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.TextBox observerHeightTextBox;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Button visibleLineColorButton;
        private System.Windows.Forms.Label visibleLineColorLabel;
        private System.Windows.Forms.Label InvisibleLineColorLabel;
        private System.Windows.Forms.Button invisibleLineColorButton;
        private System.Windows.Forms.Label observerHeightLabel;
        private System.Windows.Forms.Panel propertiesSettingsPanel;
        private System.Windows.Forms.Button changeAllObserversHeightsButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVisibleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzimuthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObserverHeightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileLengthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinHeightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxHeightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightDifferenceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinAngleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAngleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisiblePercentCol;
    }
}
