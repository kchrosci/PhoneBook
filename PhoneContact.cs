using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
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
			PhoneName = phoneName;
			PhoneNumber = phoneNumber;		
		}
	}
}
