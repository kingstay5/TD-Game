using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_shop : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _openButton;

    public void OpenShopPanel()
    {
        _shopPanel.SetActive(true);
        _openButton.SetActive(false);
        Time.timeScale = 0f;
    }
}
