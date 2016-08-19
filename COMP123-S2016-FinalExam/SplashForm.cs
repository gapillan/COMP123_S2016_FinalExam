using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GenerateNameForm SelectionForm = new GenerateNameForm();
            this.Hide();
            SelectionForm.Show();
            Timer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
