using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandbyMemoryClean
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Form form = (Form)this;
            form.ShowInTaskbar = false;
            form.Opacity = 0;
            InitializeComponent();
            RunCleaner();
        }

        private async Task RunCleaner()
        {
            while (true)
            {
                CleanUtil.Program.ClearFileSystemCache(true);
                await Task.Delay(10_000);
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
