﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efconsole.Models
{
    [Table("actor")]
    public partial class Actor
    {
        public Actor()
        {
            FilmActor = new HashSet<FilmActor>();
        }

        [Column("actor_id")]
        public ushort ActorId { get; set; }
        [Required]
        [Column("first_name", TypeName = "varchar(45)")]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name", TypeName = "varchar(45)")]
        public string LastName { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty("Actor")]
        public ICollection<FilmActor> FilmActor { get; set; }
    }
}
