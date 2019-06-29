using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_1.Models
{

    public class Outfit
    {
        private string headdress;
        private bool glasses;
        private string top;
        private string bottom;
        private bool belt;
        private bool socks;
        private string shoes;

        public string HeadDress {get; set;}
        public bool Glasses { get; set; }
        public string Top { get; set; }
        public string Bottom { get; set; }
        public bool Belt { get; set; }
        public bool Socks { get; set; }
        public string Shoes { get; set; }

        //public Outfit(string headdress, bool glasses, string top, string bottom, bool socks, bool belt, string shoes)
        //{
        //    HeadDress = headdress;
        //    Glasses = glasses;
        //    Top = top;
        //    Bottom = bottom;
        //    Belt = belt;
        //    Socks = socks;
        //    Shoes = shoes;
        //}



    }
}