using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class HauntedHouseRepository : IRepository<HauntedHouse>
    {
        public HauntedHousesContext db;

        public HauntedHouseRepository(HauntedHousesContext db)
        {
            this.db = db;
        }

        public void Create(HauntedHouse obj)
        {

            db.HauntedHouses.Add(obj);
            db.SaveChanges();
        }
        // Read
        public IEnumerable<HauntedHouse> GetAll()
        {
            return db.HauntedHouses.ToList();
        }

        public HauntedHouse GetByID(int id)
        {
            return db.HauntedHouses.Find(id);
            
        }
        // Update
        public void Update(HauntedHouse obj)
        {
            db.HauntedHouses.Update(obj);
            db.SaveChanges();
        }

        // Delete
        public void Delete(HauntedHouse obj)
        {
            db.HauntedHouses.Remove(obj);
            db.SaveChanges();
        }

        //public IEnumerable<Room> GetAllRooms()
        //{
        //    return db.Rooms.ToList();
        //}
    }
}
