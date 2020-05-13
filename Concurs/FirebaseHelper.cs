using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace Concurs
{
    public  class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://ies7-13079.firebaseio.com");
        public  async Task<int> GetVotes()
        {
            return (await firebase.Child("Vulturii_negri/Voturi").OnceSingleAsync<int>());
        }
    }
}
