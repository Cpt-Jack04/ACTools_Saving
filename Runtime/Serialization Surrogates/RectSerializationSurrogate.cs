using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class RectSerializationSurrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            Rect rect = (Rect)obj;
            info.AddValue("x", rect.x);
            info.AddValue("y", rect.y);
            info.AddValue("width", rect.width);
            info.AddValue("height", rect.height);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            Rect rect = (Rect)obj;
            rect.x = (float)info.GetValue("x", typeof(float));
            rect.y = (float)info.GetValue("y", typeof(float));
            rect.width = (float)info.GetValue("width", typeof(float));
            rect.height = (float)info.GetValue("height", typeof(float));
            obj = rect;
            return obj;
        }
    }
}