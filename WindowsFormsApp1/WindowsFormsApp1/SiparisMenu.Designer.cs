namespace WindowsFormsApp1
{
    partial class SiparisMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carifirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparismiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbirimfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvYuzdesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirimYuzdesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenecektutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carikodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailadresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satiskartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet13 = new WindowsFormsApp1.projeDataSet13();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.satiskartiTableAdapter = new WindowsFormsApp1.projeDataSet13TableAdapters.SatiskartiTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satiskartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(845, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok Kodu :";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(362, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 24);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(246, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok Birimi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(501, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stok Miktarı :";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(622, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 24);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(549, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kdv % :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(521, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "İndirim % :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(623, 103);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(123, 21);
            this.textBox6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cari Firma:";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(92, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(123, 21);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(259, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Stok Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(359, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 24);
            this.textBox1.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(204, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 73;
            this.label9.Text = "Stok Birim Fiyatı  :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(362, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 71;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(845, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "Sepete  Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(757, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 41);
            this.button2.TabIndex = 20;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(845, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 70);
            this.button4.TabIndex = 30;
            this.button4.Text = "Sipariş Gönder";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(751, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ödenecek Tutar :";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox10.Location = new System.Drawing.Point(623, 67);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(123, 24);
            this.textBox10.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(552, 426);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 32);
            this.button5.TabIndex = 76;
            this.button5.Text = "Sipariş Toplam";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(660, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 24);
            this.label19.TabIndex = 77;
            this.label19.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(92, 71);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(123, 20);
            this.textBox8.TabIndex = 79;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(2, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 78;
            this.label20.Text = "Mail Adresi :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carifirmaDataGridViewTextBoxColumn,
            this.stokadıDataGridViewTextBoxColumn,
            this.siparismiktariDataGridViewTextBoxColumn,
            this.stokbirimiDataGridViewTextBoxColumn,
            this.stokbirimfiyatiDataGridViewTextBoxColumn,
            this.kdvYuzdesiDataGridViewTextBoxColumn,
            this.indirimYuzdesiDataGridViewTextBoxColumn,
            this.odenecektutarDataGridViewTextBoxColumn,
            this.carikodDataGridViewTextBoxColumn,
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokmiktariDataGridViewTextBoxColumn,
            this.mailadresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satiskartiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(823, 279);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // carifirmaDataGridViewTextBoxColumn
            // 
            this.carifirmaDataGridViewTextBoxColumn.DataPropertyName = "Carifirma";
            this.carifirmaDataGridViewTextBoxColumn.HeaderText = "Carifirma";
            this.carifirmaDataGridViewTextBoxColumn.Name = "carifirmaDataGridViewTextBoxColumn";
            // 
            // stokadıDataGridViewTextBoxColumn
            // 
            this.stokadıDataGridViewTextBoxColumn.DataPropertyName = "Stokadı";
            this.stokadıDataGridViewTextBoxColumn.HeaderText = "Stokadı";
            this.stokadıDataGridViewTextBoxColumn.Name = "stokadıDataGridViewTextBoxColumn";
            // 
            // siparismiktariDataGridViewTextBoxColumn
            // 
            this.siparismiktariDataGridViewTextBoxColumn.DataPropertyName = "Siparismiktari";
            this.siparismiktariDataGridViewTextBoxColumn.HeaderText = "Siparismiktari";
            this.siparismiktariDataGridViewTextBoxColumn.Name = "siparismiktariDataGridViewTextBoxColumn";
            // 
            // stokbirimiDataGridViewTextBoxColumn
            // 
            this.stokbirimiDataGridViewTextBoxColumn.DataPropertyName = "Stokbirimi";
            this.stokbirimiDataGridViewTextBoxColumn.HeaderText = "Stokbirimi";
            this.stokbirimiDataGridViewTextBoxColumn.Name = "stokbirimiDataGridViewTextBoxColumn";
            // 
            // stokbirimfiyatiDataGridViewTextBoxColumn
            // 
            this.stokbirimfiyatiDataGridViewTextBoxColumn.DataPropertyName = "Stokbirimfiyati";
            this.stokbirimfiyatiDataGridViewTextBoxColumn.HeaderText = "Stokbirimfiyati";
            this.stokbirimfiyatiDataGridViewTextBoxColumn.Name = "stokbirimfiyatiDataGridViewTextBoxColumn";
            // 
            // kdvYuzdesiDataGridViewTextBoxColumn
            // 
            this.kdvYuzdesiDataGridViewTextBoxColumn.DataPropertyName = "KdvYuzdesi";
            this.kdvYuzdesiDataGridViewTextBoxColumn.HeaderText = "KdvYuzdesi";
            this.kdvYuzdesiDataGridViewTextBoxColumn.Name = "kdvYuzdesiDataGridViewTextBoxColumn";
            // 
            // indirimYuzdesiDataGridViewTextBoxColumn
            // 
            this.indirimYuzdesiDataGridViewTextBoxColumn.DataPropertyName = "indirimYuzdesi";
            this.indirimYuzdesiDataGridViewTextBoxColumn.HeaderText = "indirimYuzdesi";
            this.indirimYuzdesiDataGridViewTextBoxColumn.Name = "indirimYuzdesiDataGridViewTextBoxColumn";
            // 
            // odenecektutarDataGridViewTextBoxColumn
            // 
            this.odenecektutarDataGridViewTextBoxColumn.DataPropertyName = "Odenecektutar";
            this.odenecektutarDataGridViewTextBoxColumn.HeaderText = "Odenecektutar";
            this.odenecektutarDataGridViewTextBoxColumn.Name = "odenecektutarDataGridViewTextBoxColumn";
            // 
            // carikodDataGridViewTextBoxColumn
            // 
            this.carikodDataGridViewTextBoxColumn.DataPropertyName = "Carikod";
            this.carikodDataGridViewTextBoxColumn.HeaderText = "Carikod";
            this.carikodDataGridViewTextBoxColumn.Name = "carikodDataGridViewTextBoxColumn";
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "Stokkodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "Stokkodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            // 
            // stokmiktariDataGridViewTextBoxColumn
            // 
            this.stokmiktariDataGridViewTextBoxColumn.DataPropertyName = "Stokmiktari";
            this.stokmiktariDataGridViewTextBoxColumn.HeaderText = "Stokmiktari";
            this.stokmiktariDataGridViewTextBoxColumn.Name = "stokmiktariDataGridViewTextBoxColumn";
            // 
            // mailadresiDataGridViewTextBoxColumn
            // 
            this.mailadresiDataGridViewTextBoxColumn.DataPropertyName = "Mailadresi";
            this.mailadresiDataGridViewTextBoxColumn.HeaderText = "Mailadresi";
            this.mailadresiDataGridViewTextBoxColumn.Name = "mailadresiDataGridViewTextBoxColumn";
            // 
            // satiskartiBindingSource
            // 
            this.satiskartiBindingSource.DataMember = "Satiskarti";
            this.satiskartiBindingSource.DataSource = this.projeDataSet13;
            // 
            // projeDataSet13
            // 
            this.projeDataSet13.DataSetName = "projeDataSet13";
            this.projeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.Location = new System.Drawing.Point(362, 67);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(123, 24);
            this.textBox9.TabIndex = 80;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(501, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 18);
            this.label21.TabIndex = 81;
            this.label21.Text = "Sipariş Miktarı";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(754, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 16);
            this.label22.TabIndex = 82;
            this.label22.Text = "0  ";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox13.Location = new System.Drawing.Point(625, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(120, 24);
            this.textBox13.TabIndex = 83;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(845, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 41);
            this.button7.TabIndex = 85;
            this.button7.Text = "Sepet Listele";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(845, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 35);
            this.button8.TabIndex = 86;
            this.button8.Text = "Sepetten Cikar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(850, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Türk Lirası";
            // 
            // satiskartiTableAdapter
            // 
            this.satiskartiTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(845, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 41);
            this.button6.TabIndex = 88;
            this.button6.Text = "Sepet Güncelle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(794, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 89;
            this.label12.Text = "TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(842, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 90;
            this.label13.Text = "0  ";
            this.label13.Visible = false;
            // 
            // SiparisMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 460);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Name = "SiparisMenu";
            this.Text = "SiparisMenu";
            this.Load += new System.EventHandler(this.SiparisMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satiskartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private projeDataSet13 projeDataSet13;
        private System.Windows.Forms.BindingSource satiskartiBindingSource;
        private projeDataSet13TableAdapters.SatiskartiTableAdapter satiskartiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carifirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparismiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbirimfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvYuzdesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirimYuzdesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenecektutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carikodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailadresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}