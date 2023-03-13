namespace testApp.Model
{
  public class TodolistModels
  {
    public string ID { get; set; }

    public string name { get; set; }

    public string type { get; set; }

    public string prioty { get; set; }

    public string timeStart { get; set; }

    public string timeEnd { get; set; }

    public string status { get; set; }

    public string description { get; set; }

    public string result { get; set; }

    public bool isEdit { get; set; }

    public bool isDelete { get; set; }
    public bool IsNameValid { get; set; }
  }
}