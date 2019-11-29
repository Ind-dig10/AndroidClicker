using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
public class ItemsGameScript : MonoBehaviour
{
    public Text DamageText;
    public Text PlayerGoldUI;
    public Text LevelText;
    public Text GameTimeText;
    public Text MosterCount;

    public Slider HealthHelper;
    public EndGame endMenu;
    public GameObject GameOver;

    public Transform StartPosition;
    public GameObject GoldPrefab;
    public GameObject[] MonstersPrefab;


    public int GameTime = 60;
    public int count = 1;
    public int mosterCount = 10;
    public int PlayerGold;
    private int index = 0;
    public int PlayerDamage = 10;

    private const string bunner = "ca-app-pub-8031020776871928~6802399658";
    // Start is called before the first frame update
    float _curentTime;
    void Start()
    {
        Time.timeScale = 1;
        SpawnMonster();
        BannerView bannerb = new BannerView(bunner, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("F6B66AB65E23580A").Build();
        bannerb.LoadAd(request);
        InvokeRepeating("Timer", 0, 1);
    }
    void Timer()
    {
        _curentTime++;
        GameTimeText.text = (GameTime - _curentTime).ToString();
        if(_curentTime >= GameTime)
        {
            Time.timeScale = 0;
         //   InterstitialAd ad = new InterstitialAd()
            // GameOver.gameObject.SetActive(true);
            GameOver.gameObject.SetActive(true);
          //  endMenu.GetGold(PlayerGold);
        }
    }
    // Update is called once per frame
    void Update()
    {
        PlayerGoldUI.text = PlayerGold.ToString();
        DamageText.text = PlayerDamage.ToString();
    }
    public void TakeGold(int gold)
    {
        PlayerGold += gold;

        GameObject goldObj = Instantiate(GoldPrefab) as GameObject;
        Destroy(goldObj, 2);
        if(index < 9)
        {
            index++;
        }
        else
        {
            Time.timeScale = 0;
            endMenu.gameObject.SetActive(true);
            endMenu.GetGold(PlayerGold);
        }
        SpawnMonster();
        mosterCount--;
        count++;
        MosterCount.text = mosterCount.ToString();
        LevelText.text = count.ToString(); 
    }

    public void SpawnMonster()
    {
     //   int index = Random.Range(0, MonstersPrefab.Length);
        GameObject monsterObj = Instantiate(MonstersPrefab[index]) as GameObject;
        monsterObj.transform.position = StartPosition.position;
     
    }
}
