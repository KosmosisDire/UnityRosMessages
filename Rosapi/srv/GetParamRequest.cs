//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class GetParamRequest : Message
    {
        public const string k_RosMessageName = "rosapi/GetParam";
        public override string RosMessageName => k_RosMessageName;

        public string name;
        public string @default;

        public GetParamRequest()
        {
            this.name = "";
            this.@default = "";
        }

        public GetParamRequest(string name, string @default)
        {
            this.name = name;
            this.@default = @default;
        }

        public static GetParamRequest Deserialize(MessageDeserializer deserializer) => new GetParamRequest(deserializer);

        private GetParamRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.name);
            deserializer.Read(out this.@default);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.name);
            serializer.Write(this.@default);
        }

        public override string ToString()
        {
            return "GetParamRequest: " +
            "\nname: " + name.ToString() +
            "\n@default: " + @default.ToString();
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
