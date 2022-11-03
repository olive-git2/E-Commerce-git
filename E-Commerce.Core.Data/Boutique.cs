using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Data
{
    public class Boutique
    {
        #region Propriétés
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        public string Name { get; set; }
        Ville Adresse { get; set; }
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(50)]
        public string Email { get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        #endregion

    }
}
