using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class Register : Form
    {
        private void settext(string x, int d)
        {
            f.settext(this, x, d, eroare, 5);
        }
        private void settext()
        {
            f.settext(this, "", 0, eroare, 5);
        }
        public Register()
        {
            InitializeComponent();
        }

        private bool check_pass()
        {
            if (parola.Text.Length < 5 || parola.Text.Length > 254)
            {
                settext("Parola trebuie sa aiba intre 5 si 254 de caractere", 2);
                return false;
            }
            settext();
            return true;
        }
        private bool check_user()
        {
            if (username.Text.Length < 4 || username.Text.Length > 254)
            {
                settext("Usernameul trebuie sa aiba intre 4 si 254 de caractere", 2);
                return false;
            }
            settext();
            return true;
        }

        private void creare_cont_label_Click(object sender, EventArgs e)
        {
        }

        private void iesire_register_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_register_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            if (f.check_connection(this, eroare))
            {
                if (username.Text != "" && parola.Text != "" && nume.Text != "" && prenume.Text != "")
                {
                    if (f.check_username_requirements(this, eroare))
                    {
                        if (check_user())
                        {
                            if (check_pass())
                            {
                                if (nume.Text.Length > 254 || prenume.Text.Length > 254)
                                    settext("Numele si prenumele trebuie sa aiba maxim 254 de caractere", 2);
                                else
                                    f.creare_user(nume.Text, prenume.Text, username.Text, parola.Text, this, eroare);
                            }
                        }
                    }
                }
                else
                {
                    settext("Te rog sa completezi toate campurile", 2);
                }


            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
