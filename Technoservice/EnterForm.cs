using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Technoservice.Collection;
using Technoservice.Models;

namespace Technoservice
{
    public partial class EnterForm : Form
    {
        const string name = "Залупка";
        const string surname = "Залупкин";
        const int RoleId = 1;
        private Form1 form1 = new Form1();
        public EnterForm()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text.Length == 0 || PasswordBox.Text.Length == 0)
            {
                MessageBox.Show("Вы не заполнили!");
            }
            else
            {
                using (TehnoserviceContext db = new TehnoserviceContext())
                {
                    string login = LoginBox.Text;
                    var LogPas = db.Users.Where(x => x.Login == login);
                    if (LogPas.Any())
                    {
                        MessageBox.Show("Занято");
                    }
                    else
                    {
                        Users users = new Users()
                        {
                            UserName = name,
                            UserSurname = surname,
                            Login = LoginBox.Text,
                            Password = md5.hashPassword(PasswordBox.Text),
                            IdRole = RoleId
                        };
                        db.Users.Add(users);
                        db.SaveChanges();
                        MessageBox.Show("збс");
                    }
                }
            }
        }

        private void PasHideBtn_Click(object sender, EventArgs e)
        {

        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text.Length == 0 || PasswordBox.Text.Length == 0)
            {
                MessageBox.Show("Пустые поля");
            }
            else
            {
                string login = LoginBox.Text;
                string password = md5.hashPassword(PasswordBox.Text);
                using(TehnoserviceContext ctx = new TehnoserviceContext())
                {
                    var LogPas = ctx.Users.Where(x => x.Login == login && x.Password == password);
                    foreach (var user in LogPas)
                    {
                        if (user.IdRole != 1)
                        {
                            MessageBox.Show("Роль говно");
                        }
                        else
                        {
                            form1.label1.Text = user.Login;
                            form1.Show();
                            return;
                        }
                    }
                }
            }
        }
    }
}
