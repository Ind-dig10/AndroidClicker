using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // public GameObject EnemySk;

    // Start is called before the first frame update
    ItemsGameScript _itemsGame;

    private void Start()
    {
        _itemsGame = GameObject.FindObjectOfType<ItemsGameScript>();
    }
    public void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("Hit");
        GetComponent<HealthScript>().GetHit(_itemsGame.PlayerDamage);
     
    }

}
