//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rosapi
{
    [Serializable]
    public class DeleteParamResponse : Message
    {
        public const string k_RosMessageName = "rosapi/DeleteParam";
        public override string RosMessageName => k_RosMessageName;


        public DeleteParamResponse()
        {
        }
        public static DeleteParamResponse Deserialize(MessageDeserializer deserializer) => new DeleteParamResponse(deserializer);

        private DeleteParamResponse(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "DeleteParamResponse: ";
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
