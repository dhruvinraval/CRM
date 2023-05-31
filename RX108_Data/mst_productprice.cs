using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_productprice:BusinessObject
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


        private DateTime _RevisedDate;
        [Required(ErrorMessage = "Enter Revised Date")]
        public DateTime RevisedDate
        {
            get { return _RevisedDate; }
            set { _RevisedDate = value; }
        }

        private float _ProductPrice;
        [Required(ErrorMessage = "Enter Product Price")]
        [DataType(DataType.Currency)]
        public float ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }

        private float _AMCPrice;
        [Required(ErrorMessage = "Enter AMC Price")]
        [DataType(DataType.Currency)]
        public float AMCPrice
        {
            get { return _AMCPrice; }
            set { _AMCPrice = value; }
        }

        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_productprice() { }
        private mst_productprice(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Mst_Product_SrNo"))
                    _Mst_Product_SrNo = Convert.ToInt32(row["Mst_Product_SrNo"]);
                if (row.Table.Columns.Contains("RevisedDate"))
                    _RevisedDate = (DateTime)row["RevisedDate"];
                if (row.Table.Columns.Contains("ProductPrice"))
                    _ProductPrice = Convert.IsDBNull(row["ProductPrice"]) ? 0.0f : float.Parse(Convert.ToString(row["ProductPrice"]));
                if (row.Table.Columns.Contains("AMCPrice"))
                    _AMCPrice = Convert.IsDBNull(row["AMCPrice"]) ? 0.0f : float.Parse(Convert.ToString(row["AMCPrice"]));
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_Mst_Product_SrNo", Mst_Product_SrNo, "p_RevisedDate", RevisedDate, "p_ProductPrice", ProductPrice, "p_AMCPrice", AMCPrice, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_productprice_insertupdate", obj));
        }

        public static List<mst_productprice> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_productprice_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_productprice>(dt);
        }
        public static List<mst_productprice> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_productprice_getall");
            return CreateListFromTable<mst_productprice>(dt);
        }

        public static mst_productprice GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_productprice_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_productprice(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_productprice_delete", obj);

        }
    }
}
