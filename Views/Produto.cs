using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;



public class Produto : Form
{
    private Label lblProduto;
    private Label lblNome;
    private Label lblPreco;
    private Label lblCancel;
    private Label lblConfirm;

    private TextBox txtNome;
    private TextBox txtPreco;

    private Button btnCancel;
    private Button btnConfirm;

    
    public Produto()
    {
        Size = new Size(600,500);

        this.Text = "Produto";

        lblProduto = new Label();
        lblProduto.Text = "Cadastro de Produto";
        lblProduto.Location = new Point(170,50);
        lblProduto.Size = new Size(350,20);
        this.StartPosition = FormStartPosition.CenterScreen;
        lblProduto.Font = new Font("Arial", 14, FontStyle.Bold);
        this.Controls.Add(lblProduto);

        

        lblNome = new Label();
        lblNome.Text = "Nome";
        lblNome.Location = new Point(150,100);
        lblNome.Size = new Size(50,20);
        lblNome.Font = new Font("Arial", 10, FontStyle.Regular);
        this.Controls.Add(lblNome);

        txtNome = new TextBox();
        txtNome.Location = new Point (150,120);
        txtNome.Size = new Size(250,40);
        txtNome.Font = new Font("Arial", 10, FontStyle.Regular);
        this.Controls.Add(txtNome);




        lblPreco = new Label();
        lblPreco.Text  = "Preço";
        lblPreco.Location = new Point(150,180);
        lblPreco.Size = new Size(50, 20);
        lblPreco.Font = new Font("Arial", 10, FontStyle.Regular);
        this.Controls.Add(lblPreco);


        txtPreco = new TextBox();
        txtPreco.PlaceholderText = "R$";
        txtPreco.Location = new Point(150,200);
        txtPreco.Size = new Size(250,40);
        txtPreco.Font = new Font("Arial",10, FontStyle.Regular);
        this.Controls.Add(txtPreco);


        btnConfirm = new Button();
        btnConfirm.Text = "Confirmar";
        btnConfirm.Location = new Point(450, 340);
        btnConfirm.Size = new Size(80, 30);
        //btnConfirm.Click += new EventHandler(); falta o evento de confirmar
        this.Controls.Add(btnConfirm);

        btnCancel = new Button();
        btnCancel.Text = "Cancelar";
        btnCancel.Location = new Point(350, 340);
        btnCancel.Size =new Size(80, 30);
        btnCancel.Click += new EventHandler(btnCancel_Click);
        this.Controls.Add(btnCancel);


        

        
    }


    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
