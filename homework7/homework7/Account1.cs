namespace homework7
{
    struct Account1
    {
        public string Login;

        private string Password;

        public Account1(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public void SetPassword(string NewPassword)
        {
            this.Password=NewPassword;
        }
    }
}