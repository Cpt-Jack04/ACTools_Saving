using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class BoundsIntSerializationSurrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            BoundsInt boundsInt = (BoundsInt)obj;
            info.AddValue("position", boundsInt.position);
            info.AddValue("size", boundsInt.size);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            BoundsInt boundsInt = (BoundsInt)obj;
            boundsInt.position = (Vector3Int)info.GetValue("position", typeof(Vector3Int));
            boundsInt.size = (Vector3Int)info.GetValue("size", typeof(Vector3Int));
            obj = boundsInt;
            return obj;
        }
    }
}