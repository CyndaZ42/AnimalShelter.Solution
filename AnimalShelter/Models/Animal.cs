using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
  }
}
