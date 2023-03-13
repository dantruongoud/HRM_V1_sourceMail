using System.ComponentModel.DataAnnotations;

namespace testApp.Model
{
  public class ValidationComponents
  {
    public class ErrorTodolist
    {
      [Required(ErrorMessage = "Nhập tên công việc!")]
      public string nameTodo { get; set; }
    }
  }
}