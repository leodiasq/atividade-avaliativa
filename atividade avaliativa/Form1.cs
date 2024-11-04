namespace atividade_avaliativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(197, 325);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 0;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(578, 325);
            button4.Name = "button4";
            button4.Size = new Size(121, 40);
            button4.TabIndex = 3;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(405, 325);
            button5.Name = "button5";
            button5.Size = new Size(121, 40);
            button5.TabIndex = 4;
            button5.Text = "Ler";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(405, 403);
            button6.Name = "button6";
            button6.Size = new Size(121, 40);
            button6.TabIndex = 5;
            button6.Text = "Deletar";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(502, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 212);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(502, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 154);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(502, 31);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            ClientSize = new Size(931, 516);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
