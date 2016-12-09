using System;
using System.ComponentModel.DataAnnotations;

namespace Sample
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
