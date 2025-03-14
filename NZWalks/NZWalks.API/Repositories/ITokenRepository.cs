﻿using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToeken(IdentityUser user, List<string> roles);
    }
}
