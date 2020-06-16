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
			this.AddGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AddGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.AddGame.FlatAppearance.BorderSize = 0;
			this.AddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddGame.Location = new System.Drawing.Point(628, 10);
			this.AddGame.Margin = new System.Windows.Forms.Padding(2);
			this.AddGame.Name = "AddGame";
			this.AddGame.Size = new System.Drawing.Size(202, 26);
			this.AddGame.TabIndex = 2;
			this.AddGame.Text = "Dodaj grę";
			this.AddGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.AddGame.UseVisualStyleBackColor = false;
			this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
			// 
			// DeleteGame
			// 
			this.DeleteGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DeleteGame.FlatAppearance.BorderSize = 0;
			this.DeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteGame.Location = new System.Drawing.Point(628, 41);
			this.DeleteGame.Name = "DeleteGame";
			this.DeleteGame.Size = new System.Drawing.Size(202, 26);
			this.DeleteGame.TabIndex = 3;
			this.DeleteGame.Text = "Usuń grę";
			this.DeleteGame.UseVisualStyleBackColor = false;
			this.DeleteGame.Click += new System.EventHandler(this.DeleteGame_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Katalog gier";
			// 
			// GetGameDetails
			// 
			this.GetGameDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GetGameDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.GetGameDetails.FlatAppearance.BorderSize = 0;
			this.GetGameDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GetGameDetails.Location = new System.Drawing.Point(628, 73);
			this.GetGameDetails.Name = "GetGameDetails";
			this.GetGameDetails.Size = new System.Drawing.Size(202, 26);
			this.GetGameDetails.TabIndex = 6;
			this.GetGameDetails.Text = "Pokaż szczegóły";
			this.GetGameDetails.UseVisualStyleBackColor = false;
			this.GetGameDetails.Click += new System.EventHandler(this.GetGameDetails_Click);
			// 
			// searchText
			// 
			this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchText.BackColor = System.Drawing.Color.White;
			this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.searchText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.searchText.Location = new System.Drawing.Point(429, 13);
			this.searchText.Margin = new System.Windows.Forms.Padding(5);
			this.searchText.Name = "searchText";
			this.searchText.Size = new System.Drawing.Size(192, 20);
			this.searchText.TabIndex = 7;
			this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(370, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Wyszukaj";
			// 
			// reservNumber
			// 
			this.reservNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.reservNumber.BackColor = System.Drawing.Color.White;
			this.reservNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.reservNumber.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.reservNumber.Location = new System.Drawing.Point(628, 122);
			this.reservNumber.Margin = new System.Windows.Forms.Padding(5);
			this.reservNumber.Name = "reservNumber";
			this.reservNumber.Size = new System.Drawing.Size(202, 20);
			this.reservNumber.TabIndex = 9;
			// 
			// EditGame
			// 
			this.EditGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.EditGame.FlatAppearance.BorderSize = 0;
			this.EditGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditGame.Location = new System.Drawing.Point(628, 148);
			this.EditGame.Name = "EditGame";
			this.EditGame.Size = new System.Drawing.Size(202, 26);
			this.EditGame.TabIndex = 10;
			this.EditGame.Text = "Edytuj grę";
			this.EditGame.UseVisualStyleBackColor = false;
			this.EditGame.Click += new System.EventHandler(this.EditGame_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(629, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Wprowadź numer rezerwacji";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.Color.White;
			this.dataGridView1.Location = new System.Drawing.Point(16, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(604, 426);
			this.dataGridView1.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Desktop;
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
			this.Text = "Baza gier";
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

