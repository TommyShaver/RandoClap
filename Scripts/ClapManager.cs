using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapManager : MonoBehaviour
{
    public static ClapManager _instance { get; set; }
    public AudioClip[] _clapSamples;
    public AudioSource[] _audioScourceVoices;
    private bool[] _playerOn = new bool[9];
    private bool[] _isRandom = new bool[9];
    public int[] _samplechoice = new int[16];
    

    //Set up logic -----------------------------------------------------
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < _audioScourceVoices.Length; i++)
        {
           GetComponent<AudioSource>();
        }
    }

    //In game logic ------------------------------------------------------
    public void ClapSampleLogic()
    {
        if (_playerOn[0])
        {
            SampleStartFunction(0, _samplechoice[0], _isRandom[0]);
        }
        if (_playerOn[1])
        {
            SampleStartFunction(1, _samplechoice[1], _isRandom[1]);
        }
        if (_playerOn[2])
        {
            SampleStartFunction(2, _samplechoice[2], _isRandom[2]);
        }
        if (_playerOn[3])
        {
            SampleStartFunction(3, _samplechoice[3], _isRandom[3]);
        }
        if (_playerOn[4])
        {
            SampleStartFunction(4, _samplechoice[4], _isRandom[4]);
        }
        if (_playerOn[5])
        {
            SampleStartFunction(5, _samplechoice[5], _isRandom[5]);
        }
        if (_playerOn[6])
        {
            SampleStartFunction(6, _samplechoice[6], _isRandom[6]);
        }
        if (_playerOn[7])
        {
            SampleStartFunction(7, _samplechoice[7], _isRandom[7]);
        }
        if (_playerOn[8])
        {
            SampleStartFunction(8, _samplechoice[8], _isRandom[8]);
        }
    }
    public void WhichSample(int sample, int whichPlayer)
    {
        _samplechoice[whichPlayer] = sample;
    }
    public void IsPlayerOn(bool isOn, int whichPlayer)
    {
        _playerOn[whichPlayer] = isOn;

    }
    public void IsTimeRandom(bool isRadon, int whichPlayer)
    {
        _isRandom[whichPlayer] = isRadon;
    }
    private float ReturnRandom()
    {
        float randomNumber = UnityEngine.Random.Range(0.0f, 0.05f);
        return randomNumber;
    }

    private void SampleStartFunction(int scource, int clip, bool isRandom)
    {
        float time;
        if(isRandom) 
        {
             time = ReturnRandom(); 
        }
        else 
        {
             time = 0; 
        }
        StartCoroutine(StartSample(time, _audioScourceVoices[scource], _clapSamples[clip]));
    }

    private IEnumerator StartSample(float _time, AudioSource _playerName, AudioClip _clip)
    {
        yield return new WaitForSeconds(_time);
        _playerName.clip = _clip;
        _playerName.Play();
    }
}
