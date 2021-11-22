using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema68.Entity
{
	class Payment
	{
		private double CardNumber;
		private double CVVNumber;
		private string Name;
		private DateTime ExpirationDate;
		private string email;
		public double getCardNumber()
		{
			return CardNumber;
		}
		public void setCardNumber(double CardNum)
		{
			if (CardNumber == 16 || CardNumber == 15)
				CardNumber = CardNum;
			else
				throw new ArgumentException("Invalid Card Number");
		}
		public double getCVVNumber()
		{
			return CVVNumber;
		}
		public void setCVVNumber(double CVVNum)
		{
			if (CVVNumber == 3)
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
		public string getEmail()
		{
			Account currAcc = new Account();
			return currAcc.getEmail();

		}

	}
}
