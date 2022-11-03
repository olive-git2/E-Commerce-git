using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Data
{
    public class Panier
    {
        #region Propriétés

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id;

        User userId;
        public int PrixTotal { get; set; }
        public ICollection<Article> Contenu { get; set; } = new List<Article>();
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        #endregion



        #region Méthodes

        public void AddProductToCart(List<Article> articles)
        {
            foreach(var item in articles)
            {
                this.Contenu.Add(item);

                this.PrixTotal += item.Prix;
            }
        }

        public void RemoveProductFromCart(List<Article> articles)
        {
            foreach (var item in articles)
            {
                this.Contenu.Remove(item);

                this.PrixTotal -= item.Prix;
            }
        }
        #endregion

    }
}
