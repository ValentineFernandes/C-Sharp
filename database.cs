namespace createdatabase
{
   public partial class _Default : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            DataSet ds = CreateDataSet();
            GridView1.DataSource = ds.Tables["Student"];
            GridView1.DataBind();
         }
      }
      
      private DataSet CreateDataSet()
      {
         //creating a DataSet object for tables
         DataSet dataset = new DataSet();

         // creating the student table
         DataTable Students = CreateStudentTable();
         dataset.Tables.Add(Students);
         return dataset;
      }
      
      private DataTable CreateStudentTable()
      {
         DataTable Students = new DataTable("Student");

         // adding columns
         AddNewColumn(Students, "System.Int32", "StudentID");
         AddNewColumn(Students, "System.String", "StudentName");
         AddNewColumn(Students, "System.String", "StudentCity");

         // adding rows
         AddNewRow(Students, 1, "M H Kabir", "Kolkata");
         AddNewRow(Students, 1, "Shreya Sharma", "Delhi");
         AddNewRow(Students, 1, "Rini Mukherjee", "Hyderabad");
         AddNewRow(Students, 1, "Sunil Dubey", "Bikaner");
         AddNewRow(Students, 1, "Rajat Mishra", "Patna");

         return Students;
      }

      private void AddNewColumn(DataTable table, string columnType, string  columnName)
      {
         DataColumn column = table.Columns.Add(columnName,  Type.GetType(columnType));
      }

      //adding data into the table
      private void AddNewRow(DataTable table, int id, string name, string city)
      {
         DataRow newrow = table.NewRow();
         newrow["StudentID"] = id;
         newrow["StudentName"] = name;
         newrow["StudentCity"] = city;
         table.Rows.Add(newrow);
      }
   }
}
