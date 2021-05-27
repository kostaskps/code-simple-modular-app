using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modular_App.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConfigureControls();
        }

        private void ConfigureControls()
        {
            StartPosition = FormStartPosition.CenterScreen;

            this.menuItemExit.Click += MenuItemExit_OnClick;
        }

        private void MenuItemExit_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
