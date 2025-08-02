using System;
using System.Windows.Forms;

namespace EduMuse.ManagmentProgram
{
    partial class ManagmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Update = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox_Staff = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2NumericUpDown_MaxParticipants = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown_MaxAge = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown_MinAge = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2NumericUpDown_Duration = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2TextBox_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox_TargetAudience = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox_ProgramName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox_ProgramID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPrograms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_Title = new System.Windows.Forms.Label();
            this.guna2Button_Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Button_Back = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MaxParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_Duration)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button_Back);
            this.guna2Panel1.Controls.Add(this.guna2Button_Delete);
            this.guna2Panel1.Controls.Add(this.guna2Button_Clear);
            this.guna2Panel1.Controls.Add(this.guna2Button_Update);
            this.guna2Panel1.Controls.Add(this.guna2Button_Add);
            this.guna2Panel1.Controls.Add(this.guna2ComboBox_Staff);
            this.guna2Panel1.Controls.Add(this.guna2NumericUpDown_MaxParticipants);
            this.guna2Panel1.Controls.Add(this.guna2NumericUpDown_MaxAge);
            this.guna2Panel1.Controls.Add(this.guna2NumericUpDown_MinAge);
            this.guna2Panel1.Controls.Add(this.guna2NumericUpDown_Price);
            this.guna2Panel1.Controls.Add(this.guna2NumericUpDown_Duration);
            this.guna2Panel1.Controls.Add(this.guna2TextBox_Description);
            this.guna2Panel1.Controls.Add(this.guna2TextBox_TargetAudience);
            this.guna2Panel1.Controls.Add(this.guna2TextBox_ProgramName);
            this.guna2Panel1.Controls.Add(this.guna2TextBox_ProgramID);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(350, 600);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button_Delete
            // 
            this.guna2Button_Delete.BorderRadius = 10;
            this.guna2Button_Delete.FillColor = System.Drawing.Color.Red;
            this.guna2Button_Delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button_Delete.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Delete.Location = new System.Drawing.Point(12, 530);
            this.guna2Button_Delete.Name = "guna2Button_Delete";
            this.guna2Button_Delete.Size = new System.Drawing.Size(154, 45);
            this.guna2Button_Delete.TabIndex = 22;
            this.guna2Button_Delete.Text = "Удалить";
            this.guna2Button_Delete.Click += new System.EventHandler(this.guna2Button_Delete_Click);
            // 
            // guna2Button_Clear
            // 
            this.guna2Button_Clear.BorderRadius = 10;
            this.guna2Button_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button_Clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button_Clear.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Clear.Location = new System.Drawing.Point(184, 530);
            this.guna2Button_Clear.Name = "guna2Button_Clear";
            this.guna2Button_Clear.Size = new System.Drawing.Size(154, 45);
            this.guna2Button_Clear.TabIndex = 21;
            this.guna2Button_Clear.Text = "Очистить";
            this.guna2Button_Clear.Click += new System.EventHandler(this.guna2Button_Clear_Click);
            // 
            // guna2Button_Update
            // 
            this.guna2Button_Update.BorderRadius = 10;
            this.guna2Button_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_Update.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button_Update.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Update.Location = new System.Drawing.Point(184, 479);
            this.guna2Button_Update.Name = "guna2Button_Update";
            this.guna2Button_Update.Size = new System.Drawing.Size(154, 45);
            this.guna2Button_Update.TabIndex = 20;
            this.guna2Button_Update.Text = "Обновить";
            this.guna2Button_Update.Click += new System.EventHandler(this.guna2Button_Update_Click);
            // 
            // guna2Button_Add
            // 
            this.guna2Button_Add.BorderRadius = 10;
            this.guna2Button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button_Add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button_Add.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Add.Location = new System.Drawing.Point(12, 479);
            this.guna2Button_Add.Name = "guna2Button_Add";
            this.guna2Button_Add.Size = new System.Drawing.Size(154, 45);
            this.guna2Button_Add.TabIndex = 19;
            this.guna2Button_Add.Text = "Добавить";
            this.guna2Button_Add.Click += new System.EventHandler(this.guna2Button_Add_Click);
            // 
            // guna2ComboBox_Staff
            // 
            this.guna2ComboBox_Staff.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox_Staff.BorderRadius = 8;
            this.guna2ComboBox_Staff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox_Staff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Staff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox_Staff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox_Staff.ItemHeight = 30;
            this.guna2ComboBox_Staff.Location = new System.Drawing.Point(179, 432);
            this.guna2ComboBox_Staff.Name = "guna2ComboBox_Staff";
            this.guna2ComboBox_Staff.Size = new System.Drawing.Size(159, 36);
            this.guna2ComboBox_Staff.TabIndex = 18;
            // 
            // guna2NumericUpDown_MaxParticipants
            // 
            this.guna2NumericUpDown_MaxParticipants.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown_MaxParticipants.BorderRadius = 8;
            this.guna2NumericUpDown_MaxParticipants.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown_MaxParticipants.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown_MaxParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown_MaxParticipants.Location = new System.Drawing.Point(179, 390);
            this.guna2NumericUpDown_MaxParticipants.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.guna2NumericUpDown_MaxParticipants.Name = "guna2NumericUpDown_MaxParticipants";
            this.guna2NumericUpDown_MaxParticipants.Size = new System.Drawing.Size(159, 36);
            this.guna2NumericUpDown_MaxParticipants.TabIndex = 17;
            // 
            // guna2NumericUpDown_MaxAge
            // 
            this.guna2NumericUpDown_MaxAge.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown_MaxAge.BorderRadius = 8;
            this.guna2NumericUpDown_MaxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown_MaxAge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown_MaxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown_MaxAge.Location = new System.Drawing.Point(179, 348);
            this.guna2NumericUpDown_MaxAge.Name = "guna2NumericUpDown_MaxAge";
            this.guna2NumericUpDown_MaxAge.Size = new System.Drawing.Size(159, 36);
            this.guna2NumericUpDown_MaxAge.TabIndex = 16;
            // 
            // guna2NumericUpDown_MinAge
            // 
            this.guna2NumericUpDown_MinAge.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown_MinAge.BorderRadius = 8;
            this.guna2NumericUpDown_MinAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown_MinAge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown_MinAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown_MinAge.Location = new System.Drawing.Point(179, 306);
            this.guna2NumericUpDown_MinAge.Name = "guna2NumericUpDown_MinAge";
            this.guna2NumericUpDown_MinAge.Size = new System.Drawing.Size(159, 36);
            this.guna2NumericUpDown_MinAge.TabIndex = 15;
            // 
            // guna2NumericUpDown_Price
            // 
            this.guna2NumericUpDown_Price.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown_Price.BorderRadius = 8;
            this.guna2NumericUpDown_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown_Price.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown_Price.Location = new System.Drawing.Point(179, 264);
            this.guna2NumericUpDown_Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.guna2NumericUpDown_Price.Name = "guna2NumericUpDown_Price";
            this.guna2NumericUpDown_Price.Size = new System.Drawing.Size(159, 36);
            this.guna2NumericUpDown_Price.TabIndex = 14;
            // 
            // guna2NumericUpDown_Duration
            // 
            this.guna2NumericUpDown_Duration.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown_Duration.BorderRadius = 8;
            this.guna2NumericUpDown_Duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown_Duration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2NumericUpDown_Duration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2NumericUpDown_Duration.Location = new System.Drawing.Point(179, 222);
            this.guna2NumericUpDown_Duration.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.guna2NumericUpDown_Duration.Name = "guna2NumericUpDown_Duration";
            this.guna2NumericUpDown_Duration.Size = new System.Drawing.Size(159, 36);
            this.guna2NumericUpDown_Duration.TabIndex = 13;
            // 
            // guna2TextBox_Description
            // 
            this.guna2TextBox_Description.BorderRadius = 8;
            this.guna2TextBox_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_Description.DefaultText = "";
            this.guna2TextBox_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_Description.Location = new System.Drawing.Point(179, 180);
            this.guna2TextBox_Description.Name = "guna2TextBox_Description";
            this.guna2TextBox_Description.PlaceholderText = "";
            this.guna2TextBox_Description.SelectedText = "";
            this.guna2TextBox_Description.Size = new System.Drawing.Size(159, 36);
            this.guna2TextBox_Description.TabIndex = 12;
            // 
            // guna2TextBox_TargetAudience
            // 
            this.guna2TextBox_TargetAudience.BorderRadius = 8;
            this.guna2TextBox_TargetAudience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_TargetAudience.DefaultText = "";
            this.guna2TextBox_TargetAudience.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_TargetAudience.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_TargetAudience.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_TargetAudience.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_TargetAudience.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_TargetAudience.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox_TargetAudience.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_TargetAudience.Location = new System.Drawing.Point(179, 138);
            this.guna2TextBox_TargetAudience.Name = "guna2TextBox_TargetAudience";
            this.guna2TextBox_TargetAudience.PlaceholderText = "";
            this.guna2TextBox_TargetAudience.SelectedText = "";
            this.guna2TextBox_TargetAudience.Size = new System.Drawing.Size(159, 36);
            this.guna2TextBox_TargetAudience.TabIndex = 11;
            // 
            // guna2TextBox_ProgramName
            // 
            this.guna2TextBox_ProgramName.BorderRadius = 8;
            this.guna2TextBox_ProgramName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_ProgramName.DefaultText = "";
            this.guna2TextBox_ProgramName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_ProgramName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_ProgramName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ProgramName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ProgramName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ProgramName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox_ProgramName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ProgramName.Location = new System.Drawing.Point(179, 96);
            this.guna2TextBox_ProgramName.Name = "guna2TextBox_ProgramName";
            this.guna2TextBox_ProgramName.PlaceholderText = "";
            this.guna2TextBox_ProgramName.SelectedText = "";
            this.guna2TextBox_ProgramName.Size = new System.Drawing.Size(159, 36);
            this.guna2TextBox_ProgramName.TabIndex = 10;
            // 
            // guna2TextBox_ProgramID
            // 
            this.guna2TextBox_ProgramID.BorderRadius = 8;
            this.guna2TextBox_ProgramID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_ProgramID.DefaultText = "";
            this.guna2TextBox_ProgramID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_ProgramID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_ProgramID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ProgramID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ProgramID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ProgramID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox_ProgramID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ProgramID.Location = new System.Drawing.Point(179, 54);
            this.guna2TextBox_ProgramID.Name = "guna2TextBox_ProgramID";
            this.guna2TextBox_ProgramID.PlaceholderText = "";
            this.guna2TextBox_ProgramID.SelectedText = "";
            this.guna2TextBox_ProgramID.Size = new System.Drawing.Size(159, 36);
            this.guna2TextBox_ProgramID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ответственный сотрудник";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "Максимальное\r\nколичество участников";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Максимальный\r\nвозраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Минимальный\r\nвозраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Длительность (часов)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Целевая аудитория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название программы";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvPrograms);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(350, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(936, 600);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgvPrograms
            // 
            this.dgvPrograms.AllowUserToAddRows = false;
            this.dgvPrograms.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPrograms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrograms.ColumnHeadersHeight = 45;
            this.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrograms.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrograms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrograms.Location = new System.Drawing.Point(0, 43);
            this.dgvPrograms.Name = "dgvPrograms";
            this.dgvPrograms.ReadOnly = true;
            this.dgvPrograms.RowHeadersVisible = false;
            this.dgvPrograms.Size = new System.Drawing.Size(936, 557);
            this.dgvPrograms.TabIndex = 0;
            this.dgvPrograms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrograms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrograms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrograms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrograms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrograms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrograms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrograms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPrograms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrograms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPrograms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrograms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrograms.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPrograms.ThemeStyle.ReadOnly = true;
            this.dgvPrograms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrograms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrograms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPrograms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrograms.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPrograms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrograms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrograms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrograms_CellClick);
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(350, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(936, 40);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Управление музейными программами";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button_Minimize
            // 
            this.guna2Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Minimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Minimize.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Minimize.Location = new System.Drawing.Point(1194, 0);
            this.guna2Button_Minimize.Name = "guna2Button_Minimize";
            this.guna2Button_Minimize.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Minimize.TabIndex = 3;
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
            this.guna2Button_Close.Location = new System.Drawing.Point(1240, 0);
            this.guna2Button_Close.Name = "guna2Button_Close";
            this.guna2Button_Close.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Close.TabIndex = 4;
            this.guna2Button_Close.Text = "X";
            this.guna2Button_Close.Click += new System.EventHandler(this.guna2Button_Close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label_Title;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Button_Back
            // 
            this.guna2Button_Back.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button_Back.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_Back.Location = new System.Drawing.Point(3, 0);
            this.guna2Button_Back.Name = "guna2Button_Back";
            this.guna2Button_Back.Size = new System.Drawing.Size(46, 40);
            this.guna2Button_Back.TabIndex = 13;
            this.guna2Button_Back.Text = "←";
            this.guna2Button_Back.Click += new System.EventHandler(this.guna2Button_Back_Click);
            // 
            // ManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 600);
            this.Controls.Add(this.guna2Button_Close);
            this.Controls.Add(this.guna2Button_Minimize);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MaxParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_MinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown_Duration)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograms)).EndInit();
            this.ResumeLayout(false);

        }

        private void guna2Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void guna2Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_ProgramID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown_MaxParticipants;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown_MaxAge;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown_MinAge;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown_Price;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown_Duration;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_Description;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_TargetAudience;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_ProgramName;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox_Staff;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Add;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Clear;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Update;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrograms;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Delete;
        private System.Windows.Forms.Label label_Title;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Minimize;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Back;
    }
}