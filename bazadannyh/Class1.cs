using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace база_данных_курсовая
{
    class Class1
    {
        public string s;
        public string номер_ГОСТА;
        public string название;
        public int год_издания;
        public int ID;
        public List<string> тег;
        public Class1()
        {
            this.номер_ГОСТА = "пусто";
            this.название = "пусто";
            this.год_издания = 0;
        }
        public Class1(int ID,string номер_ГОСТА, string название, int год_издания,List<string> тег)
        {
            this.ID = ID;
            this.номер_ГОСТА = номер_ГОСТА;
            this.название = название;
            this.год_издания = год_издания;
            this.тег = тег;
        }
        public string Номер_ГОСТА
        {
            get { return номер_ГОСТА; }
            set { номер_ГОСТА = value; }
        }
        public string Название
        {
            get { return название; }
            set { название = value; }
        }
        public int Год_издания
        {
            get { return год_издания; }
            set { год_издания = value; }
        }
    }
}
