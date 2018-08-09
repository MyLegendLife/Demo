using Demo.IDAL;
using Demo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL
{
    public partial class RecordDAL : BaseDAL<Record>, IRecordDAL
    {
        private DbContext dbContext = DbContextFactory.Create();

        public List<Record> SelectRecords(string customerName)
        {
            string sql = "SelectRecords {0}";

            //var sd = @"SELECT ID,TYPE,RECORDDATE,CREATEDTIME,LASTUPDATEDTIME,CUSTOMERID FROM RECORD WHERE TYPE = {0}";

            //var xx = dbContext.Database.SqlQuery<Record>(sql, customerName);

            //foreach (var x in xx)
            //{
            //    string ee = x.Id + x.CreatedTime.ToShortDateString();
            //}

            //var dd = xx.ToList();

            return dbContext.Database.SqlQuery<Record>(sql, customerName).ToList();
        }
    }
}
