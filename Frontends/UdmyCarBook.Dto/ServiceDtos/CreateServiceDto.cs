﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmyCarBook.Dto.ServiceDtos
{
    public class CreateServiceDto
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}