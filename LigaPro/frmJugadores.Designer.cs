
namespace LigaPro22
{
    partial class frmJugadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJugadores));
            this.dni = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Ape = new System.Windows.Forms.TextBox();
            this.Domi = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.TextBox();
            this.FechaN = new System.Windows.Forms.DateTimePicker();
            this.Club = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuscarDNI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CodigPostal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.SystemColors.Control;
            this.dni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dni.Location = new System.Drawing.Point(127, 37);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(121, 20);
            this.dni.TabIndex = 1;
            this.dni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.SystemColors.Control;
            this.Nom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nom.Location = new System.Drawing.Point(127, 63);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(121, 20);
            this.Nom.TabIndex = 2;
            // 
            // Ape
            // 
            this.Ape.BackColor = System.Drawing.SystemColors.Control;
            this.Ape.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ape.Location = new System.Drawing.Point(127, 89);
            this.Ape.Name = "Ape";
            this.Ape.Size = new System.Drawing.Size(121, 20);
            this.Ape.TabIndex = 3;
            // 
            // Domi
            // 
            this.Domi.BackColor = System.Drawing.SystemColors.Control;
            this.Domi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Domi.Location = new System.Drawing.Point(127, 115);
            this.Domi.Name = "Domi";
            this.Domi.Size = new System.Drawing.Size(121, 20);
            this.Domi.TabIndex = 4;
            // 
            // Sexo
            // 
            this.Sexo.BackColor = System.Drawing.SystemColors.Control;
            this.Sexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sexo.Location = new System.Drawing.Point(127, 168);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(121, 20);
            this.Sexo.TabIndex = 6;
            // 
            // FechaN
            // 
            this.FechaN.CalendarForeColor = System.Drawing.SystemColors.Control;
            this.FechaN.CalendarMonthBackground = System.Drawing.Color.ForestGreen;
            this.FechaN.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.FechaN.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDark;
            this.FechaN.CustomFormat = "yyyy-MM-dd";
            this.FechaN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaN.Location = new System.Drawing.Point(151, 195);
            this.FechaN.Name = "FechaN";
            this.FechaN.Size = new System.Drawing.Size(97, 20);
            this.FechaN.TabIndex = 7;
            // 
            // Club
            // 
            this.Club.BackColor = System.Drawing.SystemColors.Control;
            this.Club.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Club.FormattingEnabled = true;
            this.Club.Location = new System.Drawing.Point(127, 221);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(121, 21);
            this.Club.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Domicilio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Codigo Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.ForestGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.ForestGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Club:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 173);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuscarDNI
            // 
            this.BuscarDNI.BackColor = System.Drawing.SystemColors.Control;
            this.BuscarDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuscarDNI.Location = new System.Drawing.Point(376, 37);
            this.BuscarDNI.Name = "BuscarDNI";
            this.BuscarDNI.Size = new System.Drawing.Size(136, 20);
            this.BuscarDNI.TabIndex = 13;
            this.BuscarDNI.TextChanged += new System.EventHandler(this.BuscarDNI_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.ForestGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Buscar por DNI:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(504, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 66);
            this.button1.TabIndex = 16;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodigPostal
            // 
            this.CodigPostal.BackColor = System.Drawing.SystemColors.Control;
            this.CodigPostal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodigPostal.FormattingEnabled = true;
            this.CodigPostal.Location = new System.Drawing.Point(127, 141);
            this.CodigPostal.Name = "CodigPostal";
            this.CodigPostal.Size = new System.Drawing.Size(121, 21);
            this.CodigPostal.TabIndex = 5;
            this.CodigPostal.SelectedIndexChanged += new System.EventHandler(this.CodigPostal_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(306, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 14;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(387, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 15;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(356, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 9;
            this.button4.Text = "Nuevo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(437, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 20);
            this.button5.TabIndex = 10;
            this.button5.Text = "Registrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(518, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 20);
            this.button6.TabIndex = 11;
            this.button6.Text = "Editar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(599, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 20);
            this.button7.TabIndex = 12;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CodigPostal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BuscarDNI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Club);
            this.Controls.Add(this.FechaN);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Domi);
            this.Controls.Add(this.Ape);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.dni);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJugadores";
            this.Text = "Liga del Sur";
            this.Load += new System.EventHandler(this.frmJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Ape;
        private System.Windows.Forms.TextBox Domi;
        private System.Windows.Forms.TextBox Sexo;
        private System.Windows.Forms.DateTimePicker FechaN;
        private System.Windows.Forms.ComboBox Club;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BuscarDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CodigPostal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}