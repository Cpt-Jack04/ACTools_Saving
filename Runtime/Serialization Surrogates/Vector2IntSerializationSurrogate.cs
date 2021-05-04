using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class Vector2IntSerializationSurrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            Vector2Int vector2Int = (Vector2Int)obj;
            info.AddValue("x", vector2Int.x);
            info.AddValue("y", vector2Int.y);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            Vector2Int vector2Int = (Vector2Int)obj;
            vector2Int.x = (int)info.GetValue("x", typeof(int));
            vector2Int.y = (int)info.GetValue("y", typeof(int));
            obj = vector2Int;
            return obj;
        }
    }
}