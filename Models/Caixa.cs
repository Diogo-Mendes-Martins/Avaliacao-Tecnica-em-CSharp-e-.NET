namespace LojaDoSrManoel.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
    }
}
