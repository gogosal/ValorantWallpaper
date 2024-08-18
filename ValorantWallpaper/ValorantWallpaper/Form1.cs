using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ValorantWallpaper
{
    public partial class Form1 : Form
    {
        private string _folderPath = @"C:\Riot Games\VALORANT\live\ShooterGame\Content\Movies\Menu\";
        private string _selectedFilePath;
        private string _latestFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ValorantPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Vídeos|*.mp4";
                openFileDialog.Title = "Select the wallpaper";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedFilePath = openFileDialog.FileName;
                    MessageBox.Show($"Vídeo selecionado: {_selectedFilePath}");
                }
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedFilePath))
            {
                string selectedFileExtension = Path.GetExtension(_selectedFilePath).ToLower();
                if (selectedFileExtension != ".mp4")
                {
                    MessageBox.Show("Please select an .mp4 file!");
                    return;
                }

                if (string.IsNullOrEmpty(_latestFileName))
                {
                    _latestFileName = TakeNameOfWallpaperGame();
                }

                if (!string.IsNullOrEmpty(_latestFileName))
                {
                    string latestFilePath = Path.Combine(_folderPath, _latestFileName);

                    try
                    {
                        File.Copy(_selectedFilePath, latestFilePath, overwrite: true);

                        _latestFileName = Path.GetFileName(latestFilePath);

                        MessageBox.Show("The wallpaper has been successfully changed!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when changing wallpaper: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Couldn't get the file name.");
                }
            }
            else
            {
                MessageBox.Show("No files selected.");
            }
        }

        private string TakeNameOfWallpaperGame()
        {
            if (Directory.Exists(_folderPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_folderPath);

                FileInfo latestFile = directoryInfo.GetFiles()
                    .OrderByDescending(file => file.LastWriteTime)
                    .FirstOrDefault();

                if (latestFile != null)
                {
                    return latestFile.Name;
                }
                else
                {
                    MessageBox.Show("No files found in the folder!");
                }
            }
            else
            {
                MessageBox.Show("The specified directory does not exist!");
            }
            return null;
        }
    }
}
