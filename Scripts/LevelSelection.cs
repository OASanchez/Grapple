using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    // Variables for displaying the number
    int counter = 1;

    GameObject level;

    [Header("Object References")]
    public Text levelNumber;
    
    Image myImageComponent;
    public Sprite firstLevel;
    public Sprite secondLevel;
    public Sprite thirdLevel;
    public Sprite fourthLevel;
    public Sprite fifthLevel;
    public Sprite sixthLevel;
    public Sprite seventhLevel;
    public Sprite eightLevel;
    public Sprite ninthLevel;
    public Sprite tenthLevel;

    // Start
    public void Awake()
    {
        myImageComponent = GetComponent<Image>();
    }

    // When switching which level
    public void Update()
    {
        LevelSelector();
    }

    public void plusCounter()
    {
        counter++;
        if(counter > 10){
            counter--;
        }
        Debug.Log(counter);
    }

    public void subCounter()
    {
        counter--;
        if(counter < 1){
            counter++;
        }
        Debug.Log(counter);
    }

    // Loading the specific level
    public void LevelSelected(){
        LoadLevel("Level " + counter);
    }
     public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


    public void LevelSelector()
    {
        counter.ToString();
        levelNumber.text = "Level " + counter.ToString();

        switch(counter)
        {
            case 1:
                myImageComponent.sprite = firstLevel;
                break;
            case 2:
                myImageComponent.sprite = secondLevel;
                break;
            case 3:
                myImageComponent.sprite = thirdLevel;
                break;
            case 4:
                myImageComponent.sprite = fourthLevel;
                break;
            case 5:
                myImageComponent.sprite = fifthLevel;
                break;
            case 6:
                myImageComponent.sprite = sixthLevel;
                break;
            case 7:
                myImageComponent.sprite = seventhLevel;
                break;
            case 8:
                myImageComponent.sprite = eightLevel;
                break;
            case 9:
                myImageComponent.sprite = ninthLevel;
                break;
            case 10:
                myImageComponent.sprite = tenthLevel;
                break;
            default:
                myImageComponent.sprite = firstLevel;
                break;
        }
    }
}