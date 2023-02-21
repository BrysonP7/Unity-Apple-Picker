using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Dynamic")]
    public int score = 0;
    static public int _HIGH_SCORE;

    static public int HIGH_SCORE{
        get{return _HIGH_SCORE;}
        private set{
            _HIGH_SCORE = value;
            if(HIGH_SCORE_UI_TEXT != null){
                HIGH_SCORE_UI_TEXT.text = "High Score: " + value.ToString("#,0");
            }
        }
    } 

    public GameObject scoreObject;
     public GameObject HIGH_SCORE_OBJECT;

    private TextMeshProUGUI uiText;
    static private TextMeshProUGUI HIGH_SCORE_UI_TEXT;

    void Awake(){
        HIGH_SCORE_UI_TEXT = HIGH_SCORE_OBJECT.GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        uiText = scoreObject.GetComponent<TextMeshProUGUI>();
         HIGH_SCORE_UI_TEXT.text = "High Score: " + HIGH_SCORE.ToString("#,0");
         
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");
    }

    static public void UPDATE_HIGH_SCORE(int newScore){
        if(newScore > HIGH_SCORE){
            HIGH_SCORE = newScore;
        }
    }

}
