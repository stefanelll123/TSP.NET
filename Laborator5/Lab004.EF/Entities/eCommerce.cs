using System.ComponentModel.DataAnnotations.Schema;

namespace Lab004.EF.Entities
{
    [Table("eCommerce", Schema = "BazaDeDate")]
    public class ECommerce : Business
    {
        public string URL { get; set; }
    }

}
