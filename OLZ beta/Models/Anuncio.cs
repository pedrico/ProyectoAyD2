using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLZ_beta.Models
{
    public class Anuncio
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [Required]
        [Range(1,200000)]
        [DataType(DataType.Currency)]
        public string Price { get; set; }

        [Required]
        [StringLength(80)]
        public string Category { get; set; }

        [Required]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        //[Required]
        [StringLength(1024)]
        public string ImagePath { get; set; }

    }


    /*@using (Html.BeginForm("Create", "Image", null, FormMethod.Post, 
                              new { enctype = "multipart/form-data" })) {
    @Html.AntiForgeryToken()*/
}