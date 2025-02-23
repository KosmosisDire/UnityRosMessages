//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class SetRemoteLoggerLevelResponse : Message
    {
        public const string k_RosMessageName = "industrial_msgs/SetRemoteLoggerLevel";
        public override string RosMessageName => k_RosMessageName;

        public ServiceReturnCodeMsg code;

        public SetRemoteLoggerLevelResponse()
        {
            this.code = new ServiceReturnCodeMsg();
        }

        public SetRemoteLoggerLevelResponse(ServiceReturnCodeMsg code)
        {
            this.code = code;
        }

        public static SetRemoteLoggerLevelResponse Deserialize(MessageDeserializer deserializer) => new SetRemoteLoggerLevelResponse(deserializer);

        private SetRemoteLoggerLevelResponse(MessageDeserializer deserializer)
        {
            this.code = ServiceReturnCodeMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.code);
        }

        public override string ToString()
        {
            return "SetRemoteLoggerLevelResponse: " +
            "\ncode: " + code.ToString();
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
