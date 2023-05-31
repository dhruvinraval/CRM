using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Department_M : BusinessObject
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

        private string _Department;
        [Required(ErrorMessage = "Enter Department")]
        [StringLength(100, MinimumLength = 3)]
        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }

        public Department_M() { }
        private Department_M(DataRow row)
        {
            Load(row);
        }
        public static Department_M Create(DataRow row)
        {
            if (row != null)
                return new Department_M(row);
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
                if (row.Table.Columns.Contains("Department"))
                    _Department = (string)row["Department"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_department_insertupdate", "p_SrNo", _SrNo, "p_Department", _Department));
            return result;
        }

        public static List<Department_M> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_department_getall");
            return CreateListFromTable<Department_M>(dt);
        }

        public static List<Department_M> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_department_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Department_M>(dt);
        }

        public static Department_M GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_department_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Department_M(dt.Rows[0]);
            return null;
        }

        public static void DepartmentDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_department_delete", "p_SrNo", srnopass);
        }
    }
}
