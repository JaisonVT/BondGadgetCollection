﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BondGadgetCollection.Models
{
    public class GadgetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApperasIn { get; set; }
        public string WithThisActor { get; set; }
        

        public GadgetModel(int id, string name, string description, string apperasIn, string withThisActor)
        {
            Id = id;
            Name = name;
            Description = description;
            ApperasIn = apperasIn;
            WithThisActor = withThisActor;
        }

        public GadgetModel()
        {

        }
    }
}