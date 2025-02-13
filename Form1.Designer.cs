namespace testeForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbMenu = new Label();
            btCadastrarPet = new Button();
            btCadastrarDono = new Button();
            btPets = new Button();
            btDonos = new Button();
            iconCachorro = new PictureBox();
            iconDono = new PictureBox();
            iconPetShop = new PictureBox();
            iconLista = new PictureBox();
            iconLista2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconCachorro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconDono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLista2).BeginInit();
            SuspendLayout();
            // 
            // lbMenu
            // 
            lbMenu.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenu.ForeColor = SystemColors.Control;
            lbMenu.Location = new Point(343, 9);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(124, 64);
            lbMenu.TabIndex = 0;
            lbMenu.Text = "MENU";
            lbMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btCadastrarPet
            // 
            btCadastrarPet.BackColor = Color.Peru;
            btCadastrarPet.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrarPet.ForeColor = SystemColors.Control;
            btCadastrarPet.Location = new Point(92, 152);
            btCadastrarPet.Name = "btCadastrarPet";
            btCadastrarPet.Size = new Size(182, 65);
            btCadastrarPet.TabIndex = 1;
            btCadastrarPet.Text = "CADASTRAR PET";
            btCadastrarPet.TextAlign = ContentAlignment.MiddleRight;
            btCadastrarPet.UseVisualStyleBackColor = false;
            btCadastrarPet.Click += btCadastrarPet_Click;
            // 
            // btCadastrarDono
            // 
            btCadastrarDono.BackColor = Color.Peru;
            btCadastrarDono.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCadastrarDono.ForeColor = SystemColors.Control;
            btCadastrarDono.Location = new Point(92, 291);
            btCadastrarDono.Name = "btCadastrarDono";
            btCadastrarDono.Size = new Size(182, 65);
            btCadastrarDono.TabIndex = 2;
            btCadastrarDono.Text = "CADASTRAR DONO";
            btCadastrarDono.TextAlign = ContentAlignment.MiddleRight;
            btCadastrarDono.UseVisualStyleBackColor = false;
            btCadastrarDono.Click += btCadastrarDono_Click;
            // 
            // btPets
            // 
            btPets.BackColor = Color.Peru;
            btPets.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPets.ForeColor = SystemColors.Control;
            btPets.Location = new Point(509, 152);
            btPets.Name = "btPets";
            btPets.Size = new Size(182, 65);
            btPets.TabIndex = 3;
            btPets.Text = "PETS";
            btPets.UseVisualStyleBackColor = false;
            btPets.Click += btPets_Click;
            // 
            // btDonos
            // 
            btDonos.BackColor = Color.Peru;
            btDonos.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDonos.ForeColor = SystemColors.Control;
            btDonos.Location = new Point(509, 291);
            btDonos.Name = "btDonos";
            btDonos.Size = new Size(182, 65);
            btDonos.TabIndex = 4;
            btDonos.Text = "DONOS";
            btDonos.UseVisualStyleBackColor = false;
            btDonos.Click += btDonos_Click;
            // 
            // iconCachorro
            // 
            iconCachorro.BackColor = Color.Peru;
            iconCachorro.Image = (Image)resources.GetObject("iconCachorro.Image");
            iconCachorro.Location = new Point(520, 163);
            iconCachorro.Name = "iconCachorro";
            iconCachorro.Size = new Size(32, 44);
            iconCachorro.SizeMode = PictureBoxSizeMode.Zoom;
            iconCachorro.TabIndex = 5;
            iconCachorro.TabStop = false;
            // 
            // iconDono
            // 
            iconDono.BackColor = Color.Peru;
            iconDono.Image = (Image)resources.GetObject("iconDono.Image");
            iconDono.Location = new Point(520, 301);
            iconDono.Name = "iconDono";
            iconDono.Size = new Size(32, 44);
            iconDono.SizeMode = PictureBoxSizeMode.Zoom;
            iconDono.TabIndex = 6;
            iconDono.TabStop = false;
            // 
            // iconPetShop
            // 
            iconPetShop.BackColor = Color.SaddleBrown;
            iconPetShop.Image = (Image)resources.GetObject("iconPetShop.Image");
            iconPetShop.Location = new Point(451, 21);
            iconPetShop.Name = "iconPetShop";
            iconPetShop.Size = new Size(32, 44);
            iconPetShop.SizeMode = PictureBoxSizeMode.Zoom;
            iconPetShop.TabIndex = 7;
            iconPetShop.TabStop = false;
            // 
            // iconLista
            // 
            iconLista.BackColor = Color.Peru;
            iconLista.Image = (Image)resources.GetObject("iconLista.Image");
            iconLista.Location = new Point(102, 163);
            iconLista.Name = "iconLista";
            iconLista.Size = new Size(32, 44);
            iconLista.SizeMode = PictureBoxSizeMode.Zoom;
            iconLista.TabIndex = 8;
            iconLista.TabStop = false;
            // 
            // iconLista2
            // 
            iconLista2.BackColor = Color.Peru;
            iconLista2.Image = (Image)resources.GetObject("iconLista2.Image");
            iconLista2.Location = new Point(102, 301);
            iconLista2.Name = "iconLista2";
            iconLista2.Size = new Size(32, 44);
            iconLista2.SizeMode = PictureBoxSizeMode.Zoom;
            iconLista2.TabIndex = 9;
            iconLista2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(109, 66);
            label1.Name = "label1";
            label1.Size = new Size(155, 79);
            label1.TabIndex = 10;
            label1.Text = "NOVO CADASTRO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(525, 81);
            label2.Name = "label2";
            label2.Size = new Size(157, 64);
            label2.TabIndex = 11;
            label2.Text = "CADASTROS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconLista2);
            Controls.Add(iconLista);
            Controls.Add(iconPetShop);
            Controls.Add(iconDono);
            Controls.Add(iconCachorro);
            Controls.Add(lbMenu);
            Controls.Add(btDonos);
            Controls.Add(btPets);
            Controls.Add(btCadastrarDono);
            Controls.Add(btCadastrarPet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iconCachorro).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconDono).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPetShop).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLista2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbMenu;
        private Button btCadastrarPet;
        private Button btCadastrarDono;
        private Button btPets;
        private Button btDonos;
        private PictureBox iconCachorro;
        private PictureBox iconDono;
        private PictureBox iconPetShop;
        private PictureBox iconLista;
        private PictureBox iconLista2;
        private Label label1;
        private Label label2;
    }
}
