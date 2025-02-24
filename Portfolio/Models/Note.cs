﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Objectives { get; set; }
        public DateTime Date { get; set; }
        public bool Hidden { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}