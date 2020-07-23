using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectBLL
{
    public class BLLSecurity
    {
        public static DataTable GetSecurityData()
        {
            DataTable objData = new DataTable();
            objData.TableName = "dbSecurityInfo";
            objData.Columns.Add("id", typeof(Int32));
            objData.Columns.Add("Name", typeof(string));
            objData.Columns.Add("UserId", typeof(string));
            objData.Columns.Add("Email", typeof(string));
            objData.Columns.Add("Role", typeof(string));

            objData.Rows.Add(new object[] { 1,"Ravi", 20,"Ravi@gmail.com","Administrator" });
            objData.Rows.Add(new object[] { 2, "Vashu", 21, "Vashu@gmail.com", "Financial Officer" });
            objData.Rows.Add(new object[] { 3, "Rajesh", 22, "Rajesh@gmail.com", "Bank Administrator" });
            objData.Rows.Add(new object[] { 4, "Vashu", 23, "Vashu@gmail.com", "Law Officer" });
            objData.Rows.Add(new object[] { 5, "Ravi", 24, "Ravi@gmail.com", "Verification Officer" });
            objData.Rows.Add(new object[] { 6, "Vashu", 25, "Vashu@gmail.com", "Test Role" });

            return objData;
        }
    }
}
