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

        [Required, StringLength(150, MinimumLength = 3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$"), 
            ErrorMessage= "Numele autorului trebuie sa fie de forma 'Prenume Nume'", 
            Required, 
            StringLength(50, MinimumLength = 3)]
        //^ marcheaza inceputul sirului de caractere
        //[A-Z][a-z]+ prenumele -litera mare urmata de oricate litere mici
        //\s spatiu
        //[A-Z][a-z]+ numele- litera mare urmata de oricate litere mici
        //$ marcheaza sfarsitul sirului de caractere

        public string Author { get; set; }



        //Adnotarea [Column(TypeName = "decimal(6, 2)")] permite Entity Framework Core sa mapeze corect
        //proprietatea price Price , pemitand valori cu doua zecimale
        //Atributul Display specifica modul in care dorim sa afisam numele unui camp.

        [Range(1, 300)]

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navig prop

        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
