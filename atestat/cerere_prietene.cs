using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atestat
{
    public partial class cerere_prietene : UserControl
    {
        //Panel prieteni;
        string username1, username2;
        Button btn;
        int nr;

        Panel panel_prieteni;
        int id;
        Label nu_prieteni;

        Panel panel1, panel2, panel3, panel4, mesagerie, mesaje;
        Label nume_destinatar;
        TextBox mesaj;
        Timer t;
        public cerere_prietene()
        {
            InitializeComponent();
        }
        public cerere_prietene(string s, string username1, string username2, int nr, Button btn, Panel panel_prieteni, int id, Label nu_prieteni, Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel mesagerie, Label nume_destinatar, Panel mesaje, TextBox mesaj,Timer t)//,Panel prieteni)
        {
            InitializeComponent();
            nume.Text = s;
            //this.prieteni = prieteni;
            this.t = t;
            this.mesaj = mesaj;
            this.nume_destinatar = nume_destinatar;
            this.panel1 = panel1;
            this.panel2 = panel2;
            this.panel3 = panel3;
            this.panel4 = panel4;
            this.mesaje = mesaje;
            this.mesagerie = mesagerie;
            this.panel_prieteni = panel_prieteni;
            this.id = id;
            this.nu_prieteni = nu_prieteni;
            this.username1 = username1;
            this.username2 = username2;
            this.nr = nr;
            this.btn = btn;
        }

        private void accepta_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("Insert into prieteni (username1,username2) values('" + username1 + "','" + username2 + "')", db.con);
            MySqlCommand cmd2 = new MySqlCommand("Insert into prieteni (username1,username2) values('" + username2 + "','" + username1 + "')", db.con);
            MySqlCommand cmd3 = new MySqlCommand("Delete from requests where username1='" + username1 + "' and username2='" + username2 + "'", db.con);
            MySqlCommand cmd4 = new MySqlCommand("Delete from requests where username1='" + username2 + "' and username2='" + username1 + "'", db.con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            btn.PerformClick();
            f.afisare_prieteni(panel_prieteni, id, nu_prieteni, panel1, panel2, panel3, panel4, mesagerie, nume_destinatar, mesaje, mesaj,t);
            
        }

        private void refuza_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("Delete from requests where username1='" + username1 + "' and username2='" + username2 + "'", db.con);
            MySqlCommand cmd2 = new MySqlCommand("Delete from requests where username1='" + username2 + "' and username2='" + username1 + "'", db.con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            btn.PerformClick();
          

        }

        private void cerere_prietene_Load(object sender, EventArgs e)
        {

        }
    }
}
