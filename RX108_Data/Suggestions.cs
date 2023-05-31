using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace RX108_Data
{
    public class Suggestions : BusinessObject
    {
        [Key]
        private int? _SrNo;
        public int? SrNo
        {
            get { return _SrNo; }
            set { _SrNo = value; }
        }
        private string _Suggestion;
        public string Suggestion
        {
            get { return _Suggestion; }
            set { _Suggestion = value; }
        }
        public static List<Suggestions> GetAll()
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTable("proc_suggestions_getall");
            return CreateListFromTable<Suggestions>(dt);
        }
        public static List<Suggestions> GetAll(string keyword, int sortOrder, int pageNumber, int pageSize, ref int totalRecords)
        {
            DatabaseGateway da = new DatabaseGateway();
            DataTable dt = da.QueryForDataTablePaged("proc_suggestions_getall", pageNumber, pageSize, out totalRecords, "keyword", keyword, "sortOrder", sortOrder);
            return CreateListFromTable<Suggestions>(dt);
        }
    }
}
