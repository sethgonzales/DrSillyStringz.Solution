using System.Collections.Generic;
// using AspNetCore;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    // [Required(ErrorMessage = "What type of machine is this?")]
    public string Type { get; set; }
    // [Required(ErrorMessage = "What are this machine's details?")]
    public string Details { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}