using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Student Name: Golden Pamela Apillanes
 * Studnet Number: 300867201   
 * Description: Character Builder
 * Date: August 19th 2016 
 */
namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /**
         * <summary>
         * Sets the Timer control's properties so that it is enabled with an interval
         * of 3000 milliseconds 
         * </summary>
         * @method {Timer_Tick}
         * @return {void}
         */
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Enabled = true;
            Timer.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
