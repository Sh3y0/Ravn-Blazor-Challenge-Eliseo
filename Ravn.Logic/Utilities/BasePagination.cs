using System.Collections.Generic;

namespace Ravn.Logic.Utilities
{
    public class BasePagination<TModel>
    {
        public BasePagination()
        {
            Result = new List<TModel>();
        }

        public int Counter { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<TModel> Result { get; set; }
    }
}
