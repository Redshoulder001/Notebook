using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotebookAPI.Models
{
    public class Contact : BaseEntity
    {
        
        public string Value { get; set; }
       
        public int? PersonId { get; set; }
        
        public Person Person { get; set; }
       
        public int? ContactTypeId { get; set; }
       
        public ContactType ContactType { get; set; }
        
    }

}