using System;
using exe04;
using exe05;
using exe06;
using exe07;
using exe08;

class Program
{
    static void Main()
    {   
        // verificação do exercicio 4
        // Revenda revenda = new Revenda();
        // revenda.fornecedor = "ambev";
        // Produto coca = new Produto();
        // coca.adicionar(10);
        // coca.remover(-8);
        // coca.adicionar(-10);
        // coca.preco = 10.2;
        // coca.fornecedor ="ambev";
        // Console.WriteLine(revenda.setProduto(coca));
        // Console.WriteLine(coca.quantidadeEmEstoque);
        // Console.WriteLine(coca.calcularValorTotal());


        // verificação do exercicio 5
        // Locadora locadora = new Locadora();
        // Filme filme = new Filme();
        // filme.Titulo = "aulas de c#";
        // locadora.addFilme(filme);
        // filme = new Filme();
        // filme.Titulo = "aulas de java";
        // locadora.addFilme(filme);
        // Filme filme1 = locadora.GetFilme("aulas de java");
        // Console.WriteLine(locadora.verificar(filme1));

        // verificação do exercicio 6
        // Moto moto = new Moto();
        // moto.cilindrada=150;
        // moto.marca="honda";
        // moto.dtFabricacao="2024-03";
        // Console.WriteLine(moto.cilindrada);

        // verificação do exercicio 7
        // Empresa empresa = new Empresa("001.234.567.89");
        // ContaEmpresarial contaEmpresarial = new ContaEmpresarial(empresa,123456,134567);
        // contaEmpresarial.numeroConta=123456;
        // Console.WriteLine(contaEmpresarial.saldo);

    }
}

// 4.	Crie uma classe Produto que represente um produto em uma loja online. A classe deve ter os seguintes atributos: Nome, Preco, QuantidadeEmEstoque. Implemente métodos para adicionar e remover unidades do estoque, e um método para calcular o valor total do produto em estoque. Os métodos devem alterar o estado do objeto instanciado