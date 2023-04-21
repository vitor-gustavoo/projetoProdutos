using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Views;

public class ListaProduto : Form 
{
    private ListView listView;
    private ListBox listBox;

    private ListViewItem listViewItem;
    private Button btnAlterar;
    private Button btnDelete;
    private Button btnSair;
    private Button btnInserir;
    



    public ListaProduto()
    {

        Size = new Size(700,700);
        this.Text  = "Lista de Produtos";
        this.StartPosition = FormStartPosition.CenterScreen;

        listView = new ListView();
        listView.Location = new Point(10,20);
        listView.Size = new Size(660, 550);
        listView.View = View.Details;
        listView.FullRowSelect = true;

        listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
        listView.Columns.Add("Produto", -2, HorizontalAlignment.Left);
        listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);

        this.Controls.Add(listView);
        this.LoadList();


        btnInserir = new Button();
        btnInserir.Text = "Inserir";
        btnInserir.Location = new Point(100, 600);
        btnInserir.Size =new Size(80, 30);
        btnInserir.Click += new EventHandler(btnInserir_Click);
        this.Controls.Add(btnInserir);

        btnAlterar = new Button();
        btnAlterar.Text = "Alterar";
        btnAlterar.Location = new Point(200, 600);
        btnAlterar.Size =new Size(80, 30);
        //btnAlterar.Click += new EventHandler(btnAlterar_Click); Fazer a regra do botão
        this.Controls.Add(btnAlterar);

        btnDelete = new Button();
        btnDelete.Text = "Deletar";
        btnDelete.Location = new Point(300, 600);
        btnDelete.Size =new Size(80, 30);
        //btnDelete.Click += new EventHandler(btnDelete_Click); Fazer a regra do botão
        this.Controls.Add(btnDelete);

        btnSair = new Button();
        btnSair.Text = "Sair";
        btnSair.Location = new Point(400, 600);
        btnSair.Size =new Size(80, 30);
        btnSair.Click += (sender, e) => {
        this.Close();
        };
        this.Controls.Add(btnSair);

       

    }

    private void LoadList() {
        /*
            listView.Items.Clear();
            foreach(Models.Produto p in Controller.Produto.GetLista()) {

                listView.Items.Add(
                    new ListViewItem(new [] { 
                        p.Id.ToString(), p.Nome, p.Preco.ToString()
                    })
                )
            }
        */
    }

    private void btnSair_Click(object sender, EventArgs e)
    { 
        this.Close();

    }

    private void btnInserir_Click(object sender, EventArgs e)
    {
        Produto produto = new Produto();
        produto.ShowDialog();
        this.LoadList();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        //Realizar a lógica 
     
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        //Realizar a lógica

        Confirmacao confirmacao = new Confirmacao();
        confirmacao.Show();
        
    }

    
}










