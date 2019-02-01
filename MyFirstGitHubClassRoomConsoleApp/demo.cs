using System;
using System.Security.AccessControl;

namespace MyFirstGitHubClassRoomConsoleApp
{
    public class demo
    {
        private string _navn;
        private int _alder;


        public demo(string Navn, int Alder)
        {
            _navn = Navn;
            _alder = Alder;
            
        }
        public string Navn
        {
            get { return _navn; }
        }

        public int Alder
        {
            get { return _alder; }
        }

        public void Print()
        {
            Console.WriteLine($"Mit navn er {Navn} og jeg er {Alder} år gammel.");
        }

    }


}