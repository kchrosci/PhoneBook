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
				//LOGIC TO BE IMPLEMENTED
				_phoneName = value;
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
			_phoneName = phoneName;
			_phoneNumber = phoneNumber;
		}
	}
}
