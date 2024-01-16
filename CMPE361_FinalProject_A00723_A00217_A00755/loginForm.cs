using CMPE361_FinalProject_A00723_A00217_A00755.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMPE361_FinalProject_A00723_A00217_A00755
{
    public partial class loginForm : Form
    {
        DBManager dbManager;
        public loginForm()
        {
            InitializeComponent();
            dbManager = new DBManager();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            loginTabPage.Visible = true;
            createNewAccPage.Visible = false;
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordCondition1Label.Visible = true;
            passwordCondition2Label.Visible = true;
            passwordCondition3Label.Visible = true;

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string fname, lname, email, password;

            fname = firstNameTextBox.Text;
            lname = lastNameTextBox.Text;
            email = newEmailTextBox.Text;
            password = newPasswordTextBox.Text;

            if (password == "")
            {
                MessageBox.Show("Please enter Password", "Missing Input",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }

            if (fname == "")
            {
                MessageBox.Show("Please enter first name", "Missing Input",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            if (lname == "")
            {
                MessageBox.Show("Please enter last name", "Missing Input",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            if (email == "")
            {
                MessageBox.Show("Please enter Email", "Missing Input",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            createAnAccount(fname,lname,email,password);
        }

        private bool ValidatePassword(string password)
        {
     
            return password.Length >= 8 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) ;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            loadCountry();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login(emailTextBox.Text, passwordTextBox.Text);
        }

        private void login(string loginEmail, string loginPassword)
        {

            string qurey = "SELECT * FROM [users] WHERE email= @email AND password= @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@email",loginEmail),
                new SqlParameter("@password",loginPassword),
            };

            DataTable resultTable = dbManager.ExecuteQuery(qurey, parameters);

            if (resultTable.Rows.Count == 0)
            {
                MessageBox.Show("Email or password incorrect", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User();
                foreach (DataRow row in resultTable.Rows)
                {
                    user.id = row["id"].ToString();
                    user.email = row["email"].ToString();
                    user.password = row["password"].ToString();
                    user.FName = row["FName"].ToString();
                    user.LName = row["LName"].ToString();
                    user.country = row["country"].ToString();
                }
                MessageBox.Show("Welcome " + user.FName.Substring(0,1).ToUpper() + user.FName.Substring(1).ToLower(), 
                    "Ready to Plan, Set, GO!", MessageBoxButtons.OK, MessageBoxIcon.None);

                LoginControl.loggedInUser = user;
                Plan.user = user;
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
        }

        private void createAnAccount(string fName, string lName,string email, string password)
        {
            if (checkingUser(email)==1)
            {
                MessageBox.Show("An account has been found. You can log in directly.");
            }
            else
            {
                if (!Validator.ValidateEmail(email))
                {
                    MessageBox.Show("The email is invalid.");
                }
                else { 
                        if (!Validator.ValidatePassword(password))
                        {
                            MessageBox.Show("The password does not meet the requirements.");
                        }
                        else
                        {
                            string query = "INSERT INTO [users] (email,password,FName,LName,country) VALUES (@email,@password,@fName,@lName,@country)";
                        SqlParameter[] sqlParameters = new SqlParameter[] {
                                new SqlParameter("@fName",fName),
                                new SqlParameter("@lName",lName),
                                new SqlParameter("@email",email),
                                new SqlParameter("@password",password),
                                new SqlParameter("@country",getCountryID(comboBox1.Text)),
                        };

                        int isUserCreated = dbManager.ExecuteNonQuery(query, sqlParameters);

                            if (isUserCreated==1)
                            {
                                MessageBox.Show("Account created successfully. You can log in.");
                                loginTabControl.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("An error occurred during registration.");
                            }
                       
                    }
                }
            }
        }


        private int checkingUser(string email)
        {
            //checking if there is an account of the user
            string query = "select * form [users] where email =@email";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@email",email),
            };
            int isUserFound = dbManager.ExecuteNonQuery(query, sqlParameters);

            return isUserFound;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string fName;
            int num;
            fName = firstNameTextBox.Text.Trim();

            for (int i = 0; i < fName.Length; i++)
            {
                if (firstNameTextBox.Text != "" && int.TryParse(fName[i].ToString(), out num))
                {
                    MessageBox.Show("A name cannot contain numeric values!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    firstNameTextBox.Clear();
                }
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                string lName;
                int num;
                lName = lastNameTextBox.Text.Trim();

                for (int i = 0; i < lName.Length; i++)
                {
                    if (lastNameTextBox.Text != "" && int.TryParse(lName[i].ToString(), out num))
                    {
                        MessageBox.Show("A name cannot contain numeric values!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lastNameTextBox.Clear();
                    }
                }
            }
        }

        private void newEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadCountry()
        {
            string query = "SELECT * FROM Country";

            DataTable countries = dbManager.ExecuteQuery(query);
            string[] countriesList = new string[countries.Rows.Count];

            for (int i = 0; i < countries.Rows.Count; i++)
            {
                countriesList[i] = countries.Rows[i]["CountryName"].ToString();
            }
            comboBox1.DataSource = countriesList;
        }

        private int getCountryID(string country)
        {
            int countryID = 0;
            string query = "SELECT id FROM country WHERE CountryName=@country";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@country",country),
            };
            DataTable county = dbManager.ExecuteQuery(query, sqlParameters);

            foreach (DataRow row in county.Rows)
            {
                countryID = Convert.ToInt32(row["id"].ToString());
            }
            return countryID;
        }
    }
}
