namespace ImageProcessing
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.ProcessingStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.uploadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator6StripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.RestoreTempImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2StripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flipXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3StripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mirrorHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4StripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scale50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator5StripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.PaintStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblWidths = new System.Windows.Forms.Label();
            this.lblHeights = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.ResizeTrackBar = new System.Windows.Forms.TrackBar();
            this.lblDescription = new System.Windows.Forms.Label();
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.PaintingtoolStrip = new System.Windows.Forms.ToolStrip();
            this.RedStripButton = new System.Windows.Forms.ToolStripButton();
            this.GreenStripButton = new System.Windows.Forms.ToolStripButton();
            this.BlueStripButton = new System.Windows.Forms.ToolStripButton();
            this.BlackStripButton = new System.Windows.Forms.ToolStripButton();
            this.WhiteStripButton = new System.Windows.Forms.ToolStripButton();
            this.MagentaStripButton = new System.Windows.Forms.ToolStripButton();
            this.EraserStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.ProcessingStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeTrackBar)).BeginInit();
            this.ImageGroupBox.SuspendLayout();
            this.PaintingtoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(26, 19);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(576, 410);
            this.imgMain.TabIndex = 1;
            this.imgMain.TabStop = false;
            this.imgMain.Click += new System.EventHandler(this.imgMain_Click);
            this.imgMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgMainDown_Click);
            this.imgMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMain_Click);
            this.imgMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgMainUp_Click);
            // 
            // ProcessingStrip
            // 
            this.ProcessingStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton1,
            this.AboutToolStripButton2,
            this.PaintStripButton2});
            this.ProcessingStrip.Location = new System.Drawing.Point(0, 0);
            this.ProcessingStrip.Name = "ProcessingStrip";
            this.ProcessingStrip.Size = new System.Drawing.Size(877, 25);
            this.ProcessingStrip.TabIndex = 0;
            this.ProcessingStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImageToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.Separator6StripSeparator1,
            this.saveToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton1.Text = "File";
            // 
            // uploadImageToolStripMenuItem
            // 
            this.uploadImageToolStripMenuItem.Name = "uploadImageToolStripMenuItem";
            this.uploadImageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.uploadImageToolStripMenuItem.Text = "Upload Image";
            this.uploadImageToolStripMenuItem.Click += new System.EventHandler(this.uploadImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Separator6StripSeparator1
            // 
            this.Separator6StripSeparator1.Name = "Separator6StripSeparator1";
            this.Separator6StripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreTempImageToolStripMenuItem,
            this.SetTempToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.darkenToolStripMenuItem,
            this.brightenToolStripMenuItem,
            this.Separator2StripSeparator1,
            this.flipXToolStripMenuItem,
            this.flipYToolStripMenuItem,
            this.Separator3StripSeparator2,
            this.mirrorHToolStripMenuItem,
            this.mirrorVToolStripMenuItem,
            this.Separator4StripSeparator3,
            this.scale50ToolStripMenuItem,
            this.scale200ToolStripMenuItem,
            this.Separator5StripSeparator5,
            this.rotateToolStripMenuItem,
            this.blurToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripSplitButton1.Text = "Processing";
            // 
            // RestoreTempImageToolStripMenuItem
            // 
            this.RestoreTempImageToolStripMenuItem.Enabled = false;
            this.RestoreTempImageToolStripMenuItem.Name = "RestoreTempImageToolStripMenuItem";
            this.RestoreTempImageToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.RestoreTempImageToolStripMenuItem.Text = "Restore temporary image.";
            this.RestoreTempImageToolStripMenuItem.Click += new System.EventHandler(this.RestoreTempImageToolStripMenuItem_Click);
            // 
            // SetTempToolStripMenuItem
            // 
            this.SetTempToolStripMenuItem.Enabled = false;
            this.SetTempToolStripMenuItem.Name = "SetTempToolStripMenuItem";
            this.SetTempToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.SetTempToolStripMenuItem.Text = "Set as temporary image.";
            this.SetTempToolStripMenuItem.Click += new System.EventHandler(this.SetTempToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Enabled = false;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.resetToolStripMenuItem.Text = "Reset to uploaded image.";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(207, 6);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Enabled = false;
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Enabled = false;
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.grayScaleToolStripMenuItem.Text = "Gray Scale";
            this.grayScaleToolStripMenuItem.ToolTipText = "Changes the color to grey";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // darkenToolStripMenuItem
            // 
            this.darkenToolStripMenuItem.Enabled = false;
            this.darkenToolStripMenuItem.Name = "darkenToolStripMenuItem";
            this.darkenToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.darkenToolStripMenuItem.Text = "Darken";
            this.darkenToolStripMenuItem.Click += new System.EventHandler(this.darkenToolStripMenuItem_Click);
            // 
            // brightenToolStripMenuItem
            // 
            this.brightenToolStripMenuItem.Enabled = false;
            this.brightenToolStripMenuItem.Name = "brightenToolStripMenuItem";
            this.brightenToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.brightenToolStripMenuItem.Text = "Brighten";
            this.brightenToolStripMenuItem.Click += new System.EventHandler(this.brightenToolStripMenuItem_Click);
            // 
            // Separator2StripSeparator1
            // 
            this.Separator2StripSeparator1.Name = "Separator2StripSeparator1";
            this.Separator2StripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // flipXToolStripMenuItem
            // 
            this.flipXToolStripMenuItem.Enabled = false;
            this.flipXToolStripMenuItem.Name = "flipXToolStripMenuItem";
            this.flipXToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.flipXToolStripMenuItem.Text = "Flip X";
            this.flipXToolStripMenuItem.ToolTipText = "Vertically flips the image.";
            this.flipXToolStripMenuItem.Click += new System.EventHandler(this.flipXToolStripMenuItem_Click);
            // 
            // flipYToolStripMenuItem
            // 
            this.flipYToolStripMenuItem.Enabled = false;
            this.flipYToolStripMenuItem.Name = "flipYToolStripMenuItem";
            this.flipYToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.flipYToolStripMenuItem.Text = "Flip Y";
            this.flipYToolStripMenuItem.ToolTipText = "Flips the image horizontally.";
            this.flipYToolStripMenuItem.Click += new System.EventHandler(this.flipYToolStripMenuItem_Click);
            // 
            // Separator3StripSeparator2
            // 
            this.Separator3StripSeparator2.Name = "Separator3StripSeparator2";
            this.Separator3StripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // mirrorHToolStripMenuItem
            // 
            this.mirrorHToolStripMenuItem.Enabled = false;
            this.mirrorHToolStripMenuItem.Name = "mirrorHToolStripMenuItem";
            this.mirrorHToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mirrorHToolStripMenuItem.Text = "Mirror H";
            this.mirrorHToolStripMenuItem.ToolTipText = "Reflects the image horizontally";
            this.mirrorHToolStripMenuItem.Click += new System.EventHandler(this.mirrorHToolStripMenuItem_Click);
            // 
            // mirrorVToolStripMenuItem
            // 
            this.mirrorVToolStripMenuItem.Enabled = false;
            this.mirrorVToolStripMenuItem.Name = "mirrorVToolStripMenuItem";
            this.mirrorVToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mirrorVToolStripMenuItem.Text = "Mirror V";
            this.mirrorVToolStripMenuItem.ToolTipText = "Reflects the image vertically";
            this.mirrorVToolStripMenuItem.Click += new System.EventHandler(this.mirrorVToolStripMenuItem_Click);
            // 
            // Separator4StripSeparator3
            // 
            this.Separator4StripSeparator3.Name = "Separator4StripSeparator3";
            this.Separator4StripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // scale50ToolStripMenuItem
            // 
            this.scale50ToolStripMenuItem.Enabled = false;
            this.scale50ToolStripMenuItem.Name = "scale50ToolStripMenuItem";
            this.scale50ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.scale50ToolStripMenuItem.Text = "Scale 50";
            this.scale50ToolStripMenuItem.ToolTipText = "Decreases the size of the picture by half.";
            this.scale50ToolStripMenuItem.Click += new System.EventHandler(this.scale50ToolStripMenuItem_Click);
            // 
            // scale200ToolStripMenuItem
            // 
            this.scale200ToolStripMenuItem.Enabled = false;
            this.scale200ToolStripMenuItem.Name = "scale200ToolStripMenuItem";
            this.scale200ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.scale200ToolStripMenuItem.Text = "Scale 200";
            this.scale200ToolStripMenuItem.ToolTipText = "Doubles the size of the picture.";
            this.scale200ToolStripMenuItem.Click += new System.EventHandler(this.scale200ToolStripMenuItem_Click);
            // 
            // Separator5StripSeparator5
            // 
            this.Separator5StripSeparator5.Name = "Separator5StripSeparator5";
            this.Separator5StripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseToolStripMenuItem,
            this.counterclockwiseToolStripMenuItem});
            this.rotateToolStripMenuItem.Enabled = false;
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // clockwiseToolStripMenuItem
            // 
            this.clockwiseToolStripMenuItem.Enabled = false;
            this.clockwiseToolStripMenuItem.Name = "clockwiseToolStripMenuItem";
            this.clockwiseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clockwiseToolStripMenuItem.Text = "Clockwise";
            this.clockwiseToolStripMenuItem.Click += new System.EventHandler(this.clockwiseToolStripMenuItem_Click);
            // 
            // counterclockwiseToolStripMenuItem
            // 
            this.counterclockwiseToolStripMenuItem.Enabled = false;
            this.counterclockwiseToolStripMenuItem.Name = "counterclockwiseToolStripMenuItem";
            this.counterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.counterclockwiseToolStripMenuItem.Text = "Counter-clockwise";
            this.counterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.counterclockwiseToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Enabled = false;
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // AboutToolStripButton2
            // 
            this.AboutToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripButton2.Image")));
            this.AboutToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton2.Name = "AboutToolStripButton2";
            this.AboutToolStripButton2.Size = new System.Drawing.Size(44, 22);
            this.AboutToolStripButton2.Text = "About";
            this.AboutToolStripButton2.ToolTipText = "Brief Description of the program";
            this.AboutToolStripButton2.Click += new System.EventHandler(this.AboutToolStripButton2_Click);
            // 
            // PaintStripButton2
            // 
            this.PaintStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PaintStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("PaintStripButton2.Image")));
            this.PaintStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaintStripButton2.Name = "PaintStripButton2";
            this.PaintStripButton2.Size = new System.Drawing.Size(72, 22);
            this.PaintStripButton2.Text = "Paint Mode";
            this.PaintStripButton2.Click += new System.EventHandler(this.PaintStripButton2_Click);
            // 
            // lblWidths
            // 
            this.lblWidths.AutoSize = true;
            this.lblWidths.Location = new System.Drawing.Point(710, 145);
            this.lblWidths.Name = "lblWidths";
            this.lblWidths.Size = new System.Drawing.Size(0, 13);
            this.lblWidths.TabIndex = 9;
            // 
            // lblHeights
            // 
            this.lblHeights.AutoSize = true;
            this.lblHeights.Location = new System.Drawing.Point(710, 121);
            this.lblHeights.Name = "lblHeights";
            this.lblHeights.Size = new System.Drawing.Size(0, 13);
            this.lblHeights.TabIndex = 8;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(666, 145);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(663, 121);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height:";
            // 
            // ResizeTrackBar
            // 
            this.ResizeTrackBar.Enabled = false;
            this.ResizeTrackBar.Location = new System.Drawing.Point(655, 308);
            this.ResizeTrackBar.Maximum = 3;
            this.ResizeTrackBar.Name = "ResizeTrackBar";
            this.ResizeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResizeTrackBar.Size = new System.Drawing.Size(142, 45);
            this.ResizeTrackBar.TabIndex = 11;
            this.ResizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ResizeTrackBar.Scroll += new System.EventHandler(this.Resize_Scroll);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(652, 225);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 65);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "         Resize Trackbar\r\nMove the scroller to the right  \r\nto shrink the image,\r" +
                "\n and move it back to \r\nthe left to enlargen it.\r\n";
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Controls.Add(this.imgMain);
            this.ImageGroupBox.Location = new System.Drawing.Point(12, 96);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(619, 451);
            this.ImageGroupBox.TabIndex = 15;
            this.ImageGroupBox.TabStop = false;
            this.ImageGroupBox.Text = "Inserted Image";
            // 
            // PaintingtoolStrip
            // 
            this.PaintingtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedStripButton,
            this.GreenStripButton,
            this.BlueStripButton,
            this.BlackStripButton,
            this.WhiteStripButton,
            this.MagentaStripButton,
            this.EraserStripButton});
            this.PaintingtoolStrip.Location = new System.Drawing.Point(0, 25);
            this.PaintingtoolStrip.Name = "PaintingtoolStrip";
            this.PaintingtoolStrip.Size = new System.Drawing.Size(877, 25);
            this.PaintingtoolStrip.TabIndex = 16;
            this.PaintingtoolStrip.Text = "toolStrip2";
            // 
            // RedStripButton
            // 
            this.RedStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RedStripButton.Image")));
            this.RedStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedStripButton.Name = "RedStripButton";
            this.RedStripButton.Size = new System.Drawing.Size(23, 22);
            this.RedStripButton.Text = "Red";
            this.RedStripButton.Click += new System.EventHandler(this.RedStripButton_Click);
            // 
            // GreenStripButton
            // 
            this.GreenStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GreenStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GreenStripButton.Image")));
            this.GreenStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenStripButton.Name = "GreenStripButton";
            this.GreenStripButton.Size = new System.Drawing.Size(23, 22);
            this.GreenStripButton.Text = "Green";
            this.GreenStripButton.Click += new System.EventHandler(this.GreenStripButton_Click);
            // 
            // BlueStripButton
            // 
            this.BlueStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueStripButton.Image")));
            this.BlueStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueStripButton.Name = "BlueStripButton";
            this.BlueStripButton.Size = new System.Drawing.Size(23, 22);
            this.BlueStripButton.Text = "Blue";
            this.BlueStripButton.Click += new System.EventHandler(this.BlueStripButton_Click);
            // 
            // BlackStripButton
            // 
            this.BlackStripButton.Checked = true;
            this.BlackStripButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlackStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlackStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackStripButton.Image")));
            this.BlackStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackStripButton.Name = "BlackStripButton";
            this.BlackStripButton.Size = new System.Drawing.Size(23, 22);
            this.BlackStripButton.Text = "Black";
            this.BlackStripButton.Click += new System.EventHandler(this.BlackStripButton_Click);
            // 
            // WhiteStripButton
            // 
            this.WhiteStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WhiteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("WhiteStripButton.Image")));
            this.WhiteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhiteStripButton.Name = "WhiteStripButton";
            this.WhiteStripButton.Size = new System.Drawing.Size(23, 22);
            this.WhiteStripButton.Text = "White";
            this.WhiteStripButton.Click += new System.EventHandler(this.WhiteStripButton_Click);
            // 
            // MagentaStripButton
            // 
            this.MagentaStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MagentaStripButton.Image = ((System.Drawing.Image)(resources.GetObject("MagentaStripButton.Image")));
            this.MagentaStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MagentaStripButton.Name = "MagentaStripButton";
            this.MagentaStripButton.Size = new System.Drawing.Size(23, 22);
            this.MagentaStripButton.Text = "Magenta";
            this.MagentaStripButton.Click += new System.EventHandler(this.MagentaStripButton_Click);
            // 
            // EraserStripButton
            // 
            this.EraserStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EraserStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserStripButton.Image")));
            this.EraserStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EraserStripButton.Name = "EraserStripButton";
            this.EraserStripButton.Size = new System.Drawing.Size(23, 22);
            this.EraserStripButton.Text = "Eraser";
            this.EraserStripButton.Click += new System.EventHandler(this.EraserStripButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 586);
            this.Controls.Add(this.PaintingtoolStrip);
            this.Controls.Add(this.ImageGroupBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.ResizeTrackBar);
            this.Controls.Add(this.lblWidths);
            this.Controls.Add(this.lblHeights);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.ProcessingStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ProcessingStrip.ResumeLayout(false);
            this.ProcessingStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeTrackBar)).EndInit();
            this.ImageGroupBox.ResumeLayout(false);
            this.PaintingtoolStrip.ResumeLayout(false);
            this.PaintingtoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.ToolStrip ProcessingStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem darkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem uploadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblWidths;
        private System.Windows.Forms.Label lblHeights;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TrackBar ResizeTrackBar;
        private System.Windows.Forms.ToolStripButton AboutToolStripButton2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox ImageGroupBox;
        private System.Windows.Forms.ToolStripMenuItem clockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterclockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator2StripSeparator1;
        private System.Windows.Forms.ToolStripSeparator Separator3StripSeparator2;
        private System.Windows.Forms.ToolStripSeparator Separator4StripSeparator3;
        private System.Windows.Forms.ToolStripSeparator Separator5StripSeparator5;
        private System.Windows.Forms.ToolStripSeparator Separator6StripSeparator1;
        private System.Windows.Forms.ToolStripButton PaintStripButton2;
        private System.Windows.Forms.ToolStrip PaintingtoolStrip;
        private System.Windows.Forms.ToolStripButton RedStripButton;
        private System.Windows.Forms.ToolStripButton GreenStripButton;
        private System.Windows.Forms.ToolStripButton BlueStripButton;
        private System.Windows.Forms.ToolStripButton BlackStripButton;
        private System.Windows.Forms.ToolStripButton WhiteStripButton;
        private System.Windows.Forms.ToolStripButton MagentaStripButton;
        private System.Windows.Forms.ToolStripButton EraserStripButton;
        private System.Windows.Forms.ToolStripMenuItem RestoreTempImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetTempToolStripMenuItem;
    }
}

