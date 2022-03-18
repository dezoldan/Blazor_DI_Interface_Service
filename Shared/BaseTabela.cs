using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_DI_Interface_Service.Shared
{
    public class BaseTabela
    {

        [Table("TblTotalBase")]
        public class TotalBaseDaddos
        {
            [Key]
            public int Id { get; set; }
            public int TotalBase { get; set; }
        }
    }
}
