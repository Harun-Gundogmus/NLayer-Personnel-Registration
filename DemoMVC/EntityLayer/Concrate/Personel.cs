using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Personel
    {
        [Key]
        public int personel_id { get; set; }
        [StringLength(50)]
        public string personel_name { get; set; }
        [StringLength(50)]
        public string personel_surname { get; set; }
        public int personel_age { get; set; }

    }
}
