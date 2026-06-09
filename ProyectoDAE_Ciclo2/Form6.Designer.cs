namespace ProyectoDAE_Ciclo2
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 298);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descripción:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "N° Habitación:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(472, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 31);
            this.button6.TabIndex = 11;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(367, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 31);
            this.button7.TabIndex = 12;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(262, 247);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 31);
            this.button8.TabIndex = 13;
            this.button8.Text = "Editar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(157, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 31);
            this.button9.TabIndex = 14;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(52, 247);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 31);
            this.button10.TabIndex = 15;
            this.button10.Text = "Agregar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 142);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(571, 89);
            this.textBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Disponible",
            "Ocupada",
            "Mantenimiento"});
            this.comboBox3.Location = new System.Drawing.Point(389, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Simple",
            "Doble",
            "Suite"});
            this.comboBox4.Location = new System.Drawing.Point(114, 69);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(201, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(389, 32);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(201, 20);
            this.numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(114, 31);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(201, 20);
            this.numericUpDown4.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(622, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 298);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fotografía";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroHabitacion,
            this.precio,
            this.tipo,
            this.estado,
            this.descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 308);
            this.dataGridView1.TabIndex = 8;
            // 
            // numeroHabitacion
            // 
            this.numeroHabitacion.HeaderText = "N° Habitación";
            this.numeroHabitacion.Name = "numeroHabitacion";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 350;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}