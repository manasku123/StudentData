using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class Marksheet
    {
        public int MarksheetId { get; set; }
        public int StudentId { get; set;}
        public string? Subject { get; set; }
        public int TotalMark { get; set; }
        public int Markobtained {  get; set; }

        public static int FindIndex(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
