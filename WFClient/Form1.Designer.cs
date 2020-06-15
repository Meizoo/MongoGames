namespace WFClient
{
	partial class Form1
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
            this.AddGame = new System.Windows.Forms.Button();
            this.DeleteGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GetGameDetails = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reservNumber = new System.Windows.Forms.TextBox();
            this.EditGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(628, 56);
            this.AddGame.Margin = new System.Windows.Forms.Padding(2);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(141, 26);
            this.AddGame.TabIndex = 2;
            this.AddGame.Text = "Dodaj grę";
            this.AddGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(628, 87);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(141, 26);
            this.DeleteGame.TabIndex = 3;
            this.DeleteGame.Text = "Usuń grę";
            this.DeleteGame.UseVisualStyleBackColor = true;
            this.DeleteGame.Click += new System.EventHandler(this.DeleteGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Katalog gier";
            // 
            // GetGameDetails
            // 
            this.GetGameDetails.Location = new System.Drawing.Point(628, 119);
            this.GetGameDetails.Name = "GetGameDetails";
            this.GetGameDetails.Size = new System.Drawing.Size(141, 26);
            this.GetGameDetails.TabIndex = 6;
            this.GetGameDetails.Text = "Pokaż szczegóły";
            this.GetGameDetails.UseVisualStyleBackColor = true;
            this.GetGameDetails.Click += new System.EventHandler(this.GetGameDetails_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(416, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 7;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj";
            // 
            // reservNumber
            // 
            this.reservNumber.Location = new System.Drawing.Point(628, 183);
            this.reservNumber.Name = "reservNumber";
            this.reservNumber.Size = new System.Drawing.Size(141, 20);
            this.reservNumber.TabIndex = 9;
            // 
            // EditGame
            // 
            this.EditGame.Location = new System.Drawing.Point(628, 209);
            this.EditGame.Name = "EditGame";
            this.EditGame.Size = new System.Drawing.Size(141, 26);
            this.EditGame.TabIndex = 10;
            this.EditGame.Text = "Edytuj grę";
            this.EditGame.UseVisualStyleBackColor = true;
            this.EditGame.Click += new System.EventHandler(this.EditGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wprowadź numer rezerwacji";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 310);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditGame);
            this.Controls.Add(this.reservNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.GetGameDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.AddGame);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button DeleteGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetGameDetails;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reservNumber;
        private System.Windows.Forms.Button EditGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

