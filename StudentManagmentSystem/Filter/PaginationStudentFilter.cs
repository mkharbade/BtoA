namespace StudentManagmentSystem.Filter
{
    public class PaginationStudentFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PaginationStudentFilter()
        {
            this.PageNumber= 1;
            this.PageSize = 10;
        }

        public PaginationStudentFilter(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 10 ? 10 : pageSize;
        }
    }
}
