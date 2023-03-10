using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace StudentManagmentSystem.Wrappers
{
    public class StudentResponse<T>
    {
        public StudentResponse()
        {

        }
        public StudentResponse(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
    }
}
