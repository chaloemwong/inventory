using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WeightRecord
    {
        public long Id { get; set; }
        public string WeightMachineCode { get; set; }
        public DateTime ProcessTime { get; set; }
        public string MachineCode { get; set; }
        public string ProductCode { get; set; }
        public int PackAmount { get; set; }
        public double StandardPackWeight { get; set; }
        public double Weight { get; set; }
        public string PackNo { get; set; }
        public bool IsNewPack { get; set; }
        public long? ReferPackNoId { get; set; }
        public int Status { get; set; }
        public string StaffCode { get; set; }
        public string AuthorityCode { get; set; }
        public string ReasonCode { get; set; }
        public string Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedByUserCode { get; set; }
        public string CreatedByProgramCode { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedByUserCode { get; set; }
        public string FBProductCode { get; set; }
        public double Width { get; set; }
    }
}
