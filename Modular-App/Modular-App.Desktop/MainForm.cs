using System;
using System.Drawing;
using System.Windows.Forms;

namespace Modular_App.Desktop
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            ConfigureControls();
            SetupNavigationListFromModules();
        }

        private void ConfigureControls()
        {
            int width = Screen.PrimaryScreen.Bounds.Width / 2;
            int height = Screen.PrimaryScreen.Bounds.Height / 2;
            Size = new Size(width, height);
            StartPosition = FormStartPosition.CenterScreen;

            ModuleManager.SetContainer(mdiPanel);

            mdiPanel.AutoDetectMdiChildWindows = false;
            mdiPanel.DisableHTileAction = true;
            mdiPanel.DisablePopoutAction = true;
            mdiPanel.DisableTileAction = true;
            mdiPanel.WindowActivated += MdiPanel_OnWindowActivated;

            listBoxModules.IntegralHeight = false;
            listBoxModules.SelectedIndexChanged += ListBoxModules_OnSelectedIndexChanged;

            menuItemExit.Click += MenuItemExit_OnClick;
        }

        ModuleManager ModuleManager { get { return ModuleManager.Default; } }

        // Populate navigation items in ListBox from the registered Modules
        private void SetupNavigationListFromModules()
        {
            listBoxModules.DisplayMember = "Name";
            listBoxModules.ValueMember = "ModuleType";

            for (int index = 0; index < ModuleManager.Modules.Count; index++)
            {
                var moduleInfo = ModuleManager.Modules[index];
                listBoxModules.Items.Add(moduleInfo);
            }
        }

        private void MdiPanel_OnWindowActivated(object sender, MDIWindowManager.WrappedWindowEventArgs e)
        {
            //var module = e.WrappedWindow.Window as BaseModuleForm;
            //listBoxModules.SelectedIndex = module.NavigationIndex;
        }

        private void ListBoxModules_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxModules.SelectedIndex > -1)
            {
                ModuleManager.ShowModule(listBoxModules.SelectedIndex);
            }
        }

        private void MenuItemExit_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
