using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class EmployeeReview : BusinessObject
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

        private string _ReviewName;
        [Required(ErrorMessage = "Enter Review Name")]
        [StringLength(100, MinimumLength = 3)]
        public string ReviewName
        {
            get { return _ReviewName; }
            set { _ReviewName = value; }
        }

        private float? _Points;
        [Required(ErrorMessage = "Enter Points")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 10.00 or 10")]
        public float? Points
        {
            get { return _Points; }
            set { _Points = value; }
        }

        public EmployeeReview() { }
        private EmployeeReview(DataRow row)
        {
            Load(row);
        }
        public static EmployeeReview Create(DataRow row)
        {
            if (row != null)
                return new EmployeeReview(row);
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
                if (row.Table.Columns.Contains("ReviewName"))
                    _ReviewName = (string)row["ReviewName"];
                if (row.Table.Columns.Contains("Points"))
                    _Points = (float)row["Points"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_employeereview_insertupdate", "p_SrNo", _SrNo, "p_ReviewName", _ReviewName, "p_Points", _Points));
            return result;
        }

        public static List<EmployeeReview> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_employeereview_getall");
            return CreateListFromTable<EmployeeReview>(dt);
        }

        public static List<EmployeeReview> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_employeereview_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<EmployeeReview>(dt);
        }

        public static EmployeeReview GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_employeereview_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new EmployeeReview(dt.Rows[0]);
            return null;
        }

        public static void EmployeeReviewDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_employeereview_delete", "p_SrNo", srnopass);
        }
    }
}
