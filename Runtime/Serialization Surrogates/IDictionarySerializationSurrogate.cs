using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

namespace ACTools.Saving
{
    internal class IDictionarySerializationSurrogate<TKey, TValue> : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            IDictionary<TKey, TValue> iDictionary = (IDictionary<TKey, TValue>)obj;
            info.AddValue("keyColleciton", new List<TKey>(iDictionary.Keys));
            info.AddValue("valueCollection", new List<TValue>(iDictionary.Values));
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            IDictionary<TKey, TValue> iDictionary = (IDictionary<TKey, TValue>)obj;
            List<TKey> keyCollection = (List<TKey>)info.GetValue("keyColleciton", typeof(List<TKey>));
            List<TValue> valueCollection = (List<TValue>)info.GetValue("valueCollection", typeof(List<TValue>));

            iDictionary.Clear();
            for (int index = 0; index < keyCollection.Count; ++index)
                iDictionary.Add(keyCollection[index], valueCollection[index]);

            obj = iDictionary;
            return obj;
        }
    }
}