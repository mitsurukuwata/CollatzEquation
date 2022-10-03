using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3x_1UI
{
    public partial class SettingsMenu : Form
    {
        public delegate void OnChangeColors(Settings settings);
        public event OnChangeColors ColorsChanged;
        private readonly Settings _settings = new Settings();
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void lightThemeBtn_Click(object sender, EventArgs e)
        {
            _settings.Panel1BackColor = Color.White;
            _settings.Panel2BackColor = Color.White;
            _settings.MainFormBackColor = Color.WhiteSmoke;
            _settings.ChartBackColor = Color.White;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ColorsChanged?.Invoke(_settings);
        }

        private void darkThemeBtn_Click(object sender, EventArgs e)
        {
            _settings.Panel1BackColor = Color.DarkGray;
            _settings.Panel2BackColor = Color.DarkGray;
            _settings.MainFormBackColor = Color.LightGray;
            _settings.ChartBackColor = Color.DarkGray;
        }
    }
}
