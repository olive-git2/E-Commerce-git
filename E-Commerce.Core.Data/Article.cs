using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Core.Data
{
    public class Article
    {

        #region Propriétés
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;
        public string Title { get; set; }
        public string Description { get; set; }
        public int Prix { get; set; }
        Categorie categorie { get; set; }
        Marque Marque { get; set; }
        Fournisseur Fournisseur { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        #endregion
    }
}