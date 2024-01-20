using System.Diagnostics.Metrics;
using System.Net;
using Firebase;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Group1Library.Components;




namespace Group1Library.Models
{
    namespace Firebase.Controllers{
        public class Database
        {
            string authSecret = "WkOxv54tz0fXhy7LlX2gapo2BPHzWkhvphMLvnFC";
            string basePath = "https://sadphase4-default-rtdb.firebaseio.com/";
            string senderAppName = "SADPhase4";

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "your_firebase_secret",
                BasePath = "https://yourfirebase.firebaseio.com/"
            };
        }
    }
}





