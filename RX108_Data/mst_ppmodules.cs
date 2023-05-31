using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class mst_ppmodules:BusinessObject
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


        private int _Mst_ProductPrice_SrNo;
        [Required(ErrorMessage = "Select Product version")]
        public int Mst_ProductPrice_SrNo
        {
            get { return _Mst_ProductPrice_SrNo; }
            set { _Mst_ProductPrice_SrNo = value; }
        }

        private int _Mst_Product_Module_SrNo;
        [Required(ErrorMessage = "Select Product Module")]
        public int Mst_Product_Module_SrNo
        {
            get { return _Mst_Product_Module_SrNo; }
            set { _Mst_Product_Module_SrNo = value; }
        }

        private float _PriceConsidered;
        [Required(ErrorMessage = "Enter Considered Price")]
        [DataType(DataType.Currency)]

        public float PriceConsidered
        {
            get { return _PriceConsidered; }
            set { _PriceConsidered = value; }
        }
        private string _Remark;
        [StringLength(250)]
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public mst_ppmodules() { }
        private mst_ppmodules(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("Mst_ProductPrice_SrNo"))
                    _Mst_ProductPrice_SrNo = Convert.ToInt32(row["Mst_ProductPrice_SrNo"]);
                if (row.Table.Columns.Contains("Mst_Product_Module_SrNo"))
                    _Mst_Product_Module_SrNo = Convert.ToInt32(row["Mst_Product_Module_SrNo"]);
                if (row.Table.Columns.Contains("PriceConsidered"))
                    _PriceConsidered = Convert.IsDBNull(row["PriceConsidered"]) ? 0.0f : float.Parse(Convert.ToString(row["PriceConsidered"]));
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", SrNo, "p_Mst_ProductPrice_SrNo", Mst_ProductPrice_SrNo, "p_Mst_Product_Module_SrNo", Mst_Product_Module_SrNo, "p_PriceConsidered", PriceConsidered, "p_Remark", Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_ppmodules_insertupdate", obj));
        }

        public static List<mst_ppmodules> GetAll(int pgno, int rpp, int? sort, ref int total, string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_ppmodules_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<mst_ppmodules>(dt);
        }
        public static List<mst_ppmodules> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_ppmodules_getall");
            return CreateListFromTable<mst_ppmodules>(dt);
        }

        public static mst_ppmodules GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt = dbg.QueryForDataTable("proc_mst_ppmodules_getbyid", obj);
            if (dt.Rows.Count > 0)
            {
                return new mst_ppmodules(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_ppmodules_delete", obj);

        }

    }
}
