namespace EstudoSOLID.Dominio.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string CPF { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
    }
}
