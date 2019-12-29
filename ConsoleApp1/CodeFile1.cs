using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Threading;
using System.Data.Entity;

namespace ConsoleApp1
{
    public class DBTask_Reposit
    {
        private readonly ConsoleApp1.BP_Ent ent;
        private readonly ConsoleApp1.AIent aIent;
       // private readonly ConsoleApp1.t_Department t_Department;
    //    private readonly ConsoleApp1.t_Emp t_Emp;
        public DBTask_Reposit()
        {
            ent = new BP_Ent();
            aIent = new AIent();
            
     //       t_Emp = new t_Emp();
      //      t_Department = new t_Department();
        }
        public async Task<IEnumerable<ConsoleApp1.t_Department>> GetT_Departments()
        {
            return await aIent.t_Department
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<ConsoleApp1.t_Emp>>GetT_Emps()
        {
            return await aIent.t_Emp
                .AsNoTracking()
                  .ToListAsync();
        }

        public async Task<IEnumerable<ConsoleApp1.TaskTable >> GetData()
        {

            return await ent.TaskTables
                .AsNoTracking()
                .ToListAsync();

        }
    }
}