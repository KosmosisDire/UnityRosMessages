//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.MasterControl
{
    [Serializable]
    public class PlaceMsg : Message
    {
        public const string k_RosMessageName = "master_control/Place";
        public override string RosMessageName => k_RosMessageName;

        public string object_name;
        public string group_name;
        public float approach_height;
        public Geometry.PoseStampedMsg place_pose;

        public PlaceMsg()
        {
            this.object_name = "";
            this.group_name = "";
            this.approach_height = 0.0f;
            this.place_pose = new Geometry.PoseStampedMsg();
        }

        public PlaceMsg(string object_name, string group_name, float approach_height, Geometry.PoseStampedMsg place_pose)
        {
            this.object_name = object_name;
            this.group_name = group_name;
            this.approach_height = approach_height;
            this.place_pose = place_pose;
        }

        public static PlaceMsg Deserialize(MessageDeserializer deserializer) => new PlaceMsg(deserializer);

        private PlaceMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.object_name);
            deserializer.Read(out this.group_name);
            deserializer.Read(out this.approach_height);
            this.place_pose = Geometry.PoseStampedMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.object_name);
            serializer.Write(this.group_name);
            serializer.Write(this.approach_height);
            serializer.Write(this.place_pose);
        }

        public override string ToString()
        {
            return "PlaceMsg: " +
            "\nobject_name: " + object_name.ToString() +
            "\ngroup_name: " + group_name.ToString() +
            "\napproach_height: " + approach_height.ToString() +
            "\nplace_pose: " + place_pose.ToString();
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
