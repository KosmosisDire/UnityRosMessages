//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class StartMotionRequest : Message
    {
        public const string k_RosMessageName = "industrial_msgs/StartMotion";
        public override string RosMessageName => k_RosMessageName;

        //  Resume current robot motion (e.g. after stop_motion or robot fault) 

        public StartMotionRequest()
        {
        }
        public static StartMotionRequest Deserialize(MessageDeserializer deserializer) => new StartMotionRequest(deserializer);

        private StartMotionRequest(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "StartMotionRequest: ";
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
