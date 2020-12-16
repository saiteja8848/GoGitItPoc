using System;


public class InsecurePassword
{

	public bool badpassword()
	{
		string password = "password";

		if (password == "password")
		{
			return true;
		}

		return false;
	}
	
}