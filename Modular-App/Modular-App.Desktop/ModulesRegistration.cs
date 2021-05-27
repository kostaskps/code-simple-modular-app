namespace Modular_App.Desktop
{
    public static class ModulesRegistration
    {
        /// <summary>
        /// Register the modules and call this method before running Main Form
        /// </summary>
        public static void Register()
        {
            ModuleInfoCollection.Add("Demo Module 1", typeof(DemoModule1From));
            ModuleInfoCollection.Add("Demo Module 2", typeof(DemoModule2From));
        }
    }
}
