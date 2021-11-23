using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema68.Entity
{
	class Payment
	{
		private int CardNumber;
		private int CVVNumber;
		private string Name;
		private DateTime ExpirationDate;
		private string email;
		public int getCardNumber()
		{
			return CardNumber;
		}
		public void setCardNumber(int CardNum)
		{
			if (CardNumber.ToString().Length == 16 || CardNumber.ToString().Length == 15)
				CardNumber = CardNum;
			else
				throw new ArgumentException("Invalid Card Number");
		}
		public int getCVVNumber()
		{
			return CVVNumber;
		}
		public void setCVVNumber(int CVVNum)
		{
            
			if (CVVNumber.ToString().Length == 3)
				CVVNumber = CVVNum;
			else
				throw new ArgumentException("Invalid CVV Number");
		}
		public string getName()
		{
			return Name;
		}
		public void setName(string name)
		{
			Name = name;
		}
		public DateTime getExpirationDate()
		{
			return ExpirationDate;
		}
		public DateTime setExpirationDate(DateTime date)
		{
			if (ExpirationDate > DateTime.Today)
			{
				ExpirationDate = date;
				return ExpirationDate;
			}
			else
				throw new ArgumentException("Invalid Expiration Date");
		}
		
	}
}
