using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Abstract;

namespace DataAccess.Abstract;
public interface IGenericDal<T> where T : BaseEntity, new()
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    List<T> GetAll();
    bool Any(int id);
}
