using Desafio_Ilia_API.AuxClasses;

namespace Desafio_Ilia_API.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }

        public virtual List<Horario> Horarios { get; set; }

    }
}
