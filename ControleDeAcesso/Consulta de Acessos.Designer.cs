namespace ControleDeAcesso
{
    partial class Consulta_de_Acessos
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            Nome = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            TipoOp = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            Saída = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Data, TipoOp, Entrada, Saída });
            dataGridView1.Location = new Point(79, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(502, 183);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 42);
            label1.Name = "label1";
            label1.Size = new Size(294, 40);
            label1.TabIndex = 2;
            label1.Text = "Consulta de Acessos";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_pesquisar_30;
            button1.Location = new Point(543, 86);
            button1.Name = "button1";
            button1.Size = new Size(38, 32);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // TipoOp
            // 
            TipoOp.HeaderText = "TipoOp";
            TipoOp.Name = "TipoOp";
            // 
            // Entrada
            // 
            Entrada.HeaderText = "Entrada";
            Entrada.Name = "Entrada";
            // 
            // Saída
            // 
            Saída.HeaderText = "Saída";
            Saída.Name = "Saída";
            // 
            // Consulta_de_Acessos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Consulta_de_Acessos";
            Text = "Consulta_de_Acessos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Button button1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn TipoOp;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Saída;
    }
}