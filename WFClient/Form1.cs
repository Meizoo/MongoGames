using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class Form1 : Form
    {
        private GameService gameService;
        private List<Game> games;
        private string selected;

        public Form1()
        {
            InitializeComponent();

            this.gameService = new GameService();
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
            this.dataGridView1.DataSource = null;
            var a = this.games
                .Where(i => i.Name.ToUpper().Contains(this.searchText.Text.ToUpper())).ToArray();
            this.dataGridView1.DataSource = a;

        }
        private static string[] FlightToArray(Game f) => new[]
        {
                f.Name,
                f.Developer,
                f.Publisher,
                string.Join(",", f.Platforms)
            };

        private void buyTicket_Click(object sender, EventArgs e)
        {

        }

        private void checkReserv_Click(object sender, EventArgs e)
        {

        }

        private async void AddGame_Click(object sender, EventArgs e)
        {
            var form = new CreateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.Game != null)
                    await gameService.AddProduct(form.Game);
            }
            dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }

        private async void DeleteGame_Click(object sender, EventArgs e)
        {
            var result = await gameService.DeleteProduct(this.selected);
            if (!result.IsSuccessStatusCode)
                MessageBox.Show("Taka gra nie istnieje");
            this.dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }

        private async void GetGameDetails_Click(object sender, EventArgs e)
        {
            var result = await gameService.GetProduct(this.selected);
            if (result == null)
            {
                MessageBox.Show("Nie ma takiej gry w bazie");
                return;
            }
            MessageBox.Show(result.ToString());
        }

        private async void EditGame_Click(object sender, EventArgs e)
        {
            var result = await this.gameService.UpdateProduct(null);
            if (!result.IsSuccessStatusCode)
                MessageBox.Show("Taka gra nie istnieje");
            this.dataGridView1.DataSource = await this.gameService.GetAllProducts();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            var list = await this.gameService.GetAllProducts();

            if (list is null)
            {
                MessageBox.Show("Musisz zostać zaautoryzowany");
                return;
            }
            this.games = list;
            dataGridView1.DataSource = list;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PdfGenerate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                this.selected = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                MessageBox.Show(this.selected);
            }
        }
    }
}