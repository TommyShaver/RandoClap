using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayeredSamples : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _layerSamples;

    public void DropDownUI(int index)
    {
        switch (index)
        {
            case 0:
                _layerSamples.SetActive(false);
                _mainMenu.SetActive(true);
                break;
            case 1:
                
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
        }
    }
}
