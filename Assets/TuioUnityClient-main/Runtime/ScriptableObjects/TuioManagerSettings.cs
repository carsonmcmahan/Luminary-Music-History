using TuioNet.Common;
using UnityEngine;

namespace TuioUnity
{
    [CreateAssetMenu(fileName = "New TUIO Manager Settings", menuName = "TUIO/TUIO Manager Settings")]
    public class TuioManagerSettings : ScriptableObject
    {
       public TuioConnectionType TuioConnectionType = TuioConnectionType.Websocket;
        public int UdpPort = 3333;
        public int UdpPort1 = 3333;
        public int UdpPort2 = 3333;
        public int UdpPort3 = 3333;
        public int UdpPort4 = 3333;
        public int UdpPort5 = 3333;
        public int UdpPort6 = 3333;
        public string WebsocketAddress = "10.0.0.20";
        public int WebsocketPort = 3343;
    }
}
