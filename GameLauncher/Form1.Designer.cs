namespace GameLauncher
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamePanel = new MetroFramework.Controls.MetroPanel();
            this.themeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.styleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.AutoScroll = true;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.HorizontalScrollbar = true;
            this.gamePanel.HorizontalScrollbarBarColor = true;
            this.gamePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.gamePanel.HorizontalScrollbarSize = 10;
            this.gamePanel.Location = new System.Drawing.Point(20, 60);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(990, 476);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.VerticalScrollbar = true;
            this.gamePanel.VerticalScrollbarBarColor = true;
            this.gamePanel.VerticalScrollbarHighlightOnWheel = false;
            this.gamePanel.VerticalScrollbarSize = 10;
            // 
            // themeComboBox
            // 
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.ItemHeight = 23;
            this.themeComboBox.Location = new System.Drawing.Point(233, 25);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(121, 29);
            this.themeComboBox.TabIndex = 2;
            this.themeComboBox.UseSelectable = true;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.ItemHeight = 23;
            this.styleComboBox.Location = new System.Drawing.Point(361, 25);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(121, 29);
            this.styleComboBox.TabIndex = 3;
            this.styleComboBox.UseSelectable = true;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 556);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.gamePanel);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Game Launcher";
            this.StyleChanged += new System.EventHandler(this.Main_StyleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel gamePanel;
        private MetroFramework.Controls.MetroComboBox themeComboBox;
        private MetroFramework.Controls.MetroComboBox styleComboBox;
    }
}

