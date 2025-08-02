namespace EduMuse.ScheduleAndBookingManagement
{
    partial class BookingManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Back = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel_Main = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_Schedule = new System.Windows.Forms.TabPage();
            this.guna2DataGridView_Schedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2DateTimePicker_Schedule = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tabPage_Bookings = new System.Windows.Forms.TabPage();
            this.guna2Button_Reject = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Confirm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView_Bookings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_LoginTitle = new System.Windows.Forms.Label();
            this.guna2Panel_Main.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Schedule)).BeginInit();
            this.tabPage_Bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Bookings)).BeginInit();
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
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(900, 40);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Управление программами";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(808, 0);
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
            this.guna2Button_Close.Location = new System.Drawing.Point(854, 0);
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
            // guna2Panel_Main
            // 
            this.guna2Panel_Main.BackColor = System.Drawing.Color.White;
            this.guna2Panel_Main.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel_Main.BorderRadius = 15;
            this.guna2Panel_Main.BorderThickness = 1;
            this.guna2Panel_Main.Controls.Add(this.guna2TabControl1);
            this.guna2Panel_Main.Location = new System.Drawing.Point(25, 60);
            this.guna2Panel_Main.Name = "guna2Panel_Main";
            this.guna2Panel_Main.Size = new System.Drawing.Size(850, 580);
            this.guna2Panel_Main.TabIndex = 13;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage_Schedule);
            this.guna2TabControl1.Controls.Add(this.tabPage_Bookings);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(2, 2);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(846, 576);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // tabPage_Schedule
            // 
            this.tabPage_Schedule.Controls.Add(this.label_LoginTitle);
            this.tabPage_Schedule.Controls.Add(this.guna2DataGridView_Schedule);
            this.tabPage_Schedule.Controls.Add(this.guna2DateTimePicker_Schedule);
            this.tabPage_Schedule.Location = new System.Drawing.Point(184, 4);
            this.tabPage_Schedule.Name = "tabPage_Schedule";
            this.tabPage_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Schedule.Size = new System.Drawing.Size(658, 568);
            this.tabPage_Schedule.TabIndex = 0;
            this.tabPage_Schedule.Text = "Расписание программ";
            this.tabPage_Schedule.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView_Schedule
            // 
            this.guna2DataGridView_Schedule.AllowUserToAddRows = false;
            this.guna2DataGridView_Schedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Schedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView_Schedule.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView_Schedule.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Schedule.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView_Schedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView_Schedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Schedule.Location = new System.Drawing.Point(3, 90);
            this.guna2DataGridView_Schedule.Name = "guna2DataGridView_Schedule";
            this.guna2DataGridView_Schedule.ReadOnly = true;
            this.guna2DataGridView_Schedule.RowHeadersVisible = false;
            this.guna2DataGridView_Schedule.RowTemplate.Height = 30;
            this.guna2DataGridView_Schedule.Size = new System.Drawing.Size(652, 475);
            this.guna2DataGridView_Schedule.TabIndex = 1;
            this.guna2DataGridView_Schedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Schedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Schedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Schedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Schedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Schedule.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridView_Schedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView_Schedule.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView_Schedule.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Schedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2DateTimePicker_Schedule
            // 
            this.guna2DateTimePicker_Schedule.Checked = true;
            this.guna2DateTimePicker_Schedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker_Schedule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2DateTimePicker_Schedule.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker_Schedule.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker_Schedule.Location = new System.Drawing.Point(209, 27);
            this.guna2DateTimePicker_Schedule.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker_Schedule.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker_Schedule.Name = "guna2DateTimePicker_Schedule";
            this.guna2DateTimePicker_Schedule.Size = new System.Drawing.Size(307, 36);
            this.guna2DateTimePicker_Schedule.TabIndex = 0;
            this.guna2DateTimePicker_Schedule.Value = new System.DateTime(2023, 10, 26, 17, 30, 48, 570);
            this.guna2DateTimePicker_Schedule.ValueChanged += new System.EventHandler(this.guna2DateTimePicker_Schedule_ValueChanged);
            // 
            // tabPage_Bookings
            // 
            this.tabPage_Bookings.Controls.Add(this.guna2Button_Reject);
            this.tabPage_Bookings.Controls.Add(this.guna2Button_Confirm);
            this.tabPage_Bookings.Controls.Add(this.guna2DataGridView_Bookings);
            this.tabPage_Bookings.Location = new System.Drawing.Point(184, 4);
            this.tabPage_Bookings.Name = "tabPage_Bookings";
            this.tabPage_Bookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Bookings.Size = new System.Drawing.Size(658, 568);
            this.tabPage_Bookings.TabIndex = 1;
            this.tabPage_Bookings.Text = "Управление бронированиями";
            this.tabPage_Bookings.UseVisualStyleBackColor = true;
            // 
            // guna2Button_Reject
            // 
            this.guna2Button_Reject.BorderRadius = 10;
            this.guna2Button_Reject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button_Reject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Reject.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Reject.Location = new System.Drawing.Point(198, 520);
            this.guna2Button_Reject.Name = "guna2Button_Reject";
            this.guna2Button_Reject.Size = new System.Drawing.Size(180, 45);
            this.guna2Button_Reject.TabIndex = 4;
            this.guna2Button_Reject.Text = "Отклонить";
            this.guna2Button_Reject.Click += new System.EventHandler(this.guna2Button_Reject_Click);
            // 
            // guna2Button_Confirm
            // 
            this.guna2Button_Confirm.BorderRadius = 10;
            this.guna2Button_Confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2Button_Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Confirm.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Confirm.Location = new System.Drawing.Point(12, 520);
            this.guna2Button_Confirm.Name = "guna2Button_Confirm";
            this.guna2Button_Confirm.Size = new System.Drawing.Size(180, 45);
            this.guna2Button_Confirm.TabIndex = 3;
            this.guna2Button_Confirm.Text = "Подтвердить";
            this.guna2Button_Confirm.Click += new System.EventHandler(this.guna2Button_Confirm_Click);
            // 
            // guna2DataGridView_Bookings
            // 
            this.guna2DataGridView_Bookings.AllowUserToAddRows = false;
            this.guna2DataGridView_Bookings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Bookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView_Bookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Bookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView_Bookings.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Bookings.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView_Bookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2DataGridView_Bookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Bookings.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView_Bookings.Name = "guna2DataGridView_Bookings";
            this.guna2DataGridView_Bookings.ReadOnly = true;
            this.guna2DataGridView_Bookings.RowHeadersVisible = false;
            this.guna2DataGridView_Bookings.RowTemplate.Height = 30;
            this.guna2DataGridView_Bookings.Size = new System.Drawing.Size(652, 511);
            this.guna2DataGridView_Bookings.TabIndex = 2;
            this.guna2DataGridView_Bookings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Bookings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Bookings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Bookings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Bookings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Bookings.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridView_Bookings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView_Bookings.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView_Bookings.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Bookings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label_LoginTitle
            // 
            this.label_LoginTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LoginTitle.Location = new System.Drawing.Point(3, 27);
            this.label_LoginTitle.Name = "label_LoginTitle";
            this.label_LoginTitle.Size = new System.Drawing.Size(200, 30);
            this.label_LoginTitle.TabIndex = 4;
            this.label_LoginTitle.Text = "Выберите дату:";
            this.label_LoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookingManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.guna2Panel_Main);
            this.Controls.Add(this.guna2Button_Back);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.guna2Panel_Main.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage_Schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Schedule)).EndInit();
            this.tabPage_Bookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Back;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Main;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage_Schedule;
        private System.Windows.Forms.TabPage tabPage_Bookings;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker_Schedule;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Schedule;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Reject;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Confirm;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Bookings;
        private System.Windows.Forms.Label label_LoginTitle;
    }
}