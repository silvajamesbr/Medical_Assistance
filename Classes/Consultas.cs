using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Medical_Assistance.Classes
{
    public class Consultas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(200), NotNull]
        public string Data { get; set; } = string.Empty;
        [MaxLength(200), NotNull]
        public string Hora { get; set; } = string.Empty;
        [MaxLength(200), NotNull]
        public string Descricao { get; set; } = string.Empty;
        [MaxLength(500), NotNull]
        public int PacienteId { get; set; }
        [MaxLength(200), NotNull]
        public int ProfissionalId { get; set; }
        [MaxLength(200), NotNull]
        public int EstagiarioId { get; set; }
        [MaxLength(200)]
        public int ConsultorioId { get; set; }
        [MaxLength(200), NotNull]
        public int ServicoId { get; set; }
        [MaxLength(200), NotNull]
        public string Status { get; set; } = string.Empty;
    }
}
