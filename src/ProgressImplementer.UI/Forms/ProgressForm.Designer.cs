namespace ProgressImplementer.UI.Forms
{
    partial class ProgressForm
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProportionRadioButton = new System.Windows.Forms.RadioButton();
            this.PercentRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ContentProgressBar = new System.Windows.Forms.Integration.ElementHost();
            this.contentProgressBar1 = new ProgressImplementer.UI.Controls.ContentProgressBar();
            this.BottomPanel.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.OkButton);
            this.BottomPanel.Controls.Add(this.CancelButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 161);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BottomPanel.Size = new System.Drawing.Size(1184, 40);
            this.BottomPanel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(1021, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(59, 30);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.StartProgress);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(1086, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 30);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelOperation);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.ProportionRadioButton);
            this.SettingsGroupBox.Controls.Add(this.PercentRadioButton);
            this.SettingsGroupBox.Controls.Add(this.NoneRadioButton);
            this.SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.SettingsGroupBox.Size = new System.Drawing.Size(1184, 123);
            this.SettingsGroupBox.TabIndex = 2;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Настройки прогресса";
            // 
            // ProportionRadioButton
            // 
            this.ProportionRadioButton.AutoSize = true;
            this.ProportionRadioButton.Location = new System.Drawing.Point(14, 87);
            this.ProportionRadioButton.Name = "ProportionRadioButton";
            this.ProportionRadioButton.Size = new System.Drawing.Size(222, 24);
            this.ProportionRadioButton.TabIndex = 0;
            this.ProportionRadioButton.TabStop = true;
            this.ProportionRadioButton.Text = "Вывод прогресса в долях";
            this.ProportionRadioButton.UseVisualStyleBackColor = true;
            // 
            // PercentRadioButton
            // 
            this.PercentRadioButton.AutoSize = true;
            this.PercentRadioButton.Location = new System.Drawing.Point(14, 57);
            this.PercentRadioButton.Name = "PercentRadioButton";
            this.PercentRadioButton.Size = new System.Drawing.Size(255, 24);
            this.PercentRadioButton.TabIndex = 0;
            this.PercentRadioButton.TabStop = true;
            this.PercentRadioButton.Text = "Вывод прогресса в процентах";
            this.PercentRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(14, 27);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(231, 24);
            this.NoneRadioButton.TabIndex = 0;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "Вывод прогресса не задан";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SettingsGroupBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1184, 123);
            this.TopPanel.TabIndex = 3;
            // 
            // ContentProgressBar
            // 
            this.ContentProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentProgressBar.Location = new System.Drawing.Point(0, 123);
            this.ContentProgressBar.Name = "ContentProgressBar";
            this.ContentProgressBar.Padding = new System.Windows.Forms.Padding(5);
            this.ContentProgressBar.Size = new System.Drawing.Size(1184, 38);
            this.ContentProgressBar.TabIndex = 1;
            this.ContentProgressBar.Text = "elementHost1";
            this.ContentProgressBar.Child = this.contentProgressBar1;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 201);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ContentProgressBar);
            this.Controls.Add(this.BottomPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 240);
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно с прогрессом";
            this.BottomPanel.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.RadioButton ProportionRadioButton;
        private System.Windows.Forms.RadioButton PercentRadioButton;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Integration.ElementHost ContentProgressBar;
        private Controls.ContentProgressBar contentProgressBar1;
    }
}