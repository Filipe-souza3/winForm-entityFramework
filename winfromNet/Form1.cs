using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winfromNet.models;

namespace winfromNet
{
    public partial class Form1 : Form
    {
        CarroContext dbCar = new CarroContext();
        public Form1()
        {
            InitializeComponent();
            //dataGridViewPessoa.ed
        }

        private void btnCar_Click(object sender, EventArgs e)
        {


        }

        private void btnCar_Click_1(object sender, EventArgs e)
        {
           
            if (!String.IsNullOrEmpty(inputCor.Text) && !String.IsNullOrEmpty(inputPlaca.Text))
            {
                dbCar.Carros.Add(new Carro(inputCor.Text, inputPlaca.Text));
                dbCar.SaveChanges();

                inputCor.Text = "";
                inputPlaca.Text = "";
                MessageBox.Show("Carro salvo com sucesso.");
            }else{
                MessageBox.Show("Todos os campos tem que ser preenchidos.");
            }
           
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(inputNome.Text) && !String.IsNullOrEmpty((inputIdade.Text))) { 
                int idade =int.Parse(inputIdade.Text);
                dbCar.Pessoas.Add(new Pessoa(inputNome.Text,idade));
                dbCar.SaveChanges();

                inputNome.Text = "";
                inputIdade.Text = "";
                MessageBox.Show("Pessoa salva com sucesso.");
            } else {
                MessageBox.Show("Todos os campos tem que ser preenchidos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbCar.Carros.Load();
            dataGridViewCarro.DataSource = dbCar.Carros.Local.ToBindingList();

            dbCar.Pessoas.Load();
            dataGridViewPessoa.DataSource = dbCar.Pessoas.Local.ToBindingList();
        }

        private void dataGridViewCarro_CellContentClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                contextMenuStrip1.Visible = true;
                contextMenuStrip1.Show(sender as Control, e.X,e.Y);
                var hit = dataGridViewCarro.HitTest(e.X, e.Y);
                dataGridViewCarro.ClearSelection();
                dataGridViewCarro.Rows[hit.RowIndex].Selected = true;
                dataGridViewCarro.CurrentCell =  dataGridViewCarro.Rows[hit.RowIndex].Cells[0];
            }
        }
        private void editarToolStripMenuItem_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Carro carro = (Carro)dataGridViewCarro.SelectedRows[0].DataBoundItem;
            contextMenuStrip1.Visible = false;
            inputCor.Text = carro.Cor;
            inputPlaca.Text = carro.Placa;
            //MessageBox.Show(carro.ID.ToString());
        }

        private void excluirToolStripMenuItem_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Carro c = (Carro)dataGridViewCarro.SelectedRows[0].DataBoundItem;
            contextMenuStrip1.Visible = false;

            MessageBox.Show(c.ID.ToString()+" excluido");

            dbCar.Entry(c).State = EntityState.Deleted;
            dbCar.SaveChanges();

        }
    }
}
