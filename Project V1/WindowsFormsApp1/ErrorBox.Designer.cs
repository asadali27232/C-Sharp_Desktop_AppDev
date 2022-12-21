namespace WindowsFormsApp1
{
    partial class ErrorBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.titleBar = new System.Windows.Forms.Panel();
            this.logoTitlebar = new System.Windows.Forms.PictureBox();
            this.titleTitlebar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeftExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWrong = new Bunifu.UI.WinForms.BunifuLabel();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(37)))));
            this.titleBar.Controls.Add(this.logoTitlebar);
            this.titleBar.Controls.Add(this.titleTitlebar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(388, 37);
            this.titleBar.TabIndex = 2;
            // 
            // logoTitlebar
            // 
            this.logoTitlebar.BackColor = System.Drawing.Color.Transparent;
            this.logoTitlebar.Image = ((System.Drawing.Image)(resources.GetObject("logoTitlebar.Image")));
            this.logoTitlebar.Location = new System.Drawing.Point(11, 5);
            this.logoTitlebar.Name = "logoTitlebar";
            this.logoTitlebar.Size = new System.Drawing.Size(25, 25);
            this.logoTitlebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTitlebar.TabIndex = 6;
            this.logoTitlebar.TabStop = false;
            // 
            // titleTitlebar
            // 
            this.titleTitlebar.AllowParentOverrides = false;
            this.titleTitlebar.AutoEllipsis = false;
            this.titleTitlebar.AutoSize = false;
            this.titleTitlebar.CursorType = null;
            this.titleTitlebar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.titleTitlebar.ForeColor = System.Drawing.Color.White;
            this.titleTitlebar.Location = new System.Drawing.Point(44, 1);
            this.titleTitlebar.Name = "titleTitlebar";
            this.titleTitlebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleTitlebar.Size = new System.Drawing.Size(41, 33);
            this.titleTitlebar.TabIndex = 5;
            this.titleTitlebar.Text = "Error";
            this.titleTitlebar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleTitlebar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeftExit
            // 
            this.btnLeftExit.AllowAnimations = true;
            this.btnLeftExit.AllowMouseEffects = true;
            this.btnLeftExit.AllowToggling = false;
            this.btnLeftExit.AnimationSpeed = 200;
            this.btnLeftExit.AutoGenerateColors = false;
            this.btnLeftExit.AutoRoundBorders = false;
            this.btnLeftExit.AutoSizeLeftIcon = true;
            this.btnLeftExit.AutoSizeRightIcon = true;
            this.btnLeftExit.BackColor = System.Drawing.Color.Transparent;
            this.btnLeftExit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnLeftExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeftExit.BackgroundImage")));
            this.btnLeftExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLeftExit.ButtonText = "Exit";
            this.btnLeftExit.ButtonTextMarginLeft = 0;
            this.btnLeftExit.ColorContrastOnClick = 45;
            this.btnLeftExit.ColorContrastOnHover = 45;
            this.btnLeftExit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLeftExit.CustomizableEdges = borderEdges1;
            this.btnLeftExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLeftExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLeftExit.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnLeftExit.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnLeftExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLeftExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftExit.ForeColor = System.Drawing.Color.White;
            this.btnLeftExit.IconLeft = null;
            this.btnLeftExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeftExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLeftExit.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnLeftExit.IconMarginLeft = 11;
            this.btnLeftExit.IconPadding = 10;
            this.btnLeftExit.IconRight = null;
            this.btnLeftExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeftExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLeftExit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLeftExit.IconSize = 25;
            this.btnLeftExit.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnLeftExit.IdleBorderRadius = 0;
            this.btnLeftExit.IdleBorderThickness = 0;
            this.btnLeftExit.IdleFillColor = System.Drawing.Color.Empty;
            this.btnLeftExit.IdleIconLeftImage = null;
            this.btnLeftExit.IdleIconRightImage = null;
            this.btnLeftExit.IndicateFocus = false;
            this.btnLeftExit.Location = new System.Drawing.Point(271, 61);
            this.btnLeftExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeftExit.Name = "btnLeftExit";
            this.btnLeftExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLeftExit.OnDisabledState.BorderRadius = 10;
            this.btnLeftExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLeftExit.OnDisabledState.BorderThickness = 1;
            this.btnLeftExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLeftExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLeftExit.OnDisabledState.IconLeftImage = null;
            this.btnLeftExit.OnDisabledState.IconRightImage = null;
            this.btnLeftExit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.onHoverState.BorderRadius = 10;
            this.btnLeftExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLeftExit.onHoverState.BorderThickness = 1;
            this.btnLeftExit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLeftExit.onHoverState.IconLeftImage = null;
            this.btnLeftExit.onHoverState.IconRightImage = null;
            this.btnLeftExit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.OnIdleState.BorderRadius = 10;
            this.btnLeftExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLeftExit.OnIdleState.BorderThickness = 1;
            this.btnLeftExit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLeftExit.OnIdleState.IconLeftImage = null;
            this.btnLeftExit.OnIdleState.IconRightImage = null;
            this.btnLeftExit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.OnPressedState.BorderRadius = 10;
            this.btnLeftExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLeftExit.OnPressedState.BorderThickness = 1;
            this.btnLeftExit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnLeftExit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLeftExit.OnPressedState.IconLeftImage = null;
            this.btnLeftExit.OnPressedState.IconRightImage = null;
            this.btnLeftExit.Size = new System.Drawing.Size(99, 32);
            this.btnLeftExit.TabIndex = 31;
            this.btnLeftExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLeftExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLeftExit.TextMarginLeft = 0;
            this.btnLeftExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLeftExit.UseDefaultRadiusAndThickness = true;
            this.btnLeftExit.Click += new System.EventHandler(this.btnLeftExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Size = new System.Drawing.Size(388, 108);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLeftExit);
            this.panel2.Controls.Add(this.lblWrong);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 106);
            this.panel2.TabIndex = 32;
            // 
            // lblWrong
            // 
            this.lblWrong.AllowParentOverrides = false;
            this.lblWrong.AutoEllipsis = false;
            this.lblWrong.AutoSize = false;
            this.lblWrong.CursorType = null;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(37)))));
            this.lblWrong.Location = new System.Drawing.Point(75, 6);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblWrong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWrong.Size = new System.Drawing.Size(295, 53);
            this.lblWrong.TabIndex = 30;
            this.lblWrong.Text = "Some cutom error message here.";
            this.lblWrong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWrong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblWrong.Click += new System.EventHandler(this.lblWrong_Click);
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 145);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "error";
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox logoTitlebar;
        private Bunifu.UI.WinForms.BunifuLabel titleTitlebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLeftExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel lblWrong;
    }
}