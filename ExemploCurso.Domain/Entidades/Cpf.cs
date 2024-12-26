namespace ExemploCurso.Domain.Entidades
{
    public class Cpf
    {
        public string Value { get; set; }


        public bool IsValid()
        {
            return Value.Length == 11;
        }
    }
}