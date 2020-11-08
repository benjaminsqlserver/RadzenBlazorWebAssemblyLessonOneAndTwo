using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaApp.Models.ConData
{
  [Table("Countries", Schema = "dbo")]
  public partial class Country
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CountryID
    {
      get;
      set;
    }
    public string CountryName
    {
      get;
      set;
    }
  }
}
