using SQLite;

namespace Medical_Assistance.Classes
{
    public class Paciente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), NotNull]
        public string NomeCompleto { get; set; } = string.Empty;

        [MaxLength(11), Unique, NotNull]
        public string CPF { get; set; } = string.Empty;

        [NotNull]
        public DateTime DataNascimento { get; set; }

        [NotNull, MaxLength(10)]
        public string Sexo { get; set; }

        [MaxLength(200)]
        public string Rua { get; set; } = string.Empty;

        public string Numero { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Cidade { get; set; } = string.Empty;

        [NotNull, MaxLength(100)]
        public string Estado { get; set; }

        [MaxLength(20), NotNull]
        public string Telefone { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(200), NotNull]
        public string Complemento { get; set; } = string.Empty;

        [MaxLength(8), NotNull]
        public string CEP { get; set; } = string.Empty;
        public byte[] FotoPerfil { get; set; }
    }
}
