using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Answer
    {
        public int Id { get; set; }
        public string Respuesta { get; set; }
        public bool is_correct { get; set; }
        public int Pregunta_Id { get; set; }
    }
}
