using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_productsubcategory:BusinessObject
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

        private int _Mst_ProductCategory_SrNo;
        [Required(ErrorMessage = "Select Product Category")]
        public int Mst_ProductCategory_SrNo
        {
            get { return _Mst_ProductCategory_SrNo; }
            set { _Mst_ProductCategory_SrNo = value; }
        }

        private string _ProductSubCategoryName;
        [Required(ErrorMessage = "Enter Product Category")]
        [StringLength(50, MinimumLength = 3)]
        public string ProductSubCategoryName
        {
            get { return _ProductSubCategoryName; }
            set { _ProductSubCategoryName = value; }
        }

        private int _IV_LinkName_SrNo;
        [Required(ErrorMessage = "Select Video or Image Link")]
        public int IV_LinkName_SrNo
        {
            get { return _IV_LinkName_SrNo; }
            set { _IV_LinkName_SrNo = value; }
        }

        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_productsubcategory() { }
        private mst_productsubcategory(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Status"))
                    _Status = Convert.ToChar(row["Status"].ToString());
                if (row.Table.Columns.Contains("Mst_ProductCategory_SrNo"))
                    _Mst_ProductCategory_SrNo = Convert.ToInt32(row["Mst_ProductCategory_SrNo"]);
                if (row.Table.Columns.Contains("ProductSubCategoryName"))
                    _ProductSubCategoryName = row["ProductSubCategoryName"].ToString();
                if (row.Table.Columns.Contains("IV_LinkName_SrNo"))
                    _IV_LinkName_SrNo = Convert.ToInt32(row["IV_LinkName_SrNo"]);
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_Status", Status,"p_Mst_ProductCategory_SrNo" ,Mst_ProductCategory_SrNo, "p_ProductSubCategoryName", ProductSubCategoryName, "p_IV_LinkName_SrNo", IV_LinkName_SrNo, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_productsubcategory_insertupdate", obj));
        }

        public static List<mst_productsubcategory> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_productsubcategory_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_productsubcategory>(dt);
        }
        public static List<mst_productsubcategory> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_productsubcategory_getall");
            return CreateListFromTable<mst_productsubcategory>(dt);
        }

        public static mst_productsubcategory GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_productsubcategory_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_productsubcategory(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_productsubcategory_delete", obj);

        }
    }
}