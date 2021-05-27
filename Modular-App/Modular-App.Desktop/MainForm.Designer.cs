
namespace Modular_App.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomStatusBar = new System.Windows.Forms.StatusStrip();
            this.listBoxModules = new System.Windows.Forms.ListBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.mdiPanel = new MDIWindowManager.WindowManagerPanel();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(800, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(93, 22);
            this.menuItemExit.Text = "Exit";
            // 
            // bottomStatusBar
            // 
            this.bottomStatusBar.Location = new System.Drawing.Point(0, 428);
            this.bottomStatusBar.Name = "bottomStatusBar";
            this.bottomStatusBar.Size = new System.Drawing.Size(800, 22);
            this.bottomStatusBar.TabIndex = 1;
            this.bottomStatusBar.Text = "statusStrip1";
            // 
            // listBoxModules
            // 
            this.listBoxModules.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxModules.FormattingEnabled = true;
            this.listBoxModules.Location = new System.Drawing.Point(0, 24);
            this.listBoxModules.Name = "listBoxModules";
            this.listBoxModules.Size = new System.Drawing.Size(154, 404);
            this.listBoxModules.TabIndex = 2;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter.Location = new System.Drawing.Point(154, 24);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 404);
            this.splitter.TabIndex = 3;
            this.splitter.TabStop = false;
            // 
            // mdiPanel
            // 
            this.mdiPanel.AllowUserVerticalRepositioning = false;
            this.mdiPanel.AutoDetectMdiChildWindows = true;
            this.mdiPanel.AutoHide = false;
            this.mdiPanel.ButtonRenderMode = MDIWindowManager.ButtonRenderMode.Standard;
            this.mdiPanel.DisableCloseAction = false;
            this.mdiPanel.DisableHTileAction = false;
            this.mdiPanel.DisablePopoutAction = false;
            this.mdiPanel.DisableTileAction = false;
            this.mdiPanel.EnableTabPaintEvent = false;
            this.mdiPanel.Location = new System.Drawing.Point(161, 26);
            this.mdiPanel.MinMode = false;
            this.mdiPanel.Name = "mdiPanel";
            this.mdiPanel.Orientation = MDIWindowManager.WindowManagerOrientation.Top;
            this.mdiPanel.ShowCloseButton = false;
            this.mdiPanel.ShowIcons = false;
            this.mdiPanel.ShowLayoutButtons = false;
            this.mdiPanel.ShowTitle = false;
            this.mdiPanel.Size = new System.Drawing.Size(637, 26);
            this.mdiPanel.Style = MDIWindowManager.TabStyle.ClassicTabs;
            this.mdiPanel.TabIndex = 5;
            this.mdiPanel.TabRenderMode = MDIWindowManager.TabsProvider.Standard;
            this.mdiPanel.Text = "mdiPanel";
            this.mdiPanel.TitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.mdiPanel.TitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mdiPanel);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.listBoxModules);
            this.Controls.Add(this.bottomStatusBar);
            this.Controls.Add(this.topMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.StatusStrip bottomStatusBar;
        private System.Windows.Forms.ListBox listBoxModules;
        private System.Windows.Forms.Splitter splitter;
        private MDIWindowManager.WindowManagerPanel mdiPanel;
    }
}

