namespace EduMuse
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button_ApplyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView_Programs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button_Back = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Programs)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(30, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(800, 40);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "Отчеты";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label_Title;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel_Main
            // 
            this.guna2Panel_Main.BackColor = System.Drawing.Color.White;
            this.guna2Panel_Main.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel_Main.BorderRadius = 15;
            this.guna2Panel_Main.BorderThickness = 1;
            this.guna2Panel_Main.Controls.Add(this.guna2Button3);
            this.guna2Panel_Main.Controls.Add(this.guna2Button2);
            this.guna2Panel_Main.Controls.Add(this.guna2Button1);
            this.guna2Panel_Main.Controls.Add(this.guna2Button_ApplyFilter);
            this.guna2Panel_Main.Controls.Add(this.guna2DataGridView_Programs);
            this.guna2Panel_Main.Location = new System.Drawing.Point(51, 74);
            this.guna2Panel_Main.Name = "guna2Panel_Main";
            this.guna2Panel_Main.Size = new System.Drawing.Size(742, 476);
            this.guna2Panel_Main.TabIndex = 14;
            // 
            // guna2Button_ApplyFilter
            // 
            this.guna2Button_ApplyFilter.BorderRadius = 10;
            this.guna2Button_ApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button_ApplyFilter.ForeColor = System.Drawing.Color.White;
            this.guna2Button_ApplyFilter.Location = new System.Drawing.Point(20, 15);
            this.guna2Button_ApplyFilter.Name = "guna2Button_ApplyFilter";
            this.guna2Button_ApplyFilter.Size = new System.Drawing.Size(146, 45);
            this.guna2Button_ApplyFilter.TabIndex = 3;
            this.guna2Button_ApplyFilter.Text = "Отчеты по посещаемости";
            this.guna2Button_ApplyFilter.Click += new System.EventHandler(this.guna2Button_ApplyFilter_Click);
            // 
            // guna2DataGridView_Programs
            // 
            this.guna2DataGridView_Programs.AllowUserToAddRows = false;
            this.guna2DataGridView_Programs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Programs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.guna2DataGridView_Programs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Programs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.guna2DataGridView_Programs.ColumnHeadersHeight = 40;
            this.guna2DataGridView_Programs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Programs.DefaultCellStyle = dataGridViewCellStyle21;
            this.guna2DataGridView_Programs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Programs.Location = new System.Drawing.Point(20, 66);
            this.guna2DataGridView_Programs.Name = "guna2DataGridView_Programs";
            this.guna2DataGridView_Programs.ReadOnly = true;
            this.guna2DataGridView_Programs.RowHeadersVisible = false;
            this.guna2DataGridView_Programs.RowTemplate.Height = 30;
            this.guna2DataGridView_Programs.Size = new System.Drawing.Size(710, 385);
            this.guna2DataGridView_Programs.TabIndex = 0;
            this.guna2DataGridView_Programs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Programs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Programs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Programs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Programs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Programs.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridView_Programs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView_Programs.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView_Programs.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Programs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Button_Back
            // 
            this.guna2Button_Back.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Back.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Back.Location = new System.Drawing.Point(12, 9);
            this.guna2Button_Back.Name = "guna2Button_Back";
            this.guna2Button_Back.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Back.TabIndex = 17;
            this.guna2Button_Back.Text = "←";
            // 
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(747, 9);
            this.guna2Button_Minimize.Name = "guna2Button_Minimize";
            this.guna2Button_Minimize.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Minimize.TabIndex = 15;
            this.guna2Button_Minimize.Text = "—";
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
            this.guna2Button_Close.Location = new System.Drawing.Point(792, 9);
            this.guna2Button_Close.Name = "guna2Button_Close";
            this.guna2Button_Close.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Close.TabIndex = 16;
            this.guna2Button_Close.Text = "X";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(209, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(144, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Отчеты по популярности программ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(574, 15);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(144, 45);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Отчеты по сотрудникам";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(395, 15);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(144, 45);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Вывести на печать";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 568);
            this.Controls.Add(this.guna2Panel_Main);
            this.Controls.Add(this.guna2Button_Back);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.guna2Panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Programs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Main;
        private Guna.UI2.WinForms.Guna2Button guna2Button_ApplyFilter;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Programs;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Back;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}