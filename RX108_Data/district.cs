using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class district : BusinessObject
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
        public int _Mst_State_SrNo;
        [Required(ErrorMessage = "Select State Name")]

        public int Mst_State_SrNo
        {
            get { return _Mst_State_SrNo; }
            set { _Mst_State_SrNo = value; }
        }
        private string _DistrictName;
        [Required(ErrorMessage = "Enter District Name")]
        [StringLength(100, MinimumLength = 3)]
        public string DistrictName
        {
            get { return _DistrictName; }
            set { _DistrictName = value; }
        }
       
        public district() { }
        private district(DataRow row) : base(row) { }
        public static district Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_district_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new district(dt.Rows[0]);
            return null;
        }
        public static district Create(DataRow row)
        {
            if (row != null)
                return new district(row);
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
                if (row.Table.Columns.Contains("Mst_State_SrNo"))
                    _Mst_State_SrNo = (int)row["Mst_State_SrNo"];
                if (row.Table.Columns.Contains("DistrictName"))
                    _DistrictName = row["DistrictName"].ToString();
            }
        }
        public static district GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_district_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new district(dt.Rows[0]);
            return null;
        }

        public int district_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_district_insertupdate",
            "p_SrNo", _SrNo, "p_Mst_State_SrNo", _Mst_State_SrNo, "p_DistrictName", _DistrictName));
            return result;
        }
        public static List<district> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_district_getall");
            return CreateListFromTable<district>(dt);
        }

        public static List<district> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_district_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<district>(dt);
        }
        public static void districtDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_district_delete", "p_SrNo", SrNo);
        }
    }
}
