﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efconsole.Models
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rental = new HashSet<Rental>();
        }

        [Column("inventory_id", TypeName = "mediumint unsigned")]
        public uint InventoryId { get; set; }
        [Column("film_id")]
        public ushort FilmId { get; set; }
        [Column("store_id")]
        public byte StoreId { get; set; }
        [Column("last_update", TypeName = "timestamp")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("FilmId")]
        [InverseProperty("Inventory")]
        public Film Film { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("Inventory")]
        public Store Store { get; set; }
        [InverseProperty("Inventory")]
        public ICollection<Rental> Rental { get; set; }
    }
}
