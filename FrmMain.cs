namespace WFA24091301
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pbxGreen.Click += PictureBoxClick;
            pbxOrange.Click += PictureBoxClick;
            pbxPurble.Click += PictureBoxClick;
            pbxRed.Click += PictureBoxClick;
            pbxViolet.Click += PictureBoxClick;
            pbxYellow.Click += PictureBoxClick;
        }

        private void PictureBoxClick(object? sender, EventArgs e)
        {
            BackColor = (sender as PictureBox).BackColor;
        }
    }
}
