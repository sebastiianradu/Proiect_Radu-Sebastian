
namespace Proiect_Radu_Sebastian
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.IncepetiFromularul = new System.Windows.Forms.Button();
            this.Prenume = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cat de mult Economisesti?";
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nume.Location = new System.Drawing.Point(22, 126);
            this.Nume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(74, 23);
            this.Nume.TabIndex = 4;
            this.Nume.Text = "Nume:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(130, 126);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(450, 29);
            this.tbNume.TabIndex = 5;
            this.tbNume.TextChanged += new System.EventHandler(this.tbNume_TextChanged);
            // 
            // IncepetiFromularul
            // 
            this.IncepetiFromularul.BackColor = System.Drawing.Color.LavenderBlush;
            this.IncepetiFromularul.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncepetiFromularul.Location = new System.Drawing.Point(130, 324);
            this.IncepetiFromularul.Margin = new System.Windows.Forms.Padding(4);
            this.IncepetiFromularul.Name = "IncepetiFromularul";
            this.IncepetiFromularul.Size = new System.Drawing.Size(615, 74);
            this.IncepetiFromularul.TabIndex = 6;
            this.IncepetiFromularul.Text = "Incepeti Formularul";
            this.IncepetiFromularul.UseVisualStyleBackColor = false;
            this.IncepetiFromularul.Click += new System.EventHandler(this.IncepetiFromularul_Click);
            // 
            // Prenume
            // 
            this.Prenume.AutoSize = true;
            this.Prenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Prenume.Location = new System.Drawing.Point(22, 192);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(102, 23);
            this.Prenume.TabIndex = 7;
            this.Prenume.Text = "Prenume:";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(130, 192);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(450, 29);
            this.tbPrenume.TabIndex = 8;
            this.tbPrenume.TextChanged += new System.EventHandler(this.tbPrenume_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(130, 250);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(450, 29);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.Location = new System.Drawing.Point(24, 256);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(72, 23);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verifica acum completand urmatorul formular:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(911, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.IncepetiFromularul);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button IncepetiFromularul;
        private System.Windows.Forms.Label Prenume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
    }
}

