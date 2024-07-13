//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class SetRemoteLoggerLevelRequest : Message
    {
        public const string k_RosMessageName = "industrial_msgs/SetRemoteLoggerLevel";
        public override string RosMessageName => k_RosMessageName;

        //  Sets logging level for a remote device that is attached to
        //  ROS via some communications link.  This service is meant to
        //  set the log level on the device directly so that the comms
        //  link is not overloaded with messages.
        public DebugLevelMsg level;

        public SetRemoteLoggerLevelRequest()
        {
            this.level = new DebugLevelMsg();
        }

        public SetRemoteLoggerLevelRequest(DebugLevelMsg level)
        {
            this.level = level;
        }

        public static SetRemoteLoggerLevelRequest Deserialize(MessageDeserializer deserializer) => new SetRemoteLoggerLevelRequest(deserializer);

        private SetRemoteLoggerLevelRequest(MessageDeserializer deserializer)
        {
            this.level = DebugLevelMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.level);
        }

        public override string ToString()
        {
            return "SetRemoteLoggerLevelRequest: " +
            "\nlevel: " + level.ToString();
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
