using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
	public interface ITokenService
	{
		string CreateToken(Realtor realtor);
	}
}
