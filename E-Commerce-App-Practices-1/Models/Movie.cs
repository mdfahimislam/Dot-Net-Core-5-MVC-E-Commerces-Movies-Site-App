﻿using System.ComponentModel.DataAnnotations;
using System;
using E_Commerce_App_Practices_1.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using E_Commerce_App_Practices_1.Data.Base;

namespace E_Commerce_App_Practices_1.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
