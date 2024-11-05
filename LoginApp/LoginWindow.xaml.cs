using System.Windows;

namespace LoginApp
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Kiểm tra thông tin đăng nhập
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Thực hiện các thao tác sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void BtnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chức năng quên mật khẩu đang được phát triển.");
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chức năng tạo tài khoản mới đang được phát triển.");
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
