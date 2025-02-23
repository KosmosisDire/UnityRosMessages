//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class ServiceProvidersResponse : Message
    {
        public const string k_RosMessageName = "rosapi/ServiceProviders";
        public override string RosMessageName => k_RosMessageName;

        public string[] providers;

        public ServiceProvidersResponse()
        {
            this.providers = new string[0];
        }

        public ServiceProvidersResponse(string[] providers)
        {
            this.providers = providers;
        }

        public static ServiceProvidersResponse Deserialize(MessageDeserializer deserializer) => new ServiceProvidersResponse(deserializer);

        private ServiceProvidersResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.providers, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.providers);
            serializer.Write(this.providers);
        }

        public override string ToString()
        {
            return "ServiceProvidersResponse: " +
            "\nproviders: " + System.String.Join(", ", providers.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
