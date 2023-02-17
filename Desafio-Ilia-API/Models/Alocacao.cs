namespace Desafio_Ilia_API.Models
{
    public class Alocacao
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Tempo { get; set; }
        public string NomeDoProjeto { get; set; }
    }
}
