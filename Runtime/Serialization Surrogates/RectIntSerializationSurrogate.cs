using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class RectIntSerializationSurrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            RectInt rect = (RectInt)obj;
            info.AddValue("x", rect.x);
            info.AddValue("y", rect.y);
            info.AddValue("width", rect.width);
            info.AddValue("height", rect.height);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            RectInt rect = (RectInt)obj;
            rect.x = (int)info.GetValue("x", typeof(int));
            rect.y = (int)info.GetValue("y", typeof(int));
            rect.width = (int)info.GetValue("width", typeof(int));
            rect.height = (int)info.GetValue("height", typeof(int));
            obj = rect;
            return obj;
        }
    }
}