using System;
namespace CSharpMac
{
	public class UserService
	{
        // private / local variables must be named with _
        readonly int _legalAge = 18;

        public string DefineUserStatus(int userAge)
		{
            if (userAge < _legalAge)
            {
                return "mineur";
            }
            else
            {
                return "majeur";
            }
        }

	}
}
