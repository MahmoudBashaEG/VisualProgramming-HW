using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualProgrammingHW
{
    public partial class ManagingUsers : Form
    {
        private readonly OleDbConnection _connection;
        public ManagingUsers()
        {
            InitializeComponent();
            _connection = new OleDbConnection(Constants.ConenctionString);
        }

        private void successMessage(string msg = null)
        {
            if (string.IsNullOrEmpty(msg))
                msg = "Operation Succeeded";
            MessageBox.Show(msg, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void errorMessage(string msg = null)
        {
            if (string.IsNullOrEmpty(msg))
                msg = "Operation Failed";
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool isThereAnyTextBoxesIEmpty()
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text))
                return true;
            return false;
        }
        private void clearTextBoxes()
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            listUsersInListView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isThereAnyTextBoxesIEmpty())
                {
                    errorMessage("Invalid Inputs");
                    return;
                }

                var isFoundedUserWithSameUserName = isThereAnyUserWithSameUserName(username.Text);
                if (isFoundedUserWithSameUserName)
                {
                    errorMessage("This Username is founded before, please try another one");
                    return;
                }

                OleDbCommand cmd = _connection.CreateCommand();
                cmd.CommandText = $"INSERT INTO users ([username], [password]) VALUES (@email,@password)";

                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                if (_connection.State != ConnectionState.Open)
                    _connection.Open();

                cmd.ExecuteNonQuery();

                successMessage();
                listUsersInListView();
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        private ListViewItem getSelectedItemFromListView()
        {
            if (list.SelectedItems.Count == 0)
                return null;

            return list.SelectedItems[0];
        }

        private bool isThereAnyUserWithSameUserName(string username)
        {
            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "select count(*) from users where [username] = @username";
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            cmd.Parameters.AddWithValue("@username", username);
            var data = cmd.ExecuteScalar();
            if (data is null)
                return false;

            var count = int.Parse(data.ToString());
            if (count > 0)
                return true;

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItem = getSelectedItemFromListView();
            if (selectedItem is null)
            {
                errorMessage("You Didn't Choose an Item");
                return;
            }
            if (isThereAnyTextBoxesIEmpty())
            {
                errorMessage("Invalid Inputs");
                return;
            }

            var oldUserName = selectedItem.SubItems[1].Text;
            var newUserName = username.Text;

            if (newUserName != oldUserName)
            {
                var isFoundedUserWithSameUserName = isThereAnyUserWithSameUserName(newUserName);
                if (isFoundedUserWithSameUserName)
                {
                    errorMessage("This Username is founded before, please try another one");
                    return;
                }
            }

            var id = int.Parse(selectedItem.SubItems[0].Text);
            var pass = password.Text;


            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $"update users set [username] = @username, [password] = @password where [Id] = {id}";

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            //cmd.Parameters.AddWithValue("@num", id);
            cmd.Parameters.AddWithValue("@username", newUserName);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.ExecuteNonQuery();

            clearTextBoxes();
            successMessage();
            listUsersInListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = getSelectedItemFromListView();
            if (selectedItem is null)
            {
                clearTextBoxes();
                return;
            }
            username.Text = selectedItem.SubItems[1].Text;
            password.Text = selectedItem.SubItems[2].Text;
        }

        private void listUsersInListView()
        {
            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "select * from users";
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            var data = cmd.ExecuteReader();
            list.Items.Clear();
            foreach (var item in data)
            {
                var itemm = new ListViewItem(((int)data[0]).ToString());
                itemm.SubItems.Add((string)data[1]);
                itemm.SubItems.Add((string)data[2]);
                list.Items.Add(itemm);
            }
            _connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItem = getSelectedItemFromListView();
            if (selectedItem is null)
            {
                errorMessage("You Didn't Choose an Item");
                return;
            }

            var id = int.Parse(selectedItem.SubItems[0].Text);

            OleDbCommand cmd = _connection.CreateCommand();
            cmd.CommandText = "delete from users where [ID] = @id";
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            cmd.Parameters.AddWithValue("@id", id);
            var data = cmd.ExecuteNonQuery();

            clearTextBoxes();
            successMessage();
            listUsersInListView();

            _connection.Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
