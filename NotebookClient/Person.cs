using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookClient
{
    public class Person : BaseEntity
    {

        public Person()
        {
            Contacts = new List<Contact>();
        }

        public string Firstname { get; set; }

        public string Secondname { get; set; }

        public DateTime BirthDay { get; set; }
        [JsonIgnore]
        public ICollection<Contact> Contacts { get; set; }
    }
}
