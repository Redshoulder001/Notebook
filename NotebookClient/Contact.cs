﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookClient
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
