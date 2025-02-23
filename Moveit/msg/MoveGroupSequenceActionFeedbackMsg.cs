//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class MoveGroupSequenceActionFeedbackMsg : Message
    {
        public const string k_RosMessageName = "moveit_msgs/MoveGroupSequenceActionFeedback";
        public override string RosMessageName => k_RosMessageName;

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public HeaderMsg header;
        public Actionlib.GoalStatusMsg status;
        public MoveGroupSequenceFeedbackMsg feedback;

        public MoveGroupSequenceActionFeedbackMsg()
        {
            this.header = new HeaderMsg();
            this.status = new Actionlib.GoalStatusMsg();
            this.feedback = new MoveGroupSequenceFeedbackMsg();
        }

        public MoveGroupSequenceActionFeedbackMsg(HeaderMsg header, Actionlib.GoalStatusMsg status, MoveGroupSequenceFeedbackMsg feedback)
        {
            this.header = header;
            this.status = status;
            this.feedback = feedback;
        }

        public static MoveGroupSequenceActionFeedbackMsg Deserialize(MessageDeserializer deserializer) => new MoveGroupSequenceActionFeedbackMsg(deserializer);

        private MoveGroupSequenceActionFeedbackMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            this.status = Actionlib.GoalStatusMsg.Deserialize(deserializer);
            this.feedback = MoveGroupSequenceFeedbackMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.status);
            serializer.Write(this.feedback);
        }

        public override string ToString()
        {
            return "MoveGroupSequenceActionFeedbackMsg: " +
            "\nheader: " + header.ToString() +
            "\nstatus: " + status.ToString() +
            "\nfeedback: " + feedback.ToString();
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
