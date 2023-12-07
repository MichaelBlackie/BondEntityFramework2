using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BondEntityFramework2.Models
{
    public class GadgetModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DisplayName ("Appears in this movie")]
        public string AppearsIn { get; set; }
        [Required]
        [DisplayName("With this actor")]
        public string WithThisActor { get; set; }

        public GadgetModel()
        {
            ID = -1;
            Name = "Nothing";
            Description = "Nothing Yet";
            AppearsIn = "Nowhere";
            WithThisActor = "With No One";
        }

        public GadgetModel(int iD, string name, string description, string appearsIn, string withThisActor)
        {
            ID = iD;
            Name = name;
            Description = description;
            AppearsIn = appearsIn;
            WithThisActor = withThisActor;
        }
    }
}