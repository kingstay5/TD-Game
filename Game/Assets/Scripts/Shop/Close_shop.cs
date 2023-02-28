using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_shop : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _openButton;

    public void CloseShopPanel()
    {
        _shopPanel.SetActive(false);
        _openButton.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
