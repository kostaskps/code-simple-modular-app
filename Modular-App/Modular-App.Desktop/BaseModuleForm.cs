using System.Windows.Forms;

namespace Modular_App.Desktop
{
    public partial class BaseModuleForm : Form
    {
        /// <summary>
        /// The base module class that all forms must inherit from
        /// </summary>
        public BaseModuleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the navigation index of the module
        /// </summary>
        public int NavigationIndex { get; set; }
    }
}
