using System.Diagnostics.Eventing.Reader;

namespace GlowGenda3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Add any initialization code here if needed
        }

        private void buttonGetBeautiful_Click(object sender, EventArgs e)
        {
            //Everytime someone schedules a service via radio button the selected service amount should be displayed in the label box. Only one service per group box can be selected.
            if (radioButtonRollerSet.Checked)
            {
                labelServiceAmount.Text = "$45";
            }
            else if (radioButtonShampoo.Checked)
            {
                labelServiceAmount.Text = "$30";
            }
            else if (radioButtonSilkPress.Checked)
            {
                labelServiceAmount.Text = "$45";
            }
            else if (radioButtonWigInstall.Checked)
            {
                labelServiceAmount.Text = "$150";

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
