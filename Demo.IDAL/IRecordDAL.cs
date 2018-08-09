using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Model.Entities;

namespace Demo.IDAL
{
    public partial interface IRecordDAL : IBaseDAL<Record>
    {
        //IQueryable<Record> GetRecordsByCustomerId();
        List<Record> SelectRecords(string customerName);
    }
}
