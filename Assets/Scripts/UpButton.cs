using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{
    
    public Text PriceText;
    public Text DamageText;

    public int Damage = 10;
    public int Price = 100;

    ItemsGameScript _itemsGame;
    void Start()
    {
        DamageText.text = "+" + Damage.ToString();
        PriceText.text = Price.ToString();
        _itemsGame = GameObject.FindObjectOfType<ItemsGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void UpClick()
    {
        if(_itemsGame.PlayerGold >= Price)
        {
            _itemsGame.PlayerGold -= Price;
            _itemsGame.PlayerDamage += Damage;

            Destroy(gameObject);
        }
    }

    
}
