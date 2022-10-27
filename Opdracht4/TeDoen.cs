using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Opdracht4
{
    internal class TeDoen
    {
        public int id = 0;

        private int Id
        {
            get { id++; return id; }
            set { id = value; }
        }

        public DateTime? tijdStip;

        public string titel { get; set; }
        public string[] informatie { get; set; }

        public TeDoen(DateTime? tijdStip, string titel, string[] informatie)
        {
            this.titel = titel;
            this.informatie = informatie;

            if (tijdStip == DateTime.MinValue)
            {
                tijdStip = null;
            }
        }

        public override string ToString()
        {
            string textbox = " ";
            foreach (string info in informatie)
            {
                textbox = info.ToString() +  "\n";
            }
            return textbox;
        }
    }
}