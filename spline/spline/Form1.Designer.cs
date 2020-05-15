namespace spline
{
    partial class Form1
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

        [System.ComponentModel.Browsable(false)]
        public event System.Windows.Forms.MouseEventHandler MouseWheel;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.zedGraphControlMain = new ZedGraph.ZedGraphControl();
            this.panelButtonHide = new System.Windows.Forms.Panel();
            this.buttonMenuHide = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridViewErrorSpline = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewParam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChangeTable = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelMaxError2d = new System.Windows.Forms.Panel();
            this.textBoxMaxError2dX = new System.Windows.Forms.TextBox();
            this.labelMaxError2dEnd = new System.Windows.Forms.Label();
            this.textBoxMaxError2d = new System.Windows.Forms.TextBox();
            this.labelMaxError2dBegin = new System.Windows.Forms.Label();
            this.panelMaxError1d = new System.Windows.Forms.Panel();
            this.textBoxMaxError1dX = new System.Windows.Forms.TextBox();
            this.labelMaxError1dEnd = new System.Windows.Forms.Label();
            this.textBoxMaxError1d = new System.Windows.Forms.TextBox();
            this.labelMaxError1dBegin = new System.Windows.Forms.Label();
            this.panelMaxErrorFunc = new System.Windows.Forms.Panel();
            this.textBoxMaxErrorFuncX = new System.Windows.Forms.TextBox();
            this.labelMaxErrorFuncEnd = new System.Windows.Forms.Label();
            this.textBoxMaxErrorFunc = new System.Windows.Forms.TextBox();
            this.labelMaxErrorFuncBegin = new System.Windows.Forms.Label();
            this.panelMainGrid = new System.Windows.Forms.Panel();
            this.textBoxMainGrid = new System.Windows.Forms.TextBox();
            this.labelMainGrid = new System.Windows.Forms.Label();
            this.panelSplineGrid = new System.Windows.Forms.Panel();
            this.textBoxSplineGrid = new System.Windows.Forms.TextBox();
            this.labelSplineGrid = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelSplineControl = new System.Windows.Forms.Panel();
            this.panelGraphParam = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonVisibleError = new System.Windows.Forms.Button();
            this.buttonVisibleSpline = new System.Windows.Forms.Button();
            this.buttonVisibleFunction = new System.Windows.Forms.Button();
            this.panelPerspective = new System.Windows.Forms.Panel();
            this.button2d = new System.Windows.Forms.Button();
            this.button1d = new System.Windows.Forms.Button();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelParam = new System.Windows.Forms.Panel();
            this.buttonLines = new System.Windows.Forms.Button();
            this.panelErrorSpline = new System.Windows.Forms.Panel();
            this.textBoxErrorSpline = new System.Windows.Forms.TextBox();
            this.labelErrorSpline = new System.Windows.Forms.Label();
            this.panelFragCount = new System.Windows.Forms.Panel();
            this.textBoxFragCount = new System.Windows.Forms.TextBox();
            this.labelFragCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOscTask = new System.Windows.Forms.Panel();
            this.buttonOscTask = new System.Windows.Forms.Button();
            this.labelOscP = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelMainTask = new System.Windows.Forms.Panel();
            this.buttonMainTask = new System.Windows.Forms.Button();
            this.labelMainP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTest = new System.Windows.Forms.Panel();
            this.buttonTestTask = new System.Windows.Forms.Button();
            this.labelTestP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelCurStatus = new System.Windows.Forms.Panel();
            this.statusAnimation = new System.ComponentModel.BackgroundWorker();
            this.runSpline = new System.ComponentModel.BackgroundWorker();
            this.panelMain.SuspendLayout();
            this.panelGraph.SuspendLayout();
            this.panelButtonHide.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorSpline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelMaxError2d.SuspendLayout();
            this.panelMaxError1d.SuspendLayout();
            this.panelMaxErrorFunc.SuspendLayout();
            this.panelMainGrid.SuspendLayout();
            this.panelSplineGrid.SuspendLayout();
            this.panelSplineControl.SuspendLayout();
            this.panelGraphParam.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelPerspective.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panelErrorSpline.SuspendLayout();
            this.panelFragCount.SuspendLayout();
            this.panelOscTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelMainTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelMain.Controls.Add(this.panelGraph);
            this.panelMain.Controls.Add(this.panelButtonHide);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(2087, 863);
            this.panelMain.TabIndex = 0;
            // 
            // panelGraph
            // 
            this.panelGraph.Controls.Add(this.zedGraphControlMain);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(530, 0);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1557, 833);
            this.panelGraph.TabIndex = 0;
            // 
            // zedGraphControlMain
            // 
            this.zedGraphControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlMain.IsShowPointValues = false;
            this.zedGraphControlMain.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControlMain.Name = "zedGraphControlMain";
            this.zedGraphControlMain.PointValueFormat = "G";
            this.zedGraphControlMain.Size = new System.Drawing.Size(1557, 833);
            this.zedGraphControlMain.TabIndex = 0;
            this.zedGraphControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseDown);
            this.zedGraphControlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseMove);
            this.zedGraphControlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseUp);
            this.zedGraphControlMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseWheel);
            // 
            // panelButtonHide
            // 
            this.panelButtonHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(3)))), ((int)(((byte)(192)))));
            this.panelButtonHide.Controls.Add(this.buttonMenuHide);
            this.panelButtonHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonHide.Location = new System.Drawing.Point(500, 0);
            this.panelButtonHide.Name = "panelButtonHide";
            this.panelButtonHide.Size = new System.Drawing.Size(30, 833);
            this.panelButtonHide.TabIndex = 1;
            // 
            // buttonMenuHide
            // 
            this.buttonMenuHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMenuHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenuHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenuHide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenuHide.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuHide.Name = "buttonMenuHide";
            this.buttonMenuHide.Size = new System.Drawing.Size(30, 833);
            this.buttonMenuHide.TabIndex = 0;
            this.buttonMenuHide.Text = "◀";
            this.buttonMenuHide.UseVisualStyleBackColor = true;
            this.buttonMenuHide.Click += new System.EventHandler(this.buttonMenuHide_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(3)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.panelTable);
            this.panelMenu.Controls.Add(this.buttonTable);
            this.panelMenu.Controls.Add(this.panelInfo);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.panelSplineControl);
            this.panelMenu.Controls.Add(this.panelOscTask);
            this.panelMenu.Controls.Add(this.panelMainTask);
            this.panelMenu.Controls.Add(this.panelTest);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(500, 833);
            this.panelMenu.TabIndex = 2;
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.panelTable.Controls.Add(this.dataGridViewErrorSpline);
            this.panelTable.Controls.Add(this.dataGridViewParam);
            this.panelTable.Controls.Add(this.buttonChangeTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 540);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(500, 293);
            this.panelTable.TabIndex = 7;
            this.panelTable.Visible = false;
            // 
            // dataGridViewErrorSpline
            // 
            this.dataGridViewErrorSpline.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.dataGridViewErrorSpline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewErrorSpline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewErrorSpline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrorSpline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewErrorSpline.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewErrorSpline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewErrorSpline.EnableHeadersVisualStyles = false;
            this.dataGridViewErrorSpline.GridColor = System.Drawing.Color.White;
            this.dataGridViewErrorSpline.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewErrorSpline.Name = "dataGridViewErrorSpline";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewErrorSpline.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewErrorSpline.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.dataGridViewErrorSpline.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewErrorSpline.Size = new System.Drawing.Size(500, 263);
            this.dataGridViewErrorSpline.TabIndex = 2;
            this.dataGridViewErrorSpline.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "j";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "xj";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "F(xj)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "S(xj)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "F(xj)-S(xj)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "F\'(xj)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "S\'(xj)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "F\'(xj)-S\'(xj)";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "F\'\'(xj)";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "S\'\'(xj)";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "F\'\'(xj)-S\'\'(xj)";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // dataGridViewParam
            // 
            this.dataGridViewParam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.dataGridViewParam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParam.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParam.EnableHeadersVisualStyles = false;
            this.dataGridViewParam.GridColor = System.Drawing.Color.White;
            this.dataGridViewParam.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewParam.Name = "dataGridViewParam";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParam.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewParam.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.dataGridViewParam.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewParam.Size = new System.Drawing.Size(500, 263);
            this.dataGridViewParam.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "i";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "xi-1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "xi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ai";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "bi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ci";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "di";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // buttonChangeTable
            // 
            this.buttonChangeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChangeTable.Location = new System.Drawing.Point(0, 0);
            this.buttonChangeTable.Name = "buttonChangeTable";
            this.buttonChangeTable.Size = new System.Drawing.Size(500, 30);
            this.buttonChangeTable.TabIndex = 0;
            this.buttonChangeTable.Text = "Parameters of spline";
            this.buttonChangeTable.UseVisualStyleBackColor = true;
            this.buttonChangeTable.Click += new System.EventHandler(this.buttonChangeTable_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTable.Location = new System.Drawing.Point(0, 500);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(500, 40);
            this.buttonTable.TabIndex = 6;
            this.buttonTable.Text = "▼ TABLE ▼";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.panelInfo.Controls.Add(this.panelMaxError2d);
            this.panelInfo.Controls.Add(this.panelMaxError1d);
            this.panelInfo.Controls.Add(this.panelMaxErrorFunc);
            this.panelInfo.Controls.Add(this.panelMainGrid);
            this.panelInfo.Controls.Add(this.panelSplineGrid);
            this.panelInfo.Controls.Add(this.panel6);
            this.panelInfo.Controls.Add(this.panel5);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 338);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(500, 162);
            this.panelInfo.TabIndex = 5;
            this.panelInfo.Visible = false;
            // 
            // panelMaxError2d
            // 
            this.panelMaxError2d.Controls.Add(this.textBoxMaxError2dX);
            this.panelMaxError2d.Controls.Add(this.labelMaxError2dEnd);
            this.panelMaxError2d.Controls.Add(this.textBoxMaxError2d);
            this.panelMaxError2d.Controls.Add(this.labelMaxError2dBegin);
            this.panelMaxError2d.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaxError2d.Location = new System.Drawing.Point(10, 130);
            this.panelMaxError2d.Name = "panelMaxError2d";
            this.panelMaxError2d.Size = new System.Drawing.Size(490, 30);
            this.panelMaxError2d.TabIndex = 9;
            // 
            // textBoxMaxError2dX
            // 
            this.textBoxMaxError2dX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxError2dX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxError2dX.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxError2dX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxError2dX.Location = new System.Drawing.Point(331, 0);
            this.textBoxMaxError2dX.Name = "textBoxMaxError2dX";
            this.textBoxMaxError2dX.ReadOnly = true;
            this.textBoxMaxError2dX.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxError2dX.TabIndex = 9;
            // 
            // labelMaxError2dEnd
            // 
            this.labelMaxError2dEnd.AutoSize = true;
            this.labelMaxError2dEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxError2dEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxError2dEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxError2dEnd.Location = new System.Drawing.Point(280, 0);
            this.labelMaxError2dEnd.Name = "labelMaxError2dEnd";
            this.labelMaxError2dEnd.Size = new System.Drawing.Size(51, 24);
            this.labelMaxError2dEnd.TabIndex = 8;
            this.labelMaxError2dEnd.Text = ", x = ";
            // 
            // textBoxMaxError2d
            // 
            this.textBoxMaxError2d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxError2d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxError2d.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxError2d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxError2d.Location = new System.Drawing.Point(180, 0);
            this.textBoxMaxError2d.Name = "textBoxMaxError2d";
            this.textBoxMaxError2d.ReadOnly = true;
            this.textBoxMaxError2d.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxError2d.TabIndex = 5;
            // 
            // labelMaxError2dBegin
            // 
            this.labelMaxError2dBegin.AutoSize = true;
            this.labelMaxError2dBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxError2dBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxError2dBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxError2dBegin.Location = new System.Drawing.Point(0, 0);
            this.labelMaxError2dBegin.Name = "labelMaxError2dBegin";
            this.labelMaxError2dBegin.Size = new System.Drawing.Size(180, 24);
            this.labelMaxError2dBegin.TabIndex = 4;
            this.labelMaxError2dBegin.Text = "max | F\'\'(x) - S\'\'(x)| =";
            // 
            // panelMaxError1d
            // 
            this.panelMaxError1d.Controls.Add(this.textBoxMaxError1dX);
            this.panelMaxError1d.Controls.Add(this.labelMaxError1dEnd);
            this.panelMaxError1d.Controls.Add(this.textBoxMaxError1d);
            this.panelMaxError1d.Controls.Add(this.labelMaxError1dBegin);
            this.panelMaxError1d.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaxError1d.Location = new System.Drawing.Point(10, 100);
            this.panelMaxError1d.Name = "panelMaxError1d";
            this.panelMaxError1d.Size = new System.Drawing.Size(490, 30);
            this.panelMaxError1d.TabIndex = 8;
            // 
            // textBoxMaxError1dX
            // 
            this.textBoxMaxError1dX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxError1dX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxError1dX.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxError1dX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxError1dX.Location = new System.Drawing.Point(323, 0);
            this.textBoxMaxError1dX.Name = "textBoxMaxError1dX";
            this.textBoxMaxError1dX.ReadOnly = true;
            this.textBoxMaxError1dX.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxError1dX.TabIndex = 9;
            // 
            // labelMaxError1dEnd
            // 
            this.labelMaxError1dEnd.AutoSize = true;
            this.labelMaxError1dEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxError1dEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxError1dEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxError1dEnd.Location = new System.Drawing.Point(272, 0);
            this.labelMaxError1dEnd.Name = "labelMaxError1dEnd";
            this.labelMaxError1dEnd.Size = new System.Drawing.Size(51, 24);
            this.labelMaxError1dEnd.TabIndex = 8;
            this.labelMaxError1dEnd.Text = ", x = ";
            // 
            // textBoxMaxError1d
            // 
            this.textBoxMaxError1d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxError1d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxError1d.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxError1d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxError1d.Location = new System.Drawing.Point(172, 0);
            this.textBoxMaxError1d.Name = "textBoxMaxError1d";
            this.textBoxMaxError1d.ReadOnly = true;
            this.textBoxMaxError1d.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxError1d.TabIndex = 5;
            // 
            // labelMaxError1dBegin
            // 
            this.labelMaxError1dBegin.AutoSize = true;
            this.labelMaxError1dBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxError1dBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxError1dBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxError1dBegin.Location = new System.Drawing.Point(0, 0);
            this.labelMaxError1dBegin.Name = "labelMaxError1dBegin";
            this.labelMaxError1dBegin.Size = new System.Drawing.Size(172, 24);
            this.labelMaxError1dBegin.TabIndex = 4;
            this.labelMaxError1dBegin.Text = "max | F\'(x) - S\'(x)| =";
            // 
            // panelMaxErrorFunc
            // 
            this.panelMaxErrorFunc.Controls.Add(this.textBoxMaxErrorFuncX);
            this.panelMaxErrorFunc.Controls.Add(this.labelMaxErrorFuncEnd);
            this.panelMaxErrorFunc.Controls.Add(this.textBoxMaxErrorFunc);
            this.panelMaxErrorFunc.Controls.Add(this.labelMaxErrorFuncBegin);
            this.panelMaxErrorFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaxErrorFunc.Location = new System.Drawing.Point(10, 70);
            this.panelMaxErrorFunc.Name = "panelMaxErrorFunc";
            this.panelMaxErrorFunc.Size = new System.Drawing.Size(490, 30);
            this.panelMaxErrorFunc.TabIndex = 7;
            // 
            // textBoxMaxErrorFuncX
            // 
            this.textBoxMaxErrorFuncX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxErrorFuncX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxErrorFuncX.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxErrorFuncX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxErrorFuncX.Location = new System.Drawing.Point(315, 0);
            this.textBoxMaxErrorFuncX.Name = "textBoxMaxErrorFuncX";
            this.textBoxMaxErrorFuncX.ReadOnly = true;
            this.textBoxMaxErrorFuncX.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxErrorFuncX.TabIndex = 7;
            // 
            // labelMaxErrorFuncEnd
            // 
            this.labelMaxErrorFuncEnd.AutoSize = true;
            this.labelMaxErrorFuncEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxErrorFuncEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxErrorFuncEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxErrorFuncEnd.Location = new System.Drawing.Point(264, 0);
            this.labelMaxErrorFuncEnd.Name = "labelMaxErrorFuncEnd";
            this.labelMaxErrorFuncEnd.Size = new System.Drawing.Size(51, 24);
            this.labelMaxErrorFuncEnd.TabIndex = 6;
            this.labelMaxErrorFuncEnd.Text = ", x = ";
            // 
            // textBoxMaxErrorFunc
            // 
            this.textBoxMaxErrorFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMaxErrorFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxErrorFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxErrorFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxErrorFunc.Location = new System.Drawing.Point(164, 0);
            this.textBoxMaxErrorFunc.Name = "textBoxMaxErrorFunc";
            this.textBoxMaxErrorFunc.ReadOnly = true;
            this.textBoxMaxErrorFunc.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxErrorFunc.TabIndex = 5;
            // 
            // labelMaxErrorFuncBegin
            // 
            this.labelMaxErrorFuncBegin.AutoSize = true;
            this.labelMaxErrorFuncBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxErrorFuncBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxErrorFuncBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxErrorFuncBegin.Location = new System.Drawing.Point(0, 0);
            this.labelMaxErrorFuncBegin.Name = "labelMaxErrorFuncBegin";
            this.labelMaxErrorFuncBegin.Size = new System.Drawing.Size(164, 24);
            this.labelMaxErrorFuncBegin.TabIndex = 4;
            this.labelMaxErrorFuncBegin.Text = "max | F(x) - S(x)| =";
            // 
            // panelMainGrid
            // 
            this.panelMainGrid.Controls.Add(this.textBoxMainGrid);
            this.panelMainGrid.Controls.Add(this.labelMainGrid);
            this.panelMainGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainGrid.Location = new System.Drawing.Point(10, 40);
            this.panelMainGrid.Name = "panelMainGrid";
            this.panelMainGrid.Size = new System.Drawing.Size(490, 30);
            this.panelMainGrid.TabIndex = 6;
            // 
            // textBoxMainGrid
            // 
            this.textBoxMainGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxMainGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMainGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMainGrid.Location = new System.Drawing.Point(133, 0);
            this.textBoxMainGrid.Name = "textBoxMainGrid";
            this.textBoxMainGrid.ReadOnly = true;
            this.textBoxMainGrid.Size = new System.Drawing.Size(100, 22);
            this.textBoxMainGrid.TabIndex = 5;
            // 
            // labelMainGrid
            // 
            this.labelMainGrid.AutoSize = true;
            this.labelMainGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMainGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMainGrid.Location = new System.Drawing.Point(0, 0);
            this.labelMainGrid.Name = "labelMainGrid";
            this.labelMainGrid.Size = new System.Drawing.Size(133, 24);
            this.labelMainGrid.TabIndex = 4;
            this.labelMainGrid.Text = "Main grid: N = ";
            // 
            // panelSplineGrid
            // 
            this.panelSplineGrid.Controls.Add(this.textBoxSplineGrid);
            this.panelSplineGrid.Controls.Add(this.labelSplineGrid);
            this.panelSplineGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSplineGrid.Location = new System.Drawing.Point(10, 10);
            this.panelSplineGrid.Name = "panelSplineGrid";
            this.panelSplineGrid.Size = new System.Drawing.Size(490, 30);
            this.panelSplineGrid.TabIndex = 5;
            // 
            // textBoxSplineGrid
            // 
            this.textBoxSplineGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(56)))), ((int)(((byte)(188)))));
            this.textBoxSplineGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSplineGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSplineGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSplineGrid.Location = new System.Drawing.Point(142, 0);
            this.textBoxSplineGrid.Name = "textBoxSplineGrid";
            this.textBoxSplineGrid.ReadOnly = true;
            this.textBoxSplineGrid.Size = new System.Drawing.Size(100, 22);
            this.textBoxSplineGrid.TabIndex = 5;
            // 
            // labelSplineGrid
            // 
            this.labelSplineGrid.AutoSize = true;
            this.labelSplineGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSplineGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSplineGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSplineGrid.Location = new System.Drawing.Point(0, 0);
            this.labelSplineGrid.Name = "labelSplineGrid";
            this.labelSplineGrid.Size = new System.Drawing.Size(142, 24);
            this.labelSplineGrid.TabIndex = 4;
            this.labelSplineGrid.Text = "Spline grid: n = ";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 152);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 10);
            this.panel5.TabIndex = 2;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInfo.Location = new System.Drawing.Point(0, 298);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(500, 40);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "▼ INFO ▼";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelSplineControl
            // 
            this.panelSplineControl.Controls.Add(this.panelGraphParam);
            this.panelSplineControl.Controls.Add(this.panelParam);
            this.panelSplineControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSplineControl.Location = new System.Drawing.Point(0, 198);
            this.panelSplineControl.Name = "panelSplineControl";
            this.panelSplineControl.Size = new System.Drawing.Size(500, 100);
            this.panelSplineControl.TabIndex = 3;
            // 
            // panelGraphParam
            // 
            this.panelGraphParam.Controls.Add(this.panel7);
            this.panelGraphParam.Controls.Add(this.panelPerspective);
            this.panelGraphParam.Controls.Add(this.panel4);
            this.panelGraphParam.Controls.Add(this.panel3);
            this.panelGraphParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGraphParam.Location = new System.Drawing.Point(250, 0);
            this.panelGraphParam.Name = "panelGraphParam";
            this.panelGraphParam.Size = new System.Drawing.Size(250, 100);
            this.panelGraphParam.TabIndex = 1;
            this.panelGraphParam.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonVisibleError);
            this.panel7.Controls.Add(this.buttonVisibleSpline);
            this.panel7.Controls.Add(this.buttonVisibleFunction);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(130, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 90);
            this.panel7.TabIndex = 4;
            // 
            // buttonVisibleError
            // 
            this.buttonVisibleError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(252)))), ((int)(((byte)(63)))));
            this.buttonVisibleError.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVisibleError.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisibleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisibleError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVisibleError.Location = new System.Drawing.Point(0, 60);
            this.buttonVisibleError.Name = "buttonVisibleError";
            this.buttonVisibleError.Size = new System.Drawing.Size(120, 30);
            this.buttonVisibleError.TabIndex = 2;
            this.buttonVisibleError.Text = "error";
            this.buttonVisibleError.UseVisualStyleBackColor = false;
            this.buttonVisibleError.Click += new System.EventHandler(this.buttonVisibleError_Click);
            // 
            // buttonVisibleSpline
            // 
            this.buttonVisibleSpline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(252)))), ((int)(((byte)(63)))));
            this.buttonVisibleSpline.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVisibleSpline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisibleSpline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisibleSpline.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVisibleSpline.Location = new System.Drawing.Point(0, 30);
            this.buttonVisibleSpline.Name = "buttonVisibleSpline";
            this.buttonVisibleSpline.Size = new System.Drawing.Size(120, 30);
            this.buttonVisibleSpline.TabIndex = 1;
            this.buttonVisibleSpline.Text = "spline";
            this.buttonVisibleSpline.UseVisualStyleBackColor = false;
            this.buttonVisibleSpline.Click += new System.EventHandler(this.buttonVisibleSpline_Click);
            // 
            // buttonVisibleFunction
            // 
            this.buttonVisibleFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(252)))), ((int)(((byte)(63)))));
            this.buttonVisibleFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVisibleFunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisibleFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisibleFunction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVisibleFunction.Location = new System.Drawing.Point(0, 0);
            this.buttonVisibleFunction.Name = "buttonVisibleFunction";
            this.buttonVisibleFunction.Size = new System.Drawing.Size(120, 30);
            this.buttonVisibleFunction.TabIndex = 0;
            this.buttonVisibleFunction.Text = "accurate";
            this.buttonVisibleFunction.UseVisualStyleBackColor = false;
            this.buttonVisibleFunction.Click += new System.EventHandler(this.buttonVisibleFunction_Click);
            // 
            // panelPerspective
            // 
            this.panelPerspective.Controls.Add(this.button2d);
            this.panelPerspective.Controls.Add(this.button1d);
            this.panelPerspective.Controls.Add(this.buttonFunc);
            this.panelPerspective.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPerspective.Location = new System.Drawing.Point(10, 10);
            this.panelPerspective.Name = "panelPerspective";
            this.panelPerspective.Size = new System.Drawing.Size(120, 90);
            this.panelPerspective.TabIndex = 3;
            // 
            // button2d
            // 
            this.button2d.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2d.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2d.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2d.Location = new System.Drawing.Point(0, 60);
            this.button2d.Name = "button2d";
            this.button2d.Size = new System.Drawing.Size(120, 30);
            this.button2d.TabIndex = 9;
            this.button2d.Text = "Second derivative";
            this.button2d.UseVisualStyleBackColor = true;
            this.button2d.Click += new System.EventHandler(this.button2d_Click);
            // 
            // button1d
            // 
            this.button1d.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1d.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1d.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1d.Location = new System.Drawing.Point(0, 30);
            this.button1d.Name = "button1d";
            this.button1d.Size = new System.Drawing.Size(120, 30);
            this.button1d.TabIndex = 8;
            this.button1d.Text = "First derivative";
            this.button1d.UseVisualStyleBackColor = true;
            this.button1d.Click += new System.EventHandler(this.button1d_Click);
            // 
            // buttonFunc
            // 
            this.buttonFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFunc.Location = new System.Drawing.Point(0, 0);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(120, 30);
            this.buttonFunc.TabIndex = 7;
            this.buttonFunc.Text = "Function";
            this.buttonFunc.UseVisualStyleBackColor = true;
            this.buttonFunc.Click += new System.EventHandler(this.buttonFunc_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 90);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 10);
            this.panel3.TabIndex = 1;
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.buttonLines);
            this.panelParam.Controls.Add(this.panelErrorSpline);
            this.panelParam.Controls.Add(this.panelFragCount);
            this.panelParam.Controls.Add(this.panel2);
            this.panelParam.Controls.Add(this.panel1);
            this.panelParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelParam.Location = new System.Drawing.Point(0, 0);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(250, 100);
            this.panelParam.TabIndex = 0;
            // 
            // buttonLines
            // 
            this.buttonLines.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLines.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLines.Location = new System.Drawing.Point(170, 70);
            this.buttonLines.Name = "buttonLines";
            this.buttonLines.Size = new System.Drawing.Size(80, 30);
            this.buttonLines.TabIndex = 6;
            this.buttonLines.Text = "LINES";
            this.buttonLines.UseVisualStyleBackColor = true;
            this.buttonLines.Visible = false;
            this.buttonLines.Click += new System.EventHandler(this.buttonLines_Click);
            // 
            // panelErrorSpline
            // 
            this.panelErrorSpline.Controls.Add(this.textBoxErrorSpline);
            this.panelErrorSpline.Controls.Add(this.labelErrorSpline);
            this.panelErrorSpline.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelErrorSpline.Location = new System.Drawing.Point(10, 40);
            this.panelErrorSpline.Name = "panelErrorSpline";
            this.panelErrorSpline.Size = new System.Drawing.Size(240, 30);
            this.panelErrorSpline.TabIndex = 5;
            this.panelErrorSpline.Visible = false;
            // 
            // textBoxErrorSpline
            // 
            this.textBoxErrorSpline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(3)))), ((int)(((byte)(192)))));
            this.textBoxErrorSpline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxErrorSpline.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxErrorSpline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxErrorSpline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxErrorSpline.Location = new System.Drawing.Point(120, 0);
            this.textBoxErrorSpline.Name = "textBoxErrorSpline";
            this.textBoxErrorSpline.Size = new System.Drawing.Size(67, 19);
            this.textBoxErrorSpline.TabIndex = 3;
            this.textBoxErrorSpline.Text = "0.001";
            this.textBoxErrorSpline.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            this.textBoxErrorSpline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_Move);
            // 
            // labelErrorSpline
            // 
            this.labelErrorSpline.AutoSize = true;
            this.labelErrorSpline.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelErrorSpline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorSpline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorSpline.Location = new System.Drawing.Point(0, 0);
            this.labelErrorSpline.Name = "labelErrorSpline";
            this.labelErrorSpline.Size = new System.Drawing.Size(120, 20);
            this.labelErrorSpline.TabIndex = 2;
            this.labelErrorSpline.Text = "Error of spline =";
            // 
            // panelFragCount
            // 
            this.panelFragCount.Controls.Add(this.textBoxFragCount);
            this.panelFragCount.Controls.Add(this.labelFragCount);
            this.panelFragCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFragCount.Location = new System.Drawing.Point(10, 10);
            this.panelFragCount.Name = "panelFragCount";
            this.panelFragCount.Size = new System.Drawing.Size(240, 30);
            this.panelFragCount.TabIndex = 4;
            // 
            // textBoxFragCount
            // 
            this.textBoxFragCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(3)))), ((int)(((byte)(192)))));
            this.textBoxFragCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFragCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxFragCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFragCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFragCount.Location = new System.Drawing.Point(173, 0);
            this.textBoxFragCount.Name = "textBoxFragCount";
            this.textBoxFragCount.Size = new System.Drawing.Size(67, 19);
            this.textBoxFragCount.TabIndex = 3;
            this.textBoxFragCount.Text = "5";
            this.textBoxFragCount.TextChanged += new System.EventHandler(this.textBoxTextChanged);
            this.textBoxFragCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_Move);
            // 
            // labelFragCount
            // 
            this.labelFragCount.AutoSize = true;
            this.labelFragCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFragCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFragCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFragCount.Location = new System.Drawing.Point(0, 0);
            this.labelFragCount.Name = "labelFragCount";
            this.labelFragCount.Size = new System.Drawing.Size(173, 20);
            this.labelFragCount.TabIndex = 2;
            this.labelFragCount.Text = "fragmentations count =";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 90);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 10);
            this.panel1.TabIndex = 0;
            // 
            // panelOscTask
            // 
            this.panelOscTask.Controls.Add(this.buttonOscTask);
            this.panelOscTask.Controls.Add(this.labelOscP);
            this.panelOscTask.Controls.Add(this.pictureBox3);
            this.panelOscTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOscTask.Location = new System.Drawing.Point(0, 132);
            this.panelOscTask.Name = "panelOscTask";
            this.panelOscTask.Size = new System.Drawing.Size(500, 66);
            this.panelOscTask.TabIndex = 2;
            // 
            // buttonOscTask
            // 
            this.buttonOscTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOscTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOscTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOscTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOscTask.Location = new System.Drawing.Point(202, 24);
            this.buttonOscTask.Name = "buttonOscTask";
            this.buttonOscTask.Size = new System.Drawing.Size(298, 42);
            this.buttonOscTask.TabIndex = 4;
            this.buttonOscTask.Text = "Solve oscillating task";
            this.buttonOscTask.UseVisualStyleBackColor = true;
            this.buttonOscTask.Click += new System.EventHandler(this.buttonOscTask_Click);
            // 
            // labelOscP
            // 
            this.labelOscP.AutoSize = true;
            this.labelOscP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOscP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOscP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOscP.Location = new System.Drawing.Point(202, 0);
            this.labelOscP.Name = "labelOscP";
            this.labelOscP.Size = new System.Drawing.Size(126, 24);
            this.labelOscP.TabIndex = 3;
            this.labelOscP.Text = "S\'\'(0)=S\'\'(1)=0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::spline.Properties.Resources.oscTask;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.InitialImage = global::spline.Properties.Resources.testTask;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 66);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panelMainTask
            // 
            this.panelMainTask.Controls.Add(this.buttonMainTask);
            this.panelMainTask.Controls.Add(this.labelMainP);
            this.panelMainTask.Controls.Add(this.pictureBox2);
            this.panelMainTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTask.Location = new System.Drawing.Point(0, 66);
            this.panelMainTask.Name = "panelMainTask";
            this.panelMainTask.Size = new System.Drawing.Size(500, 66);
            this.panelMainTask.TabIndex = 1;
            // 
            // buttonMainTask
            // 
            this.buttonMainTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMainTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMainTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMainTask.Location = new System.Drawing.Point(202, 24);
            this.buttonMainTask.Name = "buttonMainTask";
            this.buttonMainTask.Size = new System.Drawing.Size(298, 42);
            this.buttonMainTask.TabIndex = 3;
            this.buttonMainTask.Text = "Solve main task";
            this.buttonMainTask.UseVisualStyleBackColor = true;
            this.buttonMainTask.Click += new System.EventHandler(this.buttonMainTask_Click);
            // 
            // labelMainP
            // 
            this.labelMainP.AutoSize = true;
            this.labelMainP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMainP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMainP.Location = new System.Drawing.Point(202, 0);
            this.labelMainP.Name = "labelMainP";
            this.labelMainP.Size = new System.Drawing.Size(126, 24);
            this.labelMainP.TabIndex = 2;
            this.labelMainP.Text = "S\'\'(0)=S\'\'(1)=0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::spline.Properties.Resources.mainTask;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.InitialImage = global::spline.Properties.Resources.testTask;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 66);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelTest
            // 
            this.panelTest.Controls.Add(this.buttonTestTask);
            this.panelTest.Controls.Add(this.labelTestP);
            this.panelTest.Controls.Add(this.pictureBox1);
            this.panelTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTest.Location = new System.Drawing.Point(0, 0);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(500, 66);
            this.panelTest.TabIndex = 0;
            // 
            // buttonTestTask
            // 
            this.buttonTestTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTestTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTestTask.Location = new System.Drawing.Point(202, 24);
            this.buttonTestTask.Name = "buttonTestTask";
            this.buttonTestTask.Size = new System.Drawing.Size(298, 42);
            this.buttonTestTask.TabIndex = 2;
            this.buttonTestTask.Text = "Solve test task";
            this.buttonTestTask.UseVisualStyleBackColor = true;
            this.buttonTestTask.Click += new System.EventHandler(this.buttonTestTask_Click);
            // 
            // labelTestP
            // 
            this.labelTestP.AutoSize = true;
            this.labelTestP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTestP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTestP.Location = new System.Drawing.Point(202, 0);
            this.labelTestP.Name = "labelTestP";
            this.labelTestP.Size = new System.Drawing.Size(244, 24);
            this.labelTestP.TabIndex = 1;
            this.labelTestP.Text = "S\'\'(-1)=S\'\'(1)=φ\'\'(-1)=φ\'\'(1)=0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::spline.Properties.Resources.testTask;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.InitialImage = global::spline.Properties.Resources.testTask;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.panelCurStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 833);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(2087, 30);
            this.panelStatus.TabIndex = 1;
            // 
            // panelCurStatus
            // 
            this.panelCurStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCurStatus.Location = new System.Drawing.Point(0, 0);
            this.panelCurStatus.Name = "panelCurStatus";
            this.panelCurStatus.Size = new System.Drawing.Size(10, 28);
            this.panelCurStatus.TabIndex = 0;
            // 
            // statusAnimation
            // 
            this.statusAnimation.WorkerReportsProgress = true;
            this.statusAnimation.WorkerSupportsCancellation = true;
            this.statusAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.statusAnimation_DoWork);
            this.statusAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.statusAnimation_ProgressChanged);
            this.statusAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.statusAnimation_RunWorkerCompleted);
            // 
            // runSpline
            // 
            this.runSpline.WorkerReportsProgress = true;
            this.runSpline.WorkerSupportsCancellation = true;
            this.runSpline.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runSpline_DoWork);
            this.runSpline.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.runSpline_ProgressChanged);
            this.runSpline.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.runSpline_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2087, 863);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            this.panelButtonHide.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrorSpline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParam)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelMaxError2d.ResumeLayout(false);
            this.panelMaxError2d.PerformLayout();
            this.panelMaxError1d.ResumeLayout(false);
            this.panelMaxError1d.PerformLayout();
            this.panelMaxErrorFunc.ResumeLayout(false);
            this.panelMaxErrorFunc.PerformLayout();
            this.panelMainGrid.ResumeLayout(false);
            this.panelMainGrid.PerformLayout();
            this.panelSplineGrid.ResumeLayout(false);
            this.panelSplineGrid.PerformLayout();
            this.panelSplineControl.ResumeLayout(false);
            this.panelGraphParam.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelPerspective.ResumeLayout(false);
            this.panelParam.ResumeLayout(false);
            this.panelErrorSpline.ResumeLayout(false);
            this.panelErrorSpline.PerformLayout();
            this.panelFragCount.ResumeLayout(false);
            this.panelFragCount.PerformLayout();
            this.panelOscTask.ResumeLayout(false);
            this.panelOscTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelMainTask.ResumeLayout(false);
            this.panelMainTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtonHide;
        private System.Windows.Forms.Panel panelGraph;
        private ZedGraph.ZedGraphControl zedGraphControlMain;
        private System.Windows.Forms.Button buttonMenuHide;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonTestTask;
        private System.Windows.Forms.Label labelTestP;
        private System.Windows.Forms.Panel panelMainTask;
        private System.Windows.Forms.Panel panelOscTask;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelMainP;
        private System.Windows.Forms.Button buttonOscTask;
        private System.Windows.Forms.Label labelOscP;
        private System.Windows.Forms.Button buttonMainTask;
        private System.ComponentModel.BackgroundWorker statusAnimation;
        private System.ComponentModel.BackgroundWorker runSpline;
        private System.Windows.Forms.Panel panelSplineControl;
        private System.Windows.Forms.Panel panelGraphParam;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Panel panelFragCount;
        private System.Windows.Forms.Label labelFragCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFragCount;
        private System.Windows.Forms.Panel panelErrorSpline;
        private System.Windows.Forms.TextBox textBoxErrorSpline;
        private System.Windows.Forms.Label labelErrorSpline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLines;
        private System.Windows.Forms.Button button2d;
        private System.Windows.Forms.Button button1d;
        private System.Windows.Forms.Button buttonFunc;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonVisibleError;
        private System.Windows.Forms.Button buttonVisibleSpline;
        private System.Windows.Forms.Button buttonVisibleFunction;
        private System.Windows.Forms.Panel panelPerspective;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Label labelSplineGrid;
        private System.Windows.Forms.Panel panelSplineGrid;
        private System.Windows.Forms.TextBox textBoxSplineGrid;
        private System.Windows.Forms.Panel panelMaxError2d;
        private System.Windows.Forms.TextBox textBoxMaxError2dX;
        private System.Windows.Forms.Label labelMaxError2dEnd;
        private System.Windows.Forms.TextBox textBoxMaxError2d;
        private System.Windows.Forms.Label labelMaxError2dBegin;
        private System.Windows.Forms.Panel panelMaxError1d;
        private System.Windows.Forms.TextBox textBoxMaxError1dX;
        private System.Windows.Forms.Label labelMaxError1dEnd;
        private System.Windows.Forms.TextBox textBoxMaxError1d;
        private System.Windows.Forms.Label labelMaxError1dBegin;
        private System.Windows.Forms.Panel panelMaxErrorFunc;
        private System.Windows.Forms.TextBox textBoxMaxErrorFuncX;
        private System.Windows.Forms.Label labelMaxErrorFuncEnd;
        private System.Windows.Forms.TextBox textBoxMaxErrorFunc;
        private System.Windows.Forms.Label labelMaxErrorFuncBegin;
        private System.Windows.Forms.Panel panelMainGrid;
        private System.Windows.Forms.TextBox textBoxMainGrid;
        private System.Windows.Forms.Label labelMainGrid;
        private System.Windows.Forms.Button buttonChangeTable;
        private System.Windows.Forms.DataGridView dataGridViewParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dataGridViewErrorSpline;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Panel panelCurStatus;
    }
}

