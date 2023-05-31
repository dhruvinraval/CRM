using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_productversion:BusinessObject
    {

        private int _disID;
        public int DisID
        {
            get { return _disID; }
            set { _disID = value; }
        }
        [Key]
        private int? _SrNo;
        public int? SrNo
        {
            get { return _SrNo; }
            set { _SrNo = value; }
        }


        private int _Mst_Product_SrNo;
        [Required(ErrorMessage = "Select Product")]
        public int Mst_Product_SrNo
        {
            get { return _Mst_Product_SrNo; }
            set { _Mst_Product_SrNo = value; }
        }


        private string _VersionName;
        [Required(ErrorMessage = "Enter Product Version Name")]
        [StringLength(50, MinimumLength = 3)]
        public string VersionName
        {
            get { return _VersionName; }
            set { _VersionName = value; }
        }

        private string _VersionCode;
        [Required(ErrorMessage = "Enter Product Version Code")]
        [StringLength(20, MinimumLength = 3)]
        public string VersionCode
        {
            get { return _VersionCode; }
            set { _VersionCode = value; }
        }

        private DateTime _VersionReleaseDate;
        [Required(ErrorMessage = "Enter Version Release Date")]
        public DateTime VersionReleaseDate
        {
            get { return _VersionReleaseDate; }
            set { _VersionReleaseDate = value; }
        }

        private int _BriefVideoLink;
        public int BriefVideoLink
        {
            get { return _BriefVideoLink; }
            set { _BriefVideoLink = value; }
        }

        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_productversion() { }
        private mst_productversion(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            DateTime? dt = null;
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Mst_Product_SrNo"))
                    _Mst_Product_SrNo = Convert.ToInt32(row["Mst_Product_SrNo"]);
                if (row.Table.Columns.Contains("VersionName"))
                    _VersionName = row["VersionName"].ToString();
                if (row.Table.Columns.Contains("VersionCode"))
                    _VersionCode = row["VersionCode"].ToString();
                if (row.Table.Columns.Contains("VersionReleaseDate"))
                    _VersionReleaseDate = (DateTime)row["VersionReleaseDate"];
                if (row.Table.Columns.Contains("BriefVideoLink"))
                    _BriefVideoLink = int.Parse(Convert.ToString(row["BriefVideoLink"]));
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_Mst_Product_SrNo", Mst_Product_SrNo, "p_VersionName", VersionName, "p_VersionCode", VersionCode, "p_VersionReleaseDate", VersionReleaseDate, "p_BriefVideoLink", BriefVideoLink, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_productversion_insertupdate", obj));
        }

        public static List<mst_productversion> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_productversion_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_productversion>(dt);
        }
        public static List<mst_productversion> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_productversion_getall");
            return CreateListFromTable<mst_productversion>(dt);
        }

        public static mst_productversion GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_productversion_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_productversion(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_productversion_delete", obj);

        }


    }
}
