using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class regionchild : BusinessObject
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
        public int _Mst_Region_SrNo;
        public int Mst_Region_SrNo
        {
            get { return _Mst_Region_SrNo; }
            set { _Mst_Region_SrNo = value; }
        }
        //[Required(ErrorMessage = "Enter Country Name")]
        public int _Mst_State_SrNo;
        [Required(ErrorMessage = "Select State Name")]
        public int Mst_State_SrNo
        {
            get { return _Mst_State_SrNo; }
            set { _Mst_State_SrNo = value; }
        }
        public int _Mst_District_SrNo;
        [Required(ErrorMessage = "Select District Name")]
        public int Mst_District_SrNo
        {
            get { return _Mst_District_SrNo; }
            set { _Mst_District_SrNo = value; }
        }
        public int _Mst_Area_SrNo;
        [Required(ErrorMessage = "Select Area Name")]
        public int Mst_Area_SrNo
        {
            get { return _Mst_Area_SrNo; }
            set { _Mst_Area_SrNo = value; }
        }

        public regionchild() { }
        private regionchild(DataRow row) : base(row) { }
        public static regionchild Create(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_regionchild_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new regionchild(dt.Rows[0]);
            return null;
        }
        public static regionchild Create(DataRow row)
        {
            if (row != null)
                return new regionchild(row);
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
                if (row.Table.Columns.Contains("Mst_Region_SrNo"))
                    _Mst_Region_SrNo = (int)row["Mst_Region_SrNo"];
                if (row.Table.Columns.Contains("Mst_State_SrNo"))
                    _Mst_State_SrNo = (int)row["Mst_State_SrNo"];
                if (row.Table.Columns.Contains("Mst_District_SrNo"))
                    _Mst_District_SrNo = (int)row["Mst_District_SrNo"];
                if (row.Table.Columns.Contains("Mst_Area_SrNo"))
                    _Mst_Area_SrNo = (int)row["Mst_Area_SrNo"];
            }
        }
        public static regionchild GetByID(int? SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_regchild_getbyid", "p_SrNo", SrNo);
            if (dt.Rows.Count > 0)
                return new regionchild(dt.Rows[0]);
            return null;
        }

        public int regionchild_insertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_regchild_insertupdate",
            "p_SrNo", _SrNo, "p_Mst_Region_SrNo", _Mst_Region_SrNo, "p_Mst_State_SrNo", _Mst_State_SrNo, "p_Mst_District_SrNo", _Mst_District_SrNo, "P_Mst_Area_SrNo", _Mst_Area_SrNo));
            return result;
        }
        public static List<regionchild> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_regchild_getall");
            return CreateListFromTable<regionchild>(dt);
        }

        public static List<regionchild> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_regchild_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<regionchild>(dt);
        }
        public static void regionchildDelete(int SrNo)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_regchild_delete", "p_SrNo", SrNo);
        }
    }
}
