using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureOverlay : MonoBehaviour
{
    [SerializeField, Range(-1f, 1f)] private float temperature;
    [SerializeField] private Material freezingMaterial, hotMaterial;



    private void OnValidate()
    {
        freezingMaterial.SetFloat("_Strength", Mathf.Clamp(temperature * -1f, 0f, 1f));
        hotMaterial.SetFloat("_Strength", Mathf.Clamp(temperature, 0f, 1f));
    }

    public void ChangeTemperature(float targetTemperature)
    {

    }

    private IEnumerator Coroutine_ChangeTemperature(float targetTemperature)
    {
        yield return null;
    }
}
