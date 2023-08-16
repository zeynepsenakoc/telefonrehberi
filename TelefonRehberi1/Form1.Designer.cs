namespace TelefonRehberi1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            txtAdi = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            txtSoyadi = new TextBox();
            txtEPosta = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            txtAdresi = new RichTextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            seçtiğinÖgeyiSilToolStripMenuItem = new ToolStripMenuItem();
            seçtiğinÖgeyiGünecelleToolStripMenuItem = new ToolStripMenuItem();
            txtAra = new TextBox();
            rbtad = new RadioButton();
            radioButton3 = new RadioButton();
            btnCikis = new Button();
            btnKayit = new Button();
            btnTemizle = new Button();
            btnExcelAktar = new Button();
            ADI = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Kişi Adı";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(152, 24);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(294, 27);
            txtAdi.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Adres";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Doğum Tarihi";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "T.C. Kimlik No";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(134, 27);
            textBox6.TabIndex = 5;
            textBox6.Text = "E-Posta";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 90);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(134, 27);
            textBox7.TabIndex = 6;
            textBox7.Text = "Telefon Numarası";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 57);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(134, 27);
            textBox8.TabIndex = 7;
            textBox8.Text = "Kişi Soyadı";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(152, 57);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(294, 27);
            txtSoyadi.TabIndex = 8;
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(152, 123);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(294, 27);
            txtEPosta.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(152, 90);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(294, 27);
            maskedTextBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(152, 156);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(294, 27);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtAdresi
            // 
            txtAdresi.Location = new Point(152, 222);
            txtAdresi.Name = "txtAdresi";
            txtAdresi.Size = new Size(290, 124);
            txtAdresi.TabIndex = 13;
            txtAdresi.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ADI });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 365);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(578, 188);
            dataGridView1.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { seçtiğinÖgeyiSilToolStripMenuItem, seçtiğinÖgeyiGünecelleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 52);
            // 
            // seçtiğinÖgeyiSilToolStripMenuItem
            // 
            seçtiğinÖgeyiSilToolStripMenuItem.Name = "seçtiğinÖgeyiSilToolStripMenuItem";
            seçtiğinÖgeyiSilToolStripMenuItem.Size = new Size(240, 24);
            seçtiğinÖgeyiSilToolStripMenuItem.Text = "Seçtiğin ögeyi sil";
            // 
            // seçtiğinÖgeyiGünecelleToolStripMenuItem
            // 
            seçtiğinÖgeyiGünecelleToolStripMenuItem.Name = "seçtiğinÖgeyiGünecelleToolStripMenuItem";
            seçtiğinÖgeyiGünecelleToolStripMenuItem.Size = new Size(240, 24);
            seçtiğinÖgeyiGünecelleToolStripMenuItem.Text = "Seçtiğin ögeyi günecelle";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(12, 570);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(172, 27);
            txtAra.TabIndex = 16;
            txtAra.Text = "Kişi Ara";
            // 
            // rbtad
            // 
            rbtad.AutoSize = true;
            rbtad.Location = new Point(196, 573);
            rbtad.Name = "rbtad";
            rbtad.Size = new Size(80, 24);
            rbtad.TabIndex = 18;
            rbtad.TabStop = true;
            rbtad.Text = "Kişi Adı";
            rbtad.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(300, 573);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 24);
            radioButton3.TabIndex = 19;
            radioButton3.TabStop = true;
            radioButton3.Text = "Kişi Soyadı";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources.exit;
            btnCikis.BackgroundImageLayout = ImageLayout.Zoom;
            btnCikis.Location = new Point(596, 466);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 87);
            btnCikis.TabIndex = 20;
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            btnKayit.BackgroundImage = Properties.Resources.save1;
            btnKayit.BackgroundImageLayout = ImageLayout.Zoom;
            btnKayit.Location = new Point(448, 285);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(67, 61);
            btnKayit.TabIndex = 22;
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click_1;
            // 
            // btnTemizle
            // 
            btnTemizle.BackgroundImage = Properties.Resources.clear1;
            btnTemizle.BackgroundImageLayout = ImageLayout.Zoom;
            btnTemizle.Location = new Point(523, 285);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(67, 61);
            btnTemizle.TabIndex = 23;
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnExcelAktar
            // 
            btnExcelAktar.BackgroundImage = (Image)resources.GetObject("btnExcelAktar.BackgroundImage");
            btnExcelAktar.BackgroundImageLayout = ImageLayout.Zoom;
            btnExcelAktar.Location = new Point(609, 385);
            btnExcelAktar.Name = "btnExcelAktar";
            btnExcelAktar.Size = new Size(81, 75);
            btnExcelAktar.TabIndex = 24;
            btnExcelAktar.UseVisualStyleBackColor = true;
            btnExcelAktar.Click += btnExcelAktar_Click;
            // 
            // ADI
            // 
            ADI.HeaderText = "Adı";
            ADI.MinimumWidth = 6;
            ADI.Name = "ADI";
            ADI.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 621);
            Controls.Add(btnExcelAktar);
            Controls.Add(btnTemizle);
            Controls.Add(btnKayit);
            Controls.Add(btnCikis);
            Controls.Add(radioButton3);
            Controls.Add(rbtad);
            Controls.Add(txtAra);
            Controls.Add(dataGridView1);
            Controls.Add(txtAdresi);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtEPosta);
            Controls.Add(txtSoyadi);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtAdi);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtAdi;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox txtSoyadi;
        private TextBox txtEPosta;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private DateTimePicker dateTimePicker1;
        private RichTextBox txtAdresi;
        private DataGridView dataGridView1;
        private TextBox txtAra;
        private RadioButton rbtad;
        private RadioButton radioButton3;
        private Button btnCikis;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem seçtiğinÖgeyiSilToolStripMenuItem;
        private ToolStripMenuItem seçtiğinÖgeyiGünecelleToolStripMenuItem;
        private Button btnKayit;
        private Button btnTemizle;
        private Button btnExcelAktar;
        private DataGridViewTextBoxColumn ADI;
    }
}