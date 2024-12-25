namespace ciscoRTPStream
{
    partial class rtpStreamMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtpStreamMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkSourceCode = new System.Windows.Forms.LinkLabel();
            this.panelFooterRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupMediaSetup = new System.Windows.Forms.GroupBox();
            this.groupAddEndpoints = new System.Windows.Forms.GroupBox();
            this.groupAuthorization = new System.Windows.Forms.GroupBox();
            this.groupControls = new System.Windows.Forms.GroupBox();
            this.rtfClientDescription = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnValidateAndSave = new System.Windows.Forms.Button();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtCodec = new System.Windows.Forms.TextBox();
            this.txtSourceAddress = new System.Windows.Forms.TextBox();
            this.txtSourcePort = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnAdvReqMS = new System.Windows.Forms.Button();
            this.btnAdvReqEnd = new System.Windows.Forms.Button();
            this.btnAdvStrGo = new System.Windows.Forms.Button();
            this.btnAdvStrEnd = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblStreamStatus = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFooterRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupMediaSetup.SuspendLayout();
            this.groupAddEndpoints.SuspendLayout();
            this.groupAuthorization.SuspendLayout();
            this.groupControls.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lblTitle.Location = new System.Drawing.Point(173, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Cisco RTP Streaming Utility";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.panelFooterRight);
            this.panelFooter.Controls.Add(this.lblFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 684);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1247, 29);
            this.panelFooter.TabIndex = 2;
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkAbout.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.linkAbout.Location = new System.Drawing.Point(285, 8);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(41, 16);
            this.linkAbout.TabIndex = 5;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "About";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(9, 6);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(373, 17);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "(C) 2024 Github.com/Wriar. Licensed under MIT License";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitleDescription);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 111);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitleDescription
            // 
            this.lblTitleDescription.AutoSize = true;
            this.lblTitleDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lblTitleDescription.Location = new System.Drawing.Point(177, 67);
            this.lblTitleDescription.Name = "lblTitleDescription";
            this.lblTitleDescription.Size = new System.Drawing.Size(592, 19);
            this.lblTitleDescription.TabIndex = 3;
            this.lblTitleDescription.Text = "A tool to deliver a Multicast RTP Paging Stream to Cisco Collaboration Endpoints";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linkSourceCode
            // 
            this.linkSourceCode.AutoSize = true;
            this.linkSourceCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkSourceCode.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSourceCode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.linkSourceCode.Location = new System.Drawing.Point(99, 8);
            this.linkSourceCode.Name = "linkSourceCode";
            this.linkSourceCode.Size = new System.Drawing.Size(186, 16);
            this.linkSourceCode.TabIndex = 6;
            this.linkSourceCode.TabStop = true;
            this.linkSourceCode.Text = "Source Code && Documentation";
            this.linkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSourceCode_LinkClicked);
            // 
            // panelFooterRight
            // 
            this.panelFooterRight.Controls.Add(this.linkSourceCode);
            this.panelFooterRight.Controls.Add(this.linkAbout);
            this.panelFooterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFooterRight.Location = new System.Drawing.Point(916, 0);
            this.panelFooterRight.Name = "panelFooterRight";
            this.panelFooterRight.Padding = new System.Windows.Forms.Padding(10, 8, 5, 0);
            this.panelFooterRight.Size = new System.Drawing.Size(331, 29);
            this.panelFooterRight.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.groupControls, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupAuthorization, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupAddEndpoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupMediaSetup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 573);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupMediaSetup
            // 
            this.groupMediaSetup.Controls.Add(this.lblStreamStatus);
            this.groupMediaSetup.Controls.Add(this.txtVolume);
            this.groupMediaSetup.Controls.Add(this.tbVolume);
            this.groupMediaSetup.Controls.Add(this.txtSourcePort);
            this.groupMediaSetup.Controls.Add(this.txtSourceAddress);
            this.groupMediaSetup.Controls.Add(this.txtCodec);
            this.groupMediaSetup.Controls.Add(this.txtFile);
            this.groupMediaSetup.Controls.Add(this.btnSelectFile);
            this.groupMediaSetup.Controls.Add(this.label7);
            this.groupMediaSetup.Controls.Add(this.label6);
            this.groupMediaSetup.Controls.Add(this.label5);
            this.groupMediaSetup.Controls.Add(this.label4);
            this.groupMediaSetup.Controls.Add(this.label3);
            this.groupMediaSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMediaSetup.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMediaSetup.Location = new System.Drawing.Point(8, 8);
            this.groupMediaSetup.Name = "groupMediaSetup";
            this.groupMediaSetup.Size = new System.Drawing.Size(488, 444);
            this.groupMediaSetup.TabIndex = 0;
            this.groupMediaSetup.TabStop = false;
            this.groupMediaSetup.Text = "Media Setup";
            this.groupMediaSetup.Enter += new System.EventHandler(this.groupMediaSetup_Enter);
            // 
            // groupAddEndpoints
            // 
            this.groupAddEndpoints.Controls.Add(this.txtClients);
            this.groupAddEndpoints.Controls.Add(this.flowLayoutPanel1);
            this.groupAddEndpoints.Controls.Add(this.rtfClientDescription);
            this.groupAddEndpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAddEndpoints.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddEndpoints.Location = new System.Drawing.Point(502, 8);
            this.groupAddEndpoints.Name = "groupAddEndpoints";
            this.groupAddEndpoints.Padding = new System.Windows.Forms.Padding(5);
            this.groupAddEndpoints.Size = new System.Drawing.Size(737, 444);
            this.groupAddEndpoints.TabIndex = 1;
            this.groupAddEndpoints.TabStop = false;
            this.groupAddEndpoints.Text = "Clients";
            this.groupAddEndpoints.Enter += new System.EventHandler(this.groupAddEndpoints_Enter);
            // 
            // groupAuthorization
            // 
            this.groupAuthorization.Controls.Add(this.tableLayoutPanel2);
            this.groupAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAuthorization.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAuthorization.Location = new System.Drawing.Point(8, 458);
            this.groupAuthorization.Name = "groupAuthorization";
            this.groupAuthorization.Size = new System.Drawing.Size(488, 107);
            this.groupAuthorization.TabIndex = 2;
            this.groupAuthorization.TabStop = false;
            this.groupAuthorization.Text = "Authorization";
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.flowLayoutPanel2);
            this.groupControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControls.Location = new System.Drawing.Point(502, 458);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(737, 107);
            this.groupControls.TabIndex = 3;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Controls";
            // 
            // rtfClientDescription
            // 
            this.rtfClientDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtfClientDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfClientDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtfClientDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfClientDescription.Location = new System.Drawing.Point(5, 25);
            this.rtfClientDescription.Name = "rtfClientDescription";
            this.rtfClientDescription.Size = new System.Drawing.Size(727, 77);
            this.rtfClientDescription.TabIndex = 4;
            this.rtfClientDescription.Text = resources.GetString("rtfClientDescription.Text");
            this.rtfClientDescription.TextChanged += new System.EventHandler(this.rtfClientDescription_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnImport);
            this.flowLayoutPanel1.Controls.Add(this.btnValidateAndSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 391);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 48);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(117, 38);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.tooltip.SetToolTip(this.btnImport, "Import a CSV/TXT file of IP addresses (One IP per Line)");
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnValidateAndSave
            // 
            this.btnValidateAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateAndSave.Image = ((System.Drawing.Image)(resources.GetObject("btnValidateAndSave.Image")));
            this.btnValidateAndSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidateAndSave.Location = new System.Drawing.Point(126, 3);
            this.btnValidateAndSave.Name = "btnValidateAndSave";
            this.btnValidateAndSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnValidateAndSave.Size = new System.Drawing.Size(165, 38);
            this.btnValidateAndSave.TabIndex = 1;
            this.btnValidateAndSave.Text = "  Validate && Save";
            this.tooltip.SetToolTip(this.btnValidateAndSave, "Validate all IPs. Saves the corrected list, if requested.");
            this.btnValidateAndSave.UseVisualStyleBackColor = true;
            this.btnValidateAndSave.Click += new System.EventHandler(this.btnValidateAndSave_Click);
            // 
            // txtClients
            // 
            this.txtClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClients.Location = new System.Drawing.Point(5, 102);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(727, 289);
            this.txtClients.TabIndex = 6;
            this.txtClients.Text = "10.1.1.1";
            this.tooltip.SetToolTip(this.txtClients, "Add IPv4s for collaboration endpoints here. One IP per line. Click \'Validate\' bef" +
        "ore Streaming.");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(147, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(332, 27);
            this.txtUsername.TabIndex = 0;
            this.tooltip.SetToolTip(this.txtUsername, "Phone Username");
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(147, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(332, 27);
            this.txtPassword.TabIndex = 2;
            this.tooltip.SetToolTip(this.txtPassword, "Phone Password");
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnStart);
            this.flowLayoutPanel2.Controls.Add(this.btnStop);
            this.flowLayoutPanel2.Controls.Add(this.btnAdvReqMS);
            this.flowLayoutPanel2.Controls.Add(this.btnAdvReqEnd);
            this.flowLayoutPanel2.Controls.Add(this.btnAdvStrGo);
            this.flowLayoutPanel2.Controls.Add(this.btnAdvStrEnd);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(731, 81);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.tooltip.SetToolTip(this.btnStart, "Enable RTP Listening on phones and starts stream.");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(100, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 62);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.tooltip.SetToolTip(this.btnStop, "Disable RTP listening on phones and stops stream.");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label3.Location = new System.Drawing.Point(92, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "File:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label4.Location = new System.Drawing.Point(71, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codec:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Source Address:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label6.Location = new System.Drawing.Point(35, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Source Port:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.2F);
            this.label7.Location = new System.Drawing.Point(66, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Volume:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(385, 32);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(77, 32);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Select";
            this.tooltip.SetToolTip(this.btnSelectFile, "Select a File to stream.");
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(137, 36);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(242, 27);
            this.txtFile.TabIndex = 7;
            // 
            // txtCodec
            // 
            this.txtCodec.Location = new System.Drawing.Point(137, 69);
            this.txtCodec.Name = "txtCodec";
            this.txtCodec.ReadOnly = true;
            this.txtCodec.Size = new System.Drawing.Size(325, 27);
            this.txtCodec.TabIndex = 8;
            this.txtCodec.Text = "g711";
            this.tooltip.SetToolTip(this.txtCodec, "This cannot be changed at this time.");
            // 
            // txtSourceAddress
            // 
            this.txtSourceAddress.Location = new System.Drawing.Point(137, 102);
            this.txtSourceAddress.Name = "txtSourceAddress";
            this.txtSourceAddress.Size = new System.Drawing.Size(325, 27);
            this.txtSourceAddress.TabIndex = 9;
            this.txtSourceAddress.Text = "224.0.0.4";
            this.tooltip.SetToolTip(this.txtSourceAddress, "Multicast Source Address");
            // 
            // txtSourcePort
            // 
            this.txtSourcePort.Location = new System.Drawing.Point(137, 135);
            this.txtSourcePort.Name = "txtSourcePort";
            this.txtSourcePort.ReadOnly = true;
            this.txtSourcePort.Size = new System.Drawing.Size(325, 27);
            this.txtSourcePort.TabIndex = 10;
            this.txtSourcePort.Text = "20480";
            this.tooltip.SetToolTip(this.txtSourcePort, "Multicast Source Port");
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(137, 168);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(279, 56);
            this.tbVolume.TabIndex = 11;
            this.tooltip.SetToolTip(this.tbVolume, "Stream Volume");
            this.tbVolume.Value = 50;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // btnAdvReqMS
            // 
            this.btnAdvReqMS.ForeColor = System.Drawing.Color.Orange;
            this.btnAdvReqMS.Location = new System.Drawing.Point(200, 3);
            this.btnAdvReqMS.Name = "btnAdvReqMS";
            this.btnAdvReqMS.Size = new System.Drawing.Size(94, 62);
            this.btnAdvReqMS.TabIndex = 2;
            this.btnAdvReqMS.Text = "(ADV)\r\nREQ. MS";
            this.tooltip.SetToolTip(this.btnAdvReqMS, "Enable RTP Listening on Phones. \r\nDoes not start Media Server.");
            this.btnAdvReqMS.UseVisualStyleBackColor = true;
            this.btnAdvReqMS.Click += new System.EventHandler(this.btnAdvReqMS_Click);
            // 
            // btnAdvReqEnd
            // 
            this.btnAdvReqEnd.ForeColor = System.Drawing.Color.Orange;
            this.btnAdvReqEnd.Location = new System.Drawing.Point(300, 3);
            this.btnAdvReqEnd.Name = "btnAdvReqEnd";
            this.btnAdvReqEnd.Size = new System.Drawing.Size(105, 62);
            this.btnAdvReqEnd.TabIndex = 3;
            this.btnAdvReqEnd.Text = "(ADV)\r\nREQ. END";
            this.tooltip.SetToolTip(this.btnAdvReqEnd, "Disable RTP Listening on Phones. \r\nDoes not stop MediaServer.");
            this.btnAdvReqEnd.UseVisualStyleBackColor = true;
            this.btnAdvReqEnd.Click += new System.EventHandler(this.btnAdvReqEnd_Click);
            // 
            // btnAdvStrGo
            // 
            this.btnAdvStrGo.ForeColor = System.Drawing.Color.Orange;
            this.btnAdvStrGo.Location = new System.Drawing.Point(411, 3);
            this.btnAdvStrGo.Name = "btnAdvStrGo";
            this.btnAdvStrGo.Size = new System.Drawing.Size(94, 62);
            this.btnAdvStrGo.TabIndex = 4;
            this.btnAdvStrGo.Text = "(ADV)\r\nSTR. GO";
            this.tooltip.SetToolTip(this.btnAdvStrGo, "Start the MediaServer. \r\nDoes not start RTP Listening on Phones.");
            this.btnAdvStrGo.UseVisualStyleBackColor = true;
            this.btnAdvStrGo.Click += new System.EventHandler(this.btnAdvStrGo_Click);
            // 
            // btnAdvStrEnd
            // 
            this.btnAdvStrEnd.ForeColor = System.Drawing.Color.Orange;
            this.btnAdvStrEnd.Location = new System.Drawing.Point(511, 3);
            this.btnAdvStrEnd.Name = "btnAdvStrEnd";
            this.btnAdvStrEnd.Size = new System.Drawing.Size(94, 62);
            this.btnAdvStrEnd.TabIndex = 5;
            this.btnAdvStrEnd.Text = "(ADV)\r\nSTR. END";
            this.tooltip.SetToolTip(this.btnAdvStrEnd, "Stop the MediaServer.\r\nDoes not affect RTP listening status on phones.\r\nOnly stop" +
        "s phones enabled through the current session.");
            this.btnAdvStrEnd.UseVisualStyleBackColor = true;
            this.btnAdvStrEnd.Click += new System.EventHandler(this.btnAdvStrEnd_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(423, 169);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(39, 27);
            this.txtVolume.TabIndex = 12;
            this.txtVolume.Text = "50";
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltip.SetToolTip(this.txtVolume, "Stream Volume (%)");
            // 
            // lblStreamStatus
            // 
            this.lblStreamStatus.BackColor = System.Drawing.Color.Red;
            this.lblStreamStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreamStatus.ForeColor = System.Drawing.Color.White;
            this.lblStreamStatus.Location = new System.Drawing.Point(30, 227);
            this.lblStreamStatus.Name = "lblStreamStatus";
            this.lblStreamStatus.Size = new System.Drawing.Size(432, 37);
            this.lblStreamStatus.TabIndex = 13;
            this.lblStreamStatus.Text = "(NOT STREAMING)";
            this.lblStreamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltip.SetToolTip(this.lblStreamStatus, "Status");
            // 
            // tooltip
            // 
            this.tooltip.IsBalloon = true;
            // 
            // rtpStreamMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 713);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rtpStreamMain";
            this.Text = "Cisco RTP Streamer v0.0.1";
            this.Load += new System.EventHandler(this.rtpStreamMain_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFooterRight.ResumeLayout(false);
            this.panelFooterRight.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupMediaSetup.ResumeLayout(false);
            this.groupMediaSetup.PerformLayout();
            this.groupAddEndpoints.ResumeLayout(false);
            this.groupAddEndpoints.PerformLayout();
            this.groupAuthorization.ResumeLayout(false);
            this.groupControls.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitleDescription;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.LinkLabel linkSourceCode;
        private System.Windows.Forms.Panel panelFooterRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupMediaSetup;
        private System.Windows.Forms.GroupBox groupAddEndpoints;
        private System.Windows.Forms.GroupBox groupAuthorization;
        private System.Windows.Forms.GroupBox groupControls;
        private System.Windows.Forms.RichTextBox rtfClientDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnValidateAndSave;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtCodec;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtSourceAddress;
        private System.Windows.Forms.TextBox txtSourcePort;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnAdvReqMS;
        private System.Windows.Forms.Button btnAdvReqEnd;
        private System.Windows.Forms.Button btnAdvStrGo;
        private System.Windows.Forms.Button btnAdvStrEnd;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblStreamStatus;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

