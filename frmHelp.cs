using System;
using System.Windows.Forms;

/*
 *      For this help screen, all buttons and checkboxes 
 *      should be operational.
 *      
 *      When the Home button is clicked, the first (Home) 
 *      screen should appear.
 *      
 *      If the Exit button is clicked and the user chooses Yes 
 *      to exit the program, the program should first print out 
 *      any/all Follow Us On checkboxes that are checked.
 *      
 *      Again, all buttons should be operational. The Tab Order, 
 *      CancelButton, AcceptButton, and StartPosition should be 
 *      set, as on the Home page.
 *      
 *      Try to modularize as much as possible. Have your buttons, 
 *      etc. act like drivers. Use good function, variable, and 
 *      constant names.
 */

namespace Presidents
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        //  Set up the textbox with the program instructions
        //  here and then display said instructions.
        private void frmHelp_Load(object sender, EventArgs e)
        {
            string outputStr = "Choose a first name and a last name from each associated dropdown list\r\n\r\n";
            outputStr += "Then click the Guess button to see whether or not you are correct.\r\n\r\n";
            outputStr += "To keep it simple, only the last 15 Presidents are shown here.";

            txtInstructions.Text = outputStr;
        }

        //  Go back to main form
        private void btnHome_Click(object sender, EventArgs e)
        {
            showHomeForm();
        }

        private void showHomeForm()
        {
            //  Hide the current form
            this.Hide();

            //  Instantiate (create an instance of the) main form
            frmPresidentMatch pm = new frmPresidentMatch();

            //  Show the main form
            pm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitTheProgram();
        }

        private void exitTheProgram()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                //  Check to see if one or more of the
                //  "Follow Us On" checkboxes are checked.
                showCheckBoxButtonsSelected();

                Application.Exit();
            }
        }

        private void showCheckBoxButtonsSelected()
        {
            string selected = "";

            //  Was Facebook checkbox checked
            if (cbFacebook.Checked)
            {
                selected += cbFacebook.Text + " ";
            }
            //  Was Instagram checkbox checked
            if (cbInstagram.Checked)
            {
                selected += cbInstagram.Text + " ";
            }
            //  Was Twitter checkbox checked
            if (cbTwitter.Checked)
            {
                selected += cbTwitter.Text + " ";
            }

            //  If no checkboxes checked, just return
            if (selected.Trim() == "")
            {
                return;
            }
            else
            {   //  One or more checkboxes were checked.
                MessageBox.Show("You Follow Us On: " + selected,
                                "SOCIAL MEDIA PRESENCE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
