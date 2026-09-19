namespace SmartDesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnModule8 = new System.Windows.Forms.Button();
            this.btnModule7 = new System.Windows.Forms.Button();
            this.btnModule6 = new System.Windows.Forms.Button();
            this.btnModule5 = new System.Windows.Forms.Button();
            this.btnModule4 = new System.Windows.Forms.Button();
            this.btnModule3 = new System.Windows.Forms.Button();
            this.btnModule2 = new System.Windows.Forms.Button();
            this.btnModule1 = new System.Windows.Forms.Button();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboLanguages = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.cboLanguages);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblSubtitle);
            this.panel1.Controls.Add(this.lblMainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.SystemColors.Info;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 2);
            this.panel4.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubtitle.Location = new System.Drawing.Point(670, 13);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(300, 22);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "大灣高中 × 沙崙高中 聯名專案";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMainTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMainTitle.Location = new System.Drawing.Point(12, 13);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(362, 38);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "智慧桌面 Smart Desktop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 30);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(814, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2026 Cross-Campus Project";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStatus.Location = new System.Drawing.Point(3, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(205, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "● 系統就緒 | 請選擇功能模組";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Controls.Add(this.btnModule8);
            this.panel3.Controls.Add(this.btnModule7);
            this.panel3.Controls.Add(this.btnModule6);
            this.panel3.Controls.Add(this.btnModule5);
            this.panel3.Controls.Add(this.btnModule4);
            this.panel3.Controls.Add(this.btnModule3);
            this.panel3.Controls.Add(this.btnModule2);
            this.panel3.Controls.Add(this.btnModule1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 503);
            this.panel3.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(0, 453);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnModule8
            // 
            this.btnModule8.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule8.Location = new System.Drawing.Point(0, 350);
            this.btnModule8.Name = "btnModule8";
            this.btnModule8.Size = new System.Drawing.Size(200, 50);
            this.btnModule8.TabIndex = 7;
            this.btnModule8.Text = "第八組：XXX";
            this.btnModule8.UseVisualStyleBackColor = true;
            // 
            // btnModule7
            // 
            this.btnModule7.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule7.Location = new System.Drawing.Point(0, 300);
            this.btnModule7.Name = "btnModule7";
            this.btnModule7.Size = new System.Drawing.Size(200, 50);
            this.btnModule7.TabIndex = 6;
            this.btnModule7.Text = "第七組：XXX";
            this.btnModule7.UseVisualStyleBackColor = true;
            // 
            // btnModule6
            // 
            this.btnModule6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule6.Location = new System.Drawing.Point(0, 250);
            this.btnModule6.Name = "btnModule6";
            this.btnModule6.Size = new System.Drawing.Size(200, 50);
            this.btnModule6.TabIndex = 5;
            this.btnModule6.Text = "第六組：XXX";
            this.btnModule6.UseVisualStyleBackColor = true;
            // 
            // btnModule5
            // 
            this.btnModule5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule5.Location = new System.Drawing.Point(0, 200);
            this.btnModule5.Name = "btnModule5";
            this.btnModule5.Size = new System.Drawing.Size(200, 50);
            this.btnModule5.TabIndex = 4;
            this.btnModule5.Text = "第五組：XXX";
            this.btnModule5.UseVisualStyleBackColor = true;
            // 
            // btnModule4
            // 
            this.btnModule4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule4.Location = new System.Drawing.Point(0, 150);
            this.btnModule4.Name = "btnModule4";
            this.btnModule4.Size = new System.Drawing.Size(200, 50);
            this.btnModule4.TabIndex = 3;
            this.btnModule4.Text = "第四組：XXX";
            this.btnModule4.UseVisualStyleBackColor = true;
            // 
            // btnModule3
            // 
            this.btnModule3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule3.Location = new System.Drawing.Point(0, 100);
            this.btnModule3.Name = "btnModule3";
            this.btnModule3.Size = new System.Drawing.Size(200, 50);
            this.btnModule3.TabIndex = 2;
            this.btnModule3.Text = "第三組：XXX";
            this.btnModule3.UseVisualStyleBackColor = true;
            // 
            // btnModule2
            // 
            this.btnModule2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule2.Location = new System.Drawing.Point(0, 50);
            this.btnModule2.Name = "btnModule2";
            this.btnModule2.Size = new System.Drawing.Size(200, 50);
            this.btnModule2.TabIndex = 1;
            this.btnModule2.Text = "第二組：XXX";
            this.btnModule2.UseVisualStyleBackColor = true;
            // 
            // btnModule1
            // 
            this.btnModule1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModule1.Location = new System.Drawing.Point(0, 0);
            this.btnModule1.Name = "btnModule1";
            this.btnModule1.Size = new System.Drawing.Size(200, 50);
            this.btnModule1.TabIndex = 0;
            this.btnModule1.Text = "第一組：XXX";
            this.btnModule1.UseVisualStyleBackColor = true;
            this.btnModule1.Click += new System.EventHandler(this.btnModule1_Click);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Controls.Add(this.button1);
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(200, 70);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(782, 503);
            this.mainContentPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(782, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "第八組：XXX";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboLanguages
            // 
            this.cboLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguages.FormattingEnabled = true;
            this.cboLanguages.Location = new System.Drawing.Point(850, 38);
            this.cboLanguages.Name = "cboLanguages";
            this.cboLanguages.Size = new System.Drawing.Size(120, 23);
            this.cboLanguages.TabIndex = 2;
            this.cboLanguages.SelectedIndexChanged += new System.EventHandler(this.cboLanguages_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartDesktop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Button btnModule1;
        private System.Windows.Forms.Button btnModule8;
        private System.Windows.Forms.Button btnModule7;
        private System.Windows.Forms.Button btnModule6;
        private System.Windows.Forms.Button btnModule5;
        private System.Windows.Forms.Button btnModule4;
        private System.Windows.Forms.Button btnModule3;
        private System.Windows.Forms.Button btnModule2;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboLanguages;
    }
}

