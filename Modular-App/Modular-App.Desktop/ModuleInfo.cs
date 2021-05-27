using System;
using System.Windows.Forms;

namespace Modular_App.Desktop
{
    public class ModuleInfo
    {
        readonly Type _moduleType;

        /// <summary>
        /// Contains the module name and module class type
        /// </summary>
        /// <param name="name">The name of the module for identification purposes</param>
        /// <param name="moduleType">The module class type to create an instance when we need to show the module</param>
        public ModuleInfo(string name, Type moduleType)
        {

            if (!moduleType.IsSubclassOf(typeof(BaseModuleForm)))
                throw new ArgumentException($"{moduleType.FullName} has to be inherited from {nameof(BaseModuleForm)}");

            this.Name = name;
            this._moduleType = moduleType;
            this.Module = null;
        }

        /// <summary>
        /// Returns the name of the module
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Returns the instance of the module Form
        /// </summary>
        public BaseModuleForm Module { get; private set; }

        /// <summary>
        /// Gets or sets the index of the module displayed in the Navigation List
        /// </summary>
        public int NavigationIndex { get; set; }

        /// <summary>
        /// Show the module on a control 
        /// </summary>
        /// <param name="parent"></param>
        public void Show(MDIWindowManager.WindowManagerPanel parent)
        {
            CreateModule();
            //Module.Visible = false;
            //Module.Parent = parent;
            //Module.Dock = DockStyle.Fill;
            //Module.Visible = true;
            Module.NavigationIndex = NavigationIndex;
            parent.AddWindow(Module);
        }

        /// <summary>
        /// Activate the module in MDI panel
        /// </summary>
        /// <param name="parent"></param>
        public void ActivateWindow(MDIWindowManager.WindowManagerPanel parent)
        {
            parent.SetActiveWindow(Module);
        }

        /// <summary>
        /// Make the module invisible 
        /// </summary>
        public void Hide()
        {
            if (Module != null)
                Module.Visible = false;
        }

        /// <summary>
        /// Create a module instance 
        /// </summary>
        protected void CreateModule()
        {
            if (this.Module == null)
            {
                var constructorInfo = _moduleType.GetConstructor(Type.EmptyTypes);
                if (constructorInfo == null)
                    throw new ConstructorNotFoundException($"{_moduleType.FullName} doesn't have a public constructor with empty parameters");

                this.Module = constructorInfo.Invoke(null) as BaseModuleForm;
            }
        }

    }
}
