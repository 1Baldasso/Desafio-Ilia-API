namespace Desafio_Ilia_API.AuxClasses
{
    public class RegistroDTO
    {
        public DateTime Dia { get; set; }

        public virtual List<Horario> Horarios { get; set; }
    }
}
