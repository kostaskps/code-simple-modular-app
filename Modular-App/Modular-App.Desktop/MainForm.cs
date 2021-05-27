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

            this.mdiPanel.AutoDetectMdiChildWindows = false;
            this.mdiPanel.WindowActivated += MdiPanel_OnWindowActivated;
            
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

        private void MdiPanel_OnWindowActivated(object sender, MDIWindowManager.WrappedWindowEventArgs e)
        {
            var module = e.WrappedWindow.Window as BaseModuleForm;
            listBoxModules.SelectedIndex = module.NavigationIndex;
        }

        private void ListBoxModules_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listBoxModules.SelectedIndex > -1)
            {
                var moduleInfo = ModuleInfoCollection.Instance[listBoxModules.SelectedIndex];
                moduleInfo.NavigationIndex = listBoxModules.SelectedIndex;
                ModuleInfoCollection.ShowModule(moduleInfo, mdiPanel);
            }
        }

        private void MenuItemExit_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
