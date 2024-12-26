using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCiscoRTPStreamer
{
    public class Class1
    {
        private streamUtils sty = new streamUtils();

        public async Task SubscribeToMulticast()
        {
            string result = await streamUtils.REQUEST_MULTICAST_SUBSCRIBE(1, "239.255.255.250", "user", "password");
            Console.WriteLine(result);
        }
    }
}
