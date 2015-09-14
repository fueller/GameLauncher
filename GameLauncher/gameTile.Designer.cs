namespace GameLauncher
{
    partial class GameTile
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameTile));
            this.gamePlayButton = new MetroFramework.Controls.MetroButton();
            this.gameNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // gamePlayButton
            // 
            this.gamePlayButton.Location = new System.Drawing.Point(160, 84);
            this.gamePlayButton.Name = "gamePlayButton";
            this.gamePlayButton.Size = new System.Drawing.Size(75, 23);
            this.gamePlayButton.TabIndex = 0;
            this.gamePlayButton.Text = "Starten";
            this.gamePlayButton.UseSelectable = true;
            this.gamePlayButton.Click += new System.EventHandler(this.gamePlayButton_Click);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.gameNameLabel.Location = new System.Drawing.Point(4, 87);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(0, 0);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.UseCustomBackColor = true;
            this.gameNameLabel.UseStyleColors = true;
            // 
            // gameTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.gamePlayButton);
            this.Name = "GameTile";
            this.Size = new System.Drawing.Size(238, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton gamePlayButton;
        private MetroFramework.Controls.MetroLabel gameNameLabel;
    }
}
