using System;
using System.Linq;
using Demo.Model.Entities;

namespace Demo.IDAL
{
    public partial interface IRecordDAL : IBaseDAL<Record>
    {
        //IQueryable<Record> GetRecordsByCustomerId();
    }
}
