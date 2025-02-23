//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class DebugLevelMsg : Message
    {
        public const string k_RosMessageName = "industrial_msgs/DebugLevel";
        public override string RosMessageName => k_RosMessageName;

        //  Debug level message enumeration.  This may replicate some functionality that
        //  alreay exists in the ROS logger.
        //  TODO: Get more information on the ROS Logger.
        public byte val;
        public const byte DEBUG = 5;
        public const byte INFO = 4;
        public const byte WARN = 3;
        public const byte ERROR = 2;
        public const byte FATAL = 1;
        public const byte NONE = 0;

        public DebugLevelMsg()
        {
            this.val = 0;
        }

        public DebugLevelMsg(byte val)
        {
            this.val = val;
        }

        public static DebugLevelMsg Deserialize(MessageDeserializer deserializer) => new DebugLevelMsg(deserializer);

        private DebugLevelMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.val);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.val);
        }

        public override string ToString()
        {
            return "DebugLevelMsg: " +
            "\nval: " + val.ToString();
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
