using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Data
{
    public class Ventes
    {

        #region Propriétés
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        #endregion
    }
}
