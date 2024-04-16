using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmyCarBook.Dto.CarDescriptionDtos
{
	public class ResultCarDescriptionByCarIdDto
	{
        public int CarDescripotionID { get; set; }
        public int CarID { get; set; }
		public string Details { get; set; }
	}
}

