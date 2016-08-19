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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            
        }

        public void GenerateNames()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 49);
        }
        private void GenerateNameButton(object sender, EventArgs e)
        {
            GenerateNames();
        }
    }
}
