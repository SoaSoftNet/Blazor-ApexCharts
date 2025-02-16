﻿using System.Collections.Generic;

namespace ApexCharts
{
    internal class AppendData<TItem>
    {
        public IEnumerable<IDataPoint<TItem>> Data { get; set; }
    }

    internal class AppendNoAxisData
    {
        public IEnumerable<decimal?> Data { get; set; }
    }
}
