using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TronBattleRoyale
{
    public partial class firebase : Component
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Ukz4tcxOWGxbvwC40XSNr8PYLhWSAJ3uETlsFCuC",
            BasePath= "https://tron-battle-royale.firebaseio.com/"
        };

        IFirebaseClient client;

        public firebase()
        {
            InitializeComponent();
        }

        private void firebase_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        //private async void position(object sender, EventArgs e)
        //{
        //   SetResponse response = await client.SetTaskAsync();
        //   Basic2d result = response.ResultAs
        //}
    }
}
