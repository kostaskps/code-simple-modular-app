using System;

namespace Modular_App.Desktop
{
    public class ModuleInfo
    {
        /// <summary>
        /// Contains information about the module name and module class Type
        /// </summary>
        /// <param name="name">The name of the module that will be used in the Navigation Menu</param>
        /// <param name="moduleType">The module class Type to create an instance when we need to show the module</param>
        public ModuleInfo(string name, Type moduleType)
        {
            if (!moduleType.IsSubclassOf(typeof(BaseModuleForm)))
                throw new ArgumentException($"{moduleType.FullName} has to be inherited from {nameof(BaseModuleForm)}");

            Name = name;
            ModuleType = moduleType;
        }

        /// <summary>
        /// Returns the name of the registered module
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Get or set the position where the item was inserted
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Return the Type of the Module. Used to create a Module instace
        /// </summary>
        public Type ModuleType { get; }
    }
}
