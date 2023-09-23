namespace atestat
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.login_text_1 = new System.Windows.Forms.Label();
            this.prenume_label = new System.Windows.Forms.Label();
            this.nume_label = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.parola_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.eroare = new System.Windows.Forms.Label();
            this.register_button = new ePOSOne.btnProduct.Button_WOC();
            this.back_register = new ePOSOne.btnProduct.Button_WOC();
            this.iesire_register = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // login_text_1
            // 
            this.login_text_1.AutoSize = true;
            this.login_text_1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.login_text_1.ForeColor = System.Drawing.Color.Silver;
            this.login_text_1.Location = new System.Drawing.Point(97, 39);
            this.login_text_1.Name = "login_text_1";
            this.login_text_1.Size = new System.Drawing.Size(214, 23);
            this.login_text_1.TabIndex = 123;
            this.login_text_1.Text = "MocaMess - Register";
            // 
            // prenume_label
            // 
            this.prenume_label.AutoSize = true;
            this.prenume_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.prenume_label.ForeColor = System.Drawing.Color.White;
            this.prenume_label.Location = new System.Drawing.Point(170, 161);
            this.prenume_label.Name = "prenume_label";
            this.prenume_label.Size = new System.Drawing.Size(76, 18);
            this.prenume_label.TabIndex = 16;
            this.prenume_label.Text = "Prenume";
            // 
            // nume_label
            // 
            this.nume_label.AutoSize = true;
            this.nume_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.nume_label.ForeColor = System.Drawing.Color.White;
            this.nume_label.Location = new System.Drawing.Point(181, 97);
            this.nume_label.Name = "nume_label";
            this.nume_label.Size = new System.Drawing.Size(52, 18);
            this.nume_label.TabIndex = 15;
            this.nume_label.Text = "Nume";
            // 
            // nume
            // 
            this.nume.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.nume.Location = new System.Drawing.Point(131, 118);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(147, 20);
            this.nume.TabIndex = 1;
            this.nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prenume
            // 
            this.prenume.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.prenume.Location = new System.Drawing.Point(131, 182);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(147, 20);
            this.prenume.TabIndex = 2;
            this.prenume.Tag = "";
            this.prenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parola_label
            // 
            this.parola_label.AutoSize = true;
            this.parola_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.parola_label.ForeColor = System.Drawing.Color.White;
            this.parola_label.Location = new System.Drawing.Point(180, 288);
            this.parola_label.Name = "parola_label";
            this.parola_label.Size = new System.Drawing.Size(56, 18);
            this.parola_label.TabIndex = 20;
            this.parola_label.Text = "Parola";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(166, 224);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(80, 18);
            this.username_label.TabIndex = 19;
            this.username_label.Text = "Utilizator";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(131, 245);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(147, 20);
            this.username.TabIndex = 3;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.parola.Location = new System.Drawing.Point(131, 309);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '●';
            this.parola.Size = new System.Drawing.Size(147, 20);
            this.parola.TabIndex = 4;
            this.parola.Tag = "";
            this.parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eroare
            // 
            this.eroare.AutoSize = true;
            this.eroare.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F);
            this.eroare.Location = new System.Drawing.Point(199, 398);
            this.eroare.Name = "eroare";
            this.eroare.Size = new System.Drawing.Size(0, 15);
            this.eroare.TabIndex = 25;
            // 
            // register_button
            // 
            this.register_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.FlatAppearance.BorderSize = 0;
            this.register_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.Location = new System.Drawing.Point(153, 348);
            this.register_button.Name = "register_button";
            this.register_button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register_button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.register_button.OnHoverTextColor = System.Drawing.Color.White;
            this.register_button.Size = new System.Drawing.Size(109, 36);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Inregistrare";
            this.register_button.TextColor = System.Drawing.Color.White;
            this.register_button.UseMnemonic = false;
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // back_register
            // 
            this.back_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.ButtonColor = System.Drawing.Color.Silver;
            this.back_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatAppearance.BorderSize = 0;
            this.back_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_register.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.Location = new System.Drawing.Point(12, 447);
            this.back_register.Name = "back_register";
            this.back_register.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_register.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.back_register.OnHoverTextColor = System.Drawing.Color.Black;
            this.back_register.Size = new System.Drawing.Size(76, 39);
            this.back_register.TabIndex = 6;
            this.back_register.Text = "Inapoi";
            this.back_register.TextColor = System.Drawing.Color.Black;
            this.back_register.UseMnemonic = false;
            this.back_register.UseVisualStyleBackColor = false;
            this.back_register.Click += new System.EventHandler(this.back_register_Click);
            // 
            // iesire_register
            // 
            this.iesire_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iesire_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.ButtonColor = System.Drawing.Color.Red;
            this.iesire_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iesire_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.FlatAppearance.BorderSize = 0;
            this.iesire_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iesire_register.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.Location = new System.Drawing.Point(320, 447);
            this.iesire_register.Name = "iesire_register";
            this.iesire_register.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iesire_register.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iesire_register.OnHoverTextColor = System.Drawing.Color.White;
            this.iesire_register.Size = new System.Drawing.Size(66, 39);
            this.iesire_register.TabIndex = 7;
            this.iesire_register.Text = "Iesire";
            this.iesire_register.TextColor = System.Drawing.Color.White;
            this.iesire_register.UseMnemonic = false;
            this.iesire_register.UseVisualStyleBackColor = false;
            this.iesire_register.Click += new System.EventHandler(this.iesire_register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(398, 498);
            this.ControlBox = false;
            this.Controls.Add(this.eroare);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.back_register);
            this.Controls.Add(this.parola_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.prenume_label);
            this.Controls.Add(this.nume_label);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.login_text_1);
            this.Controls.Add(this.iesire_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC iesire_register;
        private System.Windows.Forms.Label login_text_1;
        private System.Windows.Forms.Label prenume_label;
        private System.Windows.Forms.Label nume_label;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.Label parola_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox parola;
        private ePOSOne.btnProduct.Button_WOC back_register;
        private ePOSOne.btnProduct.Button_WOC register_button;
        private System.Windows.Forms.Label eroare;
    }
}