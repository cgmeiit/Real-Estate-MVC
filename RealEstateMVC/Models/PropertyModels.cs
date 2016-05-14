using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealEstateMVC.Models
{
    public class PropertyModels:DbContext
    {
        [Key]/*primary key creates databse within class*/
        public int PropertyID { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }


            

        
        
        
        
        
        
        /*images,height,overlays,description/content,
        *button/lomk to learn more
        *Title 
        *
        *
        *
        (nmake sure to add title)?*/
    }
}