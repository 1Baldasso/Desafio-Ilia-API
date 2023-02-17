using Desafio_Ilia_API.AuxClasses;

namespace Desafio_Ilia_API.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public TimeSpan HorasTrabalhadas { get; set; }
        public TimeSpan HorasExcedentes { get; set; }
        public TimeSpan HorasDevidas { get; set; }
        public virtual List<Registro> Registros { get; set; }
        public virtual List<Alocacao> Alocacoes { get; set; }

    }
}
