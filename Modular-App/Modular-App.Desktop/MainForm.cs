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
            SetupNavigationMenuFromModules();
        }

        private void ConfigureControls()
        {
            StartPosition = FormStartPosition.CenterScreen;

            this.listBoxModules.IntegralHeight = false;
            this.listBoxModules.SelectedIndexChanged += ListBoxModules_OnSelectedIndexChanged;

            this.menuItemExit.Click += MenuItemExit_OnClick;
        }

        // Populate navigation items in ListBox from the registered Modules
        private void SetupNavigationMenuFromModules()
        {
            int itemCount = ModuleInfoCollection.Instance.Count;
            for(int index = 0; index < itemCount; index++)
            {
                var moduleInfo = ModuleInfoCollection.Instance[index];
                this.listBoxModules.Items.Add(moduleInfo.Name);
            }
        }

        private void ListBoxModules_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MenuItemExit_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
