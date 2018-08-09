using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model.Entities;

namespace Demo.IBLL
{
    public partial interface IRecordService : IBaseService<Record>
    {
        List<Record> SelectRecords(string customerName);
    }
}
