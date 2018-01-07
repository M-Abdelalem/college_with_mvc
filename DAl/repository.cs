using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAl
{
    public class repository<t>  : Irepository<t> where t:class
    {
        collegeEntities5 context;
        DbSet<t> set;
        //public repository()
        //    : this(new collegeEntities5())
        // { }
        //public repository(collegeEntities5 _context)
        //{
        //    context = _context;
        //    set = context.Set<t>();
        
        //}



        public repository()
        {
            context = new collegeEntities5();
               set = context.Set<t>();
        }

        public void add(t addedclass) 
        {
            set.Add(addedclass);

            context.SaveChanges();
        
        
        }
        public void delete(t updatedclass)
        {
            context.Entry<t>(updatedclass).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();

           
        
        
        }
        public void update(t updatedclass) {

            context.Entry<t>(updatedclass).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public IQueryable<t> select()
        {
            return (set);
        }
        public t Get_Item(int Id)
        {
            return (set.Find(Id));
        }
      
    }
}
