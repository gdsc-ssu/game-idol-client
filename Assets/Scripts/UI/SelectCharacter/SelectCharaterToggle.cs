using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharaterToggle : MonoBehaviour
{
    public int index;
    SelectCharacterUI root;
    public Toggle toggle;

    public void Set(SelectCharacterUI uiRoot, int index, Sprite sprite)
    {
        root = uiRoot;
        this.index = index;
        toggle.image.sprite = sprite;
    }

    public void OnClickToggle()
    {
        if (toggle.isOn) {
            root.SelectCharacter(index);
        } else
        {
            root.UnselectCharacter(index);
        }
    }
}
