using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.IBLL;
using Demo.IDAL;
using Demo.Model.Entities;

namespace Demo.BLL
{
    public partial class RecordService : BaseService<Record>, IRecordService
    {
        private IRecordDAL recordDAL = DALContainer.Container.Resolve<IRecordDAL>();

        public override void SetDal()
        {
            Dal = recordDAL;
        }

        public List<Record> SelectRecords(string customerName)
        {
            return recordDAL.SelectRecords(customerName);
        }
    }
}
