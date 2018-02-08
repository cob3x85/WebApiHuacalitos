using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuacalitosApi.Models
{
  public class Note
  {
    public long Id { get; set; }
    public string FromName { get; set; }
    public string Title { get; set; }
    public string ToName { get; set; }
    public NoteType NoteType { get; set; }
  }
}
