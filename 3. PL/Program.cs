using _1._DAL.Context;
using _1._DAL.DomainClass;

namespace _3._PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //Scaffold-DbContext 'Data Source=DESKTOP-56CMKMS;Initial Catalog=FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041;User ID=Linhtnph20247;Password=25102003' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmQLBanHang());
        }
    }
}