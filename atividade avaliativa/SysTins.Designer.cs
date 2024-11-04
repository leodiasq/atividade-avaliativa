using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static atividade_avaliativa.desafio_Classe.Class1;

public class FormProduto : Form
{
    // Componentes do formulário
    private TextBox txtNome, txtPreco, txtEstoque;
    private Button btnSalvar, btnListar;
    private DataGridView dgvProdutos;

    public FormProduto()
    {
        InitializeComponents();
        ConfigureLayout();
        this.Size = new Size(800, 600);
    }

    private void InitializeComponents()
    {
        txtNome = new TextBox { PlaceholderText = "Nome do Produto" };
        txtPreco = new TextBox { PlaceholderText = "Preço" };
        txtEstoque = new TextBox { PlaceholderText = "Estoque" };
        btnSalvar = new Button { Text = "Salvar" };
        btnListar = new Button { Text = "Listar" };
        dgvProdutos = new DataGridView { AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };

        // Adicionar eventos
        btnSalvar.Click += BtnSalvar_Click;
        btnListar.Click += BtnListar_Click;
    }

    private void ConfigureLayout()
    {
        FlowLayoutPanel layout = new FlowLayoutPanel();
        layout.Controls.Add(txtNome);
        layout.Controls.Add(txtPreco);
        layout.Controls.Add(txtEstoque);
        layout.Controls.Add(btnSalvar);
        layout.Controls.Add(btnListar);
        layout.Controls.Add(dgvProdutos);
        Controls.Add(layout);
    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        if (ValidateInputs(out string message))
        {
            Produto produto = new Produto
            {
                Nome = txtNome.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Estoque = int.Parse(txtEstoque.Text)
            };

            try
            {
                produto.Inserir(produto);
                MessageBox.Show("Produto salvo com sucesso!");
                ClearInputs();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Erro ao salvar produto: {ex.Message}");
            }
        }
        else
        {
            ShowErrorMessage(message);
        }
    }

    private void BtnListar_Click(object sender, EventArgs e)
    {
        try
        {
            List<Produto> produtos = new Produto().Listar();
            dgvProdutos.DataSource = produtos;
        }
        catch (Exception ex)
        {
            ShowErrorMessage($"Erro ao listar produtos: {ex.Message}");
        }
    }

    private bool ValidateInputs(out string message)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text))
        {
            message = "O nome do produto é obrigatório.";
            return false;
        }

        if (!decimal.TryParse(txtPreco.Text, out _))
        {
            message = "Por favor, insira um preço válido.";
            return false;
        }

        if (!int.TryParse(txtEstoque.Text, out _))
        {
            message = "Por favor, insira um estoque válido.";
            return false;
        }

        message = string.Empty;
        return true;
    }

    private void ClearInputs()
    {
        txtNome.Clear();
        txtPreco.Clear();
        txtEstoque.Clear();
    }

    private void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
