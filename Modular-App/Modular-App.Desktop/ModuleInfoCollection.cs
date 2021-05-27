using System;
using System.Collections;
using MDIWindowManager;

namespace Modular_App.Desktop
{
    public class ModuleInfoCollection : CollectionBase
    {
        ModuleInfo _currentModuleInfo;

        /// <summary>
        /// Contains a list of modules registered in the application
        /// </summary>
        ModuleInfoCollection() : base()
        {
            this._currentModuleInfo = null;
        }

        /// <summary>
        /// Find module info by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ModuleInfo this[int index] { get { return List[index] as ModuleInfo; } }

        /// <summary>
        /// Find module info by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ModuleInfo this[string name]
        {
            get
            {
                for (int index = 0; index < this.Count; index++)
                {
                    var moduleInfo = List[index] as ModuleInfo;
                    if (moduleInfo.Name.Equals(name))
                        return moduleInfo;
                }
                return null;
            }
        }

        /// <summary>
        /// Returns the single instance of the collection
        /// </summary>
        public static readonly ModuleInfoCollection Instance = InitInstance();

        /// <summary>
        /// Returns the module currently displayed  
        /// </summary>
        public static ModuleInfo CurrentModuleInfo { get { return Instance._currentModuleInfo; } }

        /// <summary>
        /// Register the module in the system 
        /// </summary>
        /// <param name="name">The name of the module</param>
        /// <param name="moduleType">The type of the module</param>
        public static void Add(string name, Type moduleType)
        {
            var newModuleInfo = new ModuleInfo(name, moduleType);
            Instance.Add(newModuleInfo);
        }

        /// <summary>
        /// Show the module on a control 
        /// </summary>
        /// <param name="moduleInfo"></param>
        /// <param name="parent"></param>
        public static void ShowModule(ModuleInfo moduleInfo, WindowManagerPanel parent)
        {
            if (moduleInfo == Instance._currentModuleInfo)
                return;

            bool containsModule = ContainsModule(moduleInfo, parent);
            if (containsModule)
                moduleInfo.ActivateWindow(parent);
            else
                moduleInfo.Show(parent);

            Instance._currentModuleInfo = moduleInfo;
        }

        /// <summary>
        /// Gets a value indicating if the module was found
        /// </summary>
        /// <param name="moduleInfo">The module to search for</param>
        /// <param name="parent">The MDI Panel containing the modules</param>
        /// <returns></returns>
        private static bool ContainsModule(ModuleInfo moduleInfo, WindowManagerPanel parent)
        {
            var formsCount = parent.GetAllWindows().Count;
            for (int index = 0; index < formsCount; index++)
            {
                if (parent.GetAllWindows(false)[index].Window == moduleInfo.Module)
                    return true;
            }
            return false;
        }


        /// <summary>
        /// Initializes the static field of Instance
        /// </summary>
        /// <returns></returns>
        static ModuleInfoCollection InitInstance()
        {
            return new ModuleInfoCollection();
        }

        /// <summary>
        /// Adds module info to the List
        /// </summary>
        /// <param name="moduleInfo"></param>
        void Add(ModuleInfo moduleInfo)
        {
            if (List.IndexOf(moduleInfo) < 0)
                List.Add(moduleInfo);
        }

    }
}
