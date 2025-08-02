namespace EduMuse
{
    partial class MenuForm
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
            this.guna2Button_Staff = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Programs = new Guna.UI2.WinForms.Guna2Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_Main.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel_Main
            // 
            this.guna2Panel_Main.BackColor = System.Drawing.Color.White;
            this.guna2Panel_Main.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel_Main.BorderRadius = 15;
            this.guna2Panel_Main.BorderThickness = 1;
            this.guna2Panel_Main.Controls.Add(this.label_LoginTitle);
            this.guna2Panel_Main.Controls.Add(this.guna2Button1);
            this.guna2Panel_Main.Controls.Add(this.guna2Button_Programs);
            this.guna2Panel_Main.Location = new System.Drawing.Point(24, 43);
            this.guna2Panel_Main.Name = "guna2Panel_Main";
            this.guna2Panel_Main.Size = new System.Drawing.Size(336, 300);
            this.guna2Panel_Main.TabIndex = 4;
            // 
            // guna2Button_Staff
            // 
            this.guna2Button_Staff.BorderRadius = 10;
            this.guna2Button_Staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Staff.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Staff.Location = new System.Drawing.Point(68, 93);
            this.guna2Button_Staff.Name = "guna2Button_Staff";
            this.guna2Button_Staff.Size = new System.Drawing.Size(200, 53);
            this.guna2Button_Staff.TabIndex = 1;
            this.guna2Button_Staff.Text = "Сотрудники";
            this.guna2Button_Staff.Click += new System.EventHandler(this.guna2Button_Staff_Click);
            // 
            // guna2Button_Programs
            // 
            this.guna2Button_Programs.BorderRadius = 10;
            this.guna2Button_Programs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Programs.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Programs.Location = new System.Drawing.Point(68, 127);
            this.guna2Button_Programs.Name = "guna2Button_Programs";
            this.guna2Button_Programs.Size = new System.Drawing.Size(200, 70);
            this.guna2Button_Programs.TabIndex = 0;
            this.guna2Button_Programs.Text = "Редактирование данных программ";
            this.guna2Button_Programs.Click += new System.EventHandler(this.guna2Button_Programs_Click);
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(810, 40);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "Главное меню";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(718, 0);
            this.guna2Button_Minimize.Name = "guna2Button_Minimize";
            this.guna2Button_Minimize.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Minimize.TabIndex = 6;
            this.guna2Button_Minimize.Text = "—";
            this.guna2Button_Minimize.Click += new System.EventHandler(this.guna2Button_Minimize_Click);
            // 
            // guna2Button_Close
            // 
            this.guna2Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Close.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Close.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Close.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button_Close.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Close.Location = new System.Drawing.Point(764, 0);
            this.guna2Button_Close.Name = "guna2Button_Close";
            this.guna2Button_Close.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Close.TabIndex = 7;
            this.guna2Button_Close.Text = "X";
            this.guna2Button_Close.Click += new System.EventHandler(this.guna2Button_Close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label_Title;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(68, 63);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(200, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Просмотр программ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LoginTitle.Location = new System.Drawing.Point(68, 15);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(200, 30);
            this.label_LoginTitle.TabIndex = 4;
            this.label_LoginTitle.Text = "Программы";
            this.label_LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(392, 43);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(336, 300);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Управление расписанием и бронированием";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(68, 93);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(200, 53);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Управление программами";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(68, 164);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(200, 53);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Бронирование";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.guna2Button4);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.guna2Button_Staff);
            this.guna2Panel2.Location = new System.Drawing.Point(24, 359);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(336, 251);
            this.guna2Panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Персонал";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(68, 164);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(200, 53);
            this.guna2Button4.TabIndex = 7;
            this.guna2Button4.Text = "Отчет";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2Button5);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Location = new System.Drawing.Point(392, 359);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(336, 251);
            this.guna2Panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчеты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(67, 93);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(200, 53);
            this.guna2Button5.TabIndex = 8;
            this.guna2Button5.Text = "Форма";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 649);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.guna2Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.guna2Panel_Main.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Main;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Staff;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Programs;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_LoginTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label label3;
    }
}