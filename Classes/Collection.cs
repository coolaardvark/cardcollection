using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardCollection.Classes
{
    class Collection
    {
        public Collection()
        {
            name = "";
            issuer = "";
            // A string to avoid having the year show as 0 by default
            issueYear = "";
            serialNumber = "";
            cards = 0;
            albums = 0;
            lose = 0;
            odds = new List<int>();
            notes = "";
            brokeBond = false;
        }

        public string name
        {
            get; set; 
        }

        public string issuer
        {
            get; set;
        }

        public string issueYear
        {
            get; set;
        }

        public string serialNumber
        {
            get; set;
        }

        public int cards
        {
            get; set;
        }

        public int albums
        {
            get; set;
        }

        public int lose
        {
            get; set;
        }

        public List<int> odds
        {
            get; set;
        }

        public string notes
        {
            get; set;
        }

        public Boolean brokeBond
        {
            get; set;
        }
    }
}
