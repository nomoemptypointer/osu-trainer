namespace osu_trainer
{
    public partial class SongsFolderForm : Form
    {
        // This is to be returned upon closing this form
        public string SongsFolder;

        public SongsFolderForm(string folder)
        {
            InitializeComponent();
            songsFolderTextBox.Text = folder;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SongsFolder = songsFolderTextBox.Text;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = songsFolderTextBox.Text;
                dialog.Description = "Select your osu! Songs folder";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    songsFolderTextBox.Text = dialog.SelectedPath;
                    SongsFolder = dialog.SelectedPath;
                }
            }
        }
    }
}
