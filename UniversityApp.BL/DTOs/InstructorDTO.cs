﻿using Newtonsoft.Json;
using System;

namespace UniversityApp.BL.DTOs
{
    public class InstructorDTO
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }
        
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", LastName, FirstMidName);
            }
        }
    }
}
