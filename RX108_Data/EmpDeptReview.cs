using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class EmpDeptReview : BusinessObject
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


        private float? _DisplayOrder;
        [Required(ErrorMessage = "Enter Display Order")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 10.00 or 10")]
        public float? DisplayOrder
        {
            get { return _DisplayOrder; }
            set { _DisplayOrder = value; }
        }

        private int? _Mst_Dept_SrNo;
        [Required(ErrorMessage = "Select Department")]
        public int? Mst_Dept_SrNo
        {
            get { return _Mst_Dept_SrNo; }
            set { _Mst_Dept_SrNo = value; }
        }

        private int? _Mst_EmployeeReview_SrNo;
        [Required(ErrorMessage = "Select EmployeeReview")]
        public int? Mst_EmployeeReview_SrNo
        {
            get { return _Mst_EmployeeReview_SrNo; }
            set { _Mst_EmployeeReview_SrNo = value; }
        }

        public EmpDeptReview() { }
        private EmpDeptReview(DataRow row)
        {
            Load(row);
        }
        public static EmpDeptReview Create(DataRow row)
        {
            if (row != null)
                return new EmpDeptReview(row);
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
                if (row.Table.Columns.Contains("DisplayOrder"))
                    _DisplayOrder = (float)row["DisplayOrder"];
                if (row.Table.Columns.Contains("Mst_Dept_SrNo"))
                    _Mst_Dept_SrNo = (int)row["Mst_Dept_SrNo"];
                if (row.Table.Columns.Contains("Mst_EmployeeReview_SrNo"))
                    _Mst_EmployeeReview_SrNo = (int)row["Mst_EmployeeReview_SrNo"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_empdeptreview_insertupdate", "p_SrNo", _SrNo, "p_DisplayOrder", _DisplayOrder, "p_Mst_Dept_SrNo", _Mst_Dept_SrNo, "p_Mst_EmployeeReview_SrNo", _Mst_EmployeeReview_SrNo));
            return result;
        }

        public static List<EmpDeptReview> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_empdeptreview_getall");
            return CreateListFromTable<EmpDeptReview>(dt);
        }

        public static List<EmpDeptReview> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_empdeptreview_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<EmpDeptReview>(dt);
        }

        public static EmpDeptReview GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_empdeptreview_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new EmpDeptReview(dt.Rows[0]);
            return null;
        }

        public static void EmpDeptReviewDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_empdeptreview_delete", "p_SrNo", srnopass);
        }
    }
}
