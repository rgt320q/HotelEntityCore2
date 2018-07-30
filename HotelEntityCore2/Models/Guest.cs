﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelEntityCore2.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string GuestEmail { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDay { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public string IdentitySerialNo { get; set; }
        public string Gender { get; set; }
        public string GuestMartialStatus { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string CarPlate { get; set; }
        public string RezervationNote { get; set; }
        public int? GuestSequenceNo { get; set; }
        public DateTime? InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public int RezervationId { get; set; }
        public Rezervation Rezervation { get; set; }

    }
}
