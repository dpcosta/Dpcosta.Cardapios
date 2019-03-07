namespace Dpcosta.Cardapios.Core
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Receita Receita { get; set; }
    }
}
