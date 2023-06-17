using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddMemberForm : Form
    {
        Library Library = new Library();

        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string surname = txtSurname.Text;
            bool isCorrectInput = validateInput(firstname, surname);

            if (isCorrectInput)
            {
                Member newMember = Library.AddMember(firstname, surname);

                showResult(newMember);

                clearForm();
            }
            else
            {
                MessageBox.Show("Your input must have letters and can not have digits.");
            }
        }

        private bool validateInput(string firstname, string surname)
        {
            bool firstnameContainsInt = firstname.Any(char.IsDigit);

            bool surnameContainsInt = surname.Any(char.IsDigit);

            bool isCorrectInput = false;

            if (firstnameContainsInt == false || surnameContainsInt == false)
            {
                isCorrectInput = true;
            }

            if (firstname.Equals("") || surname.Equals(""))
            {
                isCorrectInput = false;
            }

            return isCorrectInput;
        }

        private void showResult(Member newMember)
        {
            if (newMember == null)
            {
                MessageBox.Show("That user already exist.");
            }
            else
            {
                string message = "Succesfuly added " + newMember.firstname + " " + newMember.surname + "\nwith username: " + newMember.username + "\nand password:" + newMember.password;

                MessageBox.Show(message);
            }
        }

        private void clearForm()
        {
            txtFirstname.Text = "";
            txtSurname.Text = "";
        }
    }
}
