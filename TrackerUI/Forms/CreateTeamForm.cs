using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreateTeamForm : Form
    {
        #region Constructor

        public CreateTeamForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Button Controls

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        #endregion
    }
}
