using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Holidays:BusinessObject
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


        [Required(ErrorMessage = "Enter Year")]
        [RegularExpression(@"^([0-9]{4})$", ErrorMessage = "Invalid Year.")]
        private int _ForYear;
        public int ForYear
        {
            get { return _ForYear; }
            set { _ForYear = value; }
        }

        
        private string _HolidayName;
        [Required(ErrorMessage = "Enter Holiday Name")]
        [StringLength(100, MinimumLength = 3)]
        public string HolidayName
        {
            get {return _HolidayName; }
            set { _HolidayName = value; }
        }
        
        private string _Type;
        [Required(ErrorMessage = "Check Holiday Type")]
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        
        private string _date;
        [Required(ErrorMessage = "Enter Date Of Holiday")]
        public string date
        {
            get { return _date; }
            set { _date = value; }

        }

        private DateTime _ForDate;

        public DateTime ForDate
        {
            get { return _ForDate; }
            set { _ForDate = value; }
        }

        
        private string _PartialWorking;
        [Required(ErrorMessage = "Check Partial Working")]
        public string PartialWorking
        {
            get { return _PartialWorking; }
            set { _PartialWorking = value; }
        }
        private string _StartTime;
        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }
        private string _OffTime;
        public string OffTime
        {
            get { return _OffTime; }
            set { _OffTime = value; }
        }
        private string _Remark;
        [StringLength (100)]

        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        public Holidays() { }
        private Holidays(DataRow row) : base(row) { }
        protected override void Load(DataRow row)
        {
            if (row != null)
            {
                TimeSpan? tp = null;
                if (row.Table.Columns.Contains("disid"))
                    _disID = (int)row["disid"];
                if (row.Table.Columns.Contains("SrNo"))
                    _SrNo = (int)row["SrNo"];
                if (row.Table.Columns.Contains("ForYear"))
                    _ForYear = (int)row["ForYear"];
                if (row.Table.Columns.Contains("HolidayName"))
                    _HolidayName = (string)row["HolidayName"];
                if (row.Table.Columns.Contains("Type"))
                    _Type = (string)row["Type"];
                if (row.Table.Columns.Contains("ForDate")){
                    _ForDate = (DateTime)row["ForDate"];
                    _date =_ForDate.ToString("dd/MM/yyyy");
                }
                if (row.Table.Columns.Contains("PartialWorking"))
                    _PartialWorking = (string)row["PartialWorking"];
                if (row.Table.Columns.Contains("StartTime"))
                    _StartTime= row["StartTime"].ToString();
                if (row.Table.Columns.Contains("OffTime"))
                    _OffTime = row["OffTime"].ToString();
                if (row.Table.Columns.Contains("Remark"))
                    _Remark = row["Remark"].ToString();
            }
        }
        public int InsertUpdate()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            string pw="",tp="";
            if(Type == "true")
            {
                tp = "G";
            }
            else
            {
                tp = "S";
            }
            if(PartialWorking  == "true")
            {
                pw = "T";
            }
            else
            {
                pw = "F";
            }
            ForDate = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            
            object[] obj = { "p_SrNo",SrNo, "p_ForYear",ForYear, "p_HolidayName",HolidayName, "p_Type",tp, "p_ForDate", ForDate, "p_PartialWorking",pw, "p_StartTime",StartTime.Replace(" ",""), "p_OffTime",OffTime.Replace(" ",""), "p_Remark",Remark };
            return Convert.ToInt32(dbg.ExecuteScalar("proc_mst_holidays_insertupdate",obj));
        }
    
        public static List<Holidays> GetAll(int pgno,int rpp,int? sort,ref int total,string search)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "keyword", search, "sortorder", sort };
            DataTable dt = dbg.QueryForDataTablePaged("proc_mst_holidays_getall", pgno, rpp, out total, obj);
            return CreateListFromTable<Holidays>(dt);
        }

        public static List<Holidays> GetAll()
        {
            DatabaseGateway dbg = new DatabaseGateway();
            DataTable dt = dbg.QueryForDataTable("proc_mst_holidays_getall");
            return CreateListFromTable<Holidays>(dt);
        }

        public static Holidays GetByID(int? srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            DataTable dt =  dbg.QueryForDataTable("proc_mst_holidays_getbyid", obj);
            if(dt.Rows.Count >0)
            {
                return new Holidays(dt.Rows[0]);
            }
            return null;
        }

        public static int Delete(int srno)
        {
            DatabaseGateway dbg = new DatabaseGateway();
            object[] obj = { "p_SrNo", srno };
            return dbg.ExecuteNonQuery("proc_mst_holidays_delete", obj);
            
        }
    }
}
