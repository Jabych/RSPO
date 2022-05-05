using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
  public enum BookType
  {
    Book, Author, Izdatelctvo
  }
  class Book
  {
    public int id { get; set; }
    public string name { get; set; }
    public int authorid { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    public int izdatelctvoid { get; set; }
    public string izdatelctvo { get; set; }
    public override string ToString()
    {
      return "[" + id + "]" + name;
    }
  }
  class Author
  {
    public int id { get; set; }
    public string name { get; set; }
    public override string ToString()
    {
      return name;
    }
  }
  class Izdatelctvo
  {
    public int id { get; set; }
    public string name { get; set; }
    public override string ToString()
    {
      return name;
    }
  }

}
