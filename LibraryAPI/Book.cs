using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Book
    {
        #region Properties
        /// <summary>
        /// ISBN of the book
        /// </summary>
        [Key]
        public int ISBN { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int count { get; set; }
        [ForeignKey("Author")]
        public int AuthorID { get; set; } // we explicitely create the column. we can now access this column in future. 
        public virtual Author Author { get; set; } //to create a relationship. entity framework creates it but its hidden and u will not be able to access it.
        #endregion

        #region Methods
        public void Checkout()
        {
            count = count - 1;
        }
        public void Return()
        {
            count++;
        }
        #endregion
    }
}
