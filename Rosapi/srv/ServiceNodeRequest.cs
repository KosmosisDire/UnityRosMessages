//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class ServiceNodeRequest : Message
    {
        public const string k_RosMessageName = "rosapi/ServiceNode";
        public override string RosMessageName => k_RosMessageName;

        public string service;

        public ServiceNodeRequest()
        {
            this.service = "";
        }

        public ServiceNodeRequest(string service)
        {
            this.service = service;
        }

        public static ServiceNodeRequest Deserialize(MessageDeserializer deserializer) => new ServiceNodeRequest(deserializer);

        private ServiceNodeRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.service);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.service);
        }

        public override string ToString()
        {
            return "ServiceNodeRequest: " +
            "\nservice: " + service.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
