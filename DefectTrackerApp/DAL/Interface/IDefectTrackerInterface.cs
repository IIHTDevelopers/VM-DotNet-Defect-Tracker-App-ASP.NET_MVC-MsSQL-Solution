using DefectTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefectTrackerApp.DAL.Interface
{
    public interface IDefectTrackerInterface 
    {
        IEnumerable<Defect> GetDefects();
        Defect GetDefectByID(int DefectId);
        Defect InsertDefect(Defect Defect);
        int DeleteDefect(int DefectId);
        bool UpdateDefect(Defect Defect);
        void Save();
    }
}