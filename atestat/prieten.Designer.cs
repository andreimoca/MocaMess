namespace atestat
{
    partial class prieten
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nume.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.nume.Location = new System.Drawing.Point(68, 5);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(78, 31);
            this.nume.TabIndex = 25;
            this.nume.Text = "Username";
            this.nume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click);
            this.nume.MouseEnter += new System.EventHandler(this.change_Color);
            this.nume.MouseLeave += new System.EventHandler(this.change_Color);
            // 
            // prieten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nume);
            this.Name = "prieten";
            this.Size = new System.Drawing.Size(177, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nume;
    }
}
