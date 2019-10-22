using System;
using System.Collections.Generic;

namespace ListOperationsTestApp.Models
{
    public class DetailsCollectionModel : List<DetailModel>
    {
        private static readonly Lazy<DetailsCollectionModel>
            lazy = new Lazy<DetailsCollectionModel>
                (() => new DetailsCollectionModel());

        public static DetailsCollectionModel Instance { get { return lazy.Value; } }

        private DetailsCollectionModel()
        {
        }
    }
}