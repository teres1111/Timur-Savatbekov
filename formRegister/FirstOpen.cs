using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formRegister
{
    public partial class FirstOpen : Form
    {
        private List<User> userList;

        public FirstOpen()
        {
        }

        public FirstOpen(List<User> users)
        {
            InitializeComponent();
            userList = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;

            // Поиск пользователя по имени и паролю
            User foundUser = userList.Find(question => question.UserName == username && question.Password == password );
            if (foundUser != null)
            {
                if (foundUser.Role == Role.superAdmin) 
                {
                    MessageBox.Show($"Hello, {foundUser.FIO}! ROLE: {foundUser.Role}");
                    //SuperAd userListForm = new (userList);
                    //userListForm.Show();
                    this.Hide(); // Скрыть форму входа
                }
                else if (foundUser.Role == Role.Admin)
                {
                    MessageBox.Show($"Hello, {foundUser.FIO}! ROLE: {foundUser.Role}");
                }
                else
                {
                    MessageBox.Show($"Hello, {foundUser.FIO}! ROLE: {foundUser.Role}");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                // Неверные данные
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void FirstOpen_Load(object sender, EventArgs e)
        {
            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
