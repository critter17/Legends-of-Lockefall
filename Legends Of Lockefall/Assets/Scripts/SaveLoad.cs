using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveLoad {

    public static GameFileData[] savedGames = new GameFileData[3];
    public static List<string> gameFileNames = new List<string>() { "gameFile1.dat", "gameFile2.dat", "gameFile3.dat" };

    public static void Save(int gameToSave, GameFileData gameData)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Path.Combine(Application.persistentDataPath, gameFileNames[gameToSave]));
        Debug.Log("Game to save: " + gameToSave);
        Debug.Log(Path.Combine(Application.persistentDataPath, gameFileNames[gameToSave]));
        savedGames[gameToSave] = gameData;

        bf.Serialize(file, savedGames[gameToSave]);
        file.Close();
    }

    public static GameFileData Load(int gameToLoad)
    {
        if(File.Exists(Path.Combine(Application.persistentDataPath, gameFileNames[gameToLoad])))
        {
            Debug.Log("gameToLoad: " + gameToLoad);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Path.Combine(Application.persistentDataPath, gameFileNames[gameToLoad]), FileMode.Open);
            savedGames[gameToLoad] = (GameFileData) bf.Deserialize(file);
            file.Close();
            return savedGames[gameToLoad];
        }
        Debug.Log("File does not exist");
        return null;
    }

    public static void Erase(int fileToErase)
    {
        if(File.Exists(Path.Combine(Application.persistentDataPath, gameFileNames[fileToErase])))
        {
            savedGames[fileToErase] = null;
            File.Delete(Path.Combine(Application.persistentDataPath, gameFileNames[fileToErase]));
            UnityEditor.AssetDatabase.Refresh();
            Debug.Log("Erased Data");
        }
    }
}
