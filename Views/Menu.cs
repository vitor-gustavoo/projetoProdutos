using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Views;

public class Menu : Form
{
    private Label lblTitulo;
    private Button btnProduto;
    private Button btnSair;

  

    public Menu()
    {

        Size = new Size(400,300);

        this.Text = "Menu";

        lblTitulo = new Label();
        lblTitulo.Text = "Menu";
        lblTitulo.Location = new Point(160,20);
        lblTitulo.Size = new Size(80,20);
        lblTitulo.Font = new Font("Arial", 14, FontStyle.Bold);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(lblTitulo);

        
        btnProduto = new Button();
        btnProduto.Text = "Produto";
        btnProduto.Location = new Point(130, 80);
        btnProduto.Size = new Size(120, 30);
        btnProduto.Click += new EventHandler(btnProduto_Click);
        this.Controls.Add(btnProduto);

        btnSair = new Button();
        btnSair.Text = "Sair";
        btnSair.Location = new Point(130, 120);
        btnSair.Size =new Size(120, 30);
        btnSair.Click += new EventHandler(btnSair_Click);
        this.Controls.Add(btnSair);
        
    }


    private void btnSair_Click(object sender, EventArgs e)
    {   
        
        Application.Exit();
        this.Close();
    }

    private void btnProduto_Click(object sender, EventArgs e)
    {
        ListaProduto lista = new ListaProduto();
        lista.Show();
        this.Close();
    }
}
