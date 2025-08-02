namespace EduMuse.ManagmentProgram
{
    partial class FormCatalogeProgram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2Panel_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button_ApplyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox_Filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView_Programs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Back = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Programs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label_Title;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(800, 40);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Каталог программ";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel_Main
            // 
            this.guna2Panel_Main.BackColor = System.Drawing.Color.White;
            this.guna2Panel_Main.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel_Main.BorderRadius = 15;
            this.guna2Panel_Main.BorderThickness = 1;
            this.guna2Panel_Main.Controls.Add(this.guna2Button_ApplyFilter);
            this.guna2Panel_Main.Controls.Add(this.guna2ComboBox_Filter);
            this.guna2Panel_Main.Controls.Add(this.guna2TextBox_Search);
            this.guna2Panel_Main.Controls.Add(this.guna2DataGridView_Programs);
            this.guna2Panel_Main.Location = new System.Drawing.Point(25, 60);
            this.guna2Panel_Main.Name = "guna2Panel_Main";
            this.guna2Panel_Main.Size = new System.Drawing.Size(750, 480);
            this.guna2Panel_Main.TabIndex = 9;
            // 
            // guna2Button_ApplyFilter
            // 
            this.guna2Button_ApplyFilter.BorderRadius = 10;
            this.guna2Button_ApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button_ApplyFilter.ForeColor = System.Drawing.Color.White;
            this.guna2Button_ApplyFilter.Location = new System.Drawing.Point(620, 20);
            this.guna2Button_ApplyFilter.Name = "guna2Button_ApplyFilter";
            this.guna2Button_ApplyFilter.Size = new System.Drawing.Size(110, 36);
            this.guna2Button_ApplyFilter.TabIndex = 3;
            this.guna2Button_ApplyFilter.Text = "Применить";
            this.guna2Button_ApplyFilter.Click += new System.EventHandler(this.guna2Button_ApplyFilter_Click);
            // 
            // guna2ComboBox_Filter
            // 
            this.guna2ComboBox_Filter.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox_Filter.BorderRadius = 10;
            this.guna2ComboBox_Filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox_Filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Filter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox_Filter.ItemHeight = 30;
            this.guna2ComboBox_Filter.Items.AddRange(new object[] {
            "Без фильтра",
            "По теме",
            "По возрасту"});
            this.guna2ComboBox_Filter.Location = new System.Drawing.Point(280, 20);
            this.guna2ComboBox_Filter.Name = "guna2ComboBox_Filter";
            this.guna2ComboBox_Filter.Size = new System.Drawing.Size(150, 36);
            this.guna2ComboBox_Filter.StartIndex = 0;
            this.guna2ComboBox_Filter.TabIndex = 2;
            // 
            // guna2TextBox_Search
            // 
            this.guna2TextBox_Search.BorderRadius = 10;
            this.guna2TextBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_Search.DefaultText = "";
            this.guna2TextBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Search.Location = new System.Drawing.Point(20, 20);
            this.guna2TextBox_Search.Name = "guna2TextBox_Search";
            this.guna2TextBox_Search.PlaceholderText = "Поиск...";
            this.guna2TextBox_Search.SelectedText = "";
            this.guna2TextBox_Search.Size = new System.Drawing.Size(250, 36);
            this.guna2TextBox_Search.TabIndex = 1;
            // 
            // guna2DataGridView_Programs
            // 
            this.guna2DataGridView_Programs.AllowUserToAddRows = false;
            this.guna2DataGridView_Programs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Programs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView_Programs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Programs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView_Programs.ColumnHeadersHeight = 40;
            this.guna2DataGridView_Programs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Programs.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView_Programs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Programs.Location = new System.Drawing.Point(20, 75);
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
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(708, 0);
            this.guna2Button_Minimize.Name = "guna2Button_Minimize";
            this.guna2Button_Minimize.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Minimize.TabIndex = 10;
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
            this.guna2Button_Close.Location = new System.Drawing.Point(754, 0);
            this.guna2Button_Close.Name = "guna2Button_Close";
            this.guna2Button_Close.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Close.TabIndex = 11;
            this.guna2Button_Close.Text = "X";
            this.guna2Button_Close.Click += new System.EventHandler(this.guna2Button_Close_Click);
            // 
            // guna2Button_Back
            // 
            this.guna2Button_Back.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Back.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Back.Location = new System.Drawing.Point(0, 0);
            this.guna2Button_Back.Name = "guna2Button_Back";
            this.guna2Button_Back.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Back.TabIndex = 12;
            this.guna2Button_Back.Text = "←";
            this.guna2Button_Back.Click += new System.EventHandler(this.guna2Button_Back_Click);
            // 
            // FormCatalogeProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.guna2Button_Back);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.guna2Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogeProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.guna2Panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Programs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Main;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Programs;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Search;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox_Filter;
        private Guna.UI2.WinForms.Guna2Button guna2Button_ApplyFilter;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Back;
    }
}