using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Data
{
    public class Commande
    {
        #region Propriétés
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;
        User userId;
        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public int Total { get; set; }
        public bool Reglee { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        #endregion
    }
}
