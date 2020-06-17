using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class Form1 : Form
    {
        private GameService gameService;

        public Form1()
        {
            InitializeComponent();
            this.gameService = new GameService();
            this.dataGridView1.DataSource = GetProductsAsync();
        }

        public async Task<List<Game>> GetProductsAsync()
        {
            var list = await this.gameService.GetAllProducts();

            if (list is null)
            {
                MessageBox.Show("Musisz zostać zaautoryzowany");
                return null;
            }
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public async Task PdfGo()
        {

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void buyTicket_Click(object sender, EventArgs e)
        {

        }

        private void checkReserv_Click(object sender, EventArgs e)
        {

        }

        private async void AddGame_Click(object sender, EventArgs e)
        {
            var result = await gameService.AddProduct();
            dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }

        private async void DeleteGame_Click(object sender, EventArgs e)
        {
            var result = await gameService.DeleteProduct();
            if (!result.IsSuccessStatusCode)
                MessageBox.Show("Taka gra nie istnieje");
            this.dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }

        private async void GetGameDetails_Click(object sender, EventArgs e)
        {
            var result = await gameService.UpdateProduct();
            if (!result.IsSuccessStatusCode)
                MessageBox.Show("Nie ma takiej gry w bazie");
        }

        private async void EditGame_Click(object sender, EventArgs e)
        {
            var result = await this.gameService.UpdateProduct();
            if (!result.IsSuccessStatusCode)
                MessageBox.Show("Taka gra nie istnieje");
            this.dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }
    }
}