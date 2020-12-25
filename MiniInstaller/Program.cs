using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniInstaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Add .DLLs
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        static System.Reflection.Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            var dllName = args.Name.Contains(',')
                ? args.Name.Substring(0, args.Name.IndexOf(','))
                : args.Name.Replace(".dll", "");

            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;

            System.Resources.ResourceManager resourceManager = new System.Resources.ResourceManager(typeof(Program)
                .Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])resourceManager.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }
    }
}
