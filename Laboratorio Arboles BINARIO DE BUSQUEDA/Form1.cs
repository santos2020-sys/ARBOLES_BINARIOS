using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol;
using Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Tarea;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA
{
    public partial class Form1 : Form
    {
        ArbolBinariodeBusqueda ArbolBB = new ArbolBinariodeBusqueda();
        public Object dato { get; set; }
        

        public Form1()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarBtt_Click(object sender, EventArgs e)
        {
            Programador programadores = new Programador();
            programadores.Id_proyecto = int.Parse(textBoxId.Text);
            programadores.NombreTarea = nomTTextBox.Text;
            programadores.DuracionTarea = comboBoxDT.Text;
            programadores.PorAvance = comboBoxPA.Text;
            programadores.ProgramadorAsignado = ProgATextBox.Text;
            //ArbolBB.insertar(programadores);

            if (!ArbolBB.insertar(programadores))
            {
                MessageBox.Show("No se puedeningresar datos duplicados");
            }

            MessageBox.Show("Asignación Realizada");
            textBoxId.Text = " ";
            nomTTextBox.Text = " ";
            comboBoxDT.Text = " ";
            comboBoxPA.Text = " ";
            comboBoxDT.Text = " ";
            ProgATextBox.Text = " ";
        }

        private void listarBtt_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Text = ArbolBinariodeBusqueda.preorden(ArbolBB.raizArbol());
        }

        private void eliminarBtt_Click(object sender, EventArgs e)
        {
            Programador programadores = new Programador();
            programadores.Id_proyecto = int.Parse(textBox2.Text);
            ArbolBB.eliminar(programadores);

            MessageBox.Show("Se elimino con exito");
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
