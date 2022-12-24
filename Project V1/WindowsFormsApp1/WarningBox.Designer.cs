namespace WindowsFormsApp1
{
    partial class WarningBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.titleBar = new System.Windows.Forms.Panel();
            this.logoTitlebar = new System.Windows.Forms.PictureBox();
            this.titleTitlebar = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearAdminForm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.titleBar.Controls.Add(this.logoTitlebar);
            this.titleBar.Controls.Add(this.titleTitlebar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(388, 37);
            this.titleBar.TabIndex = 33;
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
            this.titleTitlebar.Size = new System.Drawing.Size(65, 33);
            this.titleTitlebar.TabIndex = 5;
            this.titleTitlebar.Text = "Warning";
            this.titleTitlebar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleTitlebar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Size = new System.Drawing.Size(388, 108);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClearAdminForm);
            this.panel2.Controls.Add(this.lblWrong);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 106);
            this.panel2.TabIndex = 32;
            // 
            // btnClearAdminForm
            // 
            this.btnClearAdminForm.AllowAnimations = true;
            this.btnClearAdminForm.AllowMouseEffects = true;
            this.btnClearAdminForm.AllowToggling = false;
            this.btnClearAdminForm.AnimationSpeed = 200;
            this.btnClearAdminForm.AutoGenerateColors = false;
            this.btnClearAdminForm.AutoRoundBorders = false;
            this.btnClearAdminForm.AutoSizeLeftIcon = true;
            this.btnClearAdminForm.AutoSizeRightIcon = true;
            this.btnClearAdminForm.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAdminForm.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClearAdminForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearAdminForm.BackgroundImage")));
            this.btnClearAdminForm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearAdminForm.ButtonText = "Continue";
            this.btnClearAdminForm.ButtonTextMarginLeft = 0;
            this.btnClearAdminForm.ColorContrastOnClick = 45;
            this.btnClearAdminForm.ColorContrastOnHover = 45;
            this.btnClearAdminForm.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClearAdminForm.CustomizableEdges = borderEdges1;
            this.btnClearAdminForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearAdminForm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearAdminForm.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClearAdminForm.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClearAdminForm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClearAdminForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAdminForm.ForeColor = System.Drawing.Color.White;
            this.btnClearAdminForm.IconLeft = null;
            this.btnClearAdminForm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAdminForm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearAdminForm.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnClearAdminForm.IconMarginLeft = 11;
            this.btnClearAdminForm.IconPadding = 10;
            this.btnClearAdminForm.IconRight = null;
            this.btnClearAdminForm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAdminForm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClearAdminForm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClearAdminForm.IconSize = 25;
            this.btnClearAdminForm.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClearAdminForm.IdleBorderRadius = 0;
            this.btnClearAdminForm.IdleBorderThickness = 0;
            this.btnClearAdminForm.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClearAdminForm.IdleIconLeftImage = null;
            this.btnClearAdminForm.IdleIconRightImage = null;
            this.btnClearAdminForm.IndicateFocus = false;
            this.btnClearAdminForm.Location = new System.Drawing.Point(268, 62);
            this.btnClearAdminForm.Margin = new System.Windows.Forms.Padding(5);
            this.btnClearAdminForm.Name = "btnClearAdminForm";
            this.btnClearAdminForm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClearAdminForm.OnDisabledState.BorderRadius = 10;
            this.btnClearAdminForm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearAdminForm.OnDisabledState.BorderThickness = 1;
            this.btnClearAdminForm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearAdminForm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClearAdminForm.OnDisabledState.IconLeftImage = null;
            this.btnClearAdminForm.OnDisabledState.IconRightImage = null;
            this.btnClearAdminForm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(191)))), ((int)(((byte)(32)))));
            this.btnClearAdminForm.onHoverState.BorderRadius = 10;
            this.btnClearAdminForm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearAdminForm.onHoverState.BorderThickness = 1;
            this.btnClearAdminForm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(191)))), ((int)(((byte)(32)))));
            this.btnClearAdminForm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClearAdminForm.onHoverState.IconLeftImage = null;
            this.btnClearAdminForm.onHoverState.IconRightImage = null;
            this.btnClearAdminForm.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.btnClearAdminForm.OnIdleState.BorderRadius = 10;
            this.btnClearAdminForm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearAdminForm.OnIdleState.BorderThickness = 1;
            this.btnClearAdminForm.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.btnClearAdminForm.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClearAdminForm.OnIdleState.IconLeftImage = null;
            this.btnClearAdminForm.OnIdleState.IconRightImage = null;
            this.btnClearAdminForm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.btnClearAdminForm.OnPressedState.BorderRadius = 10;
            this.btnClearAdminForm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClearAdminForm.OnPressedState.BorderThickness = 1;
            this.btnClearAdminForm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.btnClearAdminForm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClearAdminForm.OnPressedState.IconLeftImage = null;
            this.btnClearAdminForm.OnPressedState.IconRightImage = null;
            this.btnClearAdminForm.Size = new System.Drawing.Size(99, 32);
            this.btnClearAdminForm.TabIndex = 89;
            this.btnClearAdminForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearAdminForm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAdminForm.TextMarginLeft = 0;
            this.btnClearAdminForm.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClearAdminForm.UseDefaultRadiusAndThickness = true;
            this.btnClearAdminForm.Click += new System.EventHandler(this.btnClearAdminForm_Click);
            // 
            // lblWrong
            // 
            this.lblWrong.AllowParentOverrides = false;
            this.lblWrong.AutoEllipsis = false;
            this.lblWrong.AutoSize = false;
            this.lblWrong.CursorType = null;
            this.lblWrong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(38)))));
            this.lblWrong.Location = new System.Drawing.Point(72, 6);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblWrong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWrong.Size = new System.Drawing.Size(295, 53);
            this.lblWrong.TabIndex = 30;
            this.lblWrong.Text = "Some cutom error message here.";
            this.lblWrong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWrong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // WarningBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 145);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarningBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClearAdminForm;
    }
}