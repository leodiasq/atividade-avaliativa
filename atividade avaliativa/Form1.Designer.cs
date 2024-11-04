using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AtividadeAvaliativa
{
    partial class Form1
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            buttonCreate = new Button();
            comboBoxItems = new ComboBox();
            buttonRead = new Button();
            buttonUpdate = new Button();
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            buttonDelete = new Button();
            SuspendLayout();

            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(237, 254);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(79, 34);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Criar";
            buttonCreate.UseVisualStyleBackColor = true;

            // 
            // comboBoxItems
            // 
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(237, 209);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(409, 23);
            comboBoxItems.TabIndex = 1;

            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(352, 254);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(79, 34);
            buttonRead.TabIndex = 2;
            buttonRead.Text = "Ler";
            buttonRead.UseVisualStyleBackColor = true;

            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(461, 254);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(79, 34);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Atualizar";
            buttonUpdate.UseVisualStyleBackColor = true;

            // 
            // textBoxInput1
            // 
            textBoxInput1.Location = new Point(237, 167);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(409, 23);
            textBoxInput1.TabIndex = 4;

            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(237, 126);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(409, 23);
            textBoxInput2.TabIndex = 5;

            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(567, 254);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(79, 34);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Apagar";
            buttonDelete.UseVisualStyleBackColor = true;

           
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        // Declare UI components
        private Button buttonCreate;
        private ComboBox comboBoxItems;
        private Button buttonRead;
        private Button buttonUpdate;
        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private Button buttonDelete;

        public Size ClientSize { get; private set; }
    }
}
