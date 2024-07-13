//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class SetDrivePowerRequest : Message
    {
        public const string k_RosMessageName = "industrial_msgs/SetDrivePower";
        public override string RosMessageName => k_RosMessageName;

        //  Direct method of turning drive power on and off
        //  NOTE: Motion commands will automatically to this if
        //  drive power is not on and a motion command is received.
        public bool drive_power;

        public SetDrivePowerRequest()
        {
            this.drive_power = false;
        }

        public SetDrivePowerRequest(bool drive_power)
        {
            this.drive_power = drive_power;
        }

        public static SetDrivePowerRequest Deserialize(MessageDeserializer deserializer) => new SetDrivePowerRequest(deserializer);

        private SetDrivePowerRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.drive_power);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.drive_power);
        }

        public override string ToString()
        {
            return "SetDrivePowerRequest: " +
            "\ndrive_power: " + drive_power.ToString();
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
