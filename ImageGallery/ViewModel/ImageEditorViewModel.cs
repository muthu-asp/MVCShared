﻿using ImageGallery.Models.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageGallery.ViewModel
{
    public class ImageEditorViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Caption { get; set; }

        [Required]         
        public HttpPostedFileBase FileImage { get; set; }

        public string Details { get; set; }
        public string Make { get; set; }
        public string Modal { get; set; }
        public string Registration { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }

        internal static Gallery getEnityModel(ImageEditorViewModel model)
         {
            return new Gallery
            {
                IsActive = true,
                Title = model.Caption, 
                OrderNo = 0,
                Details=model.Details,
                Make=model.Make,
                Modal=model.Modal,
                Registration=model.Registration,
                Location =model.Location,
                DateAndTime=model.DateAndTime
            };
        }

    }

    public class ImageList
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int? OrderNo { get; set; }
        public string Title { get; set; }
        public int WebImageId { get; set; }
        public string Details { get; set; }
        public string Make { get; set; }
        public string Modal { get; set; }
        public string Registration { get; set; }
        public string Location { get; set; }
        public DateTime? DateAndTime { get; set; }

    }
}