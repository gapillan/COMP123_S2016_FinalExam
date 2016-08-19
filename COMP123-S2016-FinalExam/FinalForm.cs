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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * <summary>
         * The Load Method of this form should use the Program.character object and fill out the Text
         * values of the TextBox controls contained in the form 
         * </summary>
         * 
         * @method {FinalForm_Load}
         * @return {void}
         */
        private void FinalForm_Load(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.StrengthTextBox.Text = Program.character.Strength.ToString();
            finalForm.DexterityTextBox.Text = Program.character.Dexterity.ToString();
            finalForm.ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            finalForm.IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            finalForm.WisdomTextBox.Text = Program.character.Wisdom.ToString();
            finalForm.CharismaTextBox.Text = Program.character.Charisma.ToString();
            finalForm.RaceTextBox.Text = Program.character.Race.ToString();
            finalForm.FirstNameTextBox.Text = Program.character.FirstName.ToString();
            finalForm.LastNameTextBox.Text = Program.character.LastName.ToString();
            finalForm.Show();
            this.Hide;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
