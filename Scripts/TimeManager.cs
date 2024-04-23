using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float _beatsPreMinute = 120f;
    private float _beatInterval;
    private float _beatTimer;
    private float _updatedBPM;

    private void Start()
    {
        _beatInterval = 60f / _beatsPreMinute;
        _beatTimer = _beatInterval;
        _updatedBPM = _beatsPreMinute;
    }

    private void FixedUpdate()
    {
        _beatTimer -= Time.fixedDeltaTime;

        if (_beatTimer <= 0)
        {

            if (_beatsPreMinute <= _updatedBPM || _beatsPreMinute >= _updatedBPM)
            {
                _updatedBPM = _beatsPreMinute;
                _beatInterval = 60f / _updatedBPM;
                _beatTimer += _beatInterval;
            }
            else
            {
                _beatTimer += _beatInterval;
            }
            //ClapManager._instance.RandomStartSample();
        }
    }
}
