using System;
using System.Collections.Generic;
using System.Text;

namespace library.cs
{
    public class book
    {
        private string password = " secret";

    }

    public class book1
    {
        internal int copiesInStock = 5;
    }

    public class book2
    {
        public string title;
    }

      enum EGenre 
    { 
        Fiction, NonFiction, Science 
    };

     class book3
    {
        
        public EGenre Genre {  get; set; }
    }

}
