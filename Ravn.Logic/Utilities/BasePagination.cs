using System.Collections.Generic;

namespace Ravn.Logic.Utilities
{
    public class BasePagination<TModel>
    {
        public BasePagination()
        {
            Results = new List<TModel>();
        }

        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<TModel> Results { get; set; }
    }
}
