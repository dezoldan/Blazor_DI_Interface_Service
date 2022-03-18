using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_DI_Interface_Service.Shared
{
    public class BaseTabela
    {
        [Comment("Para esse exemplo, essa tabela guarda o total de registros da base de dados.")]
        [Table("TblTotalBase")]
        public class TotalBaseDados
        {
            [Key]
            public int Id { get; set; }
            public int TotalBase { get; set; }
        }
    }
}
