using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefectTrackerApp.Models
{
    public class Defect
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DefectName { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }
    }

}