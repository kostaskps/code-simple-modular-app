using System;
using MDIWindowManager;

namespace Modular_App.Desktop
{
    public class ModuleManager
    {
        [ThreadStatic]
        static ModuleManager defaultManager;

        ModuleInfoCollection modules;

        public ModuleManager()
        {
            
        }

        /// <summary>
        /// Provides access to the default ModuleManager instance.
        /// </summary>
        public static ModuleManager Default
        {
            get
            {
                if (defaultManager == null)
                    defaultManager = new ModuleManager();
                return defaultManager;
            }
        }

        /// <summary>
        /// Gets the collection with the registered modules
        /// </summary>
        public ModuleInfoCollection Modules
        {
            get
            {
                if (modules == null)
                    modules = new ModuleInfoCollection();
                return modules;
            }
        }

        WindowManagerPanel MdiPanel { get; set; }


        WrappedWindowCollection WrappedWindows { get { return MdiPanel.GetAllWindows(false); } }
        
        /// <summary>
        /// Adds a Module to the collection with registered Modules
        /// </summary>
        /// <param name="moduleInfo">A ModuleInfo object containing information about the Module</param>
        internal void RegisterModule(ModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                return;
            
            Modules.Add(moduleInfo);
        }

        /// <summary>
        /// Set the container that will display application Modules in separate Tabs
        /// </summary>
        /// <param name="mdiPanel">The WindowManagerPanel that will display Modules</param>
        internal void SetContainer(WindowManagerPanel mdiPanel)
        {
            MdiPanel = mdiPanel;
        }

        /// <summary>
        /// Displays a Module in a new Tab or activates a Tab if the Module is already opened
        /// </summary>
        /// <param name="index">The index from the navigation menu</param>
        internal void ShowModule(int index)
        {
            BaseModuleForm module = GetModuleByIndex(index);
            if (module == null)
            {
                var moduleInfo = Modules[index];
                var newModule = CreateModule(moduleInfo);
                MdiPanel.AddWindow(newModule);
            }
            else
                MdiPanel.SetActiveWindow(module);
        }

        /// <summary>
        /// Creates an instance of a Module designated by the specified ModuleInfo object
        /// </summary>
        /// <param name="moduleInfo">A ModuleInfo object containing information about the Module to create</param>
        /// <returns>An application Module instance</returns>
        private BaseModuleForm CreateModule(ModuleInfo moduleInfo)
        {
            var moduleConstructor = moduleInfo.ModuleType.GetConstructor(Type.EmptyTypes);
            if (moduleConstructor == null)
                throw new ConstructorNotFoundException($"{moduleInfo.ModuleType.FullName} doesn't have a public constructor with empty parameters");

            var module = moduleConstructor.Invoke(null) as BaseModuleForm;
            module.Text = moduleInfo.Name;
            return module;
        }
        
        /// <summary>
        /// Gets a Module or null
        /// </summary>
        /// <param name="index">The index of the Module from the Navigation menu</param>
        /// <returns>A Module if found, otherwise null</returns>
        private BaseModuleForm GetModuleByIndex(int index)
        {
            if (index < 0 || index > WrappedWindows.Count - 1)
                return null;
            return WrappedWindows[index].Window as BaseModuleForm;
        }
    }
}
