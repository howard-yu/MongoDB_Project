//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MongoAppdemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TPOceanDataContainer
    {
        public int ID { get; set; }
        public string StationID { get; set; }
        public string TPID { get; set; }
        public string Container { get; set; }
        public string ContainerType { get; set; }
        public Nullable<double> CBM { get; set; }
        public Nullable<int> PCS { get; set; }
        public string PCSUOM { get; set; }
        public Nullable<double> WT { get; set; }
        public string WTUOM { get; set; }
        public byte[] Version { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    }
}
