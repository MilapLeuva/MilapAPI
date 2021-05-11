namespace Milap.Model.DTO
{
    public class DataTablePaginationDTO
    {
        public DataTablePaginationDTO()
        {
            SortOrder = 1;
        }
        public string searchText { get; set; }
        public string sortColumn { get; set; }
        public int sortOrder { get; set; }
        public int SortOrder { get; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
    }
}
