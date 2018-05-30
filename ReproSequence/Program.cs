using System;
using LanBO.ServiceModel.Tables.REIBeef;
using ServiceStack.OrmLite;

namespace ReproSequence
{
	class Program
	{
		static OrmLiteConnectionFactory dbFactory;
		static System.Data.IDbConnection db;

		static void Main()
		{
			var connectionstring = "Data Source=<Server>;Initial Catalog=<Database>;MultipleActiveResultSets=true;User Id=<User>;Password=<Password>;";
			dbFactory = new OrmLiteConnectionFactory(connectionstring, SqlServer2016Dialect.Provider);
			db = dbFactory.Open();
			ResetSchema();
		   
		    //DropTable DietResult Exist? False
		    //CreateTable DietResult Exist? True
		    //DropTable DietResult Exist? False
		    //CreateTable DietResult Exist? False <----- Should be True
        }

		private static void ResetSchema()
		{
			db.DropTable<DietResult>();
			Console.WriteLine("DropTable DietResult Exist? {0}", db.TableExists<DietResult>());
			db.CreateTable<DietResult>();
			Console.WriteLine("CreateTable DietResult Exist? {0}", db.TableExists<DietResult>());
			db.DropTable<DietResult>();
			Console.WriteLine("DropTable DietResult Exist? {0}", db.TableExists<DietResult>());
			db.CreateTable<DietResult>();
			Console.WriteLine("CreateTable DietResult Exist? {0}", db.TableExists<DietResult>());
		}
	}
}
