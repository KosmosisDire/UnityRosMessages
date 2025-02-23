//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class PublishersRequest : Message
    {
        public const string k_RosMessageName = "rosapi/Publishers";
        public override string RosMessageName => k_RosMessageName;

        public string topic;

        public PublishersRequest()
        {
            this.topic = "";
        }

        public PublishersRequest(string topic)
        {
            this.topic = topic;
        }

        public static PublishersRequest Deserialize(MessageDeserializer deserializer) => new PublishersRequest(deserializer);

        private PublishersRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.topic);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.topic);
        }

        public override string ToString()
        {
            return "PublishersRequest: " +
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
