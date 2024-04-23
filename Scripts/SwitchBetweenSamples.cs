using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwitchBetweenSamples : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _layerSamples;
    [SerializeField] private GameObject _singleSamples;

    public void DropDownUI(int index)
    {
        switch (index)
        {
            case 0:
                // Place holder for choose sampels;
                break;
            case 1:
                _layerSamples.SetActive(true);
                _mainMenu.SetActive(false);
                break;
            case 2:
                _singleSamples.SetActive(true);
                _mainMenu.SetActive(false);
                break;
        }
    }

}
