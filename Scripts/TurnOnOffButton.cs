using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffButton : MonoBehaviour
{
    private BoxCollider2D _boxCollider2D;
    [SerializeField] private int _buttonIndex;
    [SerializeField] private bool _enabled;
    // Start is called before the first frame update
    void Start()
    {
        _enabled = true;
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            if(_enabled) 
            {
                _enabled = false;
                ClapManager._instance.IsPlayerOn(_enabled, _buttonIndex);
            }
            else
            {
                _enabled = true;
                ClapManager._instance.IsPlayerOn(_enabled, _buttonIndex);
            }
            
        }
    }
}
