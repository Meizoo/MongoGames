using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{
    public partial class EditForm : Form
    {
        public EditForm(Game game)
        {
            InitializeComponent();
            this.Game = game;
            this.nameBox.Text = game.Name;
            this.developerBox.Text = game.Developer;
            this.producerBox.Text = game.Publisher;
            foreach (var item in game.Platforms)
            {

                for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                {

                    if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked && checkedListBox1.Items[i].ToString() == item)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkedListBox1.SelectedIndex;
            if (selected != -1)
            {
                var text = checkedListBox1.Items[selected].ToString();
                if (!platforms.Contains(text))
                    platforms.Add(text);
            }
        }
        private List<string> platforms = new List<string>();

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Game = null;
            this.Close();
        }
        public Game Game;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(developerBox.Text) || string.IsNullOrWhiteSpace(producerBox.Text) || platforms.Count != 0)
            {
                MessageBox.Show("Uzupełnij wszystkie dane");
                return;
            }
            this.Game = new Game()
            {
                Id = Game?.Id,
                Name = nameBox.Text,
                Developer = developerBox.Text,
                Publisher = producerBox.Text,
                Platforms = platforms,
            };
            this.Close();
        }
    }
}
