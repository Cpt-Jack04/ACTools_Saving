using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace ACTools.Saving
{
    public static class LoadData
    {
        /// <summary> Loads game data from a binary file. </summary>
        /// <typeparam name="T"> Type of data being loaded. </typeparam>
        /// <param name="projectName"> The name of your project. This should ideally be the same for all save files for this game for convenience. </param>
        /// <param name="saveName"> A name for the save. This more easily allows for multiple save files. </param>
        /// <param name="dataName"> A name for the data. This should have been used when saving the data. </param>
        /// <returns> Returns the data if it exists. If it doesn't, returns the default of that type. </returns>
        public static T FromBinaryFile<T>(string projectName, string saveName, string dataName)
        {
            string path = $"{Application.persistentDataPath}/{projectName}-{saveName}.{dataName}";

            if (!File.Exists(path))
            {
                Debug.LogWarning("No file exists at " + path + ".\nReturning default of " + typeof(T).ToString() + ".");
                return default;
            }

            BinaryFormatter formatter = BinaryFormatterUtility.StoreBinaryFormatter;

            FileStream stream = new FileStream(path, FileMode.Open);

            T data = (T)formatter.Deserialize(stream);
            stream.Close();

            return data;
        }

        /// <summary> Loads game data from a binary file that has a IDictionary saved in it. </summary>
        /// <typeparam name="T"> Type of data being loaded. </typeparam>
        /// <typeparam name="TKey"> The Type of the key for the IDictionary being loaded. </typeparam>
        /// <typeparam name="TValue"> The Type of the value for the IDictionary being loaded. </typeparam>
        /// <param name="projectName"> The name of your project. This should ideally be the same for all save files for this game for convenience. </param>
        /// <param name="saveName"> A name for the save. This more easily allows for multiple save files. </param>
        /// <param name="dataName"> A name for the data. This should have been used when saving the data. </param>
        /// <returns> Returns the data if it exists. If it doesn't, returns the default of that type. </returns>
        public static T FromBinaryFile<T, TKey, TValue>(string projectName, string saveName, string dataName)
        {
            string path = $"{Application.persistentDataPath}/{projectName}-{saveName}.{dataName}";

            if (!File.Exists(path))
            {
                Debug.LogWarning("No file exists at " + path + ".\nReturning default of " + typeof(T).ToString() + ".");
                return default;
            }

            BinaryFormatter formatter = BinaryFormatterUtility.GenerateBinaryFormatter<TKey, TValue>();

            FileStream stream = new FileStream(path, FileMode.Open);

            T data = (T)formatter.Deserialize(stream);
            stream.Close();

            return data;
        }
    }
}