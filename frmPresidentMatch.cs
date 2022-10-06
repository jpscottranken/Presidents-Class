using System;
using System.Drawing;
using System.Windows.Forms;

/*
 *      Create a new C# windows form app (call the solution 
 *      PretestCh10-11 and call the project Presidents) to 
 *      create a very simplistic 2 form US Presidents 
 *      matching game.
 *      
 *      For this main screen, the first name and last name 
 *      are in a ComboBox (dropDownList). These should be 
 *      populated programmatically from the arrays you have 
 *      been given.
 *      
 *      •	If the first name and last name match, you should 
 *          show the associated image. 
 *          
 *      •	If they do not match, you should show the No Image 
 *          Available image. 
 *          
 *      •	In addition, if you find a match, also make sure 
 *          that the correct radio button is checked.
 *          
 *      When the Help button is clicked, the second (Help) 
 *      screen should appear.
 *      
 *      All buttons, radioButtons, dropDownLists, etc. should 
 *      be operational. Tab Order, Cancel, Accept, Position set 
 *      also.
 */

namespace Presidents
{
    public partial class frmPresidentMatch : Form
    {
        public frmPresidentMatch()
        {
            InitializeComponent();
        }

        //  Declare and Initialize constant
        //const int MAXPRES = 15;

        //  Global arrays
        string[] firstNames =   //  Array of President first names
        {
            "Franklin",
            "Harry",
            "Dwight",
            "John F.",
            "Lyndon",
            "Richard",
            "Gerald",
            "Jimmy",
            "Ronald",
            "George H.W.",
            "Bill",
            "George W.",
            "Barack",
            "Donald",
            "Joe"
        };

        string[] lastNames =   //  Array of President last names
        {
            "Roosevelt",
            "Truman",
            "Eisenhower",
            "Kennedy",
            "Johnson",
            "Nixon",
            "Ford",
            "Carter",
            "Reagan",
            "Bush",
            "Clinton",
            "Bush",
            "Obama",
            "Trump",
            "Biden"
        };

        string[] party =        //  Array of President party
        {
            "Democrat",
            "Democrat",
            "Republican",
            "Democrat",
            "Democrat",
            "Republican",
            "Republican",
            "Democrat",
            "Republican",
            "Republican",
            "Democrat",
            "Republican",
            "Democrat",
            "Republican",
            "Democrat"
        };

        string[] images =       //  Array of President images
        {
            @"C:\Users\jpscott\Desktop\Presidents\Images\32-franklinroosevelt.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\33-harrytruman.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\34-dwighteisenhower.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\35-johnkennedy.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\36-lyndonjohnson.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\37-richardnixon.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\38-geraldford.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\39-jimmycarter.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\40-ronaldreagan.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\41-georgehwbush.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\42-billclinton.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\43-georgewwbush.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\44-barackobama.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\45-donaldtrump.jpg",
            @"C:\Users\jpscott\Desktop\Presidents\Images\46-joebiden.jpg"
        };

        //  Image to show if no match
        string noImageAvailable = @"C:\Users\jpscott\Desktop\Presidents-Class\Images\00-nia.jpg";

        private void btnMatch_Click(object sender, EventArgs e)
        {
            bool keepGoing = checkForNoFirstNameChosen();

            //  A dropdown list item for first name WAS selected
            if (keepGoing)
            {
                keepGoing = checkForNoLastNameChosen();
            }
            //  A dropdown list item for first name WAS NOT selected
            else
            {
                return;
            }

            //  A dropdown list item for last name WAS selected
            if (keepGoing)
            {
                checkForMatch();
            }
            //  A dropdown list item for last name WAS NOT selected
            else
            {
                return;
            }
        }

        private bool checkForNoFirstNameChosen()
        {
            bool retVal = true;

            //  -1 means no selected index chosen
            if (ddlFirstName.SelectedIndex == -1)
            {
                showMessage("No First Name Was Selected!",
                            "NO FIRST NAME");
                retVal = false;
            }

            return retVal;
        }

        private bool checkForNoLastNameChosen()
        {
            bool retVal = true;

            //  -1 means no selected index chosen
            if (ddlLastName.SelectedIndex == -1)
            {
                showMessage("No Last Name Was Selected!",
                            "NO LAST NAME");
                retVal = false;
            }

            return retVal;
        }

        private void checkForMatch()
        {
            //  Did   selection location for first name
            //  match selection location for last  name
            if (ddlFirstName.SelectedIndex ==
                ddlLastName.SelectedIndex)
            {   //  There WAS a match
                //  Fill pictureBox with the associated image
                pbPresidentImage.Image =
                    Image.FromFile(images[ddlLastName.SelectedIndex]);

                //  Select president's political affiliation
                switch (party[ddlLastName.SelectedIndex])
                {
                    case "Democrat":
                        rbDemocrat.Checked = true;
                        break;

                    case "Republican":
                        rbRepublican.Checked = true;
                        break;

                    case "Independent":
                        rbIndependent.Checked = true;
                        break;

                    default:
                        return;
                }
            }
            else
            {   //  There WAS NOT a match
                pbPresidentImage.Image =
                    Image.FromFile(noImageAvailable);
                clearAllRadioButtons();
            }
        }

        //  Customer message routine
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, 
                            title, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);  
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTheGUI();
        }

        private void clearTheGUI()
        {
            ddlFirstName.SelectedIndex  = -1;
            ddlLastName.SelectedIndex   = -1;
            pbPresidentImage.Image      = null;
            clearAllRadioButtons();
        }

        private void clearAllRadioButtons()
        {
            rbDemocrat.Checked      = false;
            rbRepublican.Checked    = false;
            rbIndependent.Checked   = false;
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
                Application.Exit();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showHelpForm();
        }

        private void showHelpForm()
        {
            //  Hide the current form
            this.Hide();

            //  Instantiate (create an instance of the) main form
            frmHelp help = new frmHelp();

            //  Show the help form
            help.ShowDialog();
        }

        private void frmPresidentMatch_Load(object sender, 
                                            EventArgs e)
        {
            for (int lcv = 0; lcv < firstNames.Length; lcv++)
            {
                //  Populate first name dropDownList
                //  from the firstNames array.
                ddlFirstName.Items.Add(firstNames[lcv]);

                //  Populate last name dropDownList
                //  from the lastNames array.
                ddlLastName.Items.Add(lastNames[lcv]);
            }

            clearTheGUI();
        }
    }
}
