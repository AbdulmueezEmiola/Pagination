using Pagination.Models.Filter;
using System;

namespace Pagination.Models.Services
{
    public interface IUriService
    {
        Uri GetPageUri(PaginationFilter filter, string route);
    }
}