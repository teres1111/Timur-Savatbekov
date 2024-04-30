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


            // ������� ������ �������������
            List<User> users = new List<User>();

            // ��������� ����� �����������
            Form1 form1 = new Form1(users);

            // ���� ����� ����������� ����������� � ����������� OK, �� ��������� ����� �����
            if (form1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FirstOpen(users));
            }


        }
    }
}