//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class NodesResponse : Message
    {
        public const string k_RosMessageName = "rosapi/Nodes";
        public override string RosMessageName => k_RosMessageName;

        public string[] nodes;

        public NodesResponse()
        {
            this.nodes = new string[0];
        }

        public NodesResponse(string[] nodes)
        {
            this.nodes = nodes;
        }

        public static NodesResponse Deserialize(MessageDeserializer deserializer) => new NodesResponse(deserializer);

        private NodesResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.nodes, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.nodes);
            serializer.Write(this.nodes);
        }

        public override string ToString()
        {
            return "NodesResponse: " +
            "\nnodes: " + System.String.Join(", ", nodes.ToList());
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
