using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Dataannotations sunt clase atribut care se regasesc in namespace-ul System.ComponentModel.
//DataAnnotations pe care le putem utiliza pentru a seta constrangeri sau valori predefinite.
namespace Rusu_Maria_Smaranda_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }


        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        //Adnotarea [Column(TypeName = "decimal(6, 2)")] permite Entity Framework Core sa mapeze corect
        //proprietatea price Price , pemitand valori cu doua zecimale
        //Atributul Display specifica modul in care dorim sa afisam numele unui camp.


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navig prop

        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
