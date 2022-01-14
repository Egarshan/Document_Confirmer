namespace Document_Confirmer.forms
{
    partial class DecisionWindow
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
            this.CompareTable = new System.Windows.Forms.DataGridView();
            this.AcceptAction_btn = new System.Windows.Forms.Button();
            this.CancelAction_btn = new System.Windows.Forms.Button();
            this.WarningLevel_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompareTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CompareTable
            // 
            this.CompareTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompareTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompareTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CompareTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompareTable.Location = new System.Drawing.Point(1, 105);
            this.CompareTable.Name = "CompareTable";
            this.CompareTable.RowHeadersWidth = 51;
            this.CompareTable.RowTemplate.Height = 24;
            this.CompareTable.Size = new System.Drawing.Size(1036, 470);
            this.CompareTable.TabIndex = 0;
            // 
            // AcceptAction_btn
            // 
            this.AcceptAction_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AcceptAction_btn.BackColor = System.Drawing.Color.LightGreen;
            this.AcceptAction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptAction_btn.Location = new System.Drawing.Point(423, 631);
            this.AcceptAction_btn.Name = "AcceptAction_btn";
            this.AcceptAction_btn.Size = new System.Drawing.Size(199, 39);
            this.AcceptAction_btn.TabIndex = 1;
            this.AcceptAction_btn.Text = "Подтвердить";
            this.AcceptAction_btn.UseVisualStyleBackColor = false;
            this.AcceptAction_btn.Click += new System.EventHandler(this.AcceptAction_btn_Click);
            // 
            // CancelAction_btn
            // 
            this.CancelAction_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelAction_btn.BackColor = System.Drawing.Color.Red;
            this.CancelAction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAction_btn.Location = new System.Drawing.Point(423, 676);
            this.CancelAction_btn.Name = "CancelAction_btn";
            this.CancelAction_btn.Size = new System.Drawing.Size(199, 39);
            this.CancelAction_btn.TabIndex = 2;
            this.CancelAction_btn.Text = "Отклонить";
            this.CancelAction_btn.UseVisualStyleBackColor = false;
            this.CancelAction_btn.Click += new System.EventHandler(this.CancelAction_btn_Click);
            // 
            // WarningLevel_label
            // 
            this.WarningLevel_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WarningLevel_label.BackColor = System.Drawing.Color.Transparent;
            this.WarningLevel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarningLevel_label.Location = new System.Drawing.Point(1, 578);
            this.WarningLevel_label.Name = "WarningLevel_label";
            this.WarningLevel_label.Padding = new System.Windows.Forms.Padding(10);
            this.WarningLevel_label.Size = new System.Drawing.Size(1036, 49);
            this.WarningLevel_label.TabIndex = 3;
            this.WarningLevel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найденные совпадения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecisionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarningLevel_label);
            this.Controls.Add(this.CancelAction_btn);
            this.Controls.Add(this.AcceptAction_btn);
            this.Controls.Add(this.CompareTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DecisionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecisionWindow";
            ((System.ComponentModel.ISupportInitialize)(this.CompareTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CompareTable;
        private System.Windows.Forms.Button AcceptAction_btn;
        private System.Windows.Forms.Button CancelAction_btn;
        private System.Windows.Forms.Label WarningLevel_label;
        private System.Windows.Forms.Label label1;
    }
}