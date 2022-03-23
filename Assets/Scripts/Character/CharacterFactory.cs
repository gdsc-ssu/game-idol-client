using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    public GameObject CharacterPrefab;

    public string[] nicknames;
    public Sprite[] sprites;

    public Character[] CreateRandomCharacter(int count)
    {
        Character[] characters = new Character[count]; 

        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(CharacterPrefab);
            Character character = go.GetComponent<Character>();
            string nick = nicknames[Random.Range(0, nicknames.Length)];
            Sprite sprite = sprites[Random.Range(0, sprites.Length)];
            go.name = $"Character_{nick}";
            go.SetActive(false);
            character.Set(nick, Stats.random, sprite);
            characters[i] = character;
        }

        return characters;
    }
}
