using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Student Name: Golden Pamela Apillanes 
 * Student Number: 300867201    
 * Description: Character Builder
 * Date: August 19th 2016 
 */
namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AbilityGeneratorForm());
            /**
             * <summary>
             * Inistiates the splashForm to run the ability generator 
             * </summary>
             */
            SplashForm splashForm = new SplashForm();
            if (splashForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new AbilityGeneratorForm());
            }
        }
    }
}
