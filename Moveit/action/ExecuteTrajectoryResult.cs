//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class ExecuteTrajectoryResult : Message
    {
        public const string k_RosMessageName = "moveit_msgs/ExecuteTrajectory";
        public override string RosMessageName => k_RosMessageName;

        //  Error code - encodes the overall reason for failure
        public MoveItErrorCodesMsg error_code;

        public ExecuteTrajectoryResult()
        {
            this.error_code = new MoveItErrorCodesMsg();
        }

        public ExecuteTrajectoryResult(MoveItErrorCodesMsg error_code)
        {
            this.error_code = error_code;
        }

        public static ExecuteTrajectoryResult Deserialize(MessageDeserializer deserializer) => new ExecuteTrajectoryResult(deserializer);

        private ExecuteTrajectoryResult(MessageDeserializer deserializer)
        {
            this.error_code = MoveItErrorCodesMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.error_code);
        }

        public override string ToString()
        {
            return "ExecuteTrajectoryResult: " +
            "\nerror_code: " + error_code.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Result);
        }
    }
}
