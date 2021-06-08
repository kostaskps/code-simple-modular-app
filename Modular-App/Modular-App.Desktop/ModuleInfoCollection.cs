using System.Collections;

namespace Modular_App.Desktop
{
    public class ModuleInfoCollection : CollectionBase
    {
        /// <summary>
        /// Get ModuleInfo by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ModuleInfo this[int index]
        {
            get { return List[index] as ModuleInfo; }
        }

        /// <summary>
        /// Find ModuleInfo by name
        /// </summary>
        /// <param name="name">String representing the name of the Module</param>
        /// <returns>The ModuleInfo object or null if not found</returns>
        public ModuleInfo this[string name]
        {
            get
            {
                for (int index = 0; index < Count; index++)
                {
                    var moduleInfo = this[index];
                    if (moduleInfo.Name.Equals(name))
                        return moduleInfo;
                }
                return null;
            }
        }

        internal void Add(ModuleInfo moduleInfo)
        {
            if (List.IndexOf(moduleInfo) < 0)
                List.Add(moduleInfo);
        }

        protected override void OnInsertComplete(int index, object value)
        {
            var moduleInfo = value as ModuleInfo;
            moduleInfo.Index = index;
        }
    }
}
