using NetworkScopes;
using System;

namespace MyCompany
{
	[Generated]
	public abstract class ExampleAuthenticatorScope_Server : BaseServerAuthenticator
	{
		public abstract NetworkPromise<bool,string> AuthenticateForMatchmaker(string username, string password);
		public abstract NetworkPromise<bool,string> AuthenticateForAdmin(string secret);
	}
}