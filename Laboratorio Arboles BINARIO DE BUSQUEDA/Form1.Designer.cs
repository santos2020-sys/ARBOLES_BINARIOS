namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomTTextBox = new System.Windows.Forms.TextBox();
            this.ProgATextBox = new System.Windows.Forms.TextBox();
            this.eliminarBtt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listarBtt = new System.Windows.Forms.Button();
            this.comboBoxPA = new System.Windows.Forms.ComboBox();
            this.comboBoxDT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Tarea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración de la Tarea:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje de avance: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Programador Asignado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nomTTextBox
            // 
            this.nomTTextBox.Location = new System.Drawing.Point(210, 40);
            this.nomTTextBox.Name = "nomTTextBox";
            this.nomTTextBox.Size = new System.Drawing.Size(172, 20);
            this.nomTTextBox.TabIndex = 4;
            // 
            // ProgATextBox
            // 
            this.ProgATextBox.Location = new System.Drawing.Point(210, 163);
            this.ProgATextBox.Name = "ProgATextBox";
            this.ProgATextBox.Size = new System.Drawing.Size(172, 20);
            this.ProgATextBox.TabIndex = 7;
            // 
            // eliminarBtt
            // 
            this.eliminarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtt.Location = new System.Drawing.Point(250, 380);
            this.eliminarBtt.Name = "eliminarBtt";
            this.eliminarBtt.Size = new System.Drawing.Size(127, 29);
            this.eliminarBtt.TabIndex = 9;
            this.eliminarBtt.Text = "Eliminar Tarea";
            this.eliminarBtt.UseVisualStyleBackColor = true;
            this.eliminarBtt.Click += new System.EventHandler(this.eliminarBtt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Listar todas las Tareas:";
            // 
            // listarBtt
            // 
            this.listarBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarBtt.Location = new System.Drawing.Point(301, 241);
            this.listarBtt.Name = "listarBtt";
            this.listarBtt.Size = new System.Drawing.Size(81, 20);
            this.listarBtt.TabIndex = 12;
            this.listarBtt.Text = "Listar";
            this.listarBtt.UseVisualStyleBackColor = true;
            this.listarBtt.Click += new System.EventHandler(this.listarBtt_Click);
            // 
            // comboBoxPA
            // 
            this.comboBoxPA.FormattingEnabled = true;
            this.comboBoxPA.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBoxPA.Location = new System.Drawing.Point(210, 126);
            this.comboBoxPA.Name = "comboBoxPA";
            this.comboBoxPA.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPA.TabIndex = 13;
            // 
            // comboBoxDT
            // 
            this.comboBoxDT.FormattingEnabled = true;
            this.comboBoxDT.Items.AddRange(new object[] {
            "1 Semana",
            "2 Semanas",
            "3 Semanas",
            "1 Mes",
            "2 Meses",
            "3 Meses",
            "4 Meses",
            "5 Meses",
            "6 Meses",
            "7 Meses",
            "8 Meses",
            "9 Meses",
            "10 Meses",
            "11 Meses",
            "1 año"});
            this.comboBoxDT.Location = new System.Drawing.Point(210, 83);
            this.comboBoxDT.Name = "comboBoxDT";
            this.comboBoxDT.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre de la Tarea:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar la Tarea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarBtt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID Proyecto:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(210, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(172, 20);
            this.textBoxId.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(366, 105);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID Proyecto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 432);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDT);
            this.Controls.Add(this.comboBoxPA);
            this.Controls.Add(this.listarBtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminarBtt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgATextBox);
            this.Controls.Add(this.nomTTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomTTextBox;
        private System.Windows.Forms.TextBox ProgATextBox;
        private System.Windows.Forms.Button eliminarBtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button listarBtt;
        private System.Windows.Forms.ComboBox comboBoxPA;
        private System.Windows.Forms.ComboBox comboBoxDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
    }
}

