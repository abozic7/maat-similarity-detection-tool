namespace DIPL_Projekt
{
    partial class frmMainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.taskListResultsPerPageComboBox = new System.Windows.Forms.ComboBox();
            this.taskListResultsPerPageLabel = new System.Windows.Forms.Label();
            this.taskListStatusStrip = new System.Windows.Forms.StatusStrip();
            this.taskListStatusStripPageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskListStatusStripNoOfTasks = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskListLastPageBtn = new System.Windows.Forms.Button();
            this.taskListNextPageBtn = new System.Windows.Forms.Button();
            this.taskListPreviousPageBtn = new System.Windows.Forms.Button();
            this.taskListFirstPageBtn = new System.Windows.Forms.Button();
            this.taskListGrid = new System.Windows.Forms.DataGridView();
            this.TaskListTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListTaskCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListTaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListTaskCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListNoOfStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListNoOfFilesLoaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskListTaskAddFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaskListAlgorithmParameters = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaskListTaskResults = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaskListDeleteTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskListNewTaskBtn = new System.Windows.Forms.Button();
            this.taskDetailsPanel = new System.Windows.Forms.Panel();
            this.taskDetailsGenerateExcelReport = new System.Windows.Forms.Button();
            this.taskDetailsThresholdTxtBox = new System.Windows.Forms.TextBox();
            this.taskDetailsThresholdLabel = new System.Windows.Forms.Label();
            this.taskDetailsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.taskDetailsStatusStripTaskName = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskDetailsStatusStripPageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskDetailsStatusStripNoOfResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskDetailsResultsPerPageComboBox = new System.Windows.Forms.ComboBox();
            this.taskDetailsResultsPerPageLabel = new System.Windows.Forms.Label();
            this.taskDetailsLastPageBtn = new System.Windows.Forms.Button();
            this.taskDetailsNextPageBtn = new System.Windows.Forms.Button();
            this.taskDetailsPreviousPageBtn = new System.Windows.Forms.Button();
            this.taskDetailsFirstPageBtn = new System.Windows.Forms.Button();
            this.taskDetailsReturnToTaskListBtn = new System.Windows.Forms.Button();
            this.taskDetailsScanResultsGridView = new System.Windows.Forms.DataGridView();
            this.ScanResultsJMBAG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanResultsFile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanResultsJMBAG2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanResultsFile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanResultsSimilarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanResultsViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createTaskPanel = new System.Windows.Forms.Panel();
            this.createTaskCreateTaskBtn = new System.Windows.Forms.Button();
            this.createTaskCancelBtn = new System.Windows.Forms.Button();
            this.createTaskDescTxtBox = new System.Windows.Forms.TextBox();
            this.createTaskCourseTxtBox = new System.Windows.Forms.TextBox();
            this.createTaskDescriptionLabel = new System.Windows.Forms.Label();
            this.createTaskCourseLabel = new System.Windows.Forms.Label();
            this.createTaskNameTxtBox = new System.Windows.Forms.TextBox();
            this.createTaskNameLabel = new System.Windows.Forms.Label();
            this.algorithmParameterAdjustmentPanel = new System.Windows.Forms.Panel();
            this.algorithmParameterAdjustmentStatusStrip = new System.Windows.Forms.StatusStrip();
            this.algorithmParameterAdjustmentTaskName = new System.Windows.Forms.ToolStripStatusLabel();
            this.algorithmParameterAdjustmentPropertiesComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmParameterAdjustmentWinnowingComboBox = new System.Windows.Forms.ComboBox();
            this.algorithmParameterAdjustmentPropertiesLabel = new System.Windows.Forms.Label();
            this.algorithmParameterAdjustmentCancelBtn = new System.Windows.Forms.Button();
            this.algorithmParameterAdjustmentSaveBtn = new System.Windows.Forms.Button();
            this.algorithmParameterAdjustmentWindowSizeTxtBox = new System.Windows.Forms.TextBox();
            this.algorithmParameterAdjustmentKGramLengthTxtBox = new System.Windows.Forms.TextBox();
            this.algorithmParameterAdjustmentWinnowingLabel = new System.Windows.Forms.Label();
            this.algorithmParameterAdjustmentWindowSizeLabel = new System.Windows.Forms.Label();
            this.algorithmParameterAdjustmentKGramLengthLabel = new System.Windows.Forms.Label();
            this.addFilesPanel = new System.Windows.Forms.Panel();
            this.addFilesStatusStrip = new System.Windows.Forms.StatusStrip();
            this.addFilesStatusStripTaskName = new System.Windows.Forms.ToolStripStatusLabel();
            this.addFilesStatusStripPageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.addFilesStatusStripNoOfFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.addFilesResultsPerPageLabel = new System.Windows.Forms.Label();
            this.addFilesResultsPerPageComboBox = new System.Windows.Forms.ComboBox();
            this.addFilesLastPageBtn = new System.Windows.Forms.Button();
            this.addFilesNextPageBtn = new System.Windows.Forms.Button();
            this.addFilesPreviousPageBtn = new System.Windows.Forms.Button();
            this.addFilesFirstPageBtn = new System.Windows.Forms.Button();
            this.addFilesCancelBtn = new System.Windows.Forms.Button();
            this.addFilesSaveBtn = new System.Windows.Forms.Button();
            this.addFilesAddManyAuthorsArchivesBtn = new System.Windows.Forms.Button();
            this.addFilesFileListGridView = new System.Windows.Forms.DataGridView();
            this.AddFilesFileListJMBAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListCheckSumBeforePreprocessing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListCheckSumAfterPreprocessing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListFileContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFilesFileListRemoveBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addFilesFileListLabel = new System.Windows.Forms.Label();
            this.similarFilesComparisonPanel = new System.Windows.Forms.Panel();
            this.similarFilesComparisonFileInfo2Panel = new System.Windows.Forms.Panel();
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonHashAfterPreprocessing2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonHashBeforePreprocessing2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfBlockComments2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfBlockComments2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfLineComments2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfLineComments2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfEmptyLines2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfEmptyLines2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfLines2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfLines2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileSize2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileSize2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileName2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileAuthor2TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileName2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileAuthor2Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileInfo1Panel = new System.Windows.Forms.Panel();
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfBlockComments1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfLineComments1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfEmptyLines1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonNoOfLines1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileSize1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonHashAfterPreprocessing1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonHashBeforePreprocessing1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfBlockComments1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfLineComments1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfEmptyLines1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonNoOfLines1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileSize1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileName1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileAuthor1TxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonFileName1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonFileAuthor1Label = new System.Windows.Forms.Label();
            this.similarFilesComparisonResultsPanel = new System.Windows.Forms.Panel();
            this.similarFilesComparisonFinishOverviewBtn = new System.Windows.Forms.Button();
            this.similarFilesComparisonSimilarityTxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonSimilarityLabel = new System.Windows.Forms.Label();
            this.similarFilesComparisonPropertiesResultsTxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonCheckSumResultsTxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonWinnowingResultsTxtBox = new System.Windows.Forms.TextBox();
            this.similarFilesComparisonPropertiesResultsLabel = new System.Windows.Forms.Label();
            this.similarFilesComparisonCheckSumResultsLabel = new System.Windows.Forms.Label();
            this.similarFilesComparisonWinnowingResultsLabel = new System.Windows.Forms.Label();
            this.algorithmParameterAdjustmentCheckSumCheckBox = new System.Windows.Forms.CheckBox();
            this.taskListPanel.SuspendLayout();
            this.taskListStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).BeginInit();
            this.taskDetailsPanel.SuspendLayout();
            this.taskDetailsStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDetailsScanResultsGridView)).BeginInit();
            this.createTaskPanel.SuspendLayout();
            this.algorithmParameterAdjustmentPanel.SuspendLayout();
            this.algorithmParameterAdjustmentStatusStrip.SuspendLayout();
            this.addFilesPanel.SuspendLayout();
            this.addFilesStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFilesFileListGridView)).BeginInit();
            this.similarFilesComparisonPanel.SuspendLayout();
            this.similarFilesComparisonFileInfo2Panel.SuspendLayout();
            this.similarFilesComparisonFileInfo1Panel.SuspendLayout();
            this.similarFilesComparisonResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListPanel
            // 
            this.taskListPanel.Controls.Add(this.taskListResultsPerPageComboBox);
            this.taskListPanel.Controls.Add(this.taskListResultsPerPageLabel);
            this.taskListPanel.Controls.Add(this.taskListStatusStrip);
            this.taskListPanel.Controls.Add(this.taskListLastPageBtn);
            this.taskListPanel.Controls.Add(this.taskListNextPageBtn);
            this.taskListPanel.Controls.Add(this.taskListPreviousPageBtn);
            this.taskListPanel.Controls.Add(this.taskListFirstPageBtn);
            this.taskListPanel.Controls.Add(this.taskListGrid);
            this.taskListPanel.Controls.Add(this.taskListNewTaskBtn);
            this.taskListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListPanel.Location = new System.Drawing.Point(0, 0);
            this.taskListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Size = new System.Drawing.Size(899, 513);
            this.taskListPanel.TabIndex = 0;
            // 
            // taskListResultsPerPageComboBox
            // 
            this.taskListResultsPerPageComboBox.FormattingEnabled = true;
            this.taskListResultsPerPageComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.taskListResultsPerPageComboBox.Location = new System.Drawing.Point(183, 12);
            this.taskListResultsPerPageComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListResultsPerPageComboBox.Name = "taskListResultsPerPageComboBox";
            this.taskListResultsPerPageComboBox.Size = new System.Drawing.Size(48, 24);
            this.taskListResultsPerPageComboBox.TabIndex = 10;
            this.taskListResultsPerPageComboBox.Text = "50";
            this.taskListResultsPerPageComboBox.SelectedIndexChanged += new System.EventHandler(this.TaskListResultsPerPageComboBox_SelectedIndexChanged);
            // 
            // taskListResultsPerPageLabel
            // 
            this.taskListResultsPerPageLabel.AutoSize = true;
            this.taskListResultsPerPageLabel.Location = new System.Drawing.Point(12, 15);
            this.taskListResultsPerPageLabel.Name = "taskListResultsPerPageLabel";
            this.taskListResultsPerPageLabel.Size = new System.Drawing.Size(165, 17);
            this.taskListResultsPerPageLabel.TabIndex = 9;
            this.taskListResultsPerPageLabel.Text = "Broj rezultata po stranici:";
            // 
            // taskListStatusStrip
            // 
            this.taskListStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.taskListStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskListStatusStripPageInfo,
            this.taskListStatusStripNoOfTasks});
            this.taskListStatusStrip.Location = new System.Drawing.Point(0, 487);
            this.taskListStatusStrip.Name = "taskListStatusStrip";
            this.taskListStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.taskListStatusStrip.Size = new System.Drawing.Size(899, 26);
            this.taskListStatusStrip.TabIndex = 8;
            this.taskListStatusStrip.Text = "taskListStatusStrip";
            // 
            // taskListStatusStripPageInfo
            // 
            this.taskListStatusStripPageInfo.Name = "taskListStatusStripPageInfo";
            this.taskListStatusStripPageInfo.Size = new System.Drawing.Size(65, 20);
            this.taskListStatusStripPageInfo.Text = "Stranica:";
            // 
            // taskListStatusStripNoOfTasks
            // 
            this.taskListStatusStripNoOfTasks.Name = "taskListStatusStripNoOfTasks";
            this.taskListStatusStripNoOfTasks.Size = new System.Drawing.Size(103, 20);
            this.taskListStatusStripNoOfTasks.Text = "Broj zadataka:";
            // 
            // taskListLastPageBtn
            // 
            this.taskListLastPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskListLastPageBtn.Location = new System.Drawing.Point(503, 452);
            this.taskListLastPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListLastPageBtn.Name = "taskListLastPageBtn";
            this.taskListLastPageBtn.Size = new System.Drawing.Size(165, 34);
            this.taskListLastPageBtn.TabIndex = 7;
            this.taskListLastPageBtn.Text = "Zadnja stranica";
            this.taskListLastPageBtn.UseVisualStyleBackColor = true;
            this.taskListLastPageBtn.Click += new System.EventHandler(this.TaskListLastPageBtn_Click);
            // 
            // taskListNextPageBtn
            // 
            this.taskListNextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskListNextPageBtn.Location = new System.Drawing.Point(336, 452);
            this.taskListNextPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListNextPageBtn.Name = "taskListNextPageBtn";
            this.taskListNextPageBtn.Size = new System.Drawing.Size(161, 34);
            this.taskListNextPageBtn.TabIndex = 6;
            this.taskListNextPageBtn.Text = "Sljedeća stranica";
            this.taskListNextPageBtn.UseVisualStyleBackColor = true;
            this.taskListNextPageBtn.Click += new System.EventHandler(this.TaskListNextPageBtn_Click);
            // 
            // taskListPreviousPageBtn
            // 
            this.taskListPreviousPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskListPreviousPageBtn.Location = new System.Drawing.Point(164, 452);
            this.taskListPreviousPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListPreviousPageBtn.Name = "taskListPreviousPageBtn";
            this.taskListPreviousPageBtn.Size = new System.Drawing.Size(165, 34);
            this.taskListPreviousPageBtn.TabIndex = 5;
            this.taskListPreviousPageBtn.Text = "Prethodna stranica";
            this.taskListPreviousPageBtn.UseVisualStyleBackColor = true;
            this.taskListPreviousPageBtn.Click += new System.EventHandler(this.TaskListPreviousPageBtn_Click);
            // 
            // taskListFirstPageBtn
            // 
            this.taskListFirstPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskListFirstPageBtn.Location = new System.Drawing.Point(12, 452);
            this.taskListFirstPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListFirstPageBtn.Name = "taskListFirstPageBtn";
            this.taskListFirstPageBtn.Size = new System.Drawing.Size(147, 34);
            this.taskListFirstPageBtn.TabIndex = 4;
            this.taskListFirstPageBtn.Text = "Prva stranica";
            this.taskListFirstPageBtn.UseVisualStyleBackColor = true;
            this.taskListFirstPageBtn.Click += new System.EventHandler(this.TaskListFirstPageBtn_Click);
            // 
            // taskListGrid
            // 
            this.taskListGrid.AllowUserToAddRows = false;
            this.taskListGrid.AllowUserToDeleteRows = false;
            this.taskListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskListGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.taskListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskListTaskName,
            this.TaskListTaskCourse,
            this.TaskListTaskDescription,
            this.TaskListTaskCreatedDate,
            this.TaskListNoOfStudents,
            this.TaskListNoOfFilesLoaded,
            this.TaskListTaskAddFile,
            this.TaskListAlgorithmParameters,
            this.TaskListTaskResults,
            this.TaskListDeleteTask});
            this.taskListGrid.Location = new System.Drawing.Point(12, 52);
            this.taskListGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListGrid.Name = "taskListGrid";
            this.taskListGrid.RowHeadersWidth = 51;
            this.taskListGrid.RowTemplate.Height = 24;
            this.taskListGrid.Size = new System.Drawing.Size(875, 394);
            this.taskListGrid.TabIndex = 1;
            // 
            // TaskListTaskName
            // 
            this.TaskListTaskName.HeaderText = "Naziv";
            this.TaskListTaskName.MinimumWidth = 6;
            this.TaskListTaskName.Name = "TaskListTaskName";
            this.TaskListTaskName.ReadOnly = true;
            // 
            // TaskListTaskCourse
            // 
            this.TaskListTaskCourse.HeaderText = "Kolegij";
            this.TaskListTaskCourse.MinimumWidth = 6;
            this.TaskListTaskCourse.Name = "TaskListTaskCourse";
            this.TaskListTaskCourse.ReadOnly = true;
            // 
            // TaskListTaskDescription
            // 
            this.TaskListTaskDescription.HeaderText = "Opis";
            this.TaskListTaskDescription.MinimumWidth = 6;
            this.TaskListTaskDescription.Name = "TaskListTaskDescription";
            this.TaskListTaskDescription.ReadOnly = true;
            // 
            // TaskListTaskCreatedDate
            // 
            this.TaskListTaskCreatedDate.HeaderText = "Datum kreiranja";
            this.TaskListTaskCreatedDate.MinimumWidth = 6;
            this.TaskListTaskCreatedDate.Name = "TaskListTaskCreatedDate";
            this.TaskListTaskCreatedDate.ReadOnly = true;
            // 
            // TaskListNoOfStudents
            // 
            this.TaskListNoOfStudents.HeaderText = "Broj studenata";
            this.TaskListNoOfStudents.MinimumWidth = 6;
            this.TaskListNoOfStudents.Name = "TaskListNoOfStudents";
            this.TaskListNoOfStudents.ReadOnly = true;
            // 
            // TaskListNoOfFilesLoaded
            // 
            this.TaskListNoOfFilesLoaded.HeaderText = "Broj učitanih datoteka";
            this.TaskListNoOfFilesLoaded.MinimumWidth = 6;
            this.TaskListNoOfFilesLoaded.Name = "TaskListNoOfFilesLoaded";
            this.TaskListNoOfFilesLoaded.ReadOnly = true;
            // 
            // TaskListTaskAddFile
            // 
            this.TaskListTaskAddFile.HeaderText = "Dodaj datoteke";
            this.TaskListTaskAddFile.MinimumWidth = 6;
            this.TaskListTaskAddFile.Name = "TaskListTaskAddFile";
            // 
            // TaskListAlgorithmParameters
            // 
            this.TaskListAlgorithmParameters.HeaderText = "Odredi parametre";
            this.TaskListAlgorithmParameters.MinimumWidth = 6;
            this.TaskListAlgorithmParameters.Name = "TaskListAlgorithmParameters";
            // 
            // TaskListTaskResults
            // 
            this.TaskListTaskResults.HeaderText = "Rezultati";
            this.TaskListTaskResults.MinimumWidth = 6;
            this.TaskListTaskResults.Name = "TaskListTaskResults";
            // 
            // TaskListDeleteTask
            // 
            this.TaskListDeleteTask.HeaderText = "Obriši";
            this.TaskListDeleteTask.MinimumWidth = 6;
            this.TaskListDeleteTask.Name = "TaskListDeleteTask";
            // 
            // taskListNewTaskBtn
            // 
            this.taskListNewTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskListNewTaskBtn.Location = new System.Drawing.Point(757, 12);
            this.taskListNewTaskBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListNewTaskBtn.MaximumSize = new System.Drawing.Size(200, 34);
            this.taskListNewTaskBtn.Name = "taskListNewTaskBtn";
            this.taskListNewTaskBtn.Size = new System.Drawing.Size(129, 34);
            this.taskListNewTaskBtn.TabIndex = 2;
            this.taskListNewTaskBtn.Text = "Novi zadatak";
            this.taskListNewTaskBtn.UseVisualStyleBackColor = true;
            this.taskListNewTaskBtn.Click += new System.EventHandler(this.TaskListNewTaskBtn_Click);
            // 
            // taskDetailsPanel
            // 
            this.taskDetailsPanel.Controls.Add(this.taskDetailsGenerateExcelReport);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsThresholdTxtBox);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsThresholdLabel);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsStatusStrip);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsResultsPerPageComboBox);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsResultsPerPageLabel);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsLastPageBtn);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsNextPageBtn);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsPreviousPageBtn);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsFirstPageBtn);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsReturnToTaskListBtn);
            this.taskDetailsPanel.Controls.Add(this.taskDetailsScanResultsGridView);
            this.taskDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.taskDetailsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsPanel.Name = "taskDetailsPanel";
            this.taskDetailsPanel.Size = new System.Drawing.Size(899, 513);
            this.taskDetailsPanel.TabIndex = 3;
            this.taskDetailsPanel.Visible = false;
            // 
            // taskDetailsGenerateExcelReport
            // 
            this.taskDetailsGenerateExcelReport.Location = new System.Drawing.Point(684, 5);
            this.taskDetailsGenerateExcelReport.Name = "taskDetailsGenerateExcelReport";
            this.taskDetailsGenerateExcelReport.Size = new System.Drawing.Size(204, 31);
            this.taskDetailsGenerateExcelReport.TabIndex = 20;
            this.taskDetailsGenerateExcelReport.Text = "Generiraj .xlsx izvještaj";
            this.taskDetailsGenerateExcelReport.UseVisualStyleBackColor = true;
            this.taskDetailsGenerateExcelReport.Click += new System.EventHandler(this.taskDetailsGenerateExcelReport_Click);
            // 
            // taskDetailsThresholdTxtBox
            // 
            this.taskDetailsThresholdTxtBox.Location = new System.Drawing.Point(336, 12);
            this.taskDetailsThresholdTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsThresholdTxtBox.Name = "taskDetailsThresholdTxtBox";
            this.taskDetailsThresholdTxtBox.Size = new System.Drawing.Size(73, 22);
            this.taskDetailsThresholdTxtBox.TabIndex = 19;
            this.taskDetailsThresholdTxtBox.Text = "0";
            this.taskDetailsThresholdTxtBox.TextChanged += new System.EventHandler(this.TaskDetailsThresholdTxtBox_TextChanged);
            // 
            // taskDetailsThresholdLabel
            // 
            this.taskDetailsThresholdLabel.AutoSize = true;
            this.taskDetailsThresholdLabel.Location = new System.Drawing.Point(253, 15);
            this.taskDetailsThresholdLabel.Name = "taskDetailsThresholdLabel";
            this.taskDetailsThresholdLabel.Size = new System.Drawing.Size(76, 17);
            this.taskDetailsThresholdLabel.TabIndex = 18;
            this.taskDetailsThresholdLabel.Text = "Threshold:";
            // 
            // taskDetailsStatusStrip
            // 
            this.taskDetailsStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.taskDetailsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskDetailsStatusStripTaskName,
            this.taskDetailsStatusStripPageInfo,
            this.taskDetailsStatusStripNoOfResults});
            this.taskDetailsStatusStrip.Location = new System.Drawing.Point(0, 487);
            this.taskDetailsStatusStrip.Name = "taskDetailsStatusStrip";
            this.taskDetailsStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.taskDetailsStatusStrip.Size = new System.Drawing.Size(899, 26);
            this.taskDetailsStatusStrip.TabIndex = 17;
            this.taskDetailsStatusStrip.Text = "statusStrip1";
            // 
            // taskDetailsStatusStripTaskName
            // 
            this.taskDetailsStatusStripTaskName.Name = "taskDetailsStatusStripTaskName";
            this.taskDetailsStatusStripTaskName.Size = new System.Drawing.Size(66, 20);
            this.taskDetailsStatusStripTaskName.Text = "Zadatak:";
            // 
            // taskDetailsStatusStripPageInfo
            // 
            this.taskDetailsStatusStripPageInfo.Name = "taskDetailsStatusStripPageInfo";
            this.taskDetailsStatusStripPageInfo.Size = new System.Drawing.Size(65, 20);
            this.taskDetailsStatusStripPageInfo.Text = "Stranica:";
            // 
            // taskDetailsStatusStripNoOfResults
            // 
            this.taskDetailsStatusStripNoOfResults.Name = "taskDetailsStatusStripNoOfResults";
            this.taskDetailsStatusStripNoOfResults.Size = new System.Drawing.Size(101, 20);
            this.taskDetailsStatusStripNoOfResults.Text = "Broj rezultata:";
            // 
            // taskDetailsResultsPerPageComboBox
            // 
            this.taskDetailsResultsPerPageComboBox.FormattingEnabled = true;
            this.taskDetailsResultsPerPageComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.taskDetailsResultsPerPageComboBox.Location = new System.Drawing.Point(183, 12);
            this.taskDetailsResultsPerPageComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsResultsPerPageComboBox.Name = "taskDetailsResultsPerPageComboBox";
            this.taskDetailsResultsPerPageComboBox.Size = new System.Drawing.Size(47, 24);
            this.taskDetailsResultsPerPageComboBox.TabIndex = 16;
            this.taskDetailsResultsPerPageComboBox.Text = "50";
            this.taskDetailsResultsPerPageComboBox.SelectedIndexChanged += new System.EventHandler(this.TaskDetailsResultsPerPageComboBox_SelectedIndexChanged);
            // 
            // taskDetailsResultsPerPageLabel
            // 
            this.taskDetailsResultsPerPageLabel.AutoSize = true;
            this.taskDetailsResultsPerPageLabel.Location = new System.Drawing.Point(12, 15);
            this.taskDetailsResultsPerPageLabel.Name = "taskDetailsResultsPerPageLabel";
            this.taskDetailsResultsPerPageLabel.Size = new System.Drawing.Size(165, 17);
            this.taskDetailsResultsPerPageLabel.TabIndex = 15;
            this.taskDetailsResultsPerPageLabel.Text = "Broj rezultata po stranici:";
            // 
            // taskDetailsLastPageBtn
            // 
            this.taskDetailsLastPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDetailsLastPageBtn.Location = new System.Drawing.Point(479, 452);
            this.taskDetailsLastPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsLastPageBtn.Name = "taskDetailsLastPageBtn";
            this.taskDetailsLastPageBtn.Size = new System.Drawing.Size(149, 34);
            this.taskDetailsLastPageBtn.TabIndex = 13;
            this.taskDetailsLastPageBtn.Text = "Zadnja stranica";
            this.taskDetailsLastPageBtn.UseVisualStyleBackColor = true;
            this.taskDetailsLastPageBtn.Click += new System.EventHandler(this.TaskDetailsLastPageBtn_Click);
            // 
            // taskDetailsNextPageBtn
            // 
            this.taskDetailsNextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDetailsNextPageBtn.Location = new System.Drawing.Point(323, 452);
            this.taskDetailsNextPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsNextPageBtn.Name = "taskDetailsNextPageBtn";
            this.taskDetailsNextPageBtn.Size = new System.Drawing.Size(149, 34);
            this.taskDetailsNextPageBtn.TabIndex = 12;
            this.taskDetailsNextPageBtn.Text = "Sljedeća stranica";
            this.taskDetailsNextPageBtn.UseVisualStyleBackColor = true;
            this.taskDetailsNextPageBtn.Click += new System.EventHandler(this.TaskDetailsNextPageBtn_Click);
            // 
            // taskDetailsPreviousPageBtn
            // 
            this.taskDetailsPreviousPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDetailsPreviousPageBtn.Location = new System.Drawing.Point(147, 452);
            this.taskDetailsPreviousPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsPreviousPageBtn.Name = "taskDetailsPreviousPageBtn";
            this.taskDetailsPreviousPageBtn.Size = new System.Drawing.Size(171, 34);
            this.taskDetailsPreviousPageBtn.TabIndex = 11;
            this.taskDetailsPreviousPageBtn.Text = "Prethodna stranica";
            this.taskDetailsPreviousPageBtn.UseVisualStyleBackColor = true;
            this.taskDetailsPreviousPageBtn.Click += new System.EventHandler(this.TaskDetailsPreviousPageBtn_Click);
            // 
            // taskDetailsFirstPageBtn
            // 
            this.taskDetailsFirstPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taskDetailsFirstPageBtn.Location = new System.Drawing.Point(12, 452);
            this.taskDetailsFirstPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsFirstPageBtn.Name = "taskDetailsFirstPageBtn";
            this.taskDetailsFirstPageBtn.Size = new System.Drawing.Size(129, 34);
            this.taskDetailsFirstPageBtn.TabIndex = 10;
            this.taskDetailsFirstPageBtn.Text = "Prva stranica";
            this.taskDetailsFirstPageBtn.UseVisualStyleBackColor = true;
            this.taskDetailsFirstPageBtn.Click += new System.EventHandler(this.TaskDetailsFirstPageBtn_Click);
            // 
            // taskDetailsReturnToTaskListBtn
            // 
            this.taskDetailsReturnToTaskListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDetailsReturnToTaskListBtn.Location = new System.Drawing.Point(667, 452);
            this.taskDetailsReturnToTaskListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsReturnToTaskListBtn.Name = "taskDetailsReturnToTaskListBtn";
            this.taskDetailsReturnToTaskListBtn.Size = new System.Drawing.Size(220, 34);
            this.taskDetailsReturnToTaskListBtn.TabIndex = 9;
            this.taskDetailsReturnToTaskListBtn.Text = "Povratak na listu zadataka";
            this.taskDetailsReturnToTaskListBtn.UseVisualStyleBackColor = true;
            this.taskDetailsReturnToTaskListBtn.Click += new System.EventHandler(this.TaskDetailsReturnToTaskListBtn_Click);
            // 
            // taskDetailsScanResultsGridView
            // 
            this.taskDetailsScanResultsGridView.AllowUserToAddRows = false;
            this.taskDetailsScanResultsGridView.AllowUserToDeleteRows = false;
            this.taskDetailsScanResultsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDetailsScanResultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskDetailsScanResultsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.taskDetailsScanResultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDetailsScanResultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScanResultsJMBAG1,
            this.ScanResultsFile1,
            this.ScanResultsJMBAG2,
            this.ScanResultsFile2,
            this.ScanResultsSimilarity,
            this.ScanResultsViewDetails});
            this.taskDetailsScanResultsGridView.Location = new System.Drawing.Point(12, 39);
            this.taskDetailsScanResultsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDetailsScanResultsGridView.Name = "taskDetailsScanResultsGridView";
            this.taskDetailsScanResultsGridView.RowHeadersWidth = 51;
            this.taskDetailsScanResultsGridView.RowTemplate.Height = 24;
            this.taskDetailsScanResultsGridView.Size = new System.Drawing.Size(875, 406);
            this.taskDetailsScanResultsGridView.TabIndex = 8;
            // 
            // ScanResultsJMBAG1
            // 
            this.ScanResultsJMBAG1.HeaderText = "JMBAG1";
            this.ScanResultsJMBAG1.MinimumWidth = 6;
            this.ScanResultsJMBAG1.Name = "ScanResultsJMBAG1";
            this.ScanResultsJMBAG1.ReadOnly = true;
            // 
            // ScanResultsFile1
            // 
            this.ScanResultsFile1.HeaderText = "Datoteka1";
            this.ScanResultsFile1.MinimumWidth = 6;
            this.ScanResultsFile1.Name = "ScanResultsFile1";
            this.ScanResultsFile1.ReadOnly = true;
            // 
            // ScanResultsJMBAG2
            // 
            this.ScanResultsJMBAG2.HeaderText = "JMBAG2";
            this.ScanResultsJMBAG2.MinimumWidth = 6;
            this.ScanResultsJMBAG2.Name = "ScanResultsJMBAG2";
            this.ScanResultsJMBAG2.ReadOnly = true;
            // 
            // ScanResultsFile2
            // 
            this.ScanResultsFile2.HeaderText = "Datoteka2";
            this.ScanResultsFile2.MinimumWidth = 6;
            this.ScanResultsFile2.Name = "ScanResultsFile2";
            this.ScanResultsFile2.ReadOnly = true;
            // 
            // ScanResultsSimilarity
            // 
            this.ScanResultsSimilarity.HeaderText = "Sličnost";
            this.ScanResultsSimilarity.MinimumWidth = 6;
            this.ScanResultsSimilarity.Name = "ScanResultsSimilarity";
            this.ScanResultsSimilarity.ReadOnly = true;
            // 
            // ScanResultsViewDetails
            // 
            this.ScanResultsViewDetails.HeaderText = "Detalji";
            this.ScanResultsViewDetails.MinimumWidth = 6;
            this.ScanResultsViewDetails.Name = "ScanResultsViewDetails";
            // 
            // createTaskPanel
            // 
            this.createTaskPanel.Controls.Add(this.createTaskCreateTaskBtn);
            this.createTaskPanel.Controls.Add(this.createTaskCancelBtn);
            this.createTaskPanel.Controls.Add(this.createTaskDescTxtBox);
            this.createTaskPanel.Controls.Add(this.createTaskCourseTxtBox);
            this.createTaskPanel.Controls.Add(this.createTaskDescriptionLabel);
            this.createTaskPanel.Controls.Add(this.createTaskCourseLabel);
            this.createTaskPanel.Controls.Add(this.createTaskNameTxtBox);
            this.createTaskPanel.Controls.Add(this.createTaskNameLabel);
            this.createTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTaskPanel.Location = new System.Drawing.Point(0, 0);
            this.createTaskPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskPanel.Name = "createTaskPanel";
            this.createTaskPanel.Size = new System.Drawing.Size(899, 513);
            this.createTaskPanel.TabIndex = 16;
            this.createTaskPanel.Visible = false;
            // 
            // createTaskCreateTaskBtn
            // 
            this.createTaskCreateTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createTaskCreateTaskBtn.Location = new System.Drawing.Point(733, 468);
            this.createTaskCreateTaskBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskCreateTaskBtn.Name = "createTaskCreateTaskBtn";
            this.createTaskCreateTaskBtn.Size = new System.Drawing.Size(155, 34);
            this.createTaskCreateTaskBtn.TabIndex = 8;
            this.createTaskCreateTaskBtn.Text = "Stvori zadatak";
            this.createTaskCreateTaskBtn.UseVisualStyleBackColor = true;
            this.createTaskCreateTaskBtn.Click += new System.EventHandler(this.CreateTaskCreateTaskBtn_Click);
            // 
            // createTaskCancelBtn
            // 
            this.createTaskCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createTaskCancelBtn.Location = new System.Drawing.Point(603, 468);
            this.createTaskCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskCancelBtn.Name = "createTaskCancelBtn";
            this.createTaskCancelBtn.Size = new System.Drawing.Size(124, 34);
            this.createTaskCancelBtn.TabIndex = 6;
            this.createTaskCancelBtn.Text = "Odustani";
            this.createTaskCancelBtn.UseVisualStyleBackColor = true;
            this.createTaskCancelBtn.Click += new System.EventHandler(this.CreateTaskCancelBtn_Click);
            // 
            // createTaskDescTxtBox
            // 
            this.createTaskDescTxtBox.Location = new System.Drawing.Point(59, 68);
            this.createTaskDescTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskDescTxtBox.Name = "createTaskDescTxtBox";
            this.createTaskDescTxtBox.Size = new System.Drawing.Size(209, 22);
            this.createTaskDescTxtBox.TabIndex = 5;
            // 
            // createTaskCourseTxtBox
            // 
            this.createTaskCourseTxtBox.Location = new System.Drawing.Point(72, 39);
            this.createTaskCourseTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskCourseTxtBox.Name = "createTaskCourseTxtBox";
            this.createTaskCourseTxtBox.Size = new System.Drawing.Size(197, 22);
            this.createTaskCourseTxtBox.TabIndex = 4;
            // 
            // createTaskDescriptionLabel
            // 
            this.createTaskDescriptionLabel.AutoSize = true;
            this.createTaskDescriptionLabel.Location = new System.Drawing.Point(12, 71);
            this.createTaskDescriptionLabel.Name = "createTaskDescriptionLabel";
            this.createTaskDescriptionLabel.Size = new System.Drawing.Size(41, 17);
            this.createTaskDescriptionLabel.TabIndex = 3;
            this.createTaskDescriptionLabel.Text = "Opis:";
            // 
            // createTaskCourseLabel
            // 
            this.createTaskCourseLabel.AutoSize = true;
            this.createTaskCourseLabel.Location = new System.Drawing.Point(12, 43);
            this.createTaskCourseLabel.Name = "createTaskCourseLabel";
            this.createTaskCourseLabel.Size = new System.Drawing.Size(54, 17);
            this.createTaskCourseLabel.TabIndex = 2;
            this.createTaskCourseLabel.Text = "Kolegij:";
            // 
            // createTaskNameTxtBox
            // 
            this.createTaskNameTxtBox.Location = new System.Drawing.Point(65, 12);
            this.createTaskNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTaskNameTxtBox.Name = "createTaskNameTxtBox";
            this.createTaskNameTxtBox.Size = new System.Drawing.Size(204, 22);
            this.createTaskNameTxtBox.TabIndex = 1;
            // 
            // createTaskNameLabel
            // 
            this.createTaskNameLabel.AutoSize = true;
            this.createTaskNameLabel.Location = new System.Drawing.Point(12, 15);
            this.createTaskNameLabel.Name = "createTaskNameLabel";
            this.createTaskNameLabel.Size = new System.Drawing.Size(47, 17);
            this.createTaskNameLabel.TabIndex = 0;
            this.createTaskNameLabel.Text = "Naziv:";
            // 
            // algorithmParameterAdjustmentPanel
            // 
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentCheckSumCheckBox);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentStatusStrip);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentPropertiesComboBox);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentWinnowingComboBox);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentPropertiesLabel);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentCancelBtn);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentSaveBtn);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentWindowSizeTxtBox);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentKGramLengthTxtBox);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentWinnowingLabel);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentWindowSizeLabel);
            this.algorithmParameterAdjustmentPanel.Controls.Add(this.algorithmParameterAdjustmentKGramLengthLabel);
            this.algorithmParameterAdjustmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmParameterAdjustmentPanel.Location = new System.Drawing.Point(0, 0);
            this.algorithmParameterAdjustmentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentPanel.Name = "algorithmParameterAdjustmentPanel";
            this.algorithmParameterAdjustmentPanel.Size = new System.Drawing.Size(899, 513);
            this.algorithmParameterAdjustmentPanel.TabIndex = 7;
            this.algorithmParameterAdjustmentPanel.Visible = false;
            // 
            // algorithmParameterAdjustmentStatusStrip
            // 
            this.algorithmParameterAdjustmentStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.algorithmParameterAdjustmentStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmParameterAdjustmentTaskName});
            this.algorithmParameterAdjustmentStatusStrip.Location = new System.Drawing.Point(0, 487);
            this.algorithmParameterAdjustmentStatusStrip.Name = "algorithmParameterAdjustmentStatusStrip";
            this.algorithmParameterAdjustmentStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.algorithmParameterAdjustmentStatusStrip.Size = new System.Drawing.Size(899, 26);
            this.algorithmParameterAdjustmentStatusStrip.TabIndex = 21;
            // 
            // algorithmParameterAdjustmentTaskName
            // 
            this.algorithmParameterAdjustmentTaskName.Name = "algorithmParameterAdjustmentTaskName";
            this.algorithmParameterAdjustmentTaskName.Size = new System.Drawing.Size(66, 20);
            this.algorithmParameterAdjustmentTaskName.Text = "Zadatak:";
            // 
            // algorithmParameterAdjustmentPropertiesComboBox
            // 
            this.algorithmParameterAdjustmentPropertiesComboBox.FormattingEnabled = true;
            this.algorithmParameterAdjustmentPropertiesComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.algorithmParameterAdjustmentPropertiesComboBox.Location = new System.Drawing.Point(98, 94);
            this.algorithmParameterAdjustmentPropertiesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentPropertiesComboBox.Name = "algorithmParameterAdjustmentPropertiesComboBox";
            this.algorithmParameterAdjustmentPropertiesComboBox.Size = new System.Drawing.Size(59, 24);
            this.algorithmParameterAdjustmentPropertiesComboBox.TabIndex = 20;
            this.algorithmParameterAdjustmentPropertiesComboBox.Text = "1";
            this.algorithmParameterAdjustmentPropertiesComboBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmParameterAdjustmentCharacteristicsComboBox_SelectedIndexChanged);
            // 
            // algorithmParameterAdjustmentWinnowingComboBox
            // 
            this.algorithmParameterAdjustmentWinnowingComboBox.FormattingEnabled = true;
            this.algorithmParameterAdjustmentWinnowingComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.algorithmParameterAdjustmentWinnowingComboBox.Location = new System.Drawing.Point(98, 65);
            this.algorithmParameterAdjustmentWinnowingComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentWinnowingComboBox.Name = "algorithmParameterAdjustmentWinnowingComboBox";
            this.algorithmParameterAdjustmentWinnowingComboBox.Size = new System.Drawing.Size(60, 24);
            this.algorithmParameterAdjustmentWinnowingComboBox.TabIndex = 17;
            this.algorithmParameterAdjustmentWinnowingComboBox.Text = "1";
            this.algorithmParameterAdjustmentWinnowingComboBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmParameterAdjustmentWinnowingComboBox_SelectedIndexChanged);
            // 
            // algorithmParameterAdjustmentPropertiesLabel
            // 
            this.algorithmParameterAdjustmentPropertiesLabel.AutoSize = true;
            this.algorithmParameterAdjustmentPropertiesLabel.Location = new System.Drawing.Point(12, 97);
            this.algorithmParameterAdjustmentPropertiesLabel.Name = "algorithmParameterAdjustmentPropertiesLabel";
            this.algorithmParameterAdjustmentPropertiesLabel.Size = new System.Drawing.Size(77, 17);
            this.algorithmParameterAdjustmentPropertiesLabel.TabIndex = 16;
            this.algorithmParameterAdjustmentPropertiesLabel.Text = "Properties:";
            // 
            // algorithmParameterAdjustmentCancelBtn
            // 
            this.algorithmParameterAdjustmentCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmParameterAdjustmentCancelBtn.Location = new System.Drawing.Point(684, 452);
            this.algorithmParameterAdjustmentCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentCancelBtn.Name = "algorithmParameterAdjustmentCancelBtn";
            this.algorithmParameterAdjustmentCancelBtn.Size = new System.Drawing.Size(100, 34);
            this.algorithmParameterAdjustmentCancelBtn.TabIndex = 14;
            this.algorithmParameterAdjustmentCancelBtn.Text = "Odustani";
            this.algorithmParameterAdjustmentCancelBtn.UseVisualStyleBackColor = true;
            this.algorithmParameterAdjustmentCancelBtn.Click += new System.EventHandler(this.AlgorithmParameterAdjustmentCancelBtn_Click);
            // 
            // algorithmParameterAdjustmentSaveBtn
            // 
            this.algorithmParameterAdjustmentSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmParameterAdjustmentSaveBtn.Location = new System.Drawing.Point(789, 452);
            this.algorithmParameterAdjustmentSaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentSaveBtn.Name = "algorithmParameterAdjustmentSaveBtn";
            this.algorithmParameterAdjustmentSaveBtn.Size = new System.Drawing.Size(97, 34);
            this.algorithmParameterAdjustmentSaveBtn.TabIndex = 12;
            this.algorithmParameterAdjustmentSaveBtn.Text = "Spremi";
            this.algorithmParameterAdjustmentSaveBtn.UseVisualStyleBackColor = true;
            this.algorithmParameterAdjustmentSaveBtn.Click += new System.EventHandler(this.AlgorithmParameterAdjustmentSaveBtn_Click);
            // 
            // algorithmParameterAdjustmentWindowSizeTxtBox
            // 
            this.algorithmParameterAdjustmentWindowSizeTxtBox.Location = new System.Drawing.Point(132, 39);
            this.algorithmParameterAdjustmentWindowSizeTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentWindowSizeTxtBox.Name = "algorithmParameterAdjustmentWindowSizeTxtBox";
            this.algorithmParameterAdjustmentWindowSizeTxtBox.Size = new System.Drawing.Size(60, 22);
            this.algorithmParameterAdjustmentWindowSizeTxtBox.TabIndex = 6;
            this.algorithmParameterAdjustmentWindowSizeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // algorithmParameterAdjustmentKGramLengthTxtBox
            // 
            this.algorithmParameterAdjustmentKGramLengthTxtBox.Location = new System.Drawing.Point(129, 12);
            this.algorithmParameterAdjustmentKGramLengthTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.algorithmParameterAdjustmentKGramLengthTxtBox.Name = "algorithmParameterAdjustmentKGramLengthTxtBox";
            this.algorithmParameterAdjustmentKGramLengthTxtBox.Size = new System.Drawing.Size(60, 22);
            this.algorithmParameterAdjustmentKGramLengthTxtBox.TabIndex = 5;
            this.algorithmParameterAdjustmentKGramLengthTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // algorithmParameterAdjustmentWinnowingLabel
            // 
            this.algorithmParameterAdjustmentWinnowingLabel.AutoSize = true;
            this.algorithmParameterAdjustmentWinnowingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.algorithmParameterAdjustmentWinnowingLabel.Location = new System.Drawing.Point(12, 68);
            this.algorithmParameterAdjustmentWinnowingLabel.Name = "algorithmParameterAdjustmentWinnowingLabel";
            this.algorithmParameterAdjustmentWinnowingLabel.Size = new System.Drawing.Size(80, 17);
            this.algorithmParameterAdjustmentWinnowingLabel.TabIndex = 3;
            this.algorithmParameterAdjustmentWinnowingLabel.Text = "Winnowing:";
            // 
            // algorithmParameterAdjustmentWindowSizeLabel
            // 
            this.algorithmParameterAdjustmentWindowSizeLabel.AutoSize = true;
            this.algorithmParameterAdjustmentWindowSizeLabel.Location = new System.Drawing.Point(12, 43);
            this.algorithmParameterAdjustmentWindowSizeLabel.Name = "algorithmParameterAdjustmentWindowSizeLabel";
            this.algorithmParameterAdjustmentWindowSizeLabel.Size = new System.Drawing.Size(114, 17);
            this.algorithmParameterAdjustmentWindowSizeLabel.TabIndex = 1;
            this.algorithmParameterAdjustmentWindowSizeLabel.Text = "Veličina prozora:";
            // 
            // algorithmParameterAdjustmentKGramLengthLabel
            // 
            this.algorithmParameterAdjustmentKGramLengthLabel.AutoSize = true;
            this.algorithmParameterAdjustmentKGramLengthLabel.Location = new System.Drawing.Point(12, 15);
            this.algorithmParameterAdjustmentKGramLengthLabel.Name = "algorithmParameterAdjustmentKGramLengthLabel";
            this.algorithmParameterAdjustmentKGramLengthLabel.Size = new System.Drawing.Size(111, 17);
            this.algorithmParameterAdjustmentKGramLengthLabel.TabIndex = 0;
            this.algorithmParameterAdjustmentKGramLengthLabel.Text = "Duljina k-grama:";
            // 
            // addFilesPanel
            // 
            this.addFilesPanel.Controls.Add(this.addFilesStatusStrip);
            this.addFilesPanel.Controls.Add(this.addFilesResultsPerPageLabel);
            this.addFilesPanel.Controls.Add(this.addFilesResultsPerPageComboBox);
            this.addFilesPanel.Controls.Add(this.addFilesLastPageBtn);
            this.addFilesPanel.Controls.Add(this.addFilesNextPageBtn);
            this.addFilesPanel.Controls.Add(this.addFilesPreviousPageBtn);
            this.addFilesPanel.Controls.Add(this.addFilesFirstPageBtn);
            this.addFilesPanel.Controls.Add(this.addFilesCancelBtn);
            this.addFilesPanel.Controls.Add(this.addFilesSaveBtn);
            this.addFilesPanel.Controls.Add(this.addFilesAddManyAuthorsArchivesBtn);
            this.addFilesPanel.Controls.Add(this.addFilesFileListGridView);
            this.addFilesPanel.Controls.Add(this.addFilesFileListLabel);
            this.addFilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addFilesPanel.Location = new System.Drawing.Point(0, 0);
            this.addFilesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesPanel.Name = "addFilesPanel";
            this.addFilesPanel.Size = new System.Drawing.Size(899, 513);
            this.addFilesPanel.TabIndex = 15;
            this.addFilesPanel.Visible = false;
            // 
            // addFilesStatusStrip
            // 
            this.addFilesStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addFilesStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesStatusStripTaskName,
            this.addFilesStatusStripPageInfo,
            this.addFilesStatusStripNoOfFiles});
            this.addFilesStatusStrip.Location = new System.Drawing.Point(0, 487);
            this.addFilesStatusStrip.Name = "addFilesStatusStrip";
            this.addFilesStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.addFilesStatusStrip.Size = new System.Drawing.Size(899, 26);
            this.addFilesStatusStrip.TabIndex = 16;
            this.addFilesStatusStrip.Text = "statusStrip1";
            // 
            // addFilesStatusStripTaskName
            // 
            this.addFilesStatusStripTaskName.Name = "addFilesStatusStripTaskName";
            this.addFilesStatusStripTaskName.Size = new System.Drawing.Size(66, 20);
            this.addFilesStatusStripTaskName.Text = "Zadatak:";
            // 
            // addFilesStatusStripPageInfo
            // 
            this.addFilesStatusStripPageInfo.Name = "addFilesStatusStripPageInfo";
            this.addFilesStatusStripPageInfo.Size = new System.Drawing.Size(65, 20);
            this.addFilesStatusStripPageInfo.Text = "Stranica:";
            // 
            // addFilesStatusStripNoOfFiles
            // 
            this.addFilesStatusStripNoOfFiles.Name = "addFilesStatusStripNoOfFiles";
            this.addFilesStatusStripNoOfFiles.Size = new System.Drawing.Size(102, 20);
            this.addFilesStatusStripNoOfFiles.Text = "Broj datoteka:";
            // 
            // addFilesResultsPerPageLabel
            // 
            this.addFilesResultsPerPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesResultsPerPageLabel.AutoSize = true;
            this.addFilesResultsPerPageLabel.Location = new System.Drawing.Point(662, 15);
            this.addFilesResultsPerPageLabel.Name = "addFilesResultsPerPageLabel";
            this.addFilesResultsPerPageLabel.Size = new System.Drawing.Size(165, 17);
            this.addFilesResultsPerPageLabel.TabIndex = 15;
            this.addFilesResultsPerPageLabel.Text = "Broj rezultata po stranici:";
            // 
            // addFilesResultsPerPageComboBox
            // 
            this.addFilesResultsPerPageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesResultsPerPageComboBox.FormattingEnabled = true;
            this.addFilesResultsPerPageComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.addFilesResultsPerPageComboBox.Location = new System.Drawing.Point(833, 12);
            this.addFilesResultsPerPageComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesResultsPerPageComboBox.Name = "addFilesResultsPerPageComboBox";
            this.addFilesResultsPerPageComboBox.Size = new System.Drawing.Size(54, 24);
            this.addFilesResultsPerPageComboBox.TabIndex = 14;
            this.addFilesResultsPerPageComboBox.Text = "50";
            this.addFilesResultsPerPageComboBox.SelectedIndexChanged += new System.EventHandler(this.AddFilesResultsPerPageComboBox_SelectedIndexChanged);
            // 
            // addFilesLastPageBtn
            // 
            this.addFilesLastPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilesLastPageBtn.Location = new System.Drawing.Point(489, 411);
            this.addFilesLastPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesLastPageBtn.Name = "addFilesLastPageBtn";
            this.addFilesLastPageBtn.Size = new System.Drawing.Size(147, 34);
            this.addFilesLastPageBtn.TabIndex = 13;
            this.addFilesLastPageBtn.Text = "Zadnja stranica";
            this.addFilesLastPageBtn.UseVisualStyleBackColor = true;
            this.addFilesLastPageBtn.Click += new System.EventHandler(this.AddFilesLastPageBtn_Click);
            // 
            // addFilesNextPageBtn
            // 
            this.addFilesNextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilesNextPageBtn.Location = new System.Drawing.Point(332, 411);
            this.addFilesNextPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesNextPageBtn.Name = "addFilesNextPageBtn";
            this.addFilesNextPageBtn.Size = new System.Drawing.Size(151, 34);
            this.addFilesNextPageBtn.TabIndex = 12;
            this.addFilesNextPageBtn.Text = "Sljedeća stranica";
            this.addFilesNextPageBtn.UseVisualStyleBackColor = true;
            this.addFilesNextPageBtn.Click += new System.EventHandler(this.AddFilesNextPageBtn_Click);
            // 
            // addFilesPreviousPageBtn
            // 
            this.addFilesPreviousPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilesPreviousPageBtn.Location = new System.Drawing.Point(163, 411);
            this.addFilesPreviousPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesPreviousPageBtn.Name = "addFilesPreviousPageBtn";
            this.addFilesPreviousPageBtn.Size = new System.Drawing.Size(163, 34);
            this.addFilesPreviousPageBtn.TabIndex = 11;
            this.addFilesPreviousPageBtn.Text = "Prethodna stranica";
            this.addFilesPreviousPageBtn.UseVisualStyleBackColor = true;
            this.addFilesPreviousPageBtn.Click += new System.EventHandler(this.AddFilesPreviousPageBtn_Click);
            // 
            // addFilesFirstPageBtn
            // 
            this.addFilesFirstPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilesFirstPageBtn.Location = new System.Drawing.Point(12, 411);
            this.addFilesFirstPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesFirstPageBtn.Name = "addFilesFirstPageBtn";
            this.addFilesFirstPageBtn.Size = new System.Drawing.Size(145, 34);
            this.addFilesFirstPageBtn.TabIndex = 10;
            this.addFilesFirstPageBtn.Text = "Prva stranica";
            this.addFilesFirstPageBtn.UseVisualStyleBackColor = true;
            this.addFilesFirstPageBtn.Click += new System.EventHandler(this.AddFilesFirstPageBtn_Click);
            // 
            // addFilesCancelBtn
            // 
            this.addFilesCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesCancelBtn.Location = new System.Drawing.Point(677, 452);
            this.addFilesCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesCancelBtn.Name = "addFilesCancelBtn";
            this.addFilesCancelBtn.Size = new System.Drawing.Size(101, 34);
            this.addFilesCancelBtn.TabIndex = 7;
            this.addFilesCancelBtn.Text = "Odustani";
            this.addFilesCancelBtn.UseVisualStyleBackColor = true;
            this.addFilesCancelBtn.Click += new System.EventHandler(this.AddFilesCancelBtn_Click);
            // 
            // addFilesSaveBtn
            // 
            this.addFilesSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesSaveBtn.Location = new System.Drawing.Point(784, 452);
            this.addFilesSaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesSaveBtn.Name = "addFilesSaveBtn";
            this.addFilesSaveBtn.Size = new System.Drawing.Size(101, 34);
            this.addFilesSaveBtn.TabIndex = 6;
            this.addFilesSaveBtn.Text = "Spremi";
            this.addFilesSaveBtn.UseVisualStyleBackColor = true;
            this.addFilesSaveBtn.Click += new System.EventHandler(this.AddFilesSaveBtn_Click);
            // 
            // addFilesAddManyAuthorsArchivesBtn
            // 
            this.addFilesAddManyAuthorsArchivesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFilesAddManyAuthorsArchivesBtn.Location = new System.Drawing.Point(12, 452);
            this.addFilesAddManyAuthorsArchivesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesAddManyAuthorsArchivesBtn.Name = "addFilesAddManyAuthorsArchivesBtn";
            this.addFilesAddManyAuthorsArchivesBtn.Size = new System.Drawing.Size(315, 34);
            this.addFilesAddManyAuthorsArchivesBtn.TabIndex = 5;
            this.addFilesAddManyAuthorsArchivesBtn.Text = "Dodaj arhive jednog ili više autora";
            this.addFilesAddManyAuthorsArchivesBtn.UseVisualStyleBackColor = true;
            this.addFilesAddManyAuthorsArchivesBtn.Click += new System.EventHandler(this.AddFilesAddManyAuthorsArchivesBtn_Click);
            // 
            // addFilesFileListGridView
            // 
            this.addFilesFileListGridView.AllowUserToAddRows = false;
            this.addFilesFileListGridView.AllowUserToDeleteRows = false;
            this.addFilesFileListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilesFileListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addFilesFileListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addFilesFileListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddFilesFileListJMBAG,
            this.AddFilesFileListFile,
            this.AddFilesFileListCheckSumBeforePreprocessing,
            this.AddFilesFileListCheckSumAfterPreprocessing,
            this.AddFilesFileListFileSize,
            this.AddFilesFileListFileContent,
            this.AddFilesFileListRemoveBtn});
            this.addFilesFileListGridView.Location = new System.Drawing.Point(12, 42);
            this.addFilesFileListGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFilesFileListGridView.Name = "addFilesFileListGridView";
            this.addFilesFileListGridView.RowHeadersWidth = 51;
            this.addFilesFileListGridView.RowTemplate.Height = 24;
            this.addFilesFileListGridView.Size = new System.Drawing.Size(875, 363);
            this.addFilesFileListGridView.TabIndex = 3;
            // 
            // AddFilesFileListJMBAG
            // 
            this.AddFilesFileListJMBAG.HeaderText = "JMBAG";
            this.AddFilesFileListJMBAG.MinimumWidth = 6;
            this.AddFilesFileListJMBAG.Name = "AddFilesFileListJMBAG";
            this.AddFilesFileListJMBAG.ReadOnly = true;
            // 
            // AddFilesFileListFile
            // 
            this.AddFilesFileListFile.HeaderText = "Datoteka";
            this.AddFilesFileListFile.MinimumWidth = 6;
            this.AddFilesFileListFile.Name = "AddFilesFileListFile";
            this.AddFilesFileListFile.ReadOnly = true;
            // 
            // AddFilesFileListCheckSumBeforePreprocessing
            // 
            this.AddFilesFileListCheckSumBeforePreprocessing.HeaderText = "Sažetak (prije pretproc.)";
            this.AddFilesFileListCheckSumBeforePreprocessing.MinimumWidth = 6;
            this.AddFilesFileListCheckSumBeforePreprocessing.Name = "AddFilesFileListCheckSumBeforePreprocessing";
            this.AddFilesFileListCheckSumBeforePreprocessing.ReadOnly = true;
            // 
            // AddFilesFileListCheckSumAfterPreprocessing
            // 
            this.AddFilesFileListCheckSumAfterPreprocessing.HeaderText = "Sažetak (nakon pretproc.)";
            this.AddFilesFileListCheckSumAfterPreprocessing.MinimumWidth = 6;
            this.AddFilesFileListCheckSumAfterPreprocessing.Name = "AddFilesFileListCheckSumAfterPreprocessing";
            this.AddFilesFileListCheckSumAfterPreprocessing.ReadOnly = true;
            // 
            // AddFilesFileListFileSize
            // 
            this.AddFilesFileListFileSize.HeaderText = "Veličina datoteke";
            this.AddFilesFileListFileSize.MinimumWidth = 6;
            this.AddFilesFileListFileSize.Name = "AddFilesFileListFileSize";
            this.AddFilesFileListFileSize.ReadOnly = true;
            this.AddFilesFileListFileSize.Visible = false;
            // 
            // AddFilesFileListFileContent
            // 
            this.AddFilesFileListFileContent.HeaderText = "Sadržaj datoteke";
            this.AddFilesFileListFileContent.MinimumWidth = 6;
            this.AddFilesFileListFileContent.Name = "AddFilesFileListFileContent";
            this.AddFilesFileListFileContent.ReadOnly = true;
            this.AddFilesFileListFileContent.Visible = false;
            // 
            // AddFilesFileListRemoveBtn
            // 
            this.AddFilesFileListRemoveBtn.HeaderText = "Ukloni";
            this.AddFilesFileListRemoveBtn.MinimumWidth = 6;
            this.AddFilesFileListRemoveBtn.Name = "AddFilesFileListRemoveBtn";
            // 
            // addFilesFileListLabel
            // 
            this.addFilesFileListLabel.AutoSize = true;
            this.addFilesFileListLabel.Location = new System.Drawing.Point(12, 15);
            this.addFilesFileListLabel.Name = "addFilesFileListLabel";
            this.addFilesFileListLabel.Size = new System.Drawing.Size(159, 17);
            this.addFilesFileListLabel.TabIndex = 2;
            this.addFilesFileListLabel.Text = "Popis učitanih datoteka:";
            // 
            // similarFilesComparisonPanel
            // 
            this.similarFilesComparisonPanel.Controls.Add(this.similarFilesComparisonFileInfo2Panel);
            this.similarFilesComparisonPanel.Controls.Add(this.similarFilesComparisonFileInfo1Panel);
            this.similarFilesComparisonPanel.Controls.Add(this.similarFilesComparisonResultsPanel);
            this.similarFilesComparisonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.similarFilesComparisonPanel.Location = new System.Drawing.Point(0, 0);
            this.similarFilesComparisonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.similarFilesComparisonPanel.Name = "similarFilesComparisonPanel";
            this.similarFilesComparisonPanel.Size = new System.Drawing.Size(899, 513);
            this.similarFilesComparisonPanel.TabIndex = 8;
            this.similarFilesComparisonPanel.Visible = false;
            // 
            // similarFilesComparisonFileInfo2Panel
            // 
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonHashAfterPreprocessing2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonHashAfterPreprocessing2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonHashBeforePreprocessing2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonHashBeforePreprocessing2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfBlockComments2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfBlockComments2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfLineComments2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfLineComments2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfEmptyLines2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfEmptyLines2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfLines2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonNoOfLines2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileSize2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileSize2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileName2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileAuthor2TxtBox);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileName2Label);
            this.similarFilesComparisonFileInfo2Panel.Controls.Add(this.similarFilesComparisonFileAuthor2Label);
            this.similarFilesComparisonFileInfo2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.similarFilesComparisonFileInfo2Panel.Location = new System.Drawing.Point(472, 0);
            this.similarFilesComparisonFileInfo2Panel.Name = "similarFilesComparisonFileInfo2Panel";
            this.similarFilesComparisonFileInfo2Panel.Size = new System.Drawing.Size(427, 386);
            this.similarFilesComparisonFileInfo2Panel.TabIndex = 2;
            // 
            // similarFilesComparisonHashAfterPreprocessing2TxtBox
            // 
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox.Location = new System.Drawing.Point(187, 235);
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox.Name = "similarFilesComparisonHashAfterPreprocessing2TxtBox";
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox.ReadOnly = true;
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox.Size = new System.Drawing.Size(224, 22);
            this.similarFilesComparisonHashAfterPreprocessing2TxtBox.TabIndex = 24;
            // 
            // similarFilesComparisonHashAfterPreprocessing2Label
            // 
            this.similarFilesComparisonHashAfterPreprocessing2Label.AutoSize = true;
            this.similarFilesComparisonHashAfterPreprocessing2Label.Location = new System.Drawing.Point(14, 238);
            this.similarFilesComparisonHashAfterPreprocessing2Label.Name = "similarFilesComparisonHashAfterPreprocessing2Label";
            this.similarFilesComparisonHashAfterPreprocessing2Label.Size = new System.Drawing.Size(167, 17);
            this.similarFilesComparisonHashAfterPreprocessing2Label.TabIndex = 23;
            this.similarFilesComparisonHashAfterPreprocessing2Label.Text = "Sažetak nakon pretproc.:";
            // 
            // similarFilesComparisonHashBeforePreprocessing2TxtBox
            // 
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox.Location = new System.Drawing.Point(175, 207);
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox.Name = "similarFilesComparisonHashBeforePreprocessing2TxtBox";
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox.ReadOnly = true;
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox.Size = new System.Drawing.Size(236, 22);
            this.similarFilesComparisonHashBeforePreprocessing2TxtBox.TabIndex = 22;
            // 
            // similarFilesComparisonHashBeforePreprocessing2Label
            // 
            this.similarFilesComparisonHashBeforePreprocessing2Label.AutoSize = true;
            this.similarFilesComparisonHashBeforePreprocessing2Label.Location = new System.Drawing.Point(14, 210);
            this.similarFilesComparisonHashBeforePreprocessing2Label.Name = "similarFilesComparisonHashBeforePreprocessing2Label";
            this.similarFilesComparisonHashBeforePreprocessing2Label.Size = new System.Drawing.Size(155, 17);
            this.similarFilesComparisonHashBeforePreprocessing2Label.TabIndex = 21;
            this.similarFilesComparisonHashBeforePreprocessing2Label.Text = "Sažetak prije pretproc.:";
            // 
            // similarFilesComparisonNoOfBlockComments2TxtBox
            // 
            this.similarFilesComparisonNoOfBlockComments2TxtBox.Location = new System.Drawing.Point(158, 179);
            this.similarFilesComparisonNoOfBlockComments2TxtBox.Name = "similarFilesComparisonNoOfBlockComments2TxtBox";
            this.similarFilesComparisonNoOfBlockComments2TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfBlockComments2TxtBox.Size = new System.Drawing.Size(100, 22);
            this.similarFilesComparisonNoOfBlockComments2TxtBox.TabIndex = 20;
            // 
            // similarFilesComparisonNoOfBlockComments2Label
            // 
            this.similarFilesComparisonNoOfBlockComments2Label.AutoSize = true;
            this.similarFilesComparisonNoOfBlockComments2Label.Location = new System.Drawing.Point(14, 182);
            this.similarFilesComparisonNoOfBlockComments2Label.Name = "similarFilesComparisonNoOfBlockComments2Label";
            this.similarFilesComparisonNoOfBlockComments2Label.Size = new System.Drawing.Size(138, 17);
            this.similarFilesComparisonNoOfBlockComments2Label.TabIndex = 19;
            this.similarFilesComparisonNoOfBlockComments2Label.Text = "Broj blok komentara:";
            // 
            // similarFilesComparisonNoOfLineComments2TxtBox
            // 
            this.similarFilesComparisonNoOfLineComments2TxtBox.Location = new System.Drawing.Point(177, 151);
            this.similarFilesComparisonNoOfLineComments2TxtBox.Name = "similarFilesComparisonNoOfLineComments2TxtBox";
            this.similarFilesComparisonNoOfLineComments2TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfLineComments2TxtBox.Size = new System.Drawing.Size(100, 22);
            this.similarFilesComparisonNoOfLineComments2TxtBox.TabIndex = 18;
            // 
            // similarFilesComparisonNoOfLineComments2Label
            // 
            this.similarFilesComparisonNoOfLineComments2Label.AutoSize = true;
            this.similarFilesComparisonNoOfLineComments2Label.Location = new System.Drawing.Point(14, 154);
            this.similarFilesComparisonNoOfLineComments2Label.Name = "similarFilesComparisonNoOfLineComments2Label";
            this.similarFilesComparisonNoOfLineComments2Label.Size = new System.Drawing.Size(157, 17);
            this.similarFilesComparisonNoOfLineComments2Label.TabIndex = 17;
            this.similarFilesComparisonNoOfLineComments2Label.Text = "Broj linijskih komentara:";
            // 
            // similarFilesComparisonNoOfEmptyLines2TxtBox
            // 
            this.similarFilesComparisonNoOfEmptyLines2TxtBox.Location = new System.Drawing.Point(140, 123);
            this.similarFilesComparisonNoOfEmptyLines2TxtBox.Name = "similarFilesComparisonNoOfEmptyLines2TxtBox";
            this.similarFilesComparisonNoOfEmptyLines2TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfEmptyLines2TxtBox.Size = new System.Drawing.Size(109, 22);
            this.similarFilesComparisonNoOfEmptyLines2TxtBox.TabIndex = 16;
            // 
            // similarFilesComparisonNoOfEmptyLines2Label
            // 
            this.similarFilesComparisonNoOfEmptyLines2Label.AutoSize = true;
            this.similarFilesComparisonNoOfEmptyLines2Label.Location = new System.Drawing.Point(14, 125);
            this.similarFilesComparisonNoOfEmptyLines2Label.Name = "similarFilesComparisonNoOfEmptyLines2Label";
            this.similarFilesComparisonNoOfEmptyLines2Label.Size = new System.Drawing.Size(120, 17);
            this.similarFilesComparisonNoOfEmptyLines2Label.TabIndex = 15;
            this.similarFilesComparisonNoOfEmptyLines2Label.Text = "Broj praznih linija:";
            // 
            // similarFilesComparisonNoOfLines2TxtBox
            // 
            this.similarFilesComparisonNoOfLines2TxtBox.Location = new System.Drawing.Point(89, 94);
            this.similarFilesComparisonNoOfLines2TxtBox.Name = "similarFilesComparisonNoOfLines2TxtBox";
            this.similarFilesComparisonNoOfLines2TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfLines2TxtBox.Size = new System.Drawing.Size(119, 22);
            this.similarFilesComparisonNoOfLines2TxtBox.TabIndex = 14;
            // 
            // similarFilesComparisonNoOfLines2Label
            // 
            this.similarFilesComparisonNoOfLines2Label.AutoSize = true;
            this.similarFilesComparisonNoOfLines2Label.Location = new System.Drawing.Point(14, 97);
            this.similarFilesComparisonNoOfLines2Label.Name = "similarFilesComparisonNoOfLines2Label";
            this.similarFilesComparisonNoOfLines2Label.Size = new System.Drawing.Size(69, 17);
            this.similarFilesComparisonNoOfLines2Label.TabIndex = 13;
            this.similarFilesComparisonNoOfLines2Label.Text = "Broj linija:";
            // 
            // similarFilesComparisonFileSize2TxtBox
            // 
            this.similarFilesComparisonFileSize2TxtBox.Location = new System.Drawing.Point(140, 68);
            this.similarFilesComparisonFileSize2TxtBox.Name = "similarFilesComparisonFileSize2TxtBox";
            this.similarFilesComparisonFileSize2TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileSize2TxtBox.Size = new System.Drawing.Size(131, 22);
            this.similarFilesComparisonFileSize2TxtBox.TabIndex = 12;
            // 
            // similarFilesComparisonFileSize2Label
            // 
            this.similarFilesComparisonFileSize2Label.AutoSize = true;
            this.similarFilesComparisonFileSize2Label.Location = new System.Drawing.Point(14, 68);
            this.similarFilesComparisonFileSize2Label.Name = "similarFilesComparisonFileSize2Label";
            this.similarFilesComparisonFileSize2Label.Size = new System.Drawing.Size(120, 17);
            this.similarFilesComparisonFileSize2Label.TabIndex = 5;
            this.similarFilesComparisonFileSize2Label.Text = "Veličina datoteke:";
            // 
            // similarFilesComparisonFileName2TxtBox
            // 
            this.similarFilesComparisonFileName2TxtBox.Location = new System.Drawing.Point(89, 40);
            this.similarFilesComparisonFileName2TxtBox.Name = "similarFilesComparisonFileName2TxtBox";
            this.similarFilesComparisonFileName2TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileName2TxtBox.Size = new System.Drawing.Size(243, 22);
            this.similarFilesComparisonFileName2TxtBox.TabIndex = 3;
            // 
            // similarFilesComparisonFileAuthor2TxtBox
            // 
            this.similarFilesComparisonFileAuthor2TxtBox.Location = new System.Drawing.Point(87, 12);
            this.similarFilesComparisonFileAuthor2TxtBox.Name = "similarFilesComparisonFileAuthor2TxtBox";
            this.similarFilesComparisonFileAuthor2TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileAuthor2TxtBox.Size = new System.Drawing.Size(245, 22);
            this.similarFilesComparisonFileAuthor2TxtBox.TabIndex = 2;
            // 
            // similarFilesComparisonFileName2Label
            // 
            this.similarFilesComparisonFileName2Label.AutoSize = true;
            this.similarFilesComparisonFileName2Label.Location = new System.Drawing.Point(14, 42);
            this.similarFilesComparisonFileName2Label.Name = "similarFilesComparisonFileName2Label";
            this.similarFilesComparisonFileName2Label.Size = new System.Drawing.Size(69, 17);
            this.similarFilesComparisonFileName2Label.TabIndex = 1;
            this.similarFilesComparisonFileName2Label.Text = "Datoteka:";
            // 
            // similarFilesComparisonFileAuthor2Label
            // 
            this.similarFilesComparisonFileAuthor2Label.AutoSize = true;
            this.similarFilesComparisonFileAuthor2Label.Location = new System.Drawing.Point(14, 15);
            this.similarFilesComparisonFileAuthor2Label.Name = "similarFilesComparisonFileAuthor2Label";
            this.similarFilesComparisonFileAuthor2Label.Size = new System.Drawing.Size(67, 17);
            this.similarFilesComparisonFileAuthor2Label.TabIndex = 0;
            this.similarFilesComparisonFileAuthor2Label.Text = "JMBAG2:";
            // 
            // similarFilesComparisonFileInfo1Panel
            // 
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonHashAfterPreprocessing1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonHashBeforePreprocessing1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfBlockComments1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfLineComments1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfEmptyLines1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfLines1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileSize1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonHashAfterPreprocessing1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonHashBeforePreprocessing1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfBlockComments1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfLineComments1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfEmptyLines1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonNoOfLines1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileSize1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileName1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileAuthor1TxtBox);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileName1Label);
            this.similarFilesComparisonFileInfo1Panel.Controls.Add(this.similarFilesComparisonFileAuthor1Label);
            this.similarFilesComparisonFileInfo1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.similarFilesComparisonFileInfo1Panel.Location = new System.Drawing.Point(0, 0);
            this.similarFilesComparisonFileInfo1Panel.Name = "similarFilesComparisonFileInfo1Panel";
            this.similarFilesComparisonFileInfo1Panel.Size = new System.Drawing.Size(472, 386);
            this.similarFilesComparisonFileInfo1Panel.TabIndex = 1;
            // 
            // similarFilesComparisonHashAfterPreprocessing1TxtBox
            // 
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox.Location = new System.Drawing.Point(185, 235);
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox.Name = "similarFilesComparisonHashAfterPreprocessing1TxtBox";
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox.ReadOnly = true;
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox.Size = new System.Drawing.Size(224, 22);
            this.similarFilesComparisonHashAfterPreprocessing1TxtBox.TabIndex = 17;
            // 
            // similarFilesComparisonHashBeforePreprocessing1TxtBox
            // 
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox.Location = new System.Drawing.Point(173, 207);
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox.Name = "similarFilesComparisonHashBeforePreprocessing1TxtBox";
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox.ReadOnly = true;
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox.Size = new System.Drawing.Size(236, 22);
            this.similarFilesComparisonHashBeforePreprocessing1TxtBox.TabIndex = 16;
            // 
            // similarFilesComparisonNoOfBlockComments1TxtBox
            // 
            this.similarFilesComparisonNoOfBlockComments1TxtBox.Location = new System.Drawing.Point(156, 179);
            this.similarFilesComparisonNoOfBlockComments1TxtBox.Name = "similarFilesComparisonNoOfBlockComments1TxtBox";
            this.similarFilesComparisonNoOfBlockComments1TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfBlockComments1TxtBox.Size = new System.Drawing.Size(100, 22);
            this.similarFilesComparisonNoOfBlockComments1TxtBox.TabIndex = 15;
            // 
            // similarFilesComparisonNoOfLineComments1TxtBox
            // 
            this.similarFilesComparisonNoOfLineComments1TxtBox.Location = new System.Drawing.Point(175, 151);
            this.similarFilesComparisonNoOfLineComments1TxtBox.Name = "similarFilesComparisonNoOfLineComments1TxtBox";
            this.similarFilesComparisonNoOfLineComments1TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfLineComments1TxtBox.Size = new System.Drawing.Size(100, 22);
            this.similarFilesComparisonNoOfLineComments1TxtBox.TabIndex = 14;
            // 
            // similarFilesComparisonNoOfEmptyLines1TxtBox
            // 
            this.similarFilesComparisonNoOfEmptyLines1TxtBox.Location = new System.Drawing.Point(138, 123);
            this.similarFilesComparisonNoOfEmptyLines1TxtBox.Name = "similarFilesComparisonNoOfEmptyLines1TxtBox";
            this.similarFilesComparisonNoOfEmptyLines1TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfEmptyLines1TxtBox.Size = new System.Drawing.Size(109, 22);
            this.similarFilesComparisonNoOfEmptyLines1TxtBox.TabIndex = 13;
            // 
            // similarFilesComparisonNoOfLines1TxtBox
            // 
            this.similarFilesComparisonNoOfLines1TxtBox.Location = new System.Drawing.Point(87, 95);
            this.similarFilesComparisonNoOfLines1TxtBox.Name = "similarFilesComparisonNoOfLines1TxtBox";
            this.similarFilesComparisonNoOfLines1TxtBox.ReadOnly = true;
            this.similarFilesComparisonNoOfLines1TxtBox.Size = new System.Drawing.Size(119, 22);
            this.similarFilesComparisonNoOfLines1TxtBox.TabIndex = 12;
            // 
            // similarFilesComparisonFileSize1TxtBox
            // 
            this.similarFilesComparisonFileSize1TxtBox.Location = new System.Drawing.Point(138, 67);
            this.similarFilesComparisonFileSize1TxtBox.Name = "similarFilesComparisonFileSize1TxtBox";
            this.similarFilesComparisonFileSize1TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileSize1TxtBox.Size = new System.Drawing.Size(131, 22);
            this.similarFilesComparisonFileSize1TxtBox.TabIndex = 11;
            // 
            // similarFilesComparisonHashAfterPreprocessing1Label
            // 
            this.similarFilesComparisonHashAfterPreprocessing1Label.AutoSize = true;
            this.similarFilesComparisonHashAfterPreprocessing1Label.Location = new System.Drawing.Point(12, 238);
            this.similarFilesComparisonHashAfterPreprocessing1Label.Name = "similarFilesComparisonHashAfterPreprocessing1Label";
            this.similarFilesComparisonHashAfterPreprocessing1Label.Size = new System.Drawing.Size(167, 17);
            this.similarFilesComparisonHashAfterPreprocessing1Label.TabIndex = 10;
            this.similarFilesComparisonHashAfterPreprocessing1Label.Text = "Sažetak nakon pretproc.:";
            // 
            // similarFilesComparisonHashBeforePreprocessing1Label
            // 
            this.similarFilesComparisonHashBeforePreprocessing1Label.AutoSize = true;
            this.similarFilesComparisonHashBeforePreprocessing1Label.Location = new System.Drawing.Point(12, 210);
            this.similarFilesComparisonHashBeforePreprocessing1Label.Name = "similarFilesComparisonHashBeforePreprocessing1Label";
            this.similarFilesComparisonHashBeforePreprocessing1Label.Size = new System.Drawing.Size(155, 17);
            this.similarFilesComparisonHashBeforePreprocessing1Label.TabIndex = 9;
            this.similarFilesComparisonHashBeforePreprocessing1Label.Text = "Sažetak prije pretproc.:";
            // 
            // similarFilesComparisonNoOfBlockComments1Label
            // 
            this.similarFilesComparisonNoOfBlockComments1Label.AutoSize = true;
            this.similarFilesComparisonNoOfBlockComments1Label.Location = new System.Drawing.Point(12, 182);
            this.similarFilesComparisonNoOfBlockComments1Label.Name = "similarFilesComparisonNoOfBlockComments1Label";
            this.similarFilesComparisonNoOfBlockComments1Label.Size = new System.Drawing.Size(138, 17);
            this.similarFilesComparisonNoOfBlockComments1Label.TabIndex = 8;
            this.similarFilesComparisonNoOfBlockComments1Label.Text = "Broj blok komentara:";
            // 
            // similarFilesComparisonNoOfLineComments1Label
            // 
            this.similarFilesComparisonNoOfLineComments1Label.AutoSize = true;
            this.similarFilesComparisonNoOfLineComments1Label.Location = new System.Drawing.Point(12, 154);
            this.similarFilesComparisonNoOfLineComments1Label.Name = "similarFilesComparisonNoOfLineComments1Label";
            this.similarFilesComparisonNoOfLineComments1Label.Size = new System.Drawing.Size(157, 17);
            this.similarFilesComparisonNoOfLineComments1Label.TabIndex = 7;
            this.similarFilesComparisonNoOfLineComments1Label.Text = "Broj linijskih komentara:";
            // 
            // similarFilesComparisonNoOfEmptyLines1Label
            // 
            this.similarFilesComparisonNoOfEmptyLines1Label.AutoSize = true;
            this.similarFilesComparisonNoOfEmptyLines1Label.Location = new System.Drawing.Point(12, 125);
            this.similarFilesComparisonNoOfEmptyLines1Label.Name = "similarFilesComparisonNoOfEmptyLines1Label";
            this.similarFilesComparisonNoOfEmptyLines1Label.Size = new System.Drawing.Size(120, 17);
            this.similarFilesComparisonNoOfEmptyLines1Label.TabIndex = 6;
            this.similarFilesComparisonNoOfEmptyLines1Label.Text = "Broj praznih linija:";
            // 
            // similarFilesComparisonNoOfLines1Label
            // 
            this.similarFilesComparisonNoOfLines1Label.AutoSize = true;
            this.similarFilesComparisonNoOfLines1Label.Location = new System.Drawing.Point(12, 97);
            this.similarFilesComparisonNoOfLines1Label.Name = "similarFilesComparisonNoOfLines1Label";
            this.similarFilesComparisonNoOfLines1Label.Size = new System.Drawing.Size(69, 17);
            this.similarFilesComparisonNoOfLines1Label.TabIndex = 5;
            this.similarFilesComparisonNoOfLines1Label.Text = "Broj linija:";
            // 
            // similarFilesComparisonFileSize1Label
            // 
            this.similarFilesComparisonFileSize1Label.AutoSize = true;
            this.similarFilesComparisonFileSize1Label.Location = new System.Drawing.Point(12, 68);
            this.similarFilesComparisonFileSize1Label.Name = "similarFilesComparisonFileSize1Label";
            this.similarFilesComparisonFileSize1Label.Size = new System.Drawing.Size(120, 17);
            this.similarFilesComparisonFileSize1Label.TabIndex = 4;
            this.similarFilesComparisonFileSize1Label.Text = "Veličina datoteke:";
            // 
            // similarFilesComparisonFileName1TxtBox
            // 
            this.similarFilesComparisonFileName1TxtBox.Location = new System.Drawing.Point(87, 39);
            this.similarFilesComparisonFileName1TxtBox.Name = "similarFilesComparisonFileName1TxtBox";
            this.similarFilesComparisonFileName1TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileName1TxtBox.Size = new System.Drawing.Size(243, 22);
            this.similarFilesComparisonFileName1TxtBox.TabIndex = 3;
            // 
            // similarFilesComparisonFileAuthor1TxtBox
            // 
            this.similarFilesComparisonFileAuthor1TxtBox.Location = new System.Drawing.Point(85, 12);
            this.similarFilesComparisonFileAuthor1TxtBox.Name = "similarFilesComparisonFileAuthor1TxtBox";
            this.similarFilesComparisonFileAuthor1TxtBox.ReadOnly = true;
            this.similarFilesComparisonFileAuthor1TxtBox.Size = new System.Drawing.Size(245, 22);
            this.similarFilesComparisonFileAuthor1TxtBox.TabIndex = 2;
            // 
            // similarFilesComparisonFileName1Label
            // 
            this.similarFilesComparisonFileName1Label.AutoSize = true;
            this.similarFilesComparisonFileName1Label.Location = new System.Drawing.Point(12, 42);
            this.similarFilesComparisonFileName1Label.Name = "similarFilesComparisonFileName1Label";
            this.similarFilesComparisonFileName1Label.Size = new System.Drawing.Size(69, 17);
            this.similarFilesComparisonFileName1Label.TabIndex = 1;
            this.similarFilesComparisonFileName1Label.Text = "Datoteka:";
            // 
            // similarFilesComparisonFileAuthor1Label
            // 
            this.similarFilesComparisonFileAuthor1Label.AutoSize = true;
            this.similarFilesComparisonFileAuthor1Label.Location = new System.Drawing.Point(12, 15);
            this.similarFilesComparisonFileAuthor1Label.Name = "similarFilesComparisonFileAuthor1Label";
            this.similarFilesComparisonFileAuthor1Label.Size = new System.Drawing.Size(67, 17);
            this.similarFilesComparisonFileAuthor1Label.TabIndex = 0;
            this.similarFilesComparisonFileAuthor1Label.Text = "JMBAG1:";
            // 
            // similarFilesComparisonResultsPanel
            // 
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonFinishOverviewBtn);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonSimilarityTxtBox);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonSimilarityLabel);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonPropertiesResultsTxtBox);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonCheckSumResultsTxtBox);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonWinnowingResultsTxtBox);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonPropertiesResultsLabel);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonCheckSumResultsLabel);
            this.similarFilesComparisonResultsPanel.Controls.Add(this.similarFilesComparisonWinnowingResultsLabel);
            this.similarFilesComparisonResultsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.similarFilesComparisonResultsPanel.Location = new System.Drawing.Point(0, 386);
            this.similarFilesComparisonResultsPanel.Name = "similarFilesComparisonResultsPanel";
            this.similarFilesComparisonResultsPanel.Size = new System.Drawing.Size(899, 127);
            this.similarFilesComparisonResultsPanel.TabIndex = 0;
            // 
            // similarFilesComparisonFinishOverviewBtn
            // 
            this.similarFilesComparisonFinishOverviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.similarFilesComparisonFinishOverviewBtn.Location = new System.Drawing.Point(699, 81);
            this.similarFilesComparisonFinishOverviewBtn.Name = "similarFilesComparisonFinishOverviewBtn";
            this.similarFilesComparisonFinishOverviewBtn.Size = new System.Drawing.Size(188, 34);
            this.similarFilesComparisonFinishOverviewBtn.TabIndex = 8;
            this.similarFilesComparisonFinishOverviewBtn.Text = "Završi pregledavanje";
            this.similarFilesComparisonFinishOverviewBtn.UseVisualStyleBackColor = true;
            this.similarFilesComparisonFinishOverviewBtn.Click += new System.EventHandler(this.similarFilesComparisonFinishOverviewBtn_Click);
            // 
            // similarFilesComparisonSimilarityTxtBox
            // 
            this.similarFilesComparisonSimilarityTxtBox.Location = new System.Drawing.Point(79, 90);
            this.similarFilesComparisonSimilarityTxtBox.Name = "similarFilesComparisonSimilarityTxtBox";
            this.similarFilesComparisonSimilarityTxtBox.ReadOnly = true;
            this.similarFilesComparisonSimilarityTxtBox.Size = new System.Drawing.Size(120, 22);
            this.similarFilesComparisonSimilarityTxtBox.TabIndex = 7;
            // 
            // similarFilesComparisonSimilarityLabel
            // 
            this.similarFilesComparisonSimilarityLabel.AutoSize = true;
            this.similarFilesComparisonSimilarityLabel.Location = new System.Drawing.Point(12, 91);
            this.similarFilesComparisonSimilarityLabel.Name = "similarFilesComparisonSimilarityLabel";
            this.similarFilesComparisonSimilarityLabel.Size = new System.Drawing.Size(61, 17);
            this.similarFilesComparisonSimilarityLabel.TabIndex = 6;
            this.similarFilesComparisonSimilarityLabel.Text = "Ukupno:";
            // 
            // similarFilesComparisonPropertiesResultsTxtBox
            // 
            this.similarFilesComparisonPropertiesResultsTxtBox.Location = new System.Drawing.Point(175, 62);
            this.similarFilesComparisonPropertiesResultsTxtBox.Name = "similarFilesComparisonPropertiesResultsTxtBox";
            this.similarFilesComparisonPropertiesResultsTxtBox.ReadOnly = true;
            this.similarFilesComparisonPropertiesResultsTxtBox.Size = new System.Drawing.Size(120, 22);
            this.similarFilesComparisonPropertiesResultsTxtBox.TabIndex = 5;
            // 
            // similarFilesComparisonCheckSumResultsTxtBox
            // 
            this.similarFilesComparisonCheckSumResultsTxtBox.Location = new System.Drawing.Point(104, 34);
            this.similarFilesComparisonCheckSumResultsTxtBox.Name = "similarFilesComparisonCheckSumResultsTxtBox";
            this.similarFilesComparisonCheckSumResultsTxtBox.ReadOnly = true;
            this.similarFilesComparisonCheckSumResultsTxtBox.Size = new System.Drawing.Size(120, 22);
            this.similarFilesComparisonCheckSumResultsTxtBox.TabIndex = 4;
            // 
            // similarFilesComparisonWinnowingResultsTxtBox
            // 
            this.similarFilesComparisonWinnowingResultsTxtBox.Location = new System.Drawing.Point(98, 6);
            this.similarFilesComparisonWinnowingResultsTxtBox.Name = "similarFilesComparisonWinnowingResultsTxtBox";
            this.similarFilesComparisonWinnowingResultsTxtBox.ReadOnly = true;
            this.similarFilesComparisonWinnowingResultsTxtBox.Size = new System.Drawing.Size(120, 22);
            this.similarFilesComparisonWinnowingResultsTxtBox.TabIndex = 3;
            // 
            // similarFilesComparisonPropertiesResultsLabel
            // 
            this.similarFilesComparisonPropertiesResultsLabel.AutoSize = true;
            this.similarFilesComparisonPropertiesResultsLabel.Location = new System.Drawing.Point(12, 65);
            this.similarFilesComparisonPropertiesResultsLabel.Name = "similarFilesComparisonPropertiesResultsLabel";
            this.similarFilesComparisonPropertiesResultsLabel.Size = new System.Drawing.Size(157, 17);
            this.similarFilesComparisonPropertiesResultsLabel.TabIndex = 2;
            this.similarFilesComparisonPropertiesResultsLabel.Text = "Karakteristike datoteke:";
            // 
            // similarFilesComparisonCheckSumResultsLabel
            // 
            this.similarFilesComparisonCheckSumResultsLabel.AutoSize = true;
            this.similarFilesComparisonCheckSumResultsLabel.Location = new System.Drawing.Point(12, 37);
            this.similarFilesComparisonCheckSumResultsLabel.Name = "similarFilesComparisonCheckSumResultsLabel";
            this.similarFilesComparisonCheckSumResultsLabel.Size = new System.Drawing.Size(86, 17);
            this.similarFilesComparisonCheckSumResultsLabel.TabIndex = 1;
            this.similarFilesComparisonCheckSumResultsLabel.Text = "CheckSums:";
            // 
            // similarFilesComparisonWinnowingResultsLabel
            // 
            this.similarFilesComparisonWinnowingResultsLabel.AutoSize = true;
            this.similarFilesComparisonWinnowingResultsLabel.Location = new System.Drawing.Point(12, 9);
            this.similarFilesComparisonWinnowingResultsLabel.Name = "similarFilesComparisonWinnowingResultsLabel";
            this.similarFilesComparisonWinnowingResultsLabel.Size = new System.Drawing.Size(80, 17);
            this.similarFilesComparisonWinnowingResultsLabel.TabIndex = 0;
            this.similarFilesComparisonWinnowingResultsLabel.Text = "Winnowing:";
            // 
            // algorithmParameterAdjustmentCheckSumCheckBox
            // 
            this.algorithmParameterAdjustmentCheckSumCheckBox.AutoSize = true;
            this.algorithmParameterAdjustmentCheckSumCheckBox.Location = new System.Drawing.Point(15, 123);
            this.algorithmParameterAdjustmentCheckSumCheckBox.Name = "algorithmParameterAdjustmentCheckSumCheckBox";
            this.algorithmParameterAdjustmentCheckSumCheckBox.Size = new System.Drawing.Size(97, 21);
            this.algorithmParameterAdjustmentCheckSumCheckBox.TabIndex = 22;
            this.algorithmParameterAdjustmentCheckSumCheckBox.Text = "CheckSum";
            this.algorithmParameterAdjustmentCheckSumCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 513);
            this.Controls.Add(this.algorithmParameterAdjustmentPanel);
            this.Controls.Add(this.taskDetailsPanel);
            this.Controls.Add(this.similarFilesComparisonPanel);
            this.Controls.Add(this.addFilesPanel);
            this.Controls.Add(this.createTaskPanel);
            this.Controls.Add(this.taskListPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(914, 550);
            this.Name = "frmMainWindow";
            this.Text = "Maat";
            this.Resize += new System.EventHandler(this.resize1Func);
            this.taskListPanel.ResumeLayout(false);
            this.taskListPanel.PerformLayout();
            this.taskListStatusStrip.ResumeLayout(false);
            this.taskListStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskListGrid)).EndInit();
            this.taskDetailsPanel.ResumeLayout(false);
            this.taskDetailsPanel.PerformLayout();
            this.taskDetailsStatusStrip.ResumeLayout(false);
            this.taskDetailsStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDetailsScanResultsGridView)).EndInit();
            this.createTaskPanel.ResumeLayout(false);
            this.createTaskPanel.PerformLayout();
            this.algorithmParameterAdjustmentPanel.ResumeLayout(false);
            this.algorithmParameterAdjustmentPanel.PerformLayout();
            this.algorithmParameterAdjustmentStatusStrip.ResumeLayout(false);
            this.algorithmParameterAdjustmentStatusStrip.PerformLayout();
            this.addFilesPanel.ResumeLayout(false);
            this.addFilesPanel.PerformLayout();
            this.addFilesStatusStrip.ResumeLayout(false);
            this.addFilesStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFilesFileListGridView)).EndInit();
            this.similarFilesComparisonPanel.ResumeLayout(false);
            this.similarFilesComparisonFileInfo2Panel.ResumeLayout(false);
            this.similarFilesComparisonFileInfo2Panel.PerformLayout();
            this.similarFilesComparisonFileInfo1Panel.ResumeLayout(false);
            this.similarFilesComparisonFileInfo1Panel.PerformLayout();
            this.similarFilesComparisonResultsPanel.ResumeLayout(false);
            this.similarFilesComparisonResultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskListPanel;
        private System.Windows.Forms.DataGridView taskListGrid;
        private System.Windows.Forms.Button taskListNewTaskBtn;
        private System.Windows.Forms.Panel taskDetailsPanel;
        private System.Windows.Forms.Button taskDetailsReturnToTaskListBtn;
        private System.Windows.Forms.DataGridView taskDetailsScanResultsGridView;
        private System.Windows.Forms.Panel createTaskPanel;
        private System.Windows.Forms.TextBox createTaskDescTxtBox;
        private System.Windows.Forms.TextBox createTaskCourseTxtBox;
        private System.Windows.Forms.Label createTaskDescriptionLabel;
        private System.Windows.Forms.Label createTaskCourseLabel;
        private System.Windows.Forms.TextBox createTaskNameTxtBox;
        private System.Windows.Forms.Label createTaskNameLabel;
        private System.Windows.Forms.Button createTaskCancelBtn;
        private System.Windows.Forms.Button createTaskCreateTaskBtn;
        private System.Windows.Forms.Panel algorithmParameterAdjustmentPanel;
        private System.Windows.Forms.Label algorithmParameterAdjustmentWindowSizeLabel;
        private System.Windows.Forms.Label algorithmParameterAdjustmentKGramLengthLabel;
        private System.Windows.Forms.TextBox algorithmParameterAdjustmentKGramLengthTxtBox;
        private System.Windows.Forms.Label algorithmParameterAdjustmentWinnowingLabel;
        private System.Windows.Forms.TextBox algorithmParameterAdjustmentWindowSizeTxtBox;
        private System.Windows.Forms.Button algorithmParameterAdjustmentCancelBtn;
        private System.Windows.Forms.Button algorithmParameterAdjustmentSaveBtn;
        private System.Windows.Forms.Panel addFilesPanel;
        private System.Windows.Forms.Button addFilesCancelBtn;
        private System.Windows.Forms.Button addFilesSaveBtn;
        private System.Windows.Forms.Button addFilesAddManyAuthorsArchivesBtn;
        private System.Windows.Forms.DataGridView addFilesFileListGridView;
        private System.Windows.Forms.Label addFilesFileListLabel;
        private System.Windows.Forms.Panel similarFilesComparisonPanel;
        private System.Windows.Forms.ComboBox algorithmParameterAdjustmentPropertiesComboBox;
        private System.Windows.Forms.ComboBox algorithmParameterAdjustmentWinnowingComboBox;
        private System.Windows.Forms.Label algorithmParameterAdjustmentPropertiesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListJMBAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListCheckSumBeforePreprocessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListCheckSumAfterPreprocessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddFilesFileListFileContent;
        private System.Windows.Forms.DataGridViewButtonColumn AddFilesFileListRemoveBtn;
        private System.Windows.Forms.Button taskDetailsLastPageBtn;
        private System.Windows.Forms.Button taskDetailsNextPageBtn;
        private System.Windows.Forms.Button taskDetailsPreviousPageBtn;
        private System.Windows.Forms.Button taskDetailsFirstPageBtn;
        private System.Windows.Forms.Button addFilesFirstPageBtn;
        private System.Windows.Forms.Button addFilesLastPageBtn;
        private System.Windows.Forms.Button addFilesNextPageBtn;
        private System.Windows.Forms.Button addFilesPreviousPageBtn;
        private System.Windows.Forms.Button taskListLastPageBtn;
        private System.Windows.Forms.Button taskListNextPageBtn;
        private System.Windows.Forms.Button taskListPreviousPageBtn;
        private System.Windows.Forms.Button taskListFirstPageBtn;
        private System.Windows.Forms.Label addFilesResultsPerPageLabel;
        private System.Windows.Forms.ComboBox addFilesResultsPerPageComboBox;
        private System.Windows.Forms.ComboBox taskDetailsResultsPerPageComboBox;
        private System.Windows.Forms.Label taskDetailsResultsPerPageLabel;
        private System.Windows.Forms.StatusStrip taskListStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel taskListStatusStripPageInfo;
        private System.Windows.Forms.ToolStripStatusLabel taskListStatusStripNoOfTasks;
        private System.Windows.Forms.ComboBox taskListResultsPerPageComboBox;
        private System.Windows.Forms.Label taskListResultsPerPageLabel;
        private System.Windows.Forms.StatusStrip taskDetailsStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel taskDetailsStatusStripTaskName;
        private System.Windows.Forms.ToolStripStatusLabel taskDetailsStatusStripPageInfo;
        private System.Windows.Forms.ToolStripStatusLabel taskDetailsStatusStripNoOfResults;
        private System.Windows.Forms.StatusStrip addFilesStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel addFilesStatusStripTaskName;
        private System.Windows.Forms.ToolStripStatusLabel addFilesStatusStripPageInfo;
        private System.Windows.Forms.ToolStripStatusLabel addFilesStatusStripNoOfFiles;
        private System.Windows.Forms.TextBox taskDetailsThresholdTxtBox;
        private System.Windows.Forms.Label taskDetailsThresholdLabel;
        private System.Windows.Forms.StatusStrip algorithmParameterAdjustmentStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel algorithmParameterAdjustmentTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListTaskCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListTaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListTaskCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListNoOfStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskListNoOfFilesLoaded;
        private System.Windows.Forms.DataGridViewButtonColumn TaskListTaskAddFile;
        private System.Windows.Forms.DataGridViewButtonColumn TaskListAlgorithmParameters;
        private System.Windows.Forms.DataGridViewButtonColumn TaskListTaskResults;
        private System.Windows.Forms.DataGridViewButtonColumn TaskListDeleteTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanResultsJMBAG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanResultsFile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanResultsJMBAG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanResultsFile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanResultsSimilarity;
        private System.Windows.Forms.DataGridViewButtonColumn ScanResultsViewDetails;
        private System.Windows.Forms.Panel similarFilesComparisonFileInfo2Panel;
        private System.Windows.Forms.TextBox similarFilesComparisonFileName2TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonFileAuthor2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonFileName2Label;
        private System.Windows.Forms.Label similarFilesComparisonFileAuthor2Label;
        private System.Windows.Forms.Panel similarFilesComparisonFileInfo1Panel;
        private System.Windows.Forms.TextBox similarFilesComparisonFileName1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonFileAuthor1TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonFileName1Label;
        private System.Windows.Forms.Label similarFilesComparisonFileAuthor1Label;
        private System.Windows.Forms.Panel similarFilesComparisonResultsPanel;
        private System.Windows.Forms.Label similarFilesComparisonHashBeforePreprocessing1Label;
        private System.Windows.Forms.Label similarFilesComparisonNoOfBlockComments1Label;
        private System.Windows.Forms.Label similarFilesComparisonNoOfLineComments1Label;
        private System.Windows.Forms.Label similarFilesComparisonNoOfEmptyLines1Label;
        private System.Windows.Forms.Label similarFilesComparisonNoOfLines1Label;
        private System.Windows.Forms.Label similarFilesComparisonFileSize1Label;
        private System.Windows.Forms.Label similarFilesComparisonHashAfterPreprocessing1Label;
        private System.Windows.Forms.TextBox similarFilesComparisonFileSize2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonFileSize2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonFileSize1TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonNoOfLines2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonHashAfterPreprocessing1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonHashBeforePreprocessing1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfBlockComments1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfLineComments1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfEmptyLines1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfLines1TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfLines2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonNoOfEmptyLines2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfEmptyLines2TxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfLineComments2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonNoOfLineComments2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonNoOfBlockComments2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonNoOfBlockComments2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonHashBeforePreprocessing2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonHashBeforePreprocessing2Label;
        private System.Windows.Forms.TextBox similarFilesComparisonHashAfterPreprocessing2TxtBox;
        private System.Windows.Forms.Label similarFilesComparisonHashAfterPreprocessing2Label;
        private System.Windows.Forms.Label similarFilesComparisonPropertiesResultsLabel;
        private System.Windows.Forms.Label similarFilesComparisonCheckSumResultsLabel;
        private System.Windows.Forms.Label similarFilesComparisonWinnowingResultsLabel;
        private System.Windows.Forms.TextBox similarFilesComparisonPropertiesResultsTxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonCheckSumResultsTxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonWinnowingResultsTxtBox;
        private System.Windows.Forms.TextBox similarFilesComparisonSimilarityTxtBox;
        private System.Windows.Forms.Label similarFilesComparisonSimilarityLabel;
        private System.Windows.Forms.Button similarFilesComparisonFinishOverviewBtn;
        private System.Windows.Forms.Button taskDetailsGenerateExcelReport;
        private System.Windows.Forms.CheckBox algorithmParameterAdjustmentCheckSumCheckBox;
    }
}

