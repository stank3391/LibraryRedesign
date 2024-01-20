// FirebaseService.cs
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Group1Library.Models
{
    public class FirebaseService
    {
        private readonly IFirebaseClient client;

        public FirebaseService(string authSecret, string basePath)
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = authSecret,
                BasePath = basePath
            };
            client = new FireSharp.FirebaseClient(config);
        }

        public IFirebaseClient GetFirebaseClient()
        {
            return client;
        }
    }

}