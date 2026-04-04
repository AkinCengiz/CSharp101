using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Entity.Abstract;
public class BaseEntity : IEntity
{
    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDelete { get; set; } = false;
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? UpdateAt { get; set; }

    
}
