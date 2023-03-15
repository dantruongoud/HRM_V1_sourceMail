namespace testApp.Model
{
  public class SidebarModels
  {
    public string id { get; set; }
    public string href { get; set; }
    public string nameNav { get; set; }
    public string iconNav { get; set; }
    public bool active { get; set; }
    public string iconArrow { get; set; }
    public int number { get; set; }
    public List<SidebarModels> Childs { get; set; }
  }
}