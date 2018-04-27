using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System;

public static class SaveLoad {

    public static List<GameFileData> savedGames = new List<GameFileData>(3);
    public static List<string> gameFileNames = new List<string>() { "gameFile1.dat", "gameFile2.dat", "gameFile3.dat" };

    public static void Save(int gameToSave, GameManager gameManager)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Path.Combine(Application.persistentDataPath, gameFileNames[gameToSave]));
        Debug.Log("Game to save: " + gameToSave);
        savedGames.Insert(gameToSave, new GameFileData(gameManager));

        bf.Serialize(file, savedGames[gameToSave]);
        file.Close();
    }

    public static GameFileData Load(int gameToLoad)
    {
        GameFileData data;
        if(File.Exists(Application.persistentDataPath + gameFileNames[gameToLoad]))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Path.Combine(Application.persistentDataPath, gameFileNames[gameToLoad]), FileMode.Open);
            data = (GameFileData) bf.Deserialize(file);
            file.Close();
            return data;
        }
        return null;
    }
}

[Serializable]
public class GameFileData
{
    public int currency;

    public GameFileData(GameManager gameManager)
    {
        currency = gameManager.currency;
    }
}
