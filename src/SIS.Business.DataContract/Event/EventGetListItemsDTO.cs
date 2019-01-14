﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Business.DataContract.Event
{
    public class EventGetListItemsDTO
    {
        public int EventEntityID { get; set; }
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        [Required]
        public int FoodID { get; set; }
        public int CustID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Event")]
        public DateTime? DateOfEvent { get; set; }
    }
}
