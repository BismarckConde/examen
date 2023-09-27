namespace ventaLibro
{
    partial class PublicacionLibro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.txtauli = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.lsvLibro = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnlibro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(201, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS DE LIBROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITULO DEL LIBRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "AUTOR DEL LIBRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(321, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE PUBLICACION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "COSTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(12, 102);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(140, 23);
            this.txtlibro.TabIndex = 5;
            // 
            // txtauli
            // 
            this.txtauli.Location = new System.Drawing.Point(167, 102);
            this.txtauli.Name = "txtauli";
            this.txtauli.Size = new System.Drawing.Size(140, 23);
            this.txtauli.TabIndex = 6;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(330, 102);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(140, 23);
            this.txtfecha.TabIndex = 7;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(510, 102);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(85, 23);
            this.txtcost.TabIndex = 8;
            // 
            // lsvLibro
            // 
            this.lsvLibro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvLibro.FullRowSelect = true;
            this.lsvLibro.GridLines = true;
            this.lsvLibro.Location = new System.Drawing.Point(34, 154);
            this.lsvLibro.Name = "lsvLibro";
            this.lsvLibro.Size = new System.Drawing.Size(553, 231);
            this.lsvLibro.TabIndex = 9;
            this.lsvLibro.UseCompatibleStateImageBehavior = false;
            this.lsvLibro.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "COSTOS";
            this.columnHeader4.Width = 100;
            // 
            // btnlibro
            // 
            this.btnlibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlibro.Location = new System.Drawing.Point(455, 418);
            this.btnlibro.Name = "btnlibro";
            this.btnlibro.Size = new System.Drawing.Size(140, 49);
            this.btnlibro.TabIndex = 10;
            this.btnlibro.Text = "REGISTRAR";
            this.btnlibro.UseVisualStyleBackColor = true;
            this.btnlibro.Click += new System.EventHandler(this.btnlibro_Click);
            // 
            // PublicacionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 479);
            this.Controls.Add(this.btnlibro);
            this.Controls.Add(this.lsvLibro);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtauli);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublicacionLibro";
            this.Text = "Püblica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtlibro;
        private TextBox txtauli;
        private TextBox txtfecha;
        private TextBox txtcost;
        private ListView lsvLibro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnlibro;
    }
}