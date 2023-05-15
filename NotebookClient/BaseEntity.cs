using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookClient
{
    [Serializable]
    //[KnownType(typeof(Contact))]
    //[KnownType(typeof(ContactType))]
    //[DataContract(IsReference = true)]

    public class BaseEntity
    {

        public int Id { get; set; }
    }
    public class PersonContext : DbContext
    {

        public DbSet<Person> People { get; set; }
    }
}
