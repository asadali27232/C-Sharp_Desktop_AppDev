namespace WindowsFormsApp1
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.titleBar = new System.Windows.Forms.Panel();
            this.logoTitlebar = new System.Windows.Forms.PictureBox();
            this.titleTitlebar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelAdmin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.panel2.Controls.Add(this.btnCancelAdmin);
            this.panel2.Controls.Add(this.lblWrong);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 106);
            this.panel2.TabIndex = 32;
            // 
            // btnCancelAdmin
            // 
            this.btnCancelAdmin.AllowAnimations = true;
            this.btnCancelAdmin.AllowMouseEffects = true;
            this.btnCancelAdmin.AllowToggling = false;
            this.btnCancelAdmin.AnimationSpeed = 200;
            this.btnCancelAdmin.AutoGenerateColors = false;
            this.btnCancelAdmin.AutoRoundBorders = false;
            this.btnCancelAdmin.AutoSizeLeftIcon = true;
            this.btnCancelAdmin.AutoSizeRightIcon = true;
            this.btnCancelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelAdmin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCancelAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelAdmin.BackgroundImage")));
            this.btnCancelAdmin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelAdmin.ButtonText = "Exit";
            this.btnCancelAdmin.ButtonTextMarginLeft = 0;
            this.btnCancelAdmin.ColorContrastOnClick = 45;
            this.btnCancelAdmin.ColorContrastOnHover = 45;
            this.btnCancelAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancelAdmin.CustomizableEdges = borderEdges1;
            this.btnCancelAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelAdmin.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCancelAdmin.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCancelAdmin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdmin.IconLeft = null;
            this.btnCancelAdmin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAdmin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelAdmin.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnCancelAdmin.IconMarginLeft = 11;
            this.btnCancelAdmin.IconPadding = 10;
            this.btnCancelAdmin.IconRight = null;
            this.btnCancelAdmin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAdmin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelAdmin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelAdmin.IconSize = 25;
            this.btnCancelAdmin.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCancelAdmin.IdleBorderRadius = 0;
            this.btnCancelAdmin.IdleBorderThickness = 0;
            this.btnCancelAdmin.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCancelAdmin.IdleIconLeftImage = null;
            this.btnCancelAdmin.IdleIconRightImage = null;
            this.btnCancelAdmin.IndicateFocus = false;
            this.btnCancelAdmin.Location = new System.Drawing.Point(271, 62);
            this.btnCancelAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelAdmin.Name = "btnCancelAdmin";
            this.btnCancelAdmin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelAdmin.OnDisabledState.BorderRadius = 10;
            this.btnCancelAdmin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelAdmin.OnDisabledState.BorderThickness = 1;
            this.btnCancelAdmin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelAdmin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelAdmin.OnDisabledState.IconLeftImage = null;
            this.btnCancelAdmin.OnDisabledState.IconRightImage = null;
            this.btnCancelAdmin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(101)))), ((int)(((byte)(41)))));
            this.btnCancelAdmin.onHoverState.BorderRadius = 10;
            this.btnCancelAdmin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelAdmin.onHoverState.BorderThickness = 1;
            this.btnCancelAdmin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(101)))), ((int)(((byte)(41)))));
            this.btnCancelAdmin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdmin.onHoverState.IconLeftImage = null;
            this.btnCancelAdmin.onHoverState.IconRightImage = null;
            this.btnCancelAdmin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnCancelAdmin.OnIdleState.BorderRadius = 10;
            this.btnCancelAdmin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelAdmin.OnIdleState.BorderThickness = 1;
            this.btnCancelAdmin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnCancelAdmin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdmin.OnIdleState.IconLeftImage = null;
            this.btnCancelAdmin.OnIdleState.IconRightImage = null;
            this.btnCancelAdmin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnCancelAdmin.OnPressedState.BorderRadius = 10;
            this.btnCancelAdmin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelAdmin.OnPressedState.BorderThickness = 1;
            this.btnCancelAdmin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(76)))), ((int)(((byte)(33)))));
            this.btnCancelAdmin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdmin.OnPressedState.IconLeftImage = null;
            this.btnCancelAdmin.OnPressedState.IconRightImage = null;
            this.btnCancelAdmin.Size = new System.Drawing.Size(99, 32);
            this.btnCancelAdmin.TabIndex = 32;
            this.btnCancelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelAdmin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelAdmin.TextMarginLeft = 0;
            this.btnCancelAdmin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelAdmin.UseDefaultRadiusAndThickness = true;
            this.btnCancelAdmin.Click += new System.EventHandler(this.btnCancelAdmin_Click);
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
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 145);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel lblWrong;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelAdmin;
    }
}