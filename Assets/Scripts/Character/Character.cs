using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Stats {
    public int sing;
    public int dance;
    public int act;

    public Stats(int sing, int dance, int act)
    {
        this.sing = sing;
        this.dance = dance;
        this.act = act;
    }

    public static Stats random
    {
        get
        {
            return new Stats(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        }
    }

    public Stats Set(int newSing, int newDance, int newAct)
    {
        sing = newSing;
        dance = newDance;
        act = newAct;

        return this;
    }
}

public class Character : MonoBehaviour
{
    public string nickname;
    public Stats stats;
    public SpriteRenderer spriteRenderer;

    public void Set(string nickname, Stats stats, Sprite sprite) {
        this.nickname = nickname;
        this.stats = stats;
        this.spriteRenderer.sprite = sprite;
    }

    public void SetPosition(float x, float y, float z = 0)
    {
        this.transform.position = new Vector3(x, y, z);
    }
}
