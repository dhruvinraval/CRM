using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Perks : BusinessObject
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

        private int? _PerksType;
        [Required(ErrorMessage = "Enter Perks Type")]
        public int? PerksType
        {
            get { return _PerksType; }
            set { _PerksType = value; }
        }

        private int? _AllowType;
        [Required(ErrorMessage = "Enter Allow Type")]
        public int? AllowType
        {
            get { return _AllowType; }
            set { _AllowType = value; }
        }

        private float? _DisplaySeq;
        [Required(ErrorMessage = "Enter Display Seq")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 10.00 or 10")]
        public float? DisplaySeq
        {
            get { return _DisplaySeq; }
            set { _DisplaySeq = value; }
        }

        private string _PerkName;
        [Required(ErrorMessage = "Enter Perk Name")]
        [StringLength(100, MinimumLength = 3)]
        public string PerkName
        {
            get { return _PerkName; }
            set { _PerkName = value; }
        }

        private int? _MinPerk;
        [Required(ErrorMessage = "Enter Min Perk")]
        public int? MinPerk
        {
            get { return _MinPerk; }
            set { _MinPerk = value; }
        }

        private float? _PerkPer;
        [Required(ErrorMessage = "Enter Perk Per")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 10.00 or 10")]
        public float? PerkPer
        {
            get { return _PerkPer; }
            set { _PerkPer = value; }
        }

        private float? _FixPer;
        [Required(ErrorMessage = "Enter Fix Per")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Only Numeric Values are Allowed for e.g : 10.00 or 10")]
        public float? FixPer
        {
            get { return _FixPer; }
            set { _FixPer = value; }
        }

        private int? _CalculatedOn;
        [Required(ErrorMessage = "Enter Calculated On")]
        public int? CalculatedOn
        {
            get { return _CalculatedOn; }
            set { _CalculatedOn = value; }
        }

        public Perks() { }
        private Perks(DataRow row)
        {
            Load(row);
        }
        public static Perks Create(DataRow row)
        {
            if (row != null)
                return new Perks(row);
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
                if (row.Table.Columns.Contains("PerksType"))
                    _PerksType = (int)row["PerksType"];
                if (row.Table.Columns.Contains("AllowType"))
                    _AllowType = (int)row["AllowType"];
                if (row.Table.Columns.Contains("DisplaySeq"))
                    _DisplaySeq = (float)row["DisplaySeq"];
                if (row.Table.Columns.Contains("PerkName"))
                    _PerkName = (string)row["PerkName"];
                if (row.Table.Columns.Contains("MinPerk"))
                    _MinPerk = (int)row["MinPerk"];
                if (row.Table.Columns.Contains("PerkPer"))
                    _PerkPer = (float)row["PerkPer"];
                if (row.Table.Columns.Contains("FixPer"))
                    _FixPer = (float)row["FixPer"];
                if (row.Table.Columns.Contains("CalculatedOn"))
                    _CalculatedOn = (int)row["CalculatedOn"];
            }
        }

        public int InsertUpdate()
        {
            DatabaseGateway da = new DatabaseGateway();
            int result = Convert.ToInt32(da.ExecuteScalar("proc_mst_perks_insertupdate", "p_SrNo", _SrNo, "p_PerksType", _PerksType, "p_AllowType", _AllowType, "p_DisplaySeq", _DisplaySeq, "p_PerkName", _PerkName, "p_MinPerk", _MinPerk, "p_PerkPer", _PerkPer, "p_FixPer", _FixPer, "p_CalculatedOn", _CalculatedOn));
            return result;
        }

        public static List<Perks> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_perks_getall");
            return CreateListFromTable<Perks>(dt);
        }

        public static List<Perks> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_mst_perks_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Perks>(dt);
        }

        public static Perks GetById(int? srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_mst_perks_getbyid", "p_SrNo", srnopass);
            if (dt.Rows.Count > 0)
                return new Perks(dt.Rows[0]);
            return null;
        }

        public static void PerksDelete(int srnopass)
        {
            DatabaseGateway da = new DatabaseGateway();
            da.ExecuteNonQuery("proc_mst_perks_delete", "p_SrNo", srnopass);
        }
    }
}
