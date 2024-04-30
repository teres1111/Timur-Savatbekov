using Microsoft.VisualBasic.ApplicationServices;

namespace formRegister
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Создаем список пользователей
            List<User> users = new List<User>();

            // Открываем форму регистрации
            Form1 form1 = new Form1(users);

            // Если форма регистрации закрывается с результатом OK, то открываем форму входа
            if (form1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FirstOpen(users));
            }


        }
    }
}