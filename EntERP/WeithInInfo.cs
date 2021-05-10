using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace EntERP
{
	[SugarTable("WeithInInfo")]
	class WeithInInfo
	{
		private int id;
		private DateTime date;
		private string recordNo;
		private string carNo;
		private string grossWeight;
		private string netWeight;
		private string carType;
		private string provider;
		private string offLocation;
		private string recieveCompany;
		private string goodsName;
		private string weightWater;
		private string weightOther;
		private string overseer;
		private string operator1;
		private string weightLeft;
		private string operateUser;
		private string operateDate;
		private string modifyUser;
		private string modifyDate;
	}
}
