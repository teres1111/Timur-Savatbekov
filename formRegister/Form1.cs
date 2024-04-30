namespace formRegister
{
    public partial class Form1 : Form
    {
        private List<User> userList; // userlar royhati
        public Form1(List<User> users)
        {
            InitializeComponent();
            userList = users;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            string fullName = FullName.Text;

            // ѕровер€ем, есть ли пользователь с таким же именем
            if (userList.Exists(u => u.UserName == username))
            {
                MessageBox.Show("User with this username already exists!");
                return;
            }

            // —оздаем нового пользовател€
            User newUser = new User { FIO = fullName, UserName = username, Password = password, Role = Role.superAdmin };
            userList.Add(newUser); // ƒобавл€ем пользовател€ в список

            MessageBox.Show("User registered successfully!");

            // ѕосле успешной регистрации установим DialogResult на OK
            DialogResult = DialogResult.OK;


            string filePath = @"C:\Users\User\Desktop\format\formRegister\formRegister\UserList.txt";
            SaveUserToFile(newUser, filePath);

        }
        private void SaveUserToFile(User user, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{user.UserName},{user.Password},{user.FIO},{user.Role}");
                }
                MessageBox.Show("User data saved to file successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving user data to file: {ex.Message}");
            }
        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
