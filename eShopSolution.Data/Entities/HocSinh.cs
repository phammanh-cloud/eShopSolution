using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entities 
{
    public class HocSinh
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public DateTime DateOfBirth { set; get; }
    }
}
