namespace ProyectoDAE_Ciclo2
{
    partial class Form7
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anderson Armando Cuzul Lucero",
            "Maria José Menendez Ruiz"});
            this.comboBox1.Location = new System.Drawing.Point(285, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(447, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "C105",
            "A23",
            "B35",
            "F76"});
            this.comboBox2.Location = new System.Drawing.Point(285, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(447, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(447, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(285, 179);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(447, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Activa",
            "Finalizada",
            "Cancelada"});
            this.comboBox3.Location = new System.Drawing.Point(285, 205);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(447, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Habitación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Estado:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Suite"});
            this.comboBox4.Location = new System.Drawing.Point(545, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(187, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tipo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.habitacion,
            this.tipo,
            this.fecha_entrada,
            this.fecha_salida,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 261);
            this.dataGridView1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(623, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 31);
            this.button6.TabIndex = 16;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(518, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 31);
            this.button7.TabIndex = 17;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(413, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 31);
            this.button8.TabIndex = 18;
            this.button8.Text = "Editar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(308, 249);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 31);
            this.button9.TabIndex = 19;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(203, 249);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 31);
            this.button10.TabIndex = 20;
            this.button10.Text = "Agregar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 250;
            // 
            // habitacion
            // 
            this.habitacion.HeaderText = "Habitación";
            this.habitacion.Name = "habitacion";
            this.habitacion.Width = 150;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // fecha_entrada
            // 
            this.fecha_entrada.HeaderText = "Fecha Entrada";
            this.fecha_entrada.Name = "fecha_entrada";
            // 
            // fecha_salida
            // 
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.Name = "fecha_salida";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 570);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}