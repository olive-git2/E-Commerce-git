using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Data
{
    public class Stock
    {
        #region
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        #endregion
    }
}
