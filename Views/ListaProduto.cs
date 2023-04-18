using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;



public class ListaProduto : Form 
{
    private ListView listView;
    private ListBox listBox;

    private ListViewItem listViewItem;
    private Button btnAlter;
    private Button btnDelete;
    private Button btnSair;
    private Button btnAdd;
    



    public ListaProduto()
    {

        Size = new Size(700,700);
        this.Text  = "Lista de Produtos";

        // listBox = new ListBox();
        // listBox.Location = new Point(10, 10);
        // listBox.Size = new Size(650,600);
        // listBox.Items.Add("Kill Bill");
        // listBox.Items.Add("Rei Leão");
        // listBox.Items.Add("Coringa");
        // this.Controls.Add(listBox);


        listView = new ListView();
        listView.Location = new Point(10,20);
        listView.Size = new Size(660, 550);
        listView.View = View.Details;

        listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
        listView.Columns.Add("Produto", -2, HorizontalAlignment.Left);
        listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);

        this.Controls.Add(listView);


        btnAdd = new Button();
        btnAdd.Text = "Inserir";
        btnAdd.Location = new Point(100, 600);
        btnAdd.Size =new Size(80, 30);
        //btnAdd.Click += new EventHandler(btnAdd_Click);
        this.Controls.Add(btnAdd);

        btnAlter = new Button();
        btnAlter.Text = "Alterar";
        btnAlter.Location = new Point(200, 600);
        btnAlter.Size =new Size(80, 30);
        //btnAlter.Click += new EventHandler(btnAlter_Click);
        this.Controls.Add(btnAlter);

        btnDelete = new Button();
        btnDelete.Text = "Deletar";
        btnDelete.Location = new Point(300, 600);
        btnDelete.Size =new Size(80, 30);
        //btnDelete.Click += new EventHandler(btnDelete_Click);
        this.Controls.Add(btnDelete);

        btnSair = new Button();
        btnSair.Text = "Sair";
        btnSair.Location = new Point(400, 600);
        btnSair.Size =new Size(80, 30);
        btnSair.Click += new EventHandler(btnSair_Click);
        this.Controls.Add(btnSair);

       

    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        this.Close();
    }



    
}










