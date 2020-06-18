using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfGen;

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

        private async void GetGameDetails_Click(object sender, EventArgs e) => 
            MessageBox.Show(
                (await GetProduct()).ToString()
            );

        private async Task<Game> GetProduct()
        {
            var result = await gameService.GetProduct(this.selected);
            if (result is null)
                MessageBox.Show("Nie ma takiej gry w bazie");
            return result;
        }

        private async void EditGame_Click(object sender, EventArgs e)
        {
            var form = new EditForm(await gameService.GetProduct(this.selected));
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.Game != null)
                {
                    var result = await this.gameService.UpdateProduct(form.Game);
                    if (!result.IsSuccessStatusCode)
                        MessageBox.Show("Taka gra nie istnieje");

                }
            }
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

        private async void PdfGenerate_Click(object sender, EventArgs e)
        {
            var item = await GetProduct();
            if (!(item is null))
            {
                var dlg = new SaveFileDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var pdf = new PdfBuilder(dlg.FileName))
                        pdf.AddParagraph(
                            string.Concat("Id: ", item.Id),
                            string.Concat("Nazwa: ", item.Name),
                            string.Concat("Deweloper: ", item.Developer),
                            string.Concat("Wydawca: ", item.Publisher),
                            string.Concat("Wspierane platformy: ", string.Join(", ", item.Platforms))
                        );
                }
            }
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