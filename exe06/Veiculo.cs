namespace exe06{
// 6.	Implemente uma hierarquia de classes para representar diferentes tipos de veículos, como carros, motos e bicicletas. Cada classe deve herdar da classe base Veiculo. Adicione atributos específicos para cada tipo de veículo, como número de portas para carros, cilindrada para motos e número de marchas para bicicletas.
    public abstract class Veiculo{
        public string marca {get;set;}
        public string modelo {get;set;}
        public string dtFabricacao {get;set;}
    }

}