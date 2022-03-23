using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharaterButton : MonoBehaviour
{
    public int index;
    SelectCharacterUI root;
    public Button button;

    public void Set(SelectCharacterUI uiRoot, int index, Sprite sprite)
    {
        root = uiRoot;
        this.index = index;
        button.image.sprite = sprite;
    }

    public void OnClickButton()
    {
        //root.SetCharacterInfo(index);
    }
}
