﻿namespace RFIDServer
{
    partial class VisitorsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_visitors = new System.Windows.Forms.DataGridView();
            this.button_access_settings = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_dbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_comStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visitors)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_visitors
            // 
            this.dataGridView_visitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_visitors.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_visitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_visitors.Enabled = false;
            this.dataGridView_visitors.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_visitors.Name = "dataGridView_visitors";
            this.dataGridView_visitors.Size = new System.Drawing.Size(860, 395);
            this.dataGridView_visitors.TabIndex = 0;
            // 
            // button_access_settings
            // 
            this.button_access_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_access_settings.Enabled = false;
            this.button_access_settings.Location = new System.Drawing.Point(744, 413);
            this.button_access_settings.Name = "button_access_settings";
            this.button_access_settings.Size = new System.Drawing.Size(128, 23);
            this.button_access_settings.TabIndex = 1;
            this.button_access_settings.Text = "Настройка доступа";
            this.button_access_settings.UseVisualStyleBackColor = true;
            this.button_access_settings.Click += new System.EventHandler(this.button_access_settings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_dbStatus,
            this.toolStripStatusLabel_comStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_dbStatus
            // 
            this.toolStripStatusLabel_dbStatus.Name = "toolStripStatusLabel_dbStatus";
            this.toolStripStatusLabel_dbStatus.Size = new System.Drawing.Size(173, 17);
            this.toolStripStatusLabel_dbStatus.Text = "Подключение к базе данных...";
            // 
            // toolStripStatusLabel_comStatus
            // 
            this.toolStripStatusLabel_comStatus.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel_comStatus.Name = "toolStripStatusLabel_comStatus";
            this.toolStripStatusLabel_comStatus.Size = new System.Drawing.Size(172, 17);
            this.toolStripStatusLabel_comStatus.Text = "Инициализация COM-порта...";
            // 
            // VisitorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_access_settings);
            this.Controls.Add(this.dataGridView_visitors);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "VisitorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID сервер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitorsForm_FormClosed);
            this.Load += new System.EventHandler(this.VisitorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visitors)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_visitors;
        private System.Windows.Forms.Button button_access_settings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_dbStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_comStatus;
    }
}

