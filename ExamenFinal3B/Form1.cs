using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal3B
{
    public partial class Form1 : Form
    {
        private List<Persona> cliente = new List<Persona>();
        private int edit_indice = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void eliminar()
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void guardar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cliente;
        }

        private void Dgtvcliente_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow select = dataGridView1.SelectedRows[0];
            int posicion = dataGridView1.Rows.IndexOf(select);
            edit_indice = posicion;

            Persona Persona = cliente[posicion];
            textBox5.Text = Persona.Cliente;
            textBox3.Text = Persona.Domicilio;
            textBox6.Text = Convert.ToString(Persona.No);
        }

        public void modificar()
        {
            Persona p = new Persona();

            p.No = Convert.ToInt32(textBox4.Text);
            p.Cliente = textBox5.Text;
            p.Domicilio = textBox6.Text;

            guardar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.No = int.Parse(textBox4.Text);
            persona.Cliente = textBox5.Text;
            persona.Domicilio = textBox6.Text;

            if (edit_indice > -1)
            {
                cliente[edit_indice] = persona;
                edit_indice = -1;
            }
            else
            {
                cliente.Add(persona);
            }

            guardar();
            eliminar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Darle al boton agregar para guardar cambio", "Estado", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                cliente.RemoveAt(edit_indice);
                edit_indice = -1;
                eliminar();
                guardar();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre el elemento y borrar");
            }
        }
    }
}
