using HRMngt.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using HRMngt.Presenter;
using HRMngt.Model;
using HRMngt._Repository;

namespace HRMngt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();   
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IUserview view = new add_emp();
            IUserRepository repo = new UserRepo(connectionString);
            new UserPresenter(view, repo);
            Application.Run((Form) view);
        }
    }
}
