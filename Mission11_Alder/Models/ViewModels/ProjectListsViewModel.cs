﻿
namespace WaterProjectReal.Models.ViewModels
{
    public class ProjectsListViewModel
    {
        public IQueryable<Book>? Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}