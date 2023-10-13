using System.Collections.Generic;
// using AspNetCore;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    // [Required(ErrorMessage = "What is this engineer's name?")]
    public string Name { get; set; }
    // [Required(ErrorMessage = "What are this engineer's details?")]
    public string Details { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}
