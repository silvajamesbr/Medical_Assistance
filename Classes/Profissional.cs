using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Assistance.Classes
{
    public class Profissional
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), NotNull]
        public string NomeCompleto { get; set; } = string.Empty;

        [MaxLength(150), NotNull]
        public string Formacao { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Especialidade { get; set; } = string.Empty;

        [MaxLength(50), NotNull]
        public string NumeroCredenciamento { get; set; } = string.Empty;
    }

}
