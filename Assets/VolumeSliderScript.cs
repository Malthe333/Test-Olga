using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;


    private void Start()
    {
        Manager.Instance.ChangeMasterVolume(_slider.value);

        _slider.onValueChanged.AddListener(val => Manager.Instance.ChangeMasterVolume(val));
    }
}