using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class region:BusinessObject
    {
        private int _disID;
        public int DisID
        {
            get { return _disID; }
            set { _disID = value; }
        }
        private int? _SrNo;
        public int? SrNo
        {
            get { return _SrNo; }
            set { _SrNo = value; }
        }
        //[Required(ErrorMessage = "Enter Country Name")]
        public string _RegionName;
        [Required(ErrorMessage = "Enter Region Name")]
        [StringLength(100, MinimumLength = 3)]
        public string RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; }
        }
        private string _Remark;
        [Required(ErrorMessage = "Enter Remark")]
        [StringLength(100)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public region() { }
        private region(DataRow row) : base(row) { }
        public static region Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_region_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new region(dt.Rows[0]);
            return null;
        }
        public static region Create(DataRow row)
        {
            if (row != null)
                return new region(row);
            return null;
        }

        //public string CountryName { get; set; }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("RegionName"))
                    _RegionName = row["RegionName"].ToString();
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }
        public static region GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_region_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new region(dt.Rows[0]);
            return null;
        }

        public int region_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_region_insertupdate",
            "p_SrNo", _SrNo, "p_RegionName", _RegionName, "p_Remark", _Remark));
            return result;
        }
        public static List<region> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_region_getall");
            return CreateListFromTable<region>(dt);
        }

        public static List<region> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_region_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<region>(dt);
        }
        public static void regionDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_region_delete", "p_SrNo", SrNo);
        }
    }
}
