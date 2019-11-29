using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;
    public int Gold = 90;

    ItemsGameScript _itemsGame;
    void Start()
    {
        _itemsGame = GameObject.FindObjectOfType<ItemsGameScript>();

        _itemsGame.HealthHelper.maxValue = MaxHealth;
        _itemsGame.HealthHelper.value = MaxHealth;
    }

    void Update()
    {
        
    }
    public void GetHit(int damage)
    {
        int health = Health - damage;

        if(health <=0)
        {
            _itemsGame.TakeGold(Gold);
            Destroy(gameObject);
        }

        Health = health;
        _itemsGame.HealthHelper.value = Health;

      
    }

}
