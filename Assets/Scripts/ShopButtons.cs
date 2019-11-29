using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtons : MonoBehaviour
{
    public GameObject Shop;
    public GameObject btnCancel;
    public GameObject btnShop;
    public GameObject btnCancelExit;

    public void OnClickShop()
    {
        Shop.SetActive(true);
        btnCancel.SetActive(true);
        btnShop.SetActive(false);
        btnCancelExit.SetActive(false);
    }

    public void OnClickCancel()
    {
        Shop.SetActive(false);
        btnCancel.SetActive(false);
        btnShop.SetActive(true);
        btnCancelExit.SetActive(true);
    }

    public void OnClickCancelExit()
    {
        SceneManager.LoadScene(0);
    }
}
