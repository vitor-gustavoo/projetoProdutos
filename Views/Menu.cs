using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;



public class Menu : Form
{
    private Label lblMenu;
    private Button btnProduto;
    private Button btnSair;

    
    public Menu()
    {
        Size = new Size(400,300);

        this.Text = "Menu";

        lblMenu = new Label();
        lblMenu.Text = "Menu";
        lblMenu.Location = new Point(160,20);
        lblMenu.Size = new Size(80,20);
        lblMenu.Font = new Font("Arial", 14, FontStyle.Bold);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Controls.Add(lblMenu);

        
        btnProduto = new Button();
        btnProduto.Text = "Produto";
        btnProduto.Location = new Point(130, 80);
        btnProduto.Size = new Size(120, 30);
        //btnConfirm.Click += new EventHandler(); falta o evento de confirmar
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
        this.Close();
    }
}
