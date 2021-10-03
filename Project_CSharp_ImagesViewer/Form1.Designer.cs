namespace Project_CSharp_ImagesViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NavbarPanel = new System.Windows.Forms.Panel();
            this.AppNamelLabel = new System.Windows.Forms.Label();
            this.ImagesPanel = new System.Windows.Forms.Panel();
            this.ImagesListBox = new System.Windows.Forms.ListBox();
            this.OpenPictures_s_Button = new System.Windows.Forms.Button();
            this.OpenPicture_s_Label = new System.Windows.Forms.Label();
            this.ModelsPanel = new System.Windows.Forms.Panel();
            this.AppOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePictureModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlideShowPanel = new System.Windows.Forms.Panel();
            this.SlideShowPicture = new System.Windows.Forms.PictureBox();
            this.SlideShowStatusBarPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarLabel = new System.Windows.Forms.Label();
            this.SlideShowControlPanel = new System.Windows.Forms.Panel();
            this.SlideShowControlButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MultiPicturesModelPanel = new System.Windows.Forms.Panel();
            this.ShowPictures_inMultiPictureModelButton = new System.Windows.Forms.Button();
            this.MultiPictureNoteLabel = new System.Windows.Forms.Label();
            this.MultiPictureLabel = new System.Windows.Forms.Label();
            this.SingleModelPanel = new System.Windows.Forms.Panel();
            this.SingleModelPicture = new System.Windows.Forms.PictureBox();
            this.SignalModelControlsPanel = new System.Windows.Forms.Panel();
            this.RemovePictureButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrivousButton = new System.Windows.Forms.Button();
            this.SingleModelLabelName = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.OpenPicture_s_ServiceButton = new System.Windows.Forms.Button();
            this.OpenPictures_Service_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VisitAboutLabel = new System.Windows.Forms.Label();
            this.AboutButton2 = new System.Windows.Forms.Button();
            this.HomeIntroLabel = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenPictures = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NavbarPanel.SuspendLayout();
            this.ImagesPanel.SuspendLayout();
            this.ModelsPanel.SuspendLayout();
            this.AppOptions.SuspendLayout();
            this.SlideShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowPicture)).BeginInit();
            this.SlideShowStatusBarPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SlideShowControlPanel.SuspendLayout();
            this.MultiPicturesModelPanel.SuspendLayout();
            this.SingleModelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleModelPicture)).BeginInit();
            this.SignalModelControlsPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarPanel
            // 
            this.NavbarPanel.BackColor = System.Drawing.Color.Gray;
            this.NavbarPanel.Controls.Add(this.AppNamelLabel);
            this.NavbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarPanel.Location = new System.Drawing.Point(0, 0);
            this.NavbarPanel.Name = "NavbarPanel";
            this.NavbarPanel.Size = new System.Drawing.Size(1018, 48);
            this.NavbarPanel.TabIndex = 0;
            // 
            // AppNamelLabel
            // 
            this.AppNamelLabel.AutoSize = true;
            this.AppNamelLabel.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNamelLabel.ForeColor = System.Drawing.Color.Cyan;
            this.AppNamelLabel.Location = new System.Drawing.Point(463, 9);
            this.AppNamelLabel.Name = "AppNamelLabel";
            this.AppNamelLabel.Size = new System.Drawing.Size(253, 36);
            this.AppNamelLabel.TabIndex = 1;
            this.AppNamelLabel.Text = "Tompa Image Viewer";
            // 
            // ImagesPanel
            // 
            this.ImagesPanel.BackColor = System.Drawing.Color.Gray;
            this.ImagesPanel.Controls.Add(this.ImagesListBox);
            this.ImagesPanel.Controls.Add(this.OpenPictures_s_Button);
            this.ImagesPanel.Controls.Add(this.OpenPicture_s_Label);
            this.ImagesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagesPanel.Location = new System.Drawing.Point(0, 0);
            this.ImagesPanel.Name = "ImagesPanel";
            this.ImagesPanel.Size = new System.Drawing.Size(269, 475);
            this.ImagesPanel.TabIndex = 1;
            // 
            // ImagesListBox
            // 
            this.ImagesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagesListBox.FormattingEnabled = true;
            this.ImagesListBox.Location = new System.Drawing.Point(0, 36);
            this.ImagesListBox.Name = "ImagesListBox";
            this.ImagesListBox.Size = new System.Drawing.Size(269, 439);
            this.ImagesListBox.TabIndex = 4;
            this.ImagesListBox.SelectedIndexChanged += new System.EventHandler(this.ImagesListBox_SelectedIndexChanged);
            // 
            // OpenPictures_s_Button
            // 
            this.OpenPictures_s_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenPictures_s_Button.BackgroundImage")));
            this.OpenPictures_s_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenPictures_s_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPictures_s_Button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.OpenPictures_s_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPictures_s_Button.Location = new System.Drawing.Point(188, 0);
            this.OpenPictures_s_Button.Name = "OpenPictures_s_Button";
            this.OpenPictures_s_Button.Size = new System.Drawing.Size(81, 36);
            this.OpenPictures_s_Button.TabIndex = 3;
            this.OpenPictures_s_Button.UseVisualStyleBackColor = true;
            this.OpenPictures_s_Button.Click += new System.EventHandler(this.OpenPictures_s_Button_Click);
            // 
            // OpenPicture_s_Label
            // 
            this.OpenPicture_s_Label.AutoSize = true;
            this.OpenPicture_s_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenPicture_s_Label.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPicture_s_Label.ForeColor = System.Drawing.Color.White;
            this.OpenPicture_s_Label.Location = new System.Drawing.Point(0, 0);
            this.OpenPicture_s_Label.Name = "OpenPicture_s_Label";
            this.OpenPicture_s_Label.Size = new System.Drawing.Size(189, 36);
            this.OpenPicture_s_Label.TabIndex = 2;
            this.OpenPicture_s_Label.Text = "Open Picture(S)";
            // 
            // ModelsPanel
            // 
            this.ModelsPanel.BackColor = System.Drawing.Color.Gray;
            this.ModelsPanel.ContextMenuStrip = this.AppOptions;
            this.ModelsPanel.Controls.Add(this.SlideShowPanel);
            this.ModelsPanel.Controls.Add(this.MultiPicturesModelPanel);
            this.ModelsPanel.Controls.Add(this.SingleModelPanel);
            this.ModelsPanel.Controls.Add(this.ImagesPanel);
            this.ModelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelsPanel.Location = new System.Drawing.Point(0, 48);
            this.ModelsPanel.Name = "ModelsPanel";
            this.ModelsPanel.Size = new System.Drawing.Size(1018, 475);
            this.ModelsPanel.TabIndex = 2;
            // 
            // AppOptions
            // 
            this.AppOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPicturesToolStripMenuItem,
            this.singlePictureModelToolStripMenuItem,
            this.multiPictureModelToolStripMenuItem,
            this.slideShowModelToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.AppOptions.Name = "AppOptions";
            this.AppOptions.Size = new System.Drawing.Size(186, 114);
            // 
            // openPicturesToolStripMenuItem
            // 
            this.openPicturesToolStripMenuItem.Name = "openPicturesToolStripMenuItem";
            this.openPicturesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openPicturesToolStripMenuItem.Text = "Open Picture(s)";
            this.openPicturesToolStripMenuItem.Click += new System.EventHandler(this.OpenPictures_Service_Label_Click);
            // 
            // singlePictureModelToolStripMenuItem
            // 
            this.singlePictureModelToolStripMenuItem.Name = "singlePictureModelToolStripMenuItem";
            this.singlePictureModelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.singlePictureModelToolStripMenuItem.Text = "Single-Picture Model";
            this.singlePictureModelToolStripMenuItem.Click += new System.EventHandler(this.singlePictureModelToolStripMenuItem_Click);
            // 
            // multiPictureModelToolStripMenuItem
            // 
            this.multiPictureModelToolStripMenuItem.Name = "multiPictureModelToolStripMenuItem";
            this.multiPictureModelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.multiPictureModelToolStripMenuItem.Text = "Multi-Picture Model";
            this.multiPictureModelToolStripMenuItem.Click += new System.EventHandler(this.multiPictureModelToolStripMenuItem_Click);
            // 
            // slideShowModelToolStripMenuItem
            // 
            this.slideShowModelToolStripMenuItem.Name = "slideShowModelToolStripMenuItem";
            this.slideShowModelToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.slideShowModelToolStripMenuItem.Text = "Slide Show Model";
            this.slideShowModelToolStripMenuItem.Click += new System.EventHandler(this.slideShowModelToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SlideShowPanel
            // 
            this.SlideShowPanel.Controls.Add(this.SlideShowPicture);
            this.SlideShowPanel.Controls.Add(this.SlideShowStatusBarPanel);
            this.SlideShowPanel.Controls.Add(this.SlideShowControlPanel);
            this.SlideShowPanel.Controls.Add(this.label10);
            this.SlideShowPanel.Location = new System.Drawing.Point(503, 256);
            this.SlideShowPanel.Name = "SlideShowPanel";
            this.SlideShowPanel.Size = new System.Drawing.Size(99, 140);
            this.SlideShowPanel.TabIndex = 4;
            // 
            // SlideShowPicture
            // 
            this.SlideShowPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlideShowPicture.Image = ((System.Drawing.Image)(resources.GetObject("SlideShowPicture.Image")));
            this.SlideShowPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("SlideShowPicture.InitialImage")));
            this.SlideShowPicture.Location = new System.Drawing.Point(0, 28);
            this.SlideShowPicture.Name = "SlideShowPicture";
            this.SlideShowPicture.Size = new System.Drawing.Size(99, 9);
            this.SlideShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlideShowPicture.TabIndex = 3;
            this.SlideShowPicture.TabStop = false;
            // 
            // SlideShowStatusBarPanel
            // 
            this.SlideShowStatusBarPanel.Controls.Add(this.statusStrip1);
            this.SlideShowStatusBarPanel.Controls.Add(this.StatusBarLabel);
            this.SlideShowStatusBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SlideShowStatusBarPanel.Location = new System.Drawing.Point(0, 37);
            this.SlideShowStatusBarPanel.Name = "SlideShowStatusBarPanel";
            this.SlideShowStatusBarPanel.Size = new System.Drawing.Size(99, 27);
            this.SlideShowStatusBarPanel.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 5);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(99, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.AutoSize = true;
            this.StatusBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBarLabel.ForeColor = System.Drawing.Color.White;
            this.StatusBarLabel.Location = new System.Drawing.Point(32, 4);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(0, 20);
            this.StatusBarLabel.TabIndex = 0;
            // 
            // SlideShowControlPanel
            // 
            this.SlideShowControlPanel.Controls.Add(this.SlideShowControlButton);
            this.SlideShowControlPanel.Controls.Add(this.label11);
            this.SlideShowControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SlideShowControlPanel.Location = new System.Drawing.Point(0, 64);
            this.SlideShowControlPanel.Name = "SlideShowControlPanel";
            this.SlideShowControlPanel.Size = new System.Drawing.Size(99, 76);
            this.SlideShowControlPanel.TabIndex = 1;
            // 
            // SlideShowControlButton
            // 
            this.SlideShowControlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideShowControlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideShowControlButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SlideShowControlButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideShowControlButton.ForeColor = System.Drawing.Color.Red;
            this.SlideShowControlButton.Location = new System.Drawing.Point(467, 5);
            this.SlideShowControlButton.Name = "SlideShowControlButton";
            this.SlideShowControlButton.Size = new System.Drawing.Size(82, 36);
            this.SlideShowControlButton.TabIndex = 4;
            this.SlideShowControlButton.Text = "Pause";
            this.SlideShowControlButton.UseVisualStyleBackColor = true;
            this.SlideShowControlButton.Click += new System.EventHandler(this.SlideShowControlButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(351, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Control :- ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Slide Show Model";
            // 
            // MultiPicturesModelPanel
            // 
            this.MultiPicturesModelPanel.AutoScroll = true;
            this.MultiPicturesModelPanel.Controls.Add(this.ShowPictures_inMultiPictureModelButton);
            this.MultiPicturesModelPanel.Controls.Add(this.MultiPictureNoteLabel);
            this.MultiPicturesModelPanel.Controls.Add(this.MultiPictureLabel);
            this.MultiPicturesModelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiPicturesModelPanel.Location = new System.Drawing.Point(269, 0);
            this.MultiPicturesModelPanel.Name = "MultiPicturesModelPanel";
            this.MultiPicturesModelPanel.Size = new System.Drawing.Size(749, 475);
            this.MultiPicturesModelPanel.TabIndex = 3;
            // 
            // ShowPictures_inMultiPictureModelButton
            // 
            this.ShowPictures_inMultiPictureModelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPictures_inMultiPictureModelButton.BackgroundImage")));
            this.ShowPictures_inMultiPictureModelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPictures_inMultiPictureModelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPictures_inMultiPictureModelButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ShowPictures_inMultiPictureModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPictures_inMultiPictureModelButton.Location = new System.Drawing.Point(327, 29);
            this.ShowPictures_inMultiPictureModelButton.Name = "ShowPictures_inMultiPictureModelButton";
            this.ShowPictures_inMultiPictureModelButton.Size = new System.Drawing.Size(68, 36);
            this.ShowPictures_inMultiPictureModelButton.TabIndex = 4;
            this.ShowPictures_inMultiPictureModelButton.UseVisualStyleBackColor = true;
            this.ShowPictures_inMultiPictureModelButton.Click += new System.EventHandler(this.ShowPictures_inMultiPictureModelButton_Click);
            // 
            // MultiPictureNoteLabel
            // 
            this.MultiPictureNoteLabel.AutoSize = true;
            this.MultiPictureNoteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MultiPictureNoteLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiPictureNoteLabel.Location = new System.Drawing.Point(0, 33);
            this.MultiPictureNoteLabel.Name = "MultiPictureNoteLabel";
            this.MultiPictureNoteLabel.Size = new System.Drawing.Size(321, 25);
            this.MultiPictureNoteLabel.TabIndex = 1;
            this.MultiPictureNoteLabel.Text = "Selected Pictures Then Press Show :-";
            // 
            // MultiPictureLabel
            // 
            this.MultiPictureLabel.AutoSize = true;
            this.MultiPictureLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MultiPictureLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiPictureLabel.Location = new System.Drawing.Point(0, 0);
            this.MultiPictureLabel.Name = "MultiPictureLabel";
            this.MultiPictureLabel.Size = new System.Drawing.Size(663, 33);
            this.MultiPictureLabel.TabIndex = 0;
            this.MultiPictureLabel.Text = "Multi-Picture Model \"Selected Pictures Then They will show.\"";
            // 
            // SingleModelPanel
            // 
            this.SingleModelPanel.Controls.Add(this.SingleModelPicture);
            this.SingleModelPanel.Controls.Add(this.SignalModelControlsPanel);
            this.SingleModelPanel.Controls.Add(this.SingleModelLabelName);
            this.SingleModelPanel.Location = new System.Drawing.Point(295, 125);
            this.SingleModelPanel.Name = "SingleModelPanel";
            this.SingleModelPanel.Size = new System.Drawing.Size(200, 100);
            this.SingleModelPanel.TabIndex = 2;
            // 
            // SingleModelPicture
            // 
            this.SingleModelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SingleModelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleModelPicture.Image = ((System.Drawing.Image)(resources.GetObject("SingleModelPicture.Image")));
            this.SingleModelPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("SingleModelPicture.InitialImage")));
            this.SingleModelPicture.Location = new System.Drawing.Point(0, 33);
            this.SingleModelPicture.Name = "SingleModelPicture";
            this.SingleModelPicture.Size = new System.Drawing.Size(200, 0);
            this.SingleModelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SingleModelPicture.TabIndex = 2;
            this.SingleModelPicture.TabStop = false;
            // 
            // SignalModelControlsPanel
            // 
            this.SignalModelControlsPanel.Controls.Add(this.RemovePictureButton);
            this.SignalModelControlsPanel.Controls.Add(this.RotateButton);
            this.SignalModelControlsPanel.Controls.Add(this.NextButton);
            this.SignalModelControlsPanel.Controls.Add(this.PrivousButton);
            this.SignalModelControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignalModelControlsPanel.Location = new System.Drawing.Point(0, 22);
            this.SignalModelControlsPanel.Name = "SignalModelControlsPanel";
            this.SignalModelControlsPanel.Size = new System.Drawing.Size(200, 78);
            this.SignalModelControlsPanel.TabIndex = 1;
            // 
            // RemovePictureButton
            // 
            this.RemovePictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemovePictureButton.BackgroundImage")));
            this.RemovePictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemovePictureButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RemovePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePictureButton.Location = new System.Drawing.Point(474, 0);
            this.RemovePictureButton.Name = "RemovePictureButton";
            this.RemovePictureButton.Size = new System.Drawing.Size(75, 43);
            this.RemovePictureButton.TabIndex = 3;
            this.RemovePictureButton.UseVisualStyleBackColor = true;
            this.RemovePictureButton.Click += new System.EventHandler(this.RemovePictureButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateButton.BackgroundImage")));
            this.RotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateButton.Location = new System.Drawing.Point(372, 3);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 43);
            this.RotateButton.TabIndex = 2;
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(258, 0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 43);
            this.NextButton.TabIndex = 1;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrivousButton
            // 
            this.PrivousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrivousButton.BackgroundImage")));
            this.PrivousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrivousButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.PrivousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrivousButton.Location = new System.Drawing.Point(146, 0);
            this.PrivousButton.Name = "PrivousButton";
            this.PrivousButton.Size = new System.Drawing.Size(75, 43);
            this.PrivousButton.TabIndex = 0;
            this.PrivousButton.UseVisualStyleBackColor = true;
            this.PrivousButton.Click += new System.EventHandler(this.PrivousButton_Click);
            // 
            // SingleModelLabelName
            // 
            this.SingleModelLabelName.AutoSize = true;
            this.SingleModelLabelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.SingleModelLabelName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleModelLabelName.Location = new System.Drawing.Point(0, 0);
            this.SingleModelLabelName.Name = "SingleModelLabelName";
            this.SingleModelLabelName.Size = new System.Drawing.Size(713, 33);
            this.SingleModelLabelName.TabIndex = 0;
            this.SingleModelLabelName.Text = "    Single Picture Model -Default \'if you don\'t select anther model\'-";
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Gray;
            this.FooterPanel.Controls.Add(this.HomeButton);
            this.FooterPanel.Controls.Add(this.AboutButton);
            this.FooterPanel.Controls.Add(this.label1);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 494);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1018, 29);
            this.FooterPanel.TabIndex = 3;
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(52, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(52, 29);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutButton.BackgroundImage")));
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Location = new System.Drawing.Point(0, 0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(52, 29);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(677, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "All rights resaved to engineer Sallam Rady";
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.Gray;
            this.HomePanel.ContextMenuStrip = this.AppOptions;
            this.HomePanel.Controls.Add(this.label9);
            this.HomePanel.Controls.Add(this.OpenPicture_s_ServiceButton);
            this.HomePanel.Controls.Add(this.OpenPictures_Service_Label);
            this.HomePanel.Controls.Add(this.label2);
            this.HomePanel.Controls.Add(this.VisitAboutLabel);
            this.HomePanel.Controls.Add(this.AboutButton2);
            this.HomePanel.Controls.Add(this.HomeIntroLabel);
            this.HomePanel.Location = new System.Drawing.Point(40, 256);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(74, 28);
            this.HomePanel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(58, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(790, 56);
            this.label9.TabIndex = 10;
            this.label9.Text = "Note : You will redirect to Single Picture Model as You don\'t Choose anther model" +
    "\r\nIf you want to choose anther Model press : right click +choose your model.";
            // 
            // OpenPicture_s_ServiceButton
            // 
            this.OpenPicture_s_ServiceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenPicture_s_ServiceButton.BackgroundImage")));
            this.OpenPicture_s_ServiceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenPicture_s_ServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPicture_s_ServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.OpenPicture_s_ServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPicture_s_ServiceButton.Location = new System.Drawing.Point(234, 334);
            this.OpenPicture_s_ServiceButton.Name = "OpenPicture_s_ServiceButton";
            this.OpenPicture_s_ServiceButton.Size = new System.Drawing.Size(37, 25);
            this.OpenPicture_s_ServiceButton.TabIndex = 9;
            this.OpenPicture_s_ServiceButton.UseVisualStyleBackColor = true;
            this.OpenPicture_s_ServiceButton.Click += new System.EventHandler(this.OpenPictures_Service_Label_Click);
            // 
            // OpenPictures_Service_Label
            // 
            this.OpenPictures_Service_Label.AutoSize = true;
            this.OpenPictures_Service_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPictures_Service_Label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPictures_Service_Label.ForeColor = System.Drawing.Color.Blue;
            this.OpenPictures_Service_Label.Location = new System.Drawing.Point(58, 331);
            this.OpenPictures_Service_Label.Name = "OpenPictures_Service_Label";
            this.OpenPictures_Service_Label.Size = new System.Drawing.Size(159, 28);
            this.OpenPictures_Service_Label.TabIndex = 8;
            this.OpenPictures_Service_Label.Text = "Open Picture(S)";
            this.OpenPictures_Service_Label.Click += new System.EventHandler(this.OpenPictures_Service_Label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(47, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "The Application can provide you with this Service :-";
            // 
            // VisitAboutLabel
            // 
            this.VisitAboutLabel.AutoSize = true;
            this.VisitAboutLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitAboutLabel.ForeColor = System.Drawing.Color.Silver;
            this.VisitAboutLabel.Location = new System.Drawing.Point(47, 204);
            this.VisitAboutLabel.Name = "VisitAboutLabel";
            this.VisitAboutLabel.Size = new System.Drawing.Size(203, 28);
            this.VisitAboutLabel.TabIndex = 6;
            this.VisitAboutLabel.Text = "Visit About Page :- ";
            // 
            // AboutButton2
            // 
            this.AboutButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutButton2.BackgroundImage")));
            this.AboutButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AboutButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton2.Location = new System.Drawing.Point(255, 207);
            this.AboutButton2.Name = "AboutButton2";
            this.AboutButton2.Size = new System.Drawing.Size(52, 29);
            this.AboutButton2.TabIndex = 5;
            this.AboutButton2.UseVisualStyleBackColor = true;
            this.AboutButton2.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HomeIntroLabel
            // 
            this.HomeIntroLabel.AutoSize = true;
            this.HomeIntroLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeIntroLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeIntroLabel.ForeColor = System.Drawing.Color.Silver;
            this.HomeIntroLabel.Location = new System.Drawing.Point(47, 105);
            this.HomeIntroLabel.Name = "HomeIntroLabel";
            this.HomeIntroLabel.Size = new System.Drawing.Size(731, 56);
            this.HomeIntroLabel.TabIndex = 0;
            this.HomeIntroLabel.Text = "Welcome in Tompa Image(s) Viewer Application .\r\nIf you need more Information abou" +
    "t your Application you can See This Link";
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.Color.Gray;
            this.AboutPanel.ContextMenuStrip = this.AppOptions;
            this.AboutPanel.Controls.Add(this.label6);
            this.AboutPanel.Controls.Add(this.label5);
            this.AboutPanel.Controls.Add(this.label4);
            this.AboutPanel.Controls.Add(this.label3);
            this.AboutPanel.Location = new System.Drawing.Point(40, 304);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(59, 23);
            this.AboutPanel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(82, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(812, 224);
            this.label6.TabIndex = 3;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(91, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "About App";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(91, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name : Sallam Rady Ramadan Osman [ سلام راضي رمضان عثمان ]\r\nDepartment : Informat" +
    "ion System( IS )\r\nSection : 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(91, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "About Me";
            // 
            // OpenPictures
            // 
            this.OpenPictures.FileName = "openFileDialog1";
            this.OpenPictures.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 523);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.ModelsPanel);
            this.Controls.Add(this.NavbarPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tompa Image Viewer Application";
            this.NavbarPanel.ResumeLayout(false);
            this.NavbarPanel.PerformLayout();
            this.ImagesPanel.ResumeLayout(false);
            this.ImagesPanel.PerformLayout();
            this.ModelsPanel.ResumeLayout(false);
            this.AppOptions.ResumeLayout(false);
            this.SlideShowPanel.ResumeLayout(false);
            this.SlideShowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowPicture)).EndInit();
            this.SlideShowStatusBarPanel.ResumeLayout(false);
            this.SlideShowStatusBarPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SlideShowControlPanel.ResumeLayout(false);
            this.SlideShowControlPanel.PerformLayout();
            this.MultiPicturesModelPanel.ResumeLayout(false);
            this.MultiPicturesModelPanel.PerformLayout();
            this.SingleModelPanel.ResumeLayout(false);
            this.SingleModelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingleModelPicture)).EndInit();
            this.SignalModelControlsPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavbarPanel;
        private System.Windows.Forms.Label AppNamelLabel;
        private System.Windows.Forms.Panel ImagesPanel;
        private System.Windows.Forms.Button OpenPictures_s_Button;
        private System.Windows.Forms.Label OpenPicture_s_Label;
        private System.Windows.Forms.ListBox ImagesListBox;
        private System.Windows.Forms.Panel ModelsPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HomeIntroLabel;
        private System.Windows.Forms.Label VisitAboutLabel;
        private System.Windows.Forms.Button AboutButton2;
        private System.Windows.Forms.Button OpenPicture_s_ServiceButton;
        private System.Windows.Forms.Label OpenPictures_Service_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog OpenPictures;
        private System.Windows.Forms.Panel SingleModelPanel;
        private System.Windows.Forms.PictureBox SingleModelPicture;
        private System.Windows.Forms.Panel SignalModelControlsPanel;
        private System.Windows.Forms.Label SingleModelLabelName;
        private System.Windows.Forms.Button RemovePictureButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrivousButton;
        private System.Windows.Forms.ContextMenuStrip AppOptions;
        private System.Windows.Forms.ToolStripMenuItem openPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePictureModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiPictureModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel MultiPicturesModelPanel;
        private System.Windows.Forms.Button ShowPictures_inMultiPictureModelButton;
        private System.Windows.Forms.Label MultiPictureNoteLabel;
        private System.Windows.Forms.Label MultiPictureLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel SlideShowPanel;
        private System.Windows.Forms.PictureBox SlideShowPicture;
        private System.Windows.Forms.Panel SlideShowStatusBarPanel;
        private System.Windows.Forms.Label StatusBarLabel;
        private System.Windows.Forms.Panel SlideShowControlPanel;
        private System.Windows.Forms.Button SlideShowControlButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

