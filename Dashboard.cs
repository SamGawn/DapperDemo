using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperPractice
{
    public partial class Dashboard : Form
    {

        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(LastNameTxt.Text);
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void insertRecord_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertPerson(firstNameInsertText.Text, lastNameInsertText.Text, emailAddressInsertText.Text, phoneNumberInsertText.Text);
            
            firstNameInsertText.Text = "";
            lastNameInsertText.Text = "";
            emailAddressInsertText.Text = "";
            phoneNumberInsertText.Text = "";
        }
    }
}
