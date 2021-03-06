﻿using Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL
{
    public partial class DbContextFactory
    {
        /// <summary>
        /// 创建EF上下文对象,已存在就直接取,不存在就创建,保证线程内是唯一。
        /// </summary>
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DemoContext") as DbContext;
            if (dbContext == null)
            {
                dbContext = new DemoContext();
                CallContext.SetData("DbContext", dbContext);
            }
            return dbContext;
        }
    }
}
