using System;

namespace Vendstor.Backend.Objects
{
    [Serializable()]
    public class Pagination
    {
        public virtual int MaxResults { get; set; }
        public virtual int CurrentPage { get; set; }
        
        public virtual int NextPage
        {
            get { return CurrentPage + 1; }
        }
        public virtual int PreviousPage
        {
            get { return CurrentPage - 1; }
        }

        public virtual int PagesCount { get; set; }
        public virtual int TotalResults { get; set; }
    }
}
