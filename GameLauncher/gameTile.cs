using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GameLauncher.Properties;

namespace GameLauncher
{
    public partial class GameTile : UserControl
    {
        public GameTile()
        {
            InitializeComponent();
        }

        public JsonGameInfo GameInfo { get; set; }

        public void Init()
        {
            
            if (GameInfo.image == "error.jpg")
            {
                BackgroundImage = Resources.error;
            }
            else
            {
                var path = Path.Combine(GameInfo.dir, GameInfo.image);
                BackgroundImage = Image.FromFile(path);
            }
            

            gameNameLabel.Text = GameInfo.name;
        }

        private void gamePlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                var exePath = Path.Combine(Directory.GetCurrentDirectory(), GameInfo.dir);
                exePath = Path.Combine(exePath, GameInfo.startExe);
                ProcessStartInfo info = new ProcessStartInfo
                {
                    FileName = exePath,
                    WorkingDirectory = GameInfo.dir
                };
                Console.WriteLine(exePath);
                Process.Start(info);
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Start exe nicht gefunden\n\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}