using System.Collections.Generic;
using System.Security.AccessControl;

namespace testApp.Model
{
  public class CreateFormMailModels
  {
    public string ID { get; set; }
    public string title { get; set; }
    public string name { get; set; }
    public int number { get; set; }
    public bool typeQuestion { get; set; }
    public bool isEditQuestion { get; set; }
    public List<Answer> answers { get; set; } = new();
    public List<listUsers> UsersList { get; set; } = new();
    public class Answer
    {
      public string ID { get; set; }
      public string name { get; set; }
      public bool isEditAnswer { get; set; }
      public List<string> userId { get; set; } = new();
    }
    public class listUsers
    {
      public string ID { get; set; }
      public string name { get; set; }
      public string linkIMG { get; set; }
    }
  }
}