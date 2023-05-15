using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NotebookAPI.Models
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