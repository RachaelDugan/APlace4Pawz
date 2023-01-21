using Place4Pawz.Models;
using System.Data;

namespace Place4Pawz
{
    public class PetProfileRepository : IPetProfileRepository
    {
        private readonly IDbConnection _conn;
            public PetProfileRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public IEnumerable<PetProfileModel> GetAllProfiles()
            {
                return _conn.Query<PetProfileModel>("SELECT * FROM petprofile;");
            }
    }
    
}
