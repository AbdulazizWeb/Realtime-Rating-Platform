using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtimeRating.Infrastructure.Abstractions
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string email, string password);
    }
}
