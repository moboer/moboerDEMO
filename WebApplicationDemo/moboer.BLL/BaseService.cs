﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moboer.IBLL;
using moboer.IDAL;

namespace moboer.BLL
{
    public abstract class BaseService<T> : InterfaceBaseService<T> where T : class
    {
        protected InterfaceBaseRepository<T> CurrentRepository { get; set; }
        public BaseService(InterfaceBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        public T Add(T entity)
        {
            return CurrentRepository.Add(entity);
        }

        public bool Delete(T entity)
        {
            return CurrentRepository.Update(entity);
        }

        public bool Update(T entity)
        {
            return CurrentRepository.Delete(entity);
        }
    }
}
