using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Assistance.Classes
{
    public class Servicos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(200), NotNull]
        public string TipodeServico { get; set; } = string.Empty;

        [MaxLength(10), NotNull]
        public bool Pago { get; set; }

        [MaxLength(50)]
        public decimal Valor { get; set; }

    }
}
