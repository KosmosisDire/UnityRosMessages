//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class SubscribersRequest : Message
    {
        public const string k_RosMessageName = "rosapi/Subscribers";
        public override string RosMessageName => k_RosMessageName;

        public string topic;

        public SubscribersRequest()
        {
            this.topic = "";
        }

        public SubscribersRequest(string topic)
        {
            this.topic = topic;
        }

        public static SubscribersRequest Deserialize(MessageDeserializer deserializer) => new SubscribersRequest(deserializer);

        private SubscribersRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.topic);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.topic);
        }

        public override string ToString()
        {
            return "SubscribersRequest: " +
            "\ntopic: " + topic.ToString();
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
