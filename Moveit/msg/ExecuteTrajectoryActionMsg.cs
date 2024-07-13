//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class ExecuteTrajectoryActionMsg : Message
    {
        public const string k_RosMessageName = "moveit_msgs/ExecuteTrajectoryAction";
        public override string RosMessageName => k_RosMessageName;

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public ExecuteTrajectoryActionGoalMsg action_goal;
        public ExecuteTrajectoryActionResultMsg action_result;
        public ExecuteTrajectoryActionFeedbackMsg action_feedback;

        public ExecuteTrajectoryActionMsg()
        {
            this.action_goal = new ExecuteTrajectoryActionGoalMsg();
            this.action_result = new ExecuteTrajectoryActionResultMsg();
            this.action_feedback = new ExecuteTrajectoryActionFeedbackMsg();
        }

        public ExecuteTrajectoryActionMsg(ExecuteTrajectoryActionGoalMsg action_goal, ExecuteTrajectoryActionResultMsg action_result, ExecuteTrajectoryActionFeedbackMsg action_feedback)
        {
            this.action_goal = action_goal;
            this.action_result = action_result;
            this.action_feedback = action_feedback;
        }

        public static ExecuteTrajectoryActionMsg Deserialize(MessageDeserializer deserializer) => new ExecuteTrajectoryActionMsg(deserializer);

        private ExecuteTrajectoryActionMsg(MessageDeserializer deserializer)
        {
            this.action_goal = ExecuteTrajectoryActionGoalMsg.Deserialize(deserializer);
            this.action_result = ExecuteTrajectoryActionResultMsg.Deserialize(deserializer);
            this.action_feedback = ExecuteTrajectoryActionFeedbackMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.action_goal);
            serializer.Write(this.action_result);
            serializer.Write(this.action_feedback);
        }

        public override string ToString()
        {
            return "ExecuteTrajectoryActionMsg: " +
            "\naction_goal: " + action_goal.ToString() +
            "\naction_result: " + action_result.ToString() +
            "\naction_feedback: " + action_feedback.ToString();
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
