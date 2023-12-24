using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DefectTrackerApp.DAL.Repository
{
    public class DefectTrackerRepository : IDefectTrackerRepository
    {
        private DefectTrackerDbContext _context;
        public DefectTrackerRepository(DefectTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Defect> GetDefects()
        {
             return _context.Defects.ToList();
        }
        public Defect GetDefectByID(int id)
        {
            return _context.Defects.Find(id);
        }
        public Defect InsertDefect(Defect Defect)
        {
            return _context.Defects.Add(Defect);
        }
        public int DeleteDefect(int DefectID)
        {
            Defect Defect = _context.Defects.Find(DefectID);
            var res= _context.Defects.Remove(Defect);
            return res.Id;
        }
        public bool UpdateDefect(Defect Defect)
        {
            var res= _context.Entry(Defect).State = EntityState.Modified;
            return res.Equals("Defect");
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
