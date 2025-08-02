namespace EduMuse
{
    partial class AutoForm
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
            this.guna2Panel_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.guna2Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel_Main
            // 
            this.guna2Panel_Main.BackColor = System.Drawing.Color.White;
            this.guna2Panel_Main.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel_Main.BorderRadius = 15;
            this.guna2Panel_Main.BorderThickness = 1;
            this.guna2Panel_Main.Controls.Add(this.label_LoginTitle);
            this.guna2Panel_Main.Controls.Add(this.guna2Button_Login);
            this.guna2Panel_Main.Controls.Add(this.guna2TextBox_Password);
            this.guna2Panel_Main.Controls.Add(this.guna2TextBox_Username);
            this.guna2Panel_Main.Location = new System.Drawing.Point(50, 60);
            this.guna2Panel_Main.Name = "guna2Panel_Main";
            this.guna2Panel_Main.ShadowDecoration.Parent = this.guna2Panel_Main;
            this.guna2Panel_Main.Size = new System.Drawing.Size(300, 300);
            this.guna2Panel_Main.TabIndex = 0;
            // 
            // guna2Button_Login
            // 
            this.guna2Button_Login.BorderRadius = 10;
            this.guna2Button_Login.CheckedState.Parent = this.guna2Button_Login;
            this.guna2Button_Login.CustomImages.Parent = this.guna2Button_Login;
            this.guna2Button_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Login.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Login.HoverState.Parent = this.guna2Button_Login;
            this.guna2Button_Login.Location = new System.Drawing.Point(50, 220);
            this.guna2Button_Login.Name = "guna2Button_Login";
            this.guna2Button_Login.ShadowDecoration.Parent = this.guna2Button_Login;
            this.guna2Button_Login.Size = new System.Drawing.Size(200, 45);
            this.guna2Button_Login.TabIndex = 2;
            this.guna2Button_Login.Text = "Войти";
            this.guna2Button_Login.Click += new System.EventHandler(this.guna2Button_Login_Click);
            // 
            // guna2TextBox_Password
            // 
            this.guna2TextBox_Password.BorderRadius = 10;
            this.guna2TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_Password.DefaultText = "";
            this.guna2TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Password.DisabledState.Parent = this.guna2TextBox_Password;
            this.guna2TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Password.FocusedState.Parent = this.guna2TextBox_Password;
            this.guna2TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Password.HoverState.Parent = this.guna2TextBox_Password;
            this.guna2TextBox_Password.Location = new System.Drawing.Point(50, 150);
            this.guna2TextBox_Password.Name = "guna2TextBox_Password";
            this.guna2TextBox_Password.PasswordChar = '*';
            this.guna2TextBox_Password.PlaceholderText = "Пароль";
            this.guna2TextBox_Password.SelectedText = "";
            this.guna2TextBox_Password.ShadowDecoration.Parent = this.guna2TextBox_Password;
            this.guna2TextBox_Password.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox_Password.TabIndex = 1;
            // 
            // guna2TextBox_Username
            // 
            this.guna2TextBox_Username.BorderRadius = 10;
            this.guna2TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_Username.DefaultText = "";
            this.guna2TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Username.DisabledState.Parent = this.guna2TextBox_Username;
            this.guna2TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Username.FocusedState.Parent = this.guna2TextBox_Username;
            this.guna2TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Username.HoverState.Parent = this.guna2TextBox_Username;
            this.guna2TextBox_Username.Location = new System.Drawing.Point(50, 90);
            this.guna2TextBox_Username.Name = "guna2TextBox_Username";
            this.guna2TextBox_Username.PasswordChar = '\0';
            this.guna2TextBox_Username.PlaceholderText = "Имя пользователя";
            this.guna2TextBox_Username.SelectedText = "";
            this.guna2TextBox_Username.ShadowDecoration.Parent = this.guna2TextBox_Username;
            this.guna2TextBox_Username.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox_Username.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(400, 40);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Авторизация";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button_Close
            // 
            this.guna2Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Close.CheckedState.Parent = this.guna2Button_Close;
            this.guna2Button_Close.CustomImages.Parent = this.guna2Button_Close;
            this.guna2Button_Close.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Close.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Close.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Close.HoverState.Parent = this.guna2Button_Close;
            this.guna2Button_Close.Location = new System.Drawing.Point(354, 0);
            this.guna2Button_Close.Name = "guna2Button_Close";
            this.guna2Button_Close.ShadowDecoration.Parent = this.guna2Button_Close;
            this.guna2Button_Close.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Close.TabIndex = 2;
            this.guna2Button_Close.Text = "X";
            this.guna2Button_Close.Click += new System.EventHandler(this.guna2Button_Close_Click);
            // 
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.CheckedState.Parent = this.guna2Button_Minimize;
            this.guna2Button_Minimize.CustomImages.Parent = this.guna2Button_Minimize;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.HoverState.Parent = this.guna2Button_Minimize;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(308, 0);
            this.guna2Button_Minimize.Name = "guna2Button_Minimize";
            this.guna2Button_Minimize.ShadowDecoration.Parent = this.guna2Button_Minimize;
            this.guna2Button_Minimize.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Minimize.TabIndex = 3;
            this.guna2Button_Minimize.Text = "—";
            this.guna2Button_Minimize.Click += new System.EventHandler(this.guna2Button_Minimize_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label_Title;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LoginTitle.Location = new System.Drawing.Point(50, 30);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(200, 30);
            this.label_LoginTitle.TabIndex = 3;
            this.label_LoginTitle.Text = "Вход";
            this.label_LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.guna2Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.guna2Panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Main;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Login;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Password;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Username;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label_LoginTitle;
    }
}