using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_product_module:BusinessObject
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


        private char _Status;
        [Required(ErrorMessage = "Check For Status")]
        public char Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _ModuleName;
        [Required(ErrorMessage = "Enter Module Name")]
        [StringLength(100, MinimumLength = 3)]
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
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

        public mst_product_module() { }
        private mst_product_module(DataRow row) : base(row) { }
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
                if (row.Table.Columns.Contains("Status"))
                    _Status = Convert.ToChar(row["Status"].ToString());
                if (row.Table.Columns.Contains("ModuleName"))
                    _ModuleName = row["ModuleName"].ToString();
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
            object[] obj = { "p_SrNo", SrNo, "p_Mst_Product_SrNo", Mst_Product_SrNo, "p_Status", Status, "p_ModuleName", ModuleName,"p_StartDate", StartDate, "p_EndDate", EndDate, "p_VideoLinkMkt", VideoLinkMkt, "p_VideoLinkSupport", VideoLinkSupport, "p_VideoLinkCustomer", VideoLinkCustomer, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_product_module_insertupdate", obj));
        }

        public static List<mst_product_module> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_product_module_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_product_module>(dt);
        }
        public static List<mst_product_module> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_product_module_getall");
            return CreateListFromTable<mst_product_module>(dt);
        }

        public static mst_product_module GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_product_module_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_product_module(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_product_module_delete", obj);

        }
    }
}
