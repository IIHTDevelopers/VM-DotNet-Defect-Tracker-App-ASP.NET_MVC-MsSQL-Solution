using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefectTrackerApp.DAL.Repository
{
    public class DefectTrackerService : IDefectTrackerInterface
    {
        private IDefectTrackerRepository _repo;
        public DefectTrackerService(IDefectTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteDefect(int DefectId)
        {
            var res= _repo.DeleteDefect(DefectId);
            return res;
        }

        public Defect GetDefectByID(int DefectId)
        {
            return _repo.GetDefectByID(DefectId);
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<Defect> IDefectTrackerInterface.GetDefects()
        {
            return _repo.GetDefects();
        }

        Defect IDefectTrackerInterface.InsertDefect(Defect Defect)
        {
            return _repo.InsertDefect(Defect);
        }

        bool IDefectTrackerInterface.UpdateDefect(Defect Defect)
        {
            return _repo.UpdateDefect(Defect);
        }
    }
}