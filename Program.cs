using System;
using System.Data.SqlTypes;
using exe04;
using exe05;
using exe06;
using exe07;
using exe08;
using exe09;
using exe10;

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

        // verificação do exercicio 8
        // CursoEspanhol curso = new CursoEspanhol("Full programação",2);
        // curso.frequencia=80;
        // Console.WriteLine(curso.apto());

        // verificação do exercicio 9
        // ContaV conta = new ContaV();
        // conta.valor = 1000;
        // PagamentoTransferencia pagamento = new PagamentoTransferencia();        
        // pagamento.saldoContaBancaria = 1200;
        // pagamento.autenticador("123");
        // Console.WriteLine(conta.cobrar(pagamento));
        // Console.WriteLine(pagamento.saldoContaBancaria);

        // verificação do exercicio 10
        string[] datas = new string[] { "10", "09", "8" };
        string[] origens = new string[] { "curitiba", "salvador" };
        string[] destinos = new string[] { "curitiba", "salvador" };
        Companhia companhia = new Companhia(origens, destinos, datas);
        ReservaRegular reserva = new ReservaRegular();
        string msg;
        msg = companhia.registrarReserva(reserva, "10", "curitiba", "salvador");
        Console.WriteLine(msg);
        
    }
}

