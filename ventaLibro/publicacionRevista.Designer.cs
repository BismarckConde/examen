namespace ventaLibro
{
    partial class publicacionRevista
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
            this.btnrevist = new System.Windows.Forms.Button();
            this.lsvrevista = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtmen = new System.Windows.Forms.TextBox();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnrevist
            // 
            this.btnrevist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrevist.Location = new System.Drawing.Point(480, 389);
            this.btnrevist.Name = "btnrevist";
            this.btnrevist.Size = new System.Drawing.Size(140, 49);
            this.btnrevist.TabIndex = 21;
            this.btnrevist.Text = "REGISTRAR";
            this.btnrevist.UseVisualStyleBackColor = true;
            this.btnrevist.Click += new System.EventHandler(this.btnlibro_Click);
            // 
            // lsvrevista
            // 
            this.lsvrevista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvrevista.FullRowSelect = true;
            this.lsvrevista.GridLines = true;
            this.lsvrevista.Location = new System.Drawing.Point(12, 138);
            this.lsvrevista.Name = "lsvrevista";
            this.lsvrevista.Size = new System.Drawing.Size(608, 231);
            this.lsvrevista.TabIndex = 20;
            this.lsvrevista.UseCompatibleStateImageBehavior = false;
            this.lsvrevista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TITULO";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AUTOR";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FECHA DE PUBLICACION";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "COSTOS";
            this.columnHeader4.Width = 120;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(535, 93);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(85, 23);
            this.txtcost.TabIndex = 19;
            // 
            // txtmen
            // 
            this.txtmen.Location = new System.Drawing.Point(160, 93);
            this.txtmen.Name = "txtmen";
            this.txtmen.Size = new System.Drawing.Size(110, 23);
            this.txtmen.TabIndex = 17;
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(5, 93);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(140, 23);
            this.txtlibro.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(545, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "COSTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "PERIODICIDAD \r\nMENSUAL\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "TITULO DEL LIBRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "VENTAS DE REVISTAS";
            // 
            // txtse
            // 
            this.txtse.Location = new System.Drawing.Point(285, 93);
            this.txtse.Name = "txtse";
            this.txtse.Size = new System.Drawing.Size(110, 23);
            this.txtse.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(285, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 60);
            this.label4.TabIndex = 22;
            this.label4.Text = "PERIODICIDAD \r\nSEMANAL\r\n\r\n";
            // 
            // txtqin
            // 
            this.txtqin.Location = new System.Drawing.Point(410, 93);
            this.txtqin.Name = "txtqin";
            this.txtqin.Size = new System.Drawing.Size(110, 23);
            this.txtqin.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(410, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 60);
            this.label6.TabIndex = 24;
            this.label6.Text = "PERIODICIDAD \r\nQUINCENAL\r\n\r\n";
            // 
            // publicacionRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.txtqin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnrevist);
            this.Controls.Add(this.lsvrevista);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtmen);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "publicacionRevista";
            this.Text = "publicacionRevista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnrevist;
        private ListView lsvrevista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtcost;
        private TextBox txtmen;
        private TextBox txtlibro;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtse;
        private Label label4;
        private TextBox txtqin;
        private Label label6;
    }
}