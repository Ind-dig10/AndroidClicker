using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Text MyGold;
    public Text RecordGoldText;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

    }

    public void GetGold(int gold)
    {
        MyGold.text = gold.ToString();

        if(Setting.GoldRecord < gold)
        {
            Setting.GoldRecord = gold;
        }

        RecordGoldText.text = Setting.GoldRecord.ToString();
    }

    public void ButtonRestartClick()
    {
        SceneManager.LoadScene(1);
    }
}
