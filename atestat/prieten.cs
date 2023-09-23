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
    public partial class prieten : UserControl
    {
        string user1, user2, numee;
        Panel panel1, panel2, panel3, panel4, mesagerie, panel_mesaje;
        bool color = true;
        Label nume_destinatar;
        TextBox text;
        Timer t;
        Color c;
        public prieten(string numee, string user1, string user2, Size s, Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel mesagerie, Label nume_destinatar, Panel panel_mesaje, TextBox text,Timer t)
        {
            InitializeComponent();
            this.t = t;
            this.text = text;
            c = this.BackColor;
            this.panel1 = panel1;
            this.panel2 = panel2;
            this.panel3 = panel3;
            this.panel4 = panel4;
            this.mesagerie = mesagerie;
            this.panel_mesaje = panel_mesaje;
            this.nume_destinatar = nume_destinatar;
            this.user1 = user1;
            this.user2 = user2;
            this.numee = numee;
            nume.Text = numee;
            this.Size = new Size(s.Width, s.Height);
            nume.Size = new Size(this.Size.Width, this.Size.Height);
            nume.Location = new Point(0, 0);
        }
        private void click(object sender, MouseEventArgs e)
        {
            t.Start();
            f.user2 = user2;
            text.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            mesagerie.Visible = true;
            nume_destinatar.Text = f.getname(f.getid(user2)) + " " + f.getprenume(f.getid(user2)) + " (" + user2 + ")";
            for (int i = 0; i < f.nr_mesaje; i++)
            {
                panel_mesaje.Controls.Remove(f.mesaje[i]);
            }
            f.nr_mesaje = 0;
            f.current_h = 0;
            //mesaj panel
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM mesaje WHERE username1 = '" + user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + user2 + "'", db.con);
            int n = Convert.ToInt32(cmd1.ExecuteScalar());

            if (n != 0)
            {
                f.mesaje = new Label[n];
                MySqlCommand cmd2 = new MySqlCommand("SELECT mesaj,username1 FROM mesaje WHERE username1 = '" + user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + user2 + "'", db.con);
                MySqlDataReader r = cmd2.ExecuteReader();

                while (r.Read())
                {
                    f.mesaje[f.nr_mesaje] = new Label();
                    f.mesaje[f.nr_mesaje].BackColor = panel_mesaje.BackColor;
                    panel_mesaje.Controls.Add(f.mesaje[f.nr_mesaje]);
                    f.mesaje[f.nr_mesaje].Text = r["mesaj"].ToString();
                    f.mesaje[f.nr_mesaje].AutoSize = true;
                    f.mesaje[f.nr_mesaje].MaximumSize = new Size(Convert.ToInt32(panel_mesaje.Size.Width * 40 / 100), 0);
                    f.mesaje[f.nr_mesaje].Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
                    if (user1 != r["username1"].ToString())
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(30, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(panel_mesaje.Size.Width - f.mesaje[f.nr_mesaje].Size.Width - 30, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleRight;
                    }


                    f.current_h += f.mesaje[f.nr_mesaje].Size.Height + 10;
                    f.nr_mesaje++;
                }
                panel_mesaje.ScrollControlIntoView(f.mesaje[f.nr_mesaje - 1]);

                r.Close();

            }
        }

        private void change_Color(object sender, EventArgs e)
        {
            if (color)
            {
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = c;
            }
            color = !color;
        }

    }
}
