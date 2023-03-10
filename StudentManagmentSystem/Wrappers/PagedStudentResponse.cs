namespace StudentManagmentSystem.Wrappers
{
    public class PagedStudentResponse<T> : StudentResponse<T>
    {
        public PagedStudentResponse(T data, int pageNumber, int pageSize) 
        {
            this.PageNumber= pageNumber;
            this.PageSize= pageSize;
            this.Data = data;
            this.Message = null;
            this.Succeeded= true;
            this.Errors = null;
        }

        public int PageNumber { get; set; }
       // public int TotalPages { get; set; }
        public int PageSize { get; set; }
        //public int TotalRecords { get; set; }

    }
}
