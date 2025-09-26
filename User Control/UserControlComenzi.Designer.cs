namespace Proiect_PAW_IvanOanaGeorgiana.User_Control
{
    partial class UserControlComenzi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlComenzi = new System.Windows.Forms.TabControl();
            this.tabPageAdaugaComanda = new System.Windows.Forms.TabPage();
            this.label2TipComanda = new System.Windows.Forms.Label();
            this.label1AdaugaComanda = new System.Windows.Forms.Label();
            this.tabPageCautaComanda = new System.Windows.Forms.TabPage();
            this.tabPageActualizeazaSiStergeComanda = new System.Windows.Forms.TabPage();
            this.comboBoxTipComanda = new System.Windows.Forms.ComboBox();
            this.radioButtonIndisponibil = new System.Windows.Forms.RadioButton();
            this.radioButtonInStoc = new System.Windows.Forms.RadioButton();
            this.labelActualizeazaSiStergeComanda = new System.Windows.Forms.Label();
            this.textBox1NrComanda = new System.Windows.Forms.TextBox();
            this.labelTipComanda = new System.Windows.Forms.Label();
            this.label1NrComanda1 = new System.Windows.Forms.Label();
            this.labelStoc = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelNrComanda = new System.Windows.Forms.Label();
            this.textBox1NumarComanda = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1Stoc = new System.Windows.Forms.Label();
            this.radioButton1InStoc = new System.Windows.Forms.RadioButton();
            this.radioButton2Indisponibil = new System.Windows.Forms.RadioButton();
            this.buttonAdaugaClient = new System.Windows.Forms.Button();
            this.dataGridViewComenzi = new System.Windows.Forms.DataGridView();
            this.textBoxCautaNumarComanda = new System.Windows.Forms.TextBox();
            this.labelNumarComanda = new System.Windows.Forms.Label();
            this.labelCautaComanda = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonActualizeaza = new System.Windows.Forms.Button();
            this.tabControlComenzi.SuspendLayout();
            this.tabPageAdaugaComanda.SuspendLayout();
            this.tabPageCautaComanda.SuspendLayout();
            this.tabPageActualizeazaSiStergeComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlComenzi
            // 
            this.tabControlComenzi.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlComenzi.Controls.Add(this.tabPageAdaugaComanda);
            this.tabControlComenzi.Controls.Add(this.tabPageCautaComanda);
            this.tabControlComenzi.Controls.Add(this.tabPageActualizeazaSiStergeComanda);
            this.tabControlComenzi.Location = new System.Drawing.Point(36, 14);
            this.tabControlComenzi.Name = "tabControlComenzi";
            this.tabControlComenzi.SelectedIndex = 0;
            this.tabControlComenzi.Size = new System.Drawing.Size(1031, 417);
            this.tabControlComenzi.TabIndex = 0;
            // 
            // tabPageAdaugaComanda
            // 
            this.tabPageAdaugaComanda.Controls.Add(this.buttonAdaugaClient);
            this.tabPageAdaugaComanda.Controls.Add(this.radioButton2Indisponibil);
            this.tabPageAdaugaComanda.Controls.Add(this.radioButton1InStoc);
            this.tabPageAdaugaComanda.Controls.Add(this.label1Stoc);
            this.tabPageAdaugaComanda.Controls.Add(this.textBox1NumarComanda);
            this.tabPageAdaugaComanda.Controls.Add(this.labelNrComanda);
            this.tabPageAdaugaComanda.Controls.Add(this.comboBox2);
            this.tabPageAdaugaComanda.Controls.Add(this.label2TipComanda);
            this.tabPageAdaugaComanda.Controls.Add(this.label1AdaugaComanda);
            this.tabPageAdaugaComanda.Location = new System.Drawing.Point(4, 4);
            this.tabPageAdaugaComanda.Name = "tabPageAdaugaComanda";
            this.tabPageAdaugaComanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdaugaComanda.Size = new System.Drawing.Size(1023, 381);
            this.tabPageAdaugaComanda.TabIndex = 0;
            this.tabPageAdaugaComanda.Text = "Adauga Comanda";
            this.tabPageAdaugaComanda.UseVisualStyleBackColor = true;
            // 
            // label2TipComanda
            // 
            this.label2TipComanda.AutoSize = true;
            this.label2TipComanda.Location = new System.Drawing.Point(122, 105);
            this.label2TipComanda.Name = "label2TipComanda";
            this.label2TipComanda.Size = new System.Drawing.Size(143, 23);
            this.label2TipComanda.TabIndex = 1;
            this.label2TipComanda.Text = "Tip Comanda";
            // 
            // label1AdaugaComanda
            // 
            this.label1AdaugaComanda.AutoSize = true;
            this.label1AdaugaComanda.Location = new System.Drawing.Point(6, 3);
            this.label1AdaugaComanda.Name = "label1AdaugaComanda";
            this.label1AdaugaComanda.Size = new System.Drawing.Size(200, 23);
            this.label1AdaugaComanda.TabIndex = 0;
            this.label1AdaugaComanda.Text = "Adauga Comanda";
            // 
            // tabPageCautaComanda
            // 
            this.tabPageCautaComanda.Controls.Add(this.labelCautaComanda);
            this.tabPageCautaComanda.Controls.Add(this.dataGridViewComenzi);
            this.tabPageCautaComanda.Controls.Add(this.textBoxCautaNumarComanda);
            this.tabPageCautaComanda.Controls.Add(this.labelNumarComanda);
            this.tabPageCautaComanda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageCautaComanda.Location = new System.Drawing.Point(4, 4);
            this.tabPageCautaComanda.Name = "tabPageCautaComanda";
            this.tabPageCautaComanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCautaComanda.Size = new System.Drawing.Size(1023, 381);
            this.tabPageCautaComanda.TabIndex = 1;
            this.tabPageCautaComanda.Text = "Cauta Comanda";
            this.tabPageCautaComanda.UseVisualStyleBackColor = true;
            // 
            // tabPageActualizeazaSiStergeComanda
            // 
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.buttonSterge);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.buttonActualizeaza);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.comboBoxTipComanda);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.radioButtonIndisponibil);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.radioButtonInStoc);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.labelActualizeazaSiStergeComanda);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.textBox1NrComanda);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.labelTipComanda);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.label1NrComanda1);
            this.tabPageActualizeazaSiStergeComanda.Controls.Add(this.labelStoc);
            this.tabPageActualizeazaSiStergeComanda.Location = new System.Drawing.Point(4, 4);
            this.tabPageActualizeazaSiStergeComanda.Name = "tabPageActualizeazaSiStergeComanda";
            this.tabPageActualizeazaSiStergeComanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActualizeazaSiStergeComanda.Size = new System.Drawing.Size(1023, 381);
            this.tabPageActualizeazaSiStergeComanda.TabIndex = 2;
            this.tabPageActualizeazaSiStergeComanda.Text = "Actualizeaza si Sterge Comanda";
            this.tabPageActualizeazaSiStergeComanda.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipComanda
            // 
            this.comboBoxTipComanda.FormattingEnabled = true;
            this.comboBoxTipComanda.Items.AddRange(new object[] {
            "Mancare",
            "Supermarket",
            "Magazine si cadouri",
            "Make-up"});
            this.comboBoxTipComanda.Location = new System.Drawing.Point(115, 133);
            this.comboBoxTipComanda.Name = "comboBoxTipComanda";
            this.comboBoxTipComanda.Size = new System.Drawing.Size(341, 31);
            this.comboBoxTipComanda.TabIndex = 29;
            // 
            // radioButtonIndisponibil
            // 
            this.radioButtonIndisponibil.AutoSize = true;
            this.radioButtonIndisponibil.Location = new System.Drawing.Point(210, 249);
            this.radioButtonIndisponibil.Name = "radioButtonIndisponibil";
            this.radioButtonIndisponibil.Size = new System.Drawing.Size(141, 27);
            this.radioButtonIndisponibil.TabIndex = 28;
            this.radioButtonIndisponibil.TabStop = true;
            this.radioButtonIndisponibil.Text = "Indisponibil";
            this.radioButtonIndisponibil.UseVisualStyleBackColor = true;
            // 
            // radioButtonInStoc
            // 
            this.radioButtonInStoc.AutoSize = true;
            this.radioButtonInStoc.Location = new System.Drawing.Point(210, 216);
            this.radioButtonInStoc.Name = "radioButtonInStoc";
            this.radioButtonInStoc.Size = new System.Drawing.Size(99, 27);
            this.radioButtonInStoc.TabIndex = 27;
            this.radioButtonInStoc.TabStop = true;
            this.radioButtonInStoc.Text = "In stoc";
            this.radioButtonInStoc.UseVisualStyleBackColor = true;
            // 
            // labelActualizeazaSiStergeComanda
            // 
            this.labelActualizeazaSiStergeComanda.AutoSize = true;
            this.labelActualizeazaSiStergeComanda.Location = new System.Drawing.Point(6, 3);
            this.labelActualizeazaSiStergeComanda.Name = "labelActualizeazaSiStergeComanda";
            this.labelActualizeazaSiStergeComanda.Size = new System.Drawing.Size(331, 23);
            this.labelActualizeazaSiStergeComanda.TabIndex = 24;
            this.labelActualizeazaSiStergeComanda.Text = "Actualizeaza si Sterge Comanda";
            // 
            // textBox1NrComanda
            // 
            this.textBox1NrComanda.Location = new System.Drawing.Point(576, 132);
            this.textBox1NrComanda.Name = "textBox1NrComanda";
            this.textBox1NrComanda.Size = new System.Drawing.Size(336, 32);
            this.textBox1NrComanda.TabIndex = 23;
            // 
            // labelTipComanda
            // 
            this.labelTipComanda.AutoSize = true;
            this.labelTipComanda.Location = new System.Drawing.Point(111, 106);
            this.labelTipComanda.Name = "labelTipComanda";
            this.labelTipComanda.Size = new System.Drawing.Size(143, 23);
            this.labelTipComanda.TabIndex = 21;
            this.labelTipComanda.Text = "Tip Comanda";
            // 
            // label1NrComanda1
            // 
            this.label1NrComanda1.AutoSize = true;
            this.label1NrComanda1.Location = new System.Drawing.Point(572, 106);
            this.label1NrComanda1.Name = "label1NrComanda1";
            this.label1NrComanda1.Size = new System.Drawing.Size(184, 23);
            this.label1NrComanda1.TabIndex = 19;
            this.label1NrComanda1.Text = "Numar Comanda";
            // 
            // labelStoc
            // 
            this.labelStoc.AutoSize = true;
            this.labelStoc.Location = new System.Drawing.Point(137, 216);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(53, 23);
            this.labelStoc.TabIndex = 18;
            this.labelStoc.Text = "Stoc";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mancare",
            "Supermarket",
            "Cadouri",
            "Make-up"});
            this.comboBox2.Location = new System.Drawing.Point(126, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(344, 31);
            this.comboBox2.TabIndex = 2;
            // 
            // labelNrComanda
            // 
            this.labelNrComanda.AutoSize = true;
            this.labelNrComanda.Location = new System.Drawing.Point(619, 105);
            this.labelNrComanda.Name = "labelNrComanda";
            this.labelNrComanda.Size = new System.Drawing.Size(184, 23);
            this.labelNrComanda.TabIndex = 3;
            this.labelNrComanda.Text = "Numar Comanda";
            // 
            // textBox1NumarComanda
            // 
            this.textBox1NumarComanda.Location = new System.Drawing.Point(623, 130);
            this.textBox1NumarComanda.Name = "textBox1NumarComanda";
            this.textBox1NumarComanda.Size = new System.Drawing.Size(343, 32);
            this.textBox1NumarComanda.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1Stoc
            // 
            this.label1Stoc.AutoSize = true;
            this.label1Stoc.Location = new System.Drawing.Point(122, 216);
            this.label1Stoc.Name = "label1Stoc";
            this.label1Stoc.Size = new System.Drawing.Size(53, 23);
            this.label1Stoc.TabIndex = 5;
            this.label1Stoc.Text = "Stoc";
            // 
            // radioButton1InStoc
            // 
            this.radioButton1InStoc.AutoSize = true;
            this.radioButton1InStoc.Location = new System.Drawing.Point(181, 216);
            this.radioButton1InStoc.Name = "radioButton1InStoc";
            this.radioButton1InStoc.Size = new System.Drawing.Size(101, 27);
            this.radioButton1InStoc.TabIndex = 6;
            this.radioButton1InStoc.TabStop = true;
            this.radioButton1InStoc.Text = "In Stoc";
            this.radioButton1InStoc.UseVisualStyleBackColor = true;
            // 
            // radioButton2Indisponibil
            // 
            this.radioButton2Indisponibil.AutoSize = true;
            this.radioButton2Indisponibil.Location = new System.Drawing.Point(181, 249);
            this.radioButton2Indisponibil.Name = "radioButton2Indisponibil";
            this.radioButton2Indisponibil.Size = new System.Drawing.Size(141, 27);
            this.radioButton2Indisponibil.TabIndex = 7;
            this.radioButton2Indisponibil.TabStop = true;
            this.radioButton2Indisponibil.Text = "Indisponibil";
            this.radioButton2Indisponibil.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.BackColor = System.Drawing.Color.Chocolate;
            this.buttonAdaugaClient.Location = new System.Drawing.Point(865, 319);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.Size = new System.Drawing.Size(152, 56);
            this.buttonAdaugaClient.TabIndex = 8;
            this.buttonAdaugaClient.Text = "Adauga";
            this.buttonAdaugaClient.UseVisualStyleBackColor = false;
            // 
            // dataGridViewComenzi
            // 
            this.dataGridViewComenzi.AllowUserToAddRows = false;
            this.dataGridViewComenzi.AllowUserToDeleteRows = false;
            this.dataGridViewComenzi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComenzi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComenzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridViewComenzi.Location = new System.Drawing.Point(34, 145);
            this.dataGridViewComenzi.Name = "dataGridViewComenzi";
            this.dataGridViewComenzi.ReadOnly = true;
            this.dataGridViewComenzi.RowHeadersWidth = 62;
            this.dataGridViewComenzi.RowTemplate.Height = 28;
            this.dataGridViewComenzi.Size = new System.Drawing.Size(965, 209);
            this.dataGridViewComenzi.TabIndex = 9;
            // 
            // textBoxCautaNumarComanda
            // 
            this.textBoxCautaNumarComanda.Location = new System.Drawing.Point(93, 79);
            this.textBoxCautaNumarComanda.Name = "textBoxCautaNumarComanda";
            this.textBoxCautaNumarComanda.Size = new System.Drawing.Size(336, 32);
            this.textBoxCautaNumarComanda.TabIndex = 8;
            // 
            // labelNumarComanda
            // 
            this.labelNumarComanda.AutoSize = true;
            this.labelNumarComanda.Location = new System.Drawing.Point(89, 53);
            this.labelNumarComanda.Name = "labelNumarComanda";
            this.labelNumarComanda.Size = new System.Drawing.Size(184, 23);
            this.labelNumarComanda.TabIndex = 7;
            this.labelNumarComanda.Text = "Numar Comanda";
            // 
            // labelCautaComanda
            // 
            this.labelCautaComanda.AutoSize = true;
            this.labelCautaComanda.Location = new System.Drawing.Point(6, 3);
            this.labelCautaComanda.Name = "labelCautaComanda";
            this.labelCautaComanda.Size = new System.Drawing.Size(181, 23);
            this.labelCautaComanda.TabIndex = 10;
            this.labelCautaComanda.Text = "Cauta Comanda";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Comanda_TipComanda";
            this.Column2.HeaderText = "Tip Comanda";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Comanda_Disponibilitate";
            this.Column1.HeaderText = "Stoc";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.Red;
            this.buttonSterge.Location = new System.Drawing.Point(865, 311);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(152, 56);
            this.buttonSterge.TabIndex = 31;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = false;
            // 
            // buttonActualizeaza
            // 
            this.buttonActualizeaza.BackColor = System.Drawing.Color.Green;
            this.buttonActualizeaza.Location = new System.Drawing.Point(865, 234);
            this.buttonActualizeaza.Name = "buttonActualizeaza";
            this.buttonActualizeaza.Size = new System.Drawing.Size(152, 56);
            this.buttonActualizeaza.TabIndex = 30;
            this.buttonActualizeaza.Text = "Actualizeaza";
            this.buttonActualizeaza.UseVisualStyleBackColor = false;
            // 
            // UserControlComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlComenzi);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlComenzi";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlComenzi_Load);
            this.tabControlComenzi.ResumeLayout(false);
            this.tabPageAdaugaComanda.ResumeLayout(false);
            this.tabPageAdaugaComanda.PerformLayout();
            this.tabPageCautaComanda.ResumeLayout(false);
            this.tabPageCautaComanda.PerformLayout();
            this.tabPageActualizeazaSiStergeComanda.ResumeLayout(false);
            this.tabPageActualizeazaSiStergeComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlComenzi;
        private System.Windows.Forms.TabPage tabPageAdaugaComanda;
        private System.Windows.Forms.TabPage tabPageCautaComanda;
        private System.Windows.Forms.TabPage tabPageActualizeazaSiStergeComanda;
        private System.Windows.Forms.TextBox textBox1NrComanda;
        private System.Windows.Forms.Label labelTipComanda;
        private System.Windows.Forms.Label label1NrComanda1;
        private System.Windows.Forms.Label labelStoc;
        private System.Windows.Forms.Label labelActualizeazaSiStergeComanda;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.RadioButton radioButtonIndisponibil;
        private System.Windows.Forms.RadioButton radioButtonInStoc;
        private System.Windows.Forms.ComboBox comboBoxTipComanda;
        private System.Windows.Forms.Label label2TipComanda;
        private System.Windows.Forms.Label label1AdaugaComanda;
        private System.Windows.Forms.Label label1Stoc;
        private System.Windows.Forms.TextBox textBox1NumarComanda;
        private System.Windows.Forms.Label labelNrComanda;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton radioButton2Indisponibil;
        private System.Windows.Forms.RadioButton radioButton1InStoc;
        private System.Windows.Forms.Button buttonAdaugaClient;
        private System.Windows.Forms.Label labelCautaComanda;
        private System.Windows.Forms.DataGridView dataGridViewComenzi;
        private System.Windows.Forms.TextBox textBoxCautaNumarComanda;
        private System.Windows.Forms.Label labelNumarComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonActualizeaza;
    }
}
