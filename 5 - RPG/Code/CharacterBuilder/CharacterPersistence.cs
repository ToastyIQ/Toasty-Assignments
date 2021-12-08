using Newtonsoft.Json;
using RPG.Code;
using System;
using System.Collections.Generic;
using System.IO;

public class CharacterPersistence
{
    public string CharacterName { get; }

    public static void SaveCharacter(Character character, string path)
    {
        string CharacterName = character.CharacterName;
        string jsonCharacter = SerializeCharacter(character);
        File.WriteAllText(path, jsonCharacter);
    }

    public static string SerializeCharacter(Character character)
    {
        string jsonCharacter = JsonConvert.SerializeObject(character);
        return jsonCharacter;
    }

    public static string GetCharacterJSONFile(string path)
    {
        string deserializedCharacter = File.ReadAllText(path);
        return deserializedCharacter;
    }

    public static Character LoadCharacter(string deserializedCharacter)
    {
        try
        {
            Character savedCharacter = JsonConvert.DeserializeObject<Character>(deserializedCharacter);
            return savedCharacter;
        }
        catch (JsonReaderException)
        {
            throw new JsonReaderException("This is not a valid character file.");
        }
    }
}
