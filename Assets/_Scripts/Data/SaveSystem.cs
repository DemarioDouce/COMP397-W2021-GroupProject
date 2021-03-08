using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem 
{
    public static void SavePlayer(PlayerManger playerManger) {
        //BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.json";
        //FileStream stream = new FileStream(path,FileMode.Create);

        PlayerData data = new PlayerData(playerManger);

        //formatter.Serialize(stream, data);
        //stream.Close();
        Debug.Log("Path = "+Application.persistentDataPath);
        string json = JsonUtility.ToJson(data);
        StreamWriter sw = File.CreateText(path);
        sw.Close();
        File.WriteAllText(path, json);
    }

    public static PlayerData LoadPlayer() {

            string path = Application.persistentDataPath + "/player.data";
            if (File.Exists(path)) {

                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                stream.Close();
               
                return data;
            
            } else { Debug.LogError("Save file not found in " + path);
                return null;
            }
        }

   
}
