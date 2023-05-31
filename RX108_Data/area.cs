using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class area:BusinessObject
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

        public int _Mst_District_SrNo;
        [Required(ErrorMessage = "Select District Name")]
        public int Mst_District_SrNo
        {
            get { return _Mst_District_SrNo; }
            set { _Mst_District_SrNo = value; }
        }
        
        private string _AreaName;
        [Required(ErrorMessage = "Enter Area Name")]
        [StringLength(100, MinimumLength = 3)]
        public string AreaName
        {
            get { return _AreaName; }
            set { _AreaName = value; }
        }

        private string _ZIPCode;
        [Required(ErrorMessage = "Enter Zip Code")]
        [StringLength(6, MinimumLength = 6,ErrorMessage ="ZIP code must be 6 characters long")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 123456")]
        public string ZIPCode
        {
            get { return _ZIPCode; }
            set { _ZIPCode = value; }
        }

        public area() { }
        private area(DataRow row) : base(row) { }
        public static area Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_area_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new area(dt.Rows[0]);
            return null;
        }
        public static area Create(DataRow row)
        {
            if (row != null)
                return new area(row);
            return null;
        }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Mst_District_SrNo"))
                    _Mst_District_SrNo = (int)row["Mst_District_SrNo"];
                if (row.Table.Columns.Contains("AreaName"))
                    _AreaName = row["AreaName"].ToString();
                if (row.Table.Columns.Contains("ZIPCode"))
                    _ZIPCode = row["ZIPCode"].ToString();

            }
        }
        public static area GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_area_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new area(dt.Rows[0]);
            return null;
        }

        public int area_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_area_insertupdate",
            "p_SrNo", _SrNo,"p_Mst_District_SrNo", _Mst_District_SrNo,"p_AreaName", _AreaName,"p_ZIPCode", _ZIPCode));
            return result;
        }
        public static List<area> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_area_getall");
            return CreateListFromTable<area>(dt);
        }

        public static List<area> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_area_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<area>(dt);
        }
        public static void areaDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_area_delete", "p_SrNo", SrNo);
        }
    }
}
