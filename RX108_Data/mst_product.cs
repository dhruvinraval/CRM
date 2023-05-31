using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_product : BusinessObject
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

        private char _Status;
        [Required(ErrorMessage = "Check For Status")]
        public char Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _ProductName;
        [Required(ErrorMessage = "Enter Product Name")]
        [StringLength(100, MinimumLength = 3)]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        private string _Description;
        [Required(ErrorMessage = "Enter Product Description")]
        [StringLength(250, MinimumLength = 10)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }



        private int _Mst_ProductCategory_SrNo;
        [Required(ErrorMessage = "Select Product Category")]
        public int Mst_ProductCategory_SrNo
        {
            get { return _Mst_ProductCategory_SrNo; }
            set { _Mst_ProductCategory_SrNo = value; }
        }

        private int _Mst_ProductSubCategory_SrNo;
        [Required(ErrorMessage = "Select Product Sub Category")]
        public int Mst_ProductSubCategory_SrNo
        {
            get { return _Mst_ProductSubCategory_SrNo; }
            set { _Mst_ProductSubCategory_SrNo = value; }
        }

        private DateTime _StartDate;
        [Required(ErrorMessage = "Enter Start Date")]
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        private DateTime? _EndDate;
        public DateTime? EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }


        private int _VideoLinkMkt;
        public int VideoLinkMkt
        {
            get { return _VideoLinkMkt; }
            set { _VideoLinkMkt = value; }
        }
        private int _VideoLinkSupport;
        public int VideoLinkSupport
        {
            get { return _VideoLinkSupport; }
            set { _VideoLinkSupport = value; }
        }
        private int _VideoLinkCustomer;
        public int VideoLinkCustomer
        {
            get { return _VideoLinkCustomer; }
            set { _VideoLinkCustomer = value; }
        }

        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_product() { }
        private mst_product(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            DateTime? dt = null;
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Status"))
                    _Status = Convert.ToChar(row["Status"].ToString());
                if (row.Table.Columns.Contains("ProductName"))
                    _ProductName = row["ProductName"].ToString();
                if (row.Table.Columns.Contains("Description"))
                    _Description = row["Description"].ToString();
                if (row.Table.Columns.Contains("Mst_ProductCategory_SrNo"))
                    _Mst_ProductCategory_SrNo = Convert.ToInt32(row["Mst_ProductCategory_SrNo"]);
                if (row.Table.Columns.Contains("Mst_ProductSubCategory_SrNo"))
                    _Mst_ProductSubCategory_SrNo = Convert.ToInt32(row["Mst_ProductSubCategory_SrNo"]);

                if (row.Table.Columns.Contains("StartDate"))
                    _StartDate = (DateTime)row["StartDate"];
                if (row.Table.Columns.Contains("EndDate"))
                    _EndDate = Convert.IsDBNull(row["EndDate"]) ? dt : (DateTime)row["EndDate"];
                if (row.Table.Columns.Contains("VideoLinkMkt"))
                    _VideoLinkMkt = Convert.IsDBNull(row["VideoLinkMkt"]) ? 0 : int.Parse(Convert.ToString(row["VideoLinkMkt"]));
                if (row.Table.Columns.Contains("VideoLinkSupport"))
                    _VideoLinkSupport = Convert.IsDBNull(row["VideoLinkSupport"]) ? 0 : int.Parse(Convert.ToString(row["VideoLinkSupport"]));
                if (row.Table.Columns.Contains("VideoLinkCustomer"))
                    _VideoLinkCustomer = Convert.IsDBNull(row["VideoLinkCustomer"]) ? 0 : int.Parse(Convert.ToString(row["VideoLinkCustomer"]));
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_Status", Status, "p_ProductName", ProductName, "p_Description", Description, "p_Mst_ProductCategory_SrNo", Mst_ProductCategory_SrNo, "p_Mst_ProductSubCategory_SrNo", Mst_ProductSubCategory_SrNo, "p_StartDate", StartDate, "p_EndDate", EndDate, "p_VideoLinkMkt", VideoLinkMkt, "p_VideoLinkSupport", VideoLinkSupport, "p_VideoLinkCustomer", VideoLinkCustomer, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_product_insertupdate", obj));
        }

        public static List<mst_product> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_product_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_product>(dt);
        }
        public static List<mst_product> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_product_getall");
            return CreateListFromTable<mst_product>(dt);
        }

        public static mst_product GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_product_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_product(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_product_delete", obj);

        }
    }
}
