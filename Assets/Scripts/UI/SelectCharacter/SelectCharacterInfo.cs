using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterInfo : MonoBehaviour
{
    public Text nameText;
    public SelectCharacterStatInfo singStatInfo;
    public SelectCharacterStatInfo danceStatInfo;
    public SelectCharacterStatInfo actStatInfo;

    public void Set(Character character)
    {
        nameText.text = character.nickname;
        singStatInfo.Set(character.stats.sing);
        danceStatInfo.Set(character.stats.dance);
        actStatInfo.Set(character.stats.act);
    }
}
