using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;

namespace GameLauncher
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            try
            {
                InitializeComponent();
                //Style = MetroColorStyle.Orange;
                //Theme = MetroThemeStyle.Dark;

                foreach (var theme in Enum.GetValues(typeof(MetroThemeStyle)))
                {
                    themeComboBox.Items.Add(theme);
                }

                foreach (var style in Enum.GetValues(typeof(MetroColorStyle)))
                {
                    styleComboBox.Items.Add(style);
                }
                
                int x = 0;
                int y = 0;

                foreach (var dir in Directory.GetDirectories("games"))
                {

                    JsonGameInfo gameInfo = new JsonGameInfo();
                    if (File.Exists(Path.Combine(dir, "info.json")))
                    {
                        gameInfo = JsonConvert.DeserializeObject<JsonGameInfo>(File.ReadAllText(Path.Combine(dir, "info.json")));
                        gameInfo.dir = dir;
                    }
                    else
                    {
                        gameInfo.image = "error.jpg";
                        gameInfo.name = dir;
                        gameInfo.startExe = "";
                        gameInfo.dir = dir;
                    }

                    Console.WriteLine(gameInfo.ToString());

                    GameTile tile = new GameTile();
                    tile.Location = new Point(5 + (x * (tile.Width + 5)), 5 + (y * (tile.Height + 5)));
                    tile.GameInfo = gameInfo;
                    gamePanel.Controls.Add(tile);
                    tile.Init();
                    x++;
                    if (x < 4) continue;
                    x = 0;
                    y++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme = (MetroThemeStyle)themeComboBox.SelectedItem;
            Invalidate();
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style = (MetroColorStyle)styleComboBox.SelectedItem;
            Invalidate();
        }

        private void Main_StyleChanged(object sender, EventArgs e)
        {
            gamePanel.Theme = Theme;
            gamePanel.Style = Style;
            Invalidate();
        }
    }
}
