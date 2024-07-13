//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Industrial
{
    [Serializable]
    public class DeviceInfoMsg : Message
    {
        public const string k_RosMessageName = "industrial_msgs/DeviceInfo";
        public override string RosMessageName => k_RosMessageName;

        //  Device info captures device agnostic information about a piece of hardware.
        //  This message is meant as a generic as possible.  Items that don't apply should
        //  be left blank.  This message is not meant to replace diagnostic messages, but
        //  rather provide a standard service message that can be used to populate standard
        //  components (like a GUI for example)
        public string model;
        public string serial_number;
        public string hw_version;
        public string sw_version;
        public string address;

        public DeviceInfoMsg()
        {
            this.model = "";
            this.serial_number = "";
            this.hw_version = "";
            this.sw_version = "";
            this.address = "";
        }

        public DeviceInfoMsg(string model, string serial_number, string hw_version, string sw_version, string address)
        {
            this.model = model;
            this.serial_number = serial_number;
            this.hw_version = hw_version;
            this.sw_version = sw_version;
            this.address = address;
        }

        public static DeviceInfoMsg Deserialize(MessageDeserializer deserializer) => new DeviceInfoMsg(deserializer);

        private DeviceInfoMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.model);
            deserializer.Read(out this.serial_number);
            deserializer.Read(out this.hw_version);
            deserializer.Read(out this.sw_version);
            deserializer.Read(out this.address);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.model);
            serializer.Write(this.serial_number);
            serializer.Write(this.hw_version);
            serializer.Write(this.sw_version);
            serializer.Write(this.address);
        }

        public override string ToString()
        {
            return "DeviceInfoMsg: " +
            "\nmodel: " + model.ToString() +
            "\nserial_number: " + serial_number.ToString() +
            "\nhw_version: " + hw_version.ToString() +
            "\nsw_version: " + sw_version.ToString() +
            "\naddress: " + address.ToString();
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
