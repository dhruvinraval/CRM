using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Designation_M : BusinessObject
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

        private string _Designation;
        [Required(ErrorMessage = "Enter Designation")]
        [StringLength(100, MinimumLength = 3)]
        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }

        public Designation_M() { }
        private Designation_M(DataRow row)
        {
            Load(row);
        }
        public static Designation_M Create(DataRow row)
        {
            if (row != null)
                return new Designation_M(row);
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
                if (row.Table.Columns.Contains("Designation"))
                    _Designation = (string)row["Designation"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_designation_insertupdate", "p_SrNo", _SrNo, "p_Designation", _Designation));
            return result;
        }

        public static List<Designation_M> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_designation_getall");
            return CreateListFromTable<Designation_M>(dt);
        }

        public static List<Designation_M> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_designation_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Designation_M>(dt);
        }

        public static Designation_M GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_designation_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Designation_M(dt.Rows[0]);
            return null;
        }

        public static void DesignationDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_designation_delete", "p_SrNo", srnopass);
        }
    }
}
