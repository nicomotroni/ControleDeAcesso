namespace ControleDeAcesso
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tipousuario = new DomainUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 266);
            button1.Name = "button1";
            button1.Size = new Size(151, 27);
            button1.TabIndex = 0;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(421, 299);
            button2.Name = "button2";
            button2.Size = new Size(152, 28);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(421, 333);
            button3.Name = "button3";
            button3.Size = new Size(160, 24);
            button3.TabIndex = 2;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "CPF --- --- --- --";
            // 
            // tipousuario
            // 
            tipousuario.Location = new Point(56, 158);
            tipousuario.Name = "tipousuario";
            tipousuario.Size = new Size(329, 23);
            tipousuario.TabIndex = 8;
            tipousuario.Text = "Tipo Usuario";
            tipousuario.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuário_80;
            pictureBox1.Location = new Point(463, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 81);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(639, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tipousuario);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DomainUpDown tipousuario;
        private PictureBox pictureBox1;
    }
}
