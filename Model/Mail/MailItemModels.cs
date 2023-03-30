using System.Collections.Generic;

namespace testApp.Model
{
  public class MailItemModels
  {
    public string ID { get; set; }
    public string userSent { get; set; }
    public bool isSurvey { get; set; }
    public string titleMail { get; set; }
    public string contentMail { get; set; }
    public bool isChecked { get; set; }
    public bool isCheckStar { get; set; }
    public string time { get; set; }
  }
  public class DetailsMail
  {
    public string ID { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public string typefile { get; set; }
  }
}