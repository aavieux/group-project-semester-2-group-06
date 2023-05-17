using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain
{
    public class Shift
    {
        public int Id;
        public int emplId;
        public ShiftType shiftType { get; set; }
        public DateTime date { get; set; }

        public Shift(ShiftType shiftType, DateTime date, int empid)
        {
            this.shiftType = shiftType;
            this.date = date;
            this.emplId = empid;
        }
        public string GetShiftId()
        {
            return $"{Id}";
        }
        public string GetInfo()
        {
            return $"Employee ID: {emplId} | Shift Type: {shiftType} | Date: {date}";
        }
    }
}
