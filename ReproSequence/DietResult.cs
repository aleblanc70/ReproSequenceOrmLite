using System;
using LanBO.ServiceModel.Interface.Tables;
using LanBO.ServiceModel.Interface.Tables.REIBeef;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class DietResult
	{
		[Sequence("DietId"), ReturnOnInsert]
		public int DietId { get; set; }
		public int AccessFiber { get; set; }
		public int MainFiber { get; set; }
		public int FiberQuality { get; set; }
		public int FiberRegularity { get; set; }
		public bool ValidCategory { get; set; }
		public ulong RowVersion { get; set; }

		[Default(OrmLiteVariables.SystemUtc)]
		public DateTime? CreatedDateUtc { get; set; }

		[Default(OrmLiteVariables.SystemUtc)]
		public DateTime? UpdatedDateUtc { get; set; }

		[PrimaryKey, AutoId, ReturnOnInsert]
		public Guid? RowId { get; set; }

	}
}