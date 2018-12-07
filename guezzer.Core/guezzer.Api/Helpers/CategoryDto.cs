using guezzer.Entities;
using System;
using System.Collections.Generic;

namespace guezzer.Api.Helpers
{
    public class CategoryDto
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        //Implement more properties - such as Results per category maybe?
    }
}
