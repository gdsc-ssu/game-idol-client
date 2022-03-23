using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterUI : MonoBehaviour
{
    [Header("팩토리")]
    public CharacterFactory characterFactory;

    [Header("UI 오브젝트")]
    public SelectCharacterInfo characterInfo;
    public Transform characterButtonGrid;
    public Button makeGroupButton;
    public Text logText;

    [Header("프리팹")]
    public GameObject characterTogglePrefab;

    [Header("")]
    public Character[] characters;

    public int prevSelectCharacterIndex = -1;

    [SerializeField]
    public HashSet<int> selectCharacterIndex = new HashSet<int>();

    private void Start()
    {
        int count = 8;

        characters = characterFactory.CreateRandomCharacter(count);
        
        for (int i = 0; i < characters.Length; i++)
        {
            GameObject go = Instantiate(characterTogglePrefab, characterButtonGrid);
          
            SelectCharaterToggle sct = go.GetComponent<SelectCharaterToggle>();
            sct.Set(this, i, characters[i].spriteRenderer.sprite);
        }

        characterInfo.gameObject.SetActive(false);
        CheckActiveMakeIdolGroupButton();
    }

    private void SetCharacterInfo(int characterIndex)
    {
        if (prevSelectCharacterIndex >= 0)
        {
            characters[prevSelectCharacterIndex].gameObject.SetActive(false);
            characterInfo.gameObject.SetActive(false);
        }

        Character character = characters[characterIndex];
        characterInfo.Set(character);
        characterInfo.gameObject.SetActive(true);
        character.SetPosition(-2f, 0.5f);
        character.gameObject.SetActive(true);
        prevSelectCharacterIndex = characterIndex;
    }

    public void SelectCharacter(int characterIndex)
    {
        SetCharacterInfo(characterIndex);
        selectCharacterIndex.Add(characterIndex);
        CheckActiveMakeIdolGroupButton();
    }

    public void UnselectCharacter(int characterIndex)
    {
        characters[prevSelectCharacterIndex].gameObject.SetActive(false);
        characters[characterIndex].gameObject.SetActive(false);
        characterInfo.gameObject.SetActive(false);
        selectCharacterIndex.Remove(characterIndex);
        CheckActiveMakeIdolGroupButton();
    }

    private void CheckActiveMakeIdolGroupButton()
    {
        if (selectCharacterIndex.Count == 6)
        {
            makeGroupButton.interactable = true;
        }
        else
        {
            makeGroupButton.interactable = false;
        }

        string log;
        if (selectCharacterIndex.Count < 6)
        {
            log = "선택한 연습생이 적습니다.";
        }
        else if (selectCharacterIndex.Count > 6)
        {
            log = "선택한 연습생이 많습니다.";
        }
        else
        {
            log = "아이돌 그룹 생성 가능!";
        }

        Debug.Log(log);
        logText.text = log;
    }

    public void OnClickMakeIdolGroup()
    {
        string log;
        Debug.Log(selectCharacterIndex.Count);
        if (selectCharacterIndex.Count == 6)
        {
            log = "아이돌 그룹 생성 성공!";
        }
        else
        {
            log = "아이돌 그룹 생성 실패!";
        }

        Debug.Log(log);
        logText.text = log;
    }

}
