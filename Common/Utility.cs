using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMAssignment.Common
{public interface IUtility {

        public DataTable CreateInboundData(DataTable dt);
        public DataTable CreateOutboundData(DataTable dt);
    }

    public class Utility:IUtility {
        public DataTable CreateInboundData(DataTable dt)
        { 
        DataTable dtInbound = new DataTable();
        dt.Columns.Add("LegId", typeof(int));
        dt.Columns.Add("ArrivalLeg", typeof(string));
        dt.Columns.Add("", typeof(string));
        dt.Columns.Add("", typeof(string));
        }
            
            }
}
