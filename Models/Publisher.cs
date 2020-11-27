using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rusu_Maria_Smaranda_Lab8.Models
{
    public class Publisher
    { // cand o entit Book are o entit relationata Publisher fiecare va avea o refer catre cealalta in navig prop
        
        public int ID { get; set; }  //cheie straina pt entit Book
                                     //Entit Frm identif automat cheia primara daca ac are den ID sau numeclasaID
        public string PublisherName { get; set; }
        public ICollection<Book> Books { get; set; }  //navigation prop
    }
}
