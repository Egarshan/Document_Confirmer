namespace Document_Confirmer.forms
{
    partial class CitizenInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitizenInfo));
            this.FName_input = new System.Windows.Forms.TextBox();
            this.FN_label = new System.Windows.Forms.Label();
            this.SName_input = new System.Windows.Forms.TextBox();
            this.SN_label = new System.Windows.Forms.Label();
            this.Birth_label = new System.Windows.Forms.Label();
            this.Pass_number_label = new System.Windows.Forms.Label();
            this.PNumber_input = new System.Windows.Forms.TextBox();
            this.ExtDate_label = new System.Windows.Forms.Label();
            this.ExtPlace_label = new System.Windows.Forms.Label();
            this.PCity_input = new System.Windows.Forms.TextBox();
            this.Region_label = new System.Windows.Forms.Label();
            this.INNRegionCode_input = new System.Windows.Forms.TextBox();
            this.INNDate_label = new System.Windows.Forms.Label();
            this.INNNumber_label = new System.Windows.Forms.Label();
            this.INNNumber_input = new System.Windows.Forms.TextBox();
            this.Subdivsion_label = new System.Windows.Forms.Label();
            this.PSubdivison_input = new System.Windows.Forms.TextBox();
            this.Validity_label = new System.Windows.Forms.Label();
            this.PolicyNumber_label = new System.Windows.Forms.Label();
            this.PolicyNumber_input = new System.Windows.Forms.TextBox();
            this.FormName_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Flag_btn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Counters_panel = new System.Windows.Forms.Panel();
            this.Decline_count = new System.Windows.Forms.Label();
            this.DeclineCount_label = new System.Windows.Forms.Label();
            this.Gangsta_сount = new System.Windows.Forms.Label();
            this.Passed_сount = new System.Windows.Forms.Label();
            this.GangstaCount_label = new System.Windows.Forms.Label();
            this.PassedCount_label = new System.Windows.Forms.Label();
            this.CitizenError_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WrongPasSubdiv_label = new System.Windows.Forms.Label();
            this.WrongPasN_label = new System.Windows.Forms.Label();
            this.PassportError_label = new System.Windows.Forms.Label();
            this.PExtraditionDate_input = new System.Windows.Forms.DateTimePicker();
            this.PBirthDate_input = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WrongINNReg_label = new System.Windows.Forms.Label();
            this.WrongINNNum_label = new System.Windows.Forms.Label();
            this.INNError_label = new System.Windows.Forms.Label();
            this.INNGetDate_input = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WrongPolNum_label = new System.Windows.Forms.Label();
            this.PolicyError_label = new System.Windows.Forms.Label();
            this.PolicyActiveDate_input = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Action_btn = new System.Windows.Forms.Button();
            this.documentsDBDataSet = new Document_Confirmer.DocumentsDBDataSet();
            this.documentsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToMainScreen_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Flag_btn)).BeginInit();
            this.panel1.SuspendLayout();
            this.Counters_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FName_input
            // 
            this.FName_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FName_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FName_input.Location = new System.Drawing.Point(654, 69);
            this.FName_input.Name = "FName_input";
            this.FName_input.Size = new System.Drawing.Size(464, 34);
            this.FName_input.TabIndex = 0;
            // 
            // FN_label
            // 
            this.FN_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FN_label.AutoSize = true;
            this.FN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FN_label.Location = new System.Drawing.Point(579, 69);
            this.FN_label.Name = "FN_label";
            this.FN_label.Size = new System.Drawing.Size(69, 29);
            this.FN_label.TabIndex = 13;
            this.FN_label.Text = "Имя:";
            // 
            // SName_input
            // 
            this.SName_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SName_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SName_input.Location = new System.Drawing.Point(714, 109);
            this.SName_input.Name = "SName_input";
            this.SName_input.Size = new System.Drawing.Size(404, 34);
            this.SName_input.TabIndex = 14;
            // 
            // SN_label
            // 
            this.SN_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SN_label.AutoSize = true;
            this.SN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SN_label.Location = new System.Drawing.Point(579, 112);
            this.SN_label.Name = "SN_label";
            this.SN_label.Size = new System.Drawing.Size(129, 29);
            this.SN_label.TabIndex = 15;
            this.SN_label.Text = "Фамилия:";
            // 
            // Birth_label
            // 
            this.Birth_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Birth_label.AutoSize = true;
            this.Birth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birth_label.Location = new System.Drawing.Point(573, 109);
            this.Birth_label.Name = "Birth_label";
            this.Birth_label.Size = new System.Drawing.Size(197, 29);
            this.Birth_label.TabIndex = 19;
            this.Birth_label.Text = "Дата рождения:";
            // 
            // Pass_number_label
            // 
            this.Pass_number_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pass_number_label.AutoSize = true;
            this.Pass_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_number_label.Location = new System.Drawing.Point(573, 69);
            this.Pass_number_label.Name = "Pass_number_label";
            this.Pass_number_label.Size = new System.Drawing.Size(309, 29);
            this.Pass_number_label.TabIndex = 17;
            this.Pass_number_label.Text = "Серия и номер паспорта:";
            // 
            // PNumber_input
            // 
            this.PNumber_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNumber_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PNumber_input.Location = new System.Drawing.Point(906, 69);
            this.PNumber_input.MaxLength = 10;
            this.PNumber_input.Name = "PNumber_input";
            this.PNumber_input.Size = new System.Drawing.Size(215, 34);
            this.PNumber_input.TabIndex = 16;
            // 
            // ExtDate_label
            // 
            this.ExtDate_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtDate_label.AutoSize = true;
            this.ExtDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtDate_label.Location = new System.Drawing.Point(573, 186);
            this.ExtDate_label.Name = "ExtDate_label";
            this.ExtDate_label.Size = new System.Drawing.Size(165, 29);
            this.ExtDate_label.TabIndex = 23;
            this.ExtDate_label.Text = "Дата выдачи:";
            // 
            // ExtPlace_label
            // 
            this.ExtPlace_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtPlace_label.AutoSize = true;
            this.ExtPlace_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtPlace_label.Location = new System.Drawing.Point(573, 149);
            this.ExtPlace_label.Name = "ExtPlace_label";
            this.ExtPlace_label.Size = new System.Drawing.Size(272, 29);
            this.ExtPlace_label.TabIndex = 21;
            this.ExtPlace_label.Text = "Место выдачи (город):";
            // 
            // PCity_input
            // 
            this.PCity_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PCity_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCity_input.Location = new System.Drawing.Point(865, 149);
            this.PCity_input.Name = "PCity_input";
            this.PCity_input.Size = new System.Drawing.Size(256, 34);
            this.PCity_input.TabIndex = 20;
            // 
            // Region_label
            // 
            this.Region_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Region_label.AutoSize = true;
            this.Region_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region_label.Location = new System.Drawing.Point(582, 144);
            this.Region_label.Name = "Region_label";
            this.Region_label.Size = new System.Drawing.Size(171, 29);
            this.Region_label.TabIndex = 31;
            this.Region_label.Text = "Код  региона:";
            // 
            // INNRegionCode_input
            // 
            this.INNRegionCode_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.INNRegionCode_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNRegionCode_input.Location = new System.Drawing.Point(774, 144);
            this.INNRegionCode_input.MaxLength = 4;
            this.INNRegionCode_input.Name = "INNRegionCode_input";
            this.INNRegionCode_input.Size = new System.Drawing.Size(347, 34);
            this.INNRegionCode_input.TabIndex = 30;
            // 
            // INNDate_label
            // 
            this.INNDate_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.INNDate_label.AutoSize = true;
            this.INNDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNDate_label.Location = new System.Drawing.Point(582, 107);
            this.INNDate_label.Name = "INNDate_label";
            this.INNDate_label.Size = new System.Drawing.Size(165, 29);
            this.INNDate_label.TabIndex = 29;
            this.INNDate_label.Text = "Дата выдачи:";
            // 
            // INNNumber_label
            // 
            this.INNNumber_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.INNNumber_label.AutoSize = true;
            this.INNNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNNumber_label.Location = new System.Drawing.Point(582, 64);
            this.INNNumber_label.Name = "INNNumber_label";
            this.INNNumber_label.Size = new System.Drawing.Size(154, 29);
            this.INNNumber_label.TabIndex = 27;
            this.INNNumber_label.Text = "Номер ИНН:";
            // 
            // INNNumber_input
            // 
            this.INNNumber_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.INNNumber_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNNumber_input.Location = new System.Drawing.Point(742, 64);
            this.INNNumber_input.MaxLength = 10;
            this.INNNumber_input.Name = "INNNumber_input";
            this.INNNumber_input.Size = new System.Drawing.Size(379, 34);
            this.INNNumber_input.TabIndex = 26;
            // 
            // Subdivsion_label
            // 
            this.Subdivsion_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subdivsion_label.AutoSize = true;
            this.Subdivsion_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subdivsion_label.Location = new System.Drawing.Point(573, 226);
            this.Subdivsion_label.Name = "Subdivsion_label";
            this.Subdivsion_label.Size = new System.Drawing.Size(229, 29);
            this.Subdivsion_label.TabIndex = 25;
            this.Subdivsion_label.Text = "Номер отделения:";
            // 
            // PSubdivison_input
            // 
            this.PSubdivison_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PSubdivison_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PSubdivison_input.Location = new System.Drawing.Point(808, 229);
            this.PSubdivison_input.MaxLength = 6;
            this.PSubdivison_input.Name = "PSubdivison_input";
            this.PSubdivison_input.Size = new System.Drawing.Size(313, 34);
            this.PSubdivison_input.TabIndex = 24;
            // 
            // Validity_label
            // 
            this.Validity_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Validity_label.AutoSize = true;
            this.Validity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Validity_label.Location = new System.Drawing.Point(582, 111);
            this.Validity_label.Name = "Validity_label";
            this.Validity_label.Size = new System.Drawing.Size(220, 29);
            this.Validity_label.TabIndex = 37;
            this.Validity_label.Text = "Действителен до:";
            // 
            // PolicyNumber_label
            // 
            this.PolicyNumber_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PolicyNumber_label.AutoSize = true;
            this.PolicyNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolicyNumber_label.Location = new System.Drawing.Point(582, 71);
            this.PolicyNumber_label.Name = "PolicyNumber_label";
            this.PolicyNumber_label.Size = new System.Drawing.Size(186, 29);
            this.PolicyNumber_label.TabIndex = 35;
            this.PolicyNumber_label.Text = "Номер полиса:";
            // 
            // PolicyNumber_input
            // 
            this.PolicyNumber_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PolicyNumber_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolicyNumber_input.Location = new System.Drawing.Point(774, 71);
            this.PolicyNumber_input.MaxLength = 16;
            this.PolicyNumber_input.Name = "PolicyNumber_input";
            this.PolicyNumber_input.Size = new System.Drawing.Size(347, 34);
            this.PolicyNumber_input.TabIndex = 34;
            // 
            // FormName_label
            // 
            this.FormName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormName_label.Location = new System.Drawing.Point(605, 9);
            this.FormName_label.Name = "FormName_label";
            this.FormName_label.Size = new System.Drawing.Size(516, 37);
            this.FormName_label.TabIndex = 39;
            this.FormName_label.Text = "Form_name";
            this.FormName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(611, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Личные данные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1680, 5);
            this.label3.TabIndex = 41;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flag_btn
            // 
            this.Flag_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Flag_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Flag_btn.BackgroundImage")));
            this.Flag_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Flag_btn.Location = new System.Drawing.Point(1177, 34);
            this.Flag_btn.Name = "Flag_btn";
            this.Flag_btn.Size = new System.Drawing.Size(218, 107);
            this.Flag_btn.TabIndex = 42;
            this.Flag_btn.TabStop = false;
            this.Flag_btn.Click += new System.EventHandler(this.Flag_btn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(598, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(516, 37);
            this.label4.TabIndex = 43;
            this.label4.Text = "Паспорт";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(608, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(516, 37);
            this.label6.TabIndex = 45;
            this.label6.Text = "ИНН";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(611, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(516, 37);
            this.label8.TabIndex = 47;
            this.label8.Text = "Полис";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Counters_panel);
            this.panel1.Controls.Add(this.CitizenError_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Flag_btn);
            this.panel1.Controls.Add(this.SN_label);
            this.panel1.Controls.Add(this.SName_input);
            this.panel1.Controls.Add(this.FN_label);
            this.panel1.Controls.Add(this.FName_input);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1671, 175);
            this.panel1.TabIndex = 49;
            // 
            // Counters_panel
            // 
            this.Counters_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Counters_panel.Controls.Add(this.Decline_count);
            this.Counters_panel.Controls.Add(this.DeclineCount_label);
            this.Counters_panel.Controls.Add(this.Gangsta_сount);
            this.Counters_panel.Controls.Add(this.Passed_сount);
            this.Counters_panel.Controls.Add(this.GangstaCount_label);
            this.Counters_panel.Controls.Add(this.PassedCount_label);
            this.Counters_panel.Location = new System.Drawing.Point(1422, 34);
            this.Counters_panel.Name = "Counters_panel";
            this.Counters_panel.Size = new System.Drawing.Size(270, 109);
            this.Counters_panel.TabIndex = 45;
            this.Counters_panel.Visible = false;
            // 
            // Decline_count
            // 
            this.Decline_count.AutoSize = true;
            this.Decline_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decline_count.Location = new System.Drawing.Point(180, 40);
            this.Decline_count.Name = "Decline_count";
            this.Decline_count.Size = new System.Drawing.Size(26, 29);
            this.Decline_count.TabIndex = 5;
            this.Decline_count.Text = "0";
            // 
            // DeclineCount_label
            // 
            this.DeclineCount_label.AutoSize = true;
            this.DeclineCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeclineCount_label.Location = new System.Drawing.Point(3, 40);
            this.DeclineCount_label.Name = "DeclineCount_label";
            this.DeclineCount_label.Size = new System.Drawing.Size(149, 29);
            this.DeclineCount_label.TabIndex = 4;
            this.DeclineCount_label.Text = "Отклонено:";
            // 
            // Gangsta_сount
            // 
            this.Gangsta_сount.AutoSize = true;
            this.Gangsta_сount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gangsta_сount.Location = new System.Drawing.Point(180, 69);
            this.Gangsta_сount.Name = "Gangsta_сount";
            this.Gangsta_сount.Size = new System.Drawing.Size(26, 29);
            this.Gangsta_сount.TabIndex = 3;
            this.Gangsta_сount.Text = "0";
            // 
            // Passed_сount
            // 
            this.Passed_сount.AutoSize = true;
            this.Passed_сount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passed_сount.Location = new System.Drawing.Point(180, 8);
            this.Passed_сount.Name = "Passed_сount";
            this.Passed_сount.Size = new System.Drawing.Size(26, 29);
            this.Passed_сount.TabIndex = 2;
            this.Passed_сount.Text = "0";
            // 
            // GangstaCount_label
            // 
            this.GangstaCount_label.AutoSize = true;
            this.GangstaCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GangstaCount_label.Location = new System.Drawing.Point(3, 69);
            this.GangstaCount_label.Name = "GangstaCount_label";
            this.GangstaCount_label.Size = new System.Drawing.Size(171, 29);
            this.GangstaCount_label.TabIndex = 1;
            this.GangstaCount_label.Text = "Преступники:";
            // 
            // PassedCount_label
            // 
            this.PassedCount_label.AutoSize = true;
            this.PassedCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassedCount_label.Location = new System.Drawing.Point(3, 8);
            this.PassedCount_label.Name = "PassedCount_label";
            this.PassedCount_label.Size = new System.Drawing.Size(159, 29);
            this.PassedCount_label.TabIndex = 0;
            this.PassedCount_label.Text = "Пропущено: ";
            // 
            // CitizenError_label
            // 
            this.CitizenError_label.AutoSize = true;
            this.CitizenError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitizenError_label.ForeColor = System.Drawing.Color.Red;
            this.CitizenError_label.Location = new System.Drawing.Point(3, 21);
            this.CitizenError_label.Name = "CitizenError_label";
            this.CitizenError_label.Size = new System.Drawing.Size(0, 29);
            this.CitizenError_label.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.WrongPasSubdiv_label);
            this.panel2.Controls.Add(this.WrongPasN_label);
            this.panel2.Controls.Add(this.PassportError_label);
            this.panel2.Controls.Add(this.PExtraditionDate_input);
            this.panel2.Controls.Add(this.PBirthDate_input);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PNumber_input);
            this.panel2.Controls.Add(this.Pass_number_label);
            this.panel2.Controls.Add(this.Birth_label);
            this.panel2.Controls.Add(this.PCity_input);
            this.panel2.Controls.Add(this.ExtPlace_label);
            this.panel2.Controls.Add(this.ExtDate_label);
            this.panel2.Controls.Add(this.PSubdivison_input);
            this.panel2.Controls.Add(this.Subdivsion_label);
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1671, 277);
            this.panel2.TabIndex = 50;
            // 
            // WrongPasSubdiv_label
            // 
            this.WrongPasSubdiv_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WrongPasSubdiv_label.AutoSize = true;
            this.WrongPasSubdiv_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongPasSubdiv_label.ForeColor = System.Drawing.Color.Red;
            this.WrongPasSubdiv_label.Location = new System.Drawing.Point(1127, 232);
            this.WrongPasSubdiv_label.Name = "WrongPasSubdiv_label";
            this.WrongPasSubdiv_label.Size = new System.Drawing.Size(363, 29);
            this.WrongPasSubdiv_label.TabIndex = 47;
            this.WrongPasSubdiv_label.Text = "Формат: 6 цифр без пробелов";
            this.WrongPasSubdiv_label.Visible = false;
            // 
            // WrongPasN_label
            // 
            this.WrongPasN_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WrongPasN_label.AutoSize = true;
            this.WrongPasN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongPasN_label.ForeColor = System.Drawing.Color.Red;
            this.WrongPasN_label.Location = new System.Drawing.Point(1127, 69);
            this.WrongPasN_label.Name = "WrongPasN_label";
            this.WrongPasN_label.Size = new System.Drawing.Size(376, 29);
            this.WrongPasN_label.TabIndex = 46;
            this.WrongPasN_label.Text = "Формат: 10 цифр без пробелов";
            this.WrongPasN_label.Visible = false;
            // 
            // PassportError_label
            // 
            this.PassportError_label.AutoSize = true;
            this.PassportError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportError_label.ForeColor = System.Drawing.Color.Red;
            this.PassportError_label.Location = new System.Drawing.Point(7, 19);
            this.PassportError_label.Name = "PassportError_label";
            this.PassportError_label.Size = new System.Drawing.Size(0, 29);
            this.PassportError_label.TabIndex = 44;
            // 
            // PExtraditionDate_input
            // 
            this.PExtraditionDate_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PExtraditionDate_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PExtraditionDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PExtraditionDate_input.Location = new System.Drawing.Point(742, 186);
            this.PExtraditionDate_input.MaxDate = new System.DateTime(2045, 1, 25, 23, 59, 0, 0);
            this.PExtraditionDate_input.MinDate = new System.DateTime(1913, 12, 25, 23, 59, 0, 0);
            this.PExtraditionDate_input.Name = "PExtraditionDate_input";
            this.PExtraditionDate_input.Size = new System.Drawing.Size(379, 34);
            this.PExtraditionDate_input.TabIndex = 45;
            this.PExtraditionDate_input.Value = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // PBirthDate_input
            // 
            this.PBirthDate_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBirthDate_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PBirthDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PBirthDate_input.Location = new System.Drawing.Point(776, 109);
            this.PBirthDate_input.MaxDate = new System.DateTime(2045, 1, 25, 23, 59, 59, 0);
            this.PBirthDate_input.MinDate = new System.DateTime(1913, 12, 25, 23, 59, 59, 0);
            this.PBirthDate_input.Name = "PBirthDate_input";
            this.PBirthDate_input.Size = new System.Drawing.Size(345, 34);
            this.PBirthDate_input.TabIndex = 44;
            this.PBirthDate_input.Value = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(-10, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1680, 5);
            this.label11.TabIndex = 41;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.WrongINNReg_label);
            this.panel3.Controls.Add(this.WrongINNNum_label);
            this.panel3.Controls.Add(this.INNError_label);
            this.panel3.Controls.Add(this.INNGetDate_input);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.INNNumber_input);
            this.panel3.Controls.Add(this.INNNumber_label);
            this.panel3.Controls.Add(this.INNDate_label);
            this.panel3.Controls.Add(this.INNRegionCode_input);
            this.panel3.Controls.Add(this.Region_label);
            this.panel3.Location = new System.Drawing.Point(0, 523);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1671, 193);
            this.panel3.TabIndex = 51;
            // 
            // WrongINNReg_label
            // 
            this.WrongINNReg_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WrongINNReg_label.AutoSize = true;
            this.WrongINNReg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongINNReg_label.ForeColor = System.Drawing.Color.Red;
            this.WrongINNReg_label.Location = new System.Drawing.Point(1127, 147);
            this.WrongINNReg_label.Name = "WrongINNReg_label";
            this.WrongINNReg_label.Size = new System.Drawing.Size(380, 29);
            this.WrongINNReg_label.TabIndex = 49;
            this.WrongINNReg_label.Text = "Формат: 4 цифры без пробелов";
            this.WrongINNReg_label.Visible = false;
            // 
            // WrongINNNum_label
            // 
            this.WrongINNNum_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WrongINNNum_label.AutoSize = true;
            this.WrongINNNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongINNNum_label.ForeColor = System.Drawing.Color.Red;
            this.WrongINNNum_label.Location = new System.Drawing.Point(1127, 67);
            this.WrongINNNum_label.Name = "WrongINNNum_label";
            this.WrongINNNum_label.Size = new System.Drawing.Size(376, 29);
            this.WrongINNNum_label.TabIndex = 48;
            this.WrongINNNum_label.Text = "Формат: 10 цифр без пробелов";
            this.WrongINNNum_label.Visible = false;
            // 
            // INNError_label
            // 
            this.INNError_label.AutoSize = true;
            this.INNError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNError_label.ForeColor = System.Drawing.Color.Red;
            this.INNError_label.Location = new System.Drawing.Point(7, 19);
            this.INNError_label.Name = "INNError_label";
            this.INNError_label.Size = new System.Drawing.Size(0, 29);
            this.INNError_label.TabIndex = 46;
            // 
            // INNGetDate_input
            // 
            this.INNGetDate_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.INNGetDate_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.INNGetDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.INNGetDate_input.Location = new System.Drawing.Point(753, 107);
            this.INNGetDate_input.MaxDate = new System.DateTime(2045, 1, 25, 23, 59, 0, 0);
            this.INNGetDate_input.MinDate = new System.DateTime(1913, 12, 25, 23, 59, 0, 0);
            this.INNGetDate_input.Name = "INNGetDate_input";
            this.INNGetDate_input.Size = new System.Drawing.Size(368, 34);
            this.INNGetDate_input.TabIndex = 46;
            this.INNGetDate_input.Value = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1680, 5);
            this.label1.TabIndex = 41;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.WrongPolNum_label);
            this.panel4.Controls.Add(this.PolicyError_label);
            this.panel4.Controls.Add(this.PolicyActiveDate_input);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.PolicyNumber_input);
            this.panel4.Controls.Add(this.PolicyNumber_label);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.Validity_label);
            this.panel4.Location = new System.Drawing.Point(0, 722);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1671, 160);
            this.panel4.TabIndex = 52;
            // 
            // WrongPolNum_label
            // 
            this.WrongPolNum_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WrongPolNum_label.AutoSize = true;
            this.WrongPolNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongPolNum_label.ForeColor = System.Drawing.Color.Red;
            this.WrongPolNum_label.Location = new System.Drawing.Point(1127, 74);
            this.WrongPolNum_label.Name = "WrongPolNum_label";
            this.WrongPolNum_label.Size = new System.Drawing.Size(376, 29);
            this.WrongPolNum_label.TabIndex = 51;
            this.WrongPolNum_label.Text = "Формат: 16 цифр без пробелов";
            this.WrongPolNum_label.Visible = false;
            // 
            // PolicyError_label
            // 
            this.PolicyError_label.AutoSize = true;
            this.PolicyError_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolicyError_label.ForeColor = System.Drawing.Color.Red;
            this.PolicyError_label.Location = new System.Drawing.Point(12, 21);
            this.PolicyError_label.Name = "PolicyError_label";
            this.PolicyError_label.Size = new System.Drawing.Size(0, 29);
            this.PolicyError_label.TabIndex = 47;
            // 
            // PolicyActiveDate_input
            // 
            this.PolicyActiveDate_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PolicyActiveDate_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolicyActiveDate_input.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PolicyActiveDate_input.Location = new System.Drawing.Point(808, 111);
            this.PolicyActiveDate_input.MaxDate = new System.DateTime(2045, 1, 25, 23, 59, 0, 0);
            this.PolicyActiveDate_input.MinDate = new System.DateTime(1913, 12, 25, 23, 59, 0, 0);
            this.PolicyActiveDate_input.Name = "PolicyActiveDate_input";
            this.PolicyActiveDate_input.Size = new System.Drawing.Size(313, 34);
            this.PolicyActiveDate_input.TabIndex = 47;
            this.PolicyActiveDate_input.Value = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-10, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1680, 5);
            this.label7.TabIndex = 41;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Action_btn
            // 
            this.Action_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Action_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Action_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Action_btn.Location = new System.Drawing.Point(789, 888);
            this.Action_btn.MaximumSize = new System.Drawing.Size(162, 39);
            this.Action_btn.MinimumSize = new System.Drawing.Size(162, 39);
            this.Action_btn.Name = "Action_btn";
            this.Action_btn.Size = new System.Drawing.Size(162, 39);
            this.Action_btn.TabIndex = 53;
            this.Action_btn.Text = "Action_name";
            this.Action_btn.UseVisualStyleBackColor = false;
            this.Action_btn.Click += new System.EventHandler(this.Action_btn_Click);
            // 
            // documentsDBDataSet
            // 
            this.documentsDBDataSet.DataSetName = "DocumentsDBDataSet";
            this.documentsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsDBDataSetBindingSource
            // 
            this.documentsDBDataSetBindingSource.DataSource = this.documentsDBDataSet;
            this.documentsDBDataSetBindingSource.Position = 0;
            // 
            // ToMainScreen_btn
            // 
            this.ToMainScreen_btn.BackColor = System.Drawing.Color.Red;
            this.ToMainScreen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainScreen_btn.Location = new System.Drawing.Point(12, 7);
            this.ToMainScreen_btn.MaximumSize = new System.Drawing.Size(104, 39);
            this.ToMainScreen_btn.MinimumSize = new System.Drawing.Size(104, 39);
            this.ToMainScreen_btn.Name = "ToMainScreen_btn";
            this.ToMainScreen_btn.Size = new System.Drawing.Size(104, 39);
            this.ToMainScreen_btn.TabIndex = 48;
            this.ToMainScreen_btn.Text = "Назад";
            this.ToMainScreen_btn.UseVisualStyleBackColor = false;
            this.ToMainScreen_btn.Click += new System.EventHandler(this.ToMainScreen_btn_Click);
            // 
            // CitizenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1667, 971);
            this.Controls.Add(this.Action_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToMainScreen_btn);
            this.Controls.Add(this.FormName_label);
            this.Name = "CitizenInfo";
            this.Text = "CitizenInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CitizenInfo_FormClosed);
            this.BackColorChanged += new System.EventHandler(this.CitizenInfo_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Flag_btn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Counters_panel.ResumeLayout(false);
            this.Counters_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FName_input;
        private System.Windows.Forms.Label FN_label;
        private System.Windows.Forms.TextBox SName_input;
        private System.Windows.Forms.Label SN_label;
        private System.Windows.Forms.Label Birth_label;
        private System.Windows.Forms.Label Pass_number_label;
        private System.Windows.Forms.TextBox PNumber_input;
        private System.Windows.Forms.Label ExtDate_label;
        private System.Windows.Forms.Label ExtPlace_label;
        private System.Windows.Forms.TextBox PCity_input;
        private System.Windows.Forms.Label Region_label;
        private System.Windows.Forms.TextBox INNRegionCode_input;
        private System.Windows.Forms.Label INNDate_label;
        private System.Windows.Forms.Label INNNumber_label;
        private System.Windows.Forms.TextBox INNNumber_input;
        private System.Windows.Forms.Label Subdivsion_label;
        private System.Windows.Forms.TextBox PSubdivison_input;
        private System.Windows.Forms.Label Validity_label;
        private System.Windows.Forms.Label PolicyNumber_label;
        private System.Windows.Forms.TextBox PolicyNumber_input;
        private System.Windows.Forms.Label FormName_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Flag_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PBirthDate_input;
        private System.Windows.Forms.DateTimePicker PExtraditionDate_input;
        private System.Windows.Forms.DateTimePicker INNGetDate_input;
        private System.Windows.Forms.DateTimePicker PolicyActiveDate_input;
        private System.Windows.Forms.Button Action_btn;
        private System.Windows.Forms.Label CitizenError_label;
        private System.Windows.Forms.Label PassportError_label;
        private System.Windows.Forms.Label INNError_label;
        private System.Windows.Forms.Label PolicyError_label;
        private System.Windows.Forms.Label WrongPasN_label;
        private System.Windows.Forms.Label WrongPasSubdiv_label;
        private System.Windows.Forms.Label WrongINNReg_label;
        private System.Windows.Forms.Label WrongINNNum_label;
        private System.Windows.Forms.Label WrongPolNum_label;
        private DocumentsDBDataSet documentsDBDataSet;
        private System.Windows.Forms.BindingSource documentsDBDataSetBindingSource;
        private System.Windows.Forms.Button ToMainScreen_btn;
        private System.Windows.Forms.Panel Counters_panel;
        private System.Windows.Forms.Label Gangsta_сount;
        private System.Windows.Forms.Label Passed_сount;
        private System.Windows.Forms.Label GangstaCount_label;
        private System.Windows.Forms.Label PassedCount_label;
        private System.Windows.Forms.Label Decline_count;
        private System.Windows.Forms.Label DeclineCount_label;
    }
}