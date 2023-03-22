using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Shift
    {
        private int Id;
        private int emplId;
        private ShiftType shiftType;
        private DateTime date;
        public string GetShift()
        {
            return $"{Id}";
        }
    }
}
