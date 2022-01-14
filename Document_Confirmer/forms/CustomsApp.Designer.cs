namespace Document_Confirmer
{
    partial class CustomsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomsApp));
            this.App_label = new System.Windows.Forms.Label();
            this.New_citizen_btn = new System.Windows.Forms.Button();
            this.Check_citizen_btn = new System.Windows.Forms.Button();
            this.MainBtns_panel = new System.Windows.Forms.Panel();
            this.MainBtns_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // App_label
            // 
            this.App_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.App_label.BackColor = System.Drawing.Color.Transparent;
            this.App_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.App_label.Location = new System.Drawing.Point(174, 25);
            this.App_label.MaximumSize = new System.Drawing.Size(0, 46);
            this.App_label.MinimumSize = new System.Drawing.Size(370, 46);
            this.App_label.Name = "App_label";
            this.App_label.Size = new System.Drawing.Size(370, 46);
            this.App_label.TabIndex = 0;
            this.App_label.Text = "Сервис таможни";
            this.App_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_citizen_btn
            // 
            this.New_citizen_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.New_citizen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_citizen_btn.Location = new System.Drawing.Point(181, 10);
            this.New_citizen_btn.MaximumSize = new System.Drawing.Size(160, 63);
            this.New_citizen_btn.Name = "New_citizen_btn";
            this.New_citizen_btn.Size = new System.Drawing.Size(160, 63);
            this.New_citizen_btn.TabIndex = 1;
            this.New_citizen_btn.Text = "Регистрация\r\nгражданина";
            this.New_citizen_btn.UseVisualStyleBackColor = true;
            this.New_citizen_btn.Click += new System.EventHandler(this.New_citizen_btn_Click);
            // 
            // Check_citizen_btn
            // 
            this.Check_citizen_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Check_citizen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_citizen_btn.Location = new System.Drawing.Point(366, 10);
            this.Check_citizen_btn.MaximumSize = new System.Drawing.Size(160, 63);
            this.Check_citizen_btn.MinimumSize = new System.Drawing.Size(160, 63);
            this.Check_citizen_btn.Name = "Check_citizen_btn";
            this.Check_citizen_btn.Size = new System.Drawing.Size(160, 63);
            this.Check_citizen_btn.TabIndex = 2;
            this.Check_citizen_btn.Text = "Проверить\r\nгражданина";
            this.Check_citizen_btn.UseVisualStyleBackColor = true;
            this.Check_citizen_btn.Click += new System.EventHandler(this.Check_citizen_btn_Click);
            // 
            // MainBtns_panel
            // 
            this.MainBtns_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBtns_panel.BackColor = System.Drawing.Color.Transparent;
            this.MainBtns_panel.Controls.Add(this.New_citizen_btn);
            this.MainBtns_panel.Controls.Add(this.Check_citizen_btn);
            this.MainBtns_panel.Location = new System.Drawing.Point(1, 413);
            this.MainBtns_panel.MaximumSize = new System.Drawing.Size(0, 88);
            this.MainBtns_panel.MinimumSize = new System.Drawing.Size(709, 88);
            this.MainBtns_panel.Name = "MainBtns_panel";
            this.MainBtns_panel.Size = new System.Drawing.Size(709, 88);
            this.MainBtns_panel.TabIndex = 3;
            // 
            // CustomsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 498);
            this.Controls.Add(this.MainBtns_panel);
            this.Controls.Add(this.App_label);
            this.Name = "CustomsApp";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainBtns_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label App_label;
        private System.Windows.Forms.Button New_citizen_btn;
        private System.Windows.Forms.Button Check_citizen_btn;
        private System.Windows.Forms.Panel MainBtns_panel;
    }
}

