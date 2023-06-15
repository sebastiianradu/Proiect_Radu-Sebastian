
namespace Proiect_Radu_Sebastian
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AfisareSondaj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DELETEdb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 527);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AfisareSondaj
            // 
            this.AfisareSondaj.BackColor = System.Drawing.Color.LightCyan;
            this.AfisareSondaj.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfisareSondaj.ForeColor = System.Drawing.Color.DimGray;
            this.AfisareSondaj.Location = new System.Drawing.Point(12, 56);
            this.AfisareSondaj.Name = "AfisareSondaj";
            this.AfisareSondaj.Size = new System.Drawing.Size(887, 78);
            this.AfisareSondaj.TabIndex = 1;
            this.AfisareSondaj.Text = "Afisare Sondaj";
            this.AfisareSondaj.UseVisualStyleBackColor = false;
            this.AfisareSondaj.Click += new System.EventHandler(this.AfisareSondaj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.imprimareToolStripMenuItem1});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.salvareToolStripMenuItem1.Text = "Salvare ca fisier CSV";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // imprimareToolStripMenuItem1
            // 
            this.imprimareToolStripMenuItem1.Name = "imprimareToolStripMenuItem1";
            this.imprimareToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.imprimareToolStripMenuItem1.Text = "Imprimare";
            // 
            // DELETEdb
            // 
            this.DELETEdb.BackColor = System.Drawing.Color.LightCyan;
            this.DELETEdb.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEdb.ForeColor = System.Drawing.Color.DimGray;
            this.DELETEdb.Location = new System.Drawing.Point(921, 56);
            this.DELETEdb.Name = "DELETEdb";
            this.DELETEdb.Size = new System.Drawing.Size(259, 78);
            this.DELETEdb.TabIndex = 5;
            this.DELETEdb.Text = "Stergere BD";
            this.DELETEdb.UseVisualStyleBackColor = false;
            this.DELETEdb.Click += new System.EventHandler(this.DELETEdb_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1192, 679);
            this.Controls.Add(this.DELETEdb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AfisareSondaj);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AfisareSondaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem1;
        private System.Windows.Forms.Button DELETEdb;
    }
}