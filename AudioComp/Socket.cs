using SocketIOClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Screen_Recorder.AudioComp
{
    class Socket
    {
        SocketIO client = new SocketIO("https://nodetoolapi.adayroi.online");
        public Socket()
        {
            Init();
        }
        public void Init()
        {
            client.OnConnected += async (sender, e) =>
            {
               await client.EmitAsync("bytes", "sdfdsd", new
                {
                    source = "client001",
                    bytes = Encoding.UTF8.GetBytes(".net core")
                });
            };

            /*client.On("bytes", response =>
            {
                var result = response.GetValue<ByteResponse>();
            });*/


        }
    }
}
