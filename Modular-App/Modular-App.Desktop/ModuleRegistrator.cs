namespace Modular_App.Desktop
{
    public static class ModuleRegistrator
    {
        /// <summary>
        /// Registers the Modules of the Application. Call this method before running Main Form
        /// </summary>
        public static void Register()
        {
            ModuleManager.Default.RegisterModule(new ModuleInfo("Demo Module 1", typeof(DemoModule1Form)));
            ModuleManager.Default.RegisterModule(new ModuleInfo("Demo Module 2", typeof(DemoModule2Form)));
        }
    }
}
