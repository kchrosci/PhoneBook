using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
	class PhoneContact
	{
		private string _phoneName;
		private string _phoneNumber;
		public string PhoneName
		{
			get
			{
				return _phoneName;
			}
			set
			{
				if (int.Parse(value) < 12)
					_phoneName = value;
				else
					throw new InvalidOperationException();
			}
		}
		public string PhoneNumber
		{
			get
			{
				return _phoneNumber;
			}
			set
			{
				_phoneNumber = value;
			}
		}
		public PhoneContact(string phoneName, string phoneNumber)
		{
			PhoneName = phoneName;
			PhoneNumber = phoneNumber;
		}
	}
}
