using System;
using System.Net.Http;
using System.Windows.Forms;

namespace WFClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			var client = new HttpClient();

			//var r = client.GetAsync("http://localhost:52163/GameRepository/GetAllGames").Result;
			var r = client.GetAsync("http://localhost:52163/GameRepository/GetTest").Result;

			this.Output.Text = r.Content.ReadAsStringAsync().Result;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
