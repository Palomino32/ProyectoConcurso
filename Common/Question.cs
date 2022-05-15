using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Question
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int Nivel_Id { get; set; }
        public decimal Premio { get; set; }
    }
}
