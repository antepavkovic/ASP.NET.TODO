using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.TODO.Models
{
    public class Todo
    {

        public int ID { get; set; }
        [DisplayName("Naziv zadatka")]
        public string Naziv { get; set; }
        [DisplayName("Rok ili datum zadatka")]
        [DataType(DataType.Date)]
        public DateTime Rok { get; set; }

    }
}
