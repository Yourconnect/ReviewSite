﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace ReviewsSite.Repositories
{
    public interface IRepository<T> 
    {
        //C
        void Create(T obj);

        //R
        IEnumerable<T> GetAll();
        T GetByID(int id);

        //U
        void Update(T obj);

        //D
        void Delete(T obj);
    }
}
