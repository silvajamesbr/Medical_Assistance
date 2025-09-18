using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Assistance.Classes
{
    public class Estagiario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), NotNull]
        public string NomeCompleto { get; set; } = string.Empty;

        [MaxLength(150), NotNull]
        public string Curso { get; set; } = string.Empty;

        [MaxLength(50), NotNull]
        public string NumeroMatricula { get; set; } = string.Empty;

        [MaxLength(15), NotNull]
        public string Telefone { get; set; } = string.Empty;

        [MaxLength(150), NotNull]
        public string Email { get; set; } = string.Empty;
    }

}
