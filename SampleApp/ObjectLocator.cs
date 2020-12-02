using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
	public class ObjectConverter
	{

		public JToken getJson()
		{
			Person p = new Person();
			p.FirstName = "FirstName";
			p.LastName = "LastName";
			p.Address = "Bedford";

			return   Newtonsoft.Json.JsonConvert.SerializeObject(p);
		
		}
		
		public void badcode()
		{
		     string username = "username";
		     string password = "password";		
			
		}
		
		public void vulnerablecode()
		{
		     int i=1;
		     int j=2;
		     int k=3;
		     int l=4;
			
		   if (i >1)
		   {
		       if (j > 2)
		       {
			   
			  if (k > 3)
			  {
				
				if (l > 4)
				{
				Console.Write("in loop");	
				}
			  }
			       
			       
		       }
			   
		   }
			
		}
	}
}
