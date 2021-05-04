using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace ACTools.Saving
{
    // Based on this video from GameDevGuide: https://www.youtube.com/watch?v=5roZtuqZyuw
    public static class BinaryFormatterUtility
    {
        private static BinaryFormatter storedBinaryFormatter = null;
        public static BinaryFormatter StoreBinaryFormatter
        {
            get
            {
                if (storedBinaryFormatter == null)
                    storedBinaryFormatter = GenerateBinaryFormatter();
                return storedBinaryFormatter;
            }
        }

        #region Standard Formatter

        /// <summary> Sets up the BinaryFormatter to be used for saving and loading. </summary>
        /// <returns> The BinaryFormatter to be used for saving and loading. </returns>
        public static BinaryFormatter GenerateBinaryFormatter()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            SurrogateSelector selector = new SurrogateSelector();

            AddSurrogatesToSelector(ref selector);

            formatter.SurrogateSelector = selector;
            return formatter;
        }

        /// <summary> Sets up a given SurrogateSelector to be used for a BinaryFormatter. </summary>
        /// <param name="selector"> The given SurrogateSelector to add SerializationSurrogates to. </param>
        public static void AddSurrogatesToSelector(ref SurrogateSelector selector)
        {
            selector.AddSurrogate(typeof(Bounds), new StreamingContext(StreamingContextStates.All), new BoundsSerializationSurrogate());
            selector.AddSurrogate(typeof(BoundsInt), new StreamingContext(StreamingContextStates.All), new BoundsIntSerializationSurrogate());

            selector.AddSurrogate(typeof(Color), new StreamingContext(StreamingContextStates.All), new ColorSerializationSurrogate());
            selector.AddSurrogate(typeof(Color32), new StreamingContext(StreamingContextStates.All), new Color32SerializationSurrogate());

            selector.AddSurrogate(typeof(Quaternion), new StreamingContext(StreamingContextStates.All), new QuaternionSerializationSurrogate());

            selector.AddSurrogate(typeof(Rect), new StreamingContext(StreamingContextStates.All), new RectSerializationSurrogate());
            selector.AddSurrogate(typeof(RectInt), new StreamingContext(StreamingContextStates.All), new RectIntSerializationSurrogate());

            selector.AddSurrogate(typeof(Vector2), new StreamingContext(StreamingContextStates.All), new Vector2SerializationSurrogate());
            selector.AddSurrogate(typeof(Vector3), new StreamingContext(StreamingContextStates.All), new Vector3SerializationSurrogate());
            selector.AddSurrogate(typeof(Vector4), new StreamingContext(StreamingContextStates.All), new Vector4SerializationSurrogate());
            selector.AddSurrogate(typeof(Vector2Int), new StreamingContext(StreamingContextStates.All), new Vector2IntSerializationSurrogate());
            selector.AddSurrogate(typeof(Vector3Int), new StreamingContext(StreamingContextStates.All), new Vector3IntSerializationSurrogate());
        }

        #endregion


        #region Dictionary Formatter

        /// <summary> Sets up the BinaryFormatter to be used for saving and loading when a dictionary is being saved. </summary>
        /// <typeparam name="TKey"> The Type of the key for this dictionary. </typeparam>
        /// <typeparam name="TValue"> The Type of the value for this dictionary. </typeparam>
        /// <returns> The BinaryFormatter to be used for saving and loading. </returns>
        public static BinaryFormatter GenerateBinaryFormatter<TKey, TValue>()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            SurrogateSelector selector = new SurrogateSelector();

            AddSurrogatesToSelector<TKey, TValue>(ref selector);

            formatter.SurrogateSelector = selector;
            return formatter;
        }

        /// <summary> Sets up a given SurrogateSelector to be used for a BinaryFormatter with the IDictionarySerializationSurrogate class. </summary>
        /// <typeparam name="TKey"> The Type of the key for the dictionary. </typeparam>
        /// <typeparam name="TValue"> The Type of the value for the dictionary. </typeparam>
        /// <param name="selector"> The given SurrogateSelector to add SerializationSurrogates to. </param>
        /// <param name="addDefaultSurrogateSelectors"> Should the default SerializationSurrogate be added to this SurrogateSelector? </param>
        public static void AddSurrogatesToSelector<TKey, TValue>(ref SurrogateSelector selector, bool addDefaultSurrogateSelectors = true)
        {
            if (addDefaultSurrogateSelectors)
                AddSurrogatesToSelector(ref selector);

            selector.AddSurrogate(typeof(IDictionary<TKey, TValue>), new StreamingContext(StreamingContextStates.All), new IDictionarySerializationSurrogate<TKey, TValue>());
        }

        #endregion
    }
}