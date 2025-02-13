namespace testeForm.Forms
{
    partial class ListaPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPets));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btEditarPet = new Button();
            btExcluirPet = new Button();
            btPesquisaPet = new Button();
            txtPesquisaPet = new TextBox();
            dtgListPets = new DataGridView();
            IdPet = new DataGridViewTextBoxColumn();
            NomePet = new DataGridViewTextBoxColumn();
            IdadePet = new DataGridViewTextBoxColumn();
            EspeciePet = new DataGridViewTextBoxColumn();
            RacaPet = new DataGridViewTextBoxColumn();
            DonoPet = new DataGridViewTextBoxColumn();
            iconPetShop = new PictureBox();
            lbPetCadastrado = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).BeginInit();
            SuspendLayout();
            // 
            // btEditarPet
            // 
            btEditarPet.BackColor = Color.Peru;
            btEditarPet.Image = (Image)resources.GetObject("btEditarPet.Image");
            btEditarPet.Location = new Point(664, 98);
            btEditarPet.Name = "btEditarPet";
            btEditarPet.Size = new Size(63, 60);
            btEditarPet.TabIndex = 51;
            btEditarPet.UseVisualStyleBackColor = false;
            // 
            // btExcluirPet
            // 
            btExcluirPet.BackColor = Color.Peru;
            btExcluirPet.Image = (Image)resources.GetObject("btExcluirPet.Image");
            btExcluirPet.Location = new Point(586, 98);
            btExcluirPet.Name = "btExcluirPet";
            btExcluirPet.Size = new Size(63, 60);
            btExcluirPet.TabIndex = 50;
            btExcluirPet.UseVisualStyleBackColor = false;
            // 
            // btPesquisaPet
            // 
            btPesquisaPet.BackColor = Color.Peru;
            btPesquisaPet.Image = (Image)resources.GetObject("btPesquisaPet.Image");
            btPesquisaPet.Location = new Point(501, 98);
            btPesquisaPet.Name = "btPesquisaPet";
            btPesquisaPet.Size = new Size(63, 60);
            btPesquisaPet.TabIndex = 49;
            btPesquisaPet.UseVisualStyleBackColor = false;
            // 
            // txtPesquisaPet
            // 
            txtPesquisaPet.Location = new Point(63, 121);
            txtPesquisaPet.Name = "txtPesquisaPet";
            txtPesquisaPet.Size = new Size(432, 27);
            txtPesquisaPet.TabIndex = 48;
            // 
            // dtgListPets
            // 
            dtgListPets.AllowUserToOrderColumns = true;
            dtgListPets.BackgroundColor = SystemColors.HighlightText;
            dtgListPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListPets.Columns.AddRange(new DataGridViewColumn[] { IdPet, NomePet, IdadePet, EspeciePet, RacaPet, DonoPet });
            dtgListPets.Location = new Point(64, 175);
            dtgListPets.Name = "dtgListPets";
            dtgListPets.RowHeadersWidth = 51;
            dtgListPets.Size = new Size(673, 254);
            dtgListPets.TabIndex = 47;
            // 
            // IdPet
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            IdPet.DefaultCellStyle = dataGridViewCellStyle7;
            IdPet.FillWeight = 60F;
            IdPet.HeaderText = "ID";
            IdPet.MinimumWidth = 6;
            IdPet.Name = "IdPet";
            IdPet.Width = 60;
            // 
            // NomePet
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NomePet.DefaultCellStyle = dataGridViewCellStyle8;
            NomePet.HeaderText = "Nome";
            NomePet.MinimumWidth = 6;
            NomePet.Name = "NomePet";
            NomePet.Width = 125;
            // 
            // IdadePet
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            IdadePet.DefaultCellStyle = dataGridViewCellStyle9;
            IdadePet.HeaderText = "Idade";
            IdadePet.MinimumWidth = 6;
            IdadePet.Name = "IdadePet";
            IdadePet.Width = 60;
            // 
            // EspeciePet
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EspeciePet.DefaultCellStyle = dataGridViewCellStyle10;
            EspeciePet.HeaderText = "Espécie";
            EspeciePet.MinimumWidth = 6;
            EspeciePet.Name = "EspeciePet";
            EspeciePet.Width = 125;
            // 
            // RacaPet
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            RacaPet.DefaultCellStyle = dataGridViewCellStyle11;
            RacaPet.HeaderText = "Raça";
            RacaPet.MinimumWidth = 6;
            RacaPet.Name = "RacaPet";
            RacaPet.Width = 125;
            // 
            // DonoPet
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DonoPet.DefaultCellStyle = dataGridViewCellStyle12;
            DonoPet.HeaderText = "Dono";
            DonoPet.MinimumWidth = 6;
            DonoPet.Name = "DonoPet";
            DonoPet.Width = 125;
            // 
            // iconPetShop
            // 
            iconPetShop.BackColor = Color.SaddleBrown;
            iconPetShop.Image = (Image)resources.GetObject("iconPetShop.Image");
            iconPetShop.Location = new Point(557, 30);
            iconPetShop.Name = "iconPetShop";
            iconPetShop.Size = new Size(32, 44);
            iconPetShop.SizeMode = PictureBoxSizeMode.Zoom;
            iconPetShop.TabIndex = 46;
            iconPetShop.TabStop = false;
            // 
            // lbPetCadastrado
            // 
            lbPetCadastrado.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPetCadastrado.ForeColor = SystemColors.Control;
            lbPetCadastrado.Location = new Point(237, 21);
            lbPetCadastrado.Name = "lbPetCadastrado";
            lbPetCadastrado.Size = new Size(327, 64);
            lbPetCadastrado.TabIndex = 45;
            lbPetCadastrado.Text = "PETS CADASTRADOS";
            lbPetCadastrado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListaPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btEditarPet);
            Controls.Add(btExcluirPet);
            Controls.Add(btPesquisaPet);
            Controls.Add(txtPesquisaPet);
            Controls.Add(dtgListPets);
            Controls.Add(iconPetShop);
            Controls.Add(lbPetCadastrado);
            Name = "ListaPets";
            Text = "ListaPets";
            ((System.ComponentModel.ISupportInitialize)dtgListPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditarPet;
        private Button btExcluirPet;
        private Button btPesquisaPet;
        private TextBox txtPesquisaPet;
        private DataGridView dtgListPets;
        private DataGridViewTextBoxColumn IdPet;
        private DataGridViewTextBoxColumn NomePet;
        private DataGridViewTextBoxColumn IdadePet;
        private DataGridViewTextBoxColumn EspeciePet;
        private DataGridViewTextBoxColumn RacaPet;
        private DataGridViewTextBoxColumn DonoPet;
        private PictureBox iconPetShop;
        private Label lbPetCadastrado;
    }
}