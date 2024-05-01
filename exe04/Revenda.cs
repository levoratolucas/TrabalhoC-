namespace exe04{
public class Revenda
{
    public string fornecedor;
    public bool setProduto(IProduto produto)
    {
        if(produto.autenticador(fornecedor) == true){
            return true;
        }else{
            return false;
        }          
    }

    public int gerador(int num){
        return num +10;
    }
    public string gerador(string num){
        return num + " dez";
    }
}
}