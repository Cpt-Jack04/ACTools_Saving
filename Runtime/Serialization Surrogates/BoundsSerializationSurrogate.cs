using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class BoundsSerializationSurrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            Bounds bounds = (Bounds)obj;
            info.AddValue("center", bounds.center);
            info.AddValue("size", bounds.size);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            Bounds bounds = (Bounds)obj;
            bounds.center = (Vector3)info.GetValue("center", typeof(Vector3));
            bounds.size = (Vector3)info.GetValue("size", typeof(Vector3));
            obj = bounds;
            return obj;
        }
    }
}