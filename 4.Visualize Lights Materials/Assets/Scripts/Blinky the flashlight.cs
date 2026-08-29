using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkytheflashlight : MonoBehaviour
{
    public Light flashLight;
    public float minFlickerTime = 0.1f; // Minimum time the light can stay on or off
    public float maxFlickerTime = 1.0f;
    IEnumerator Flicker()
    {
        while (true)
        {
            // Randomly enable or disable the flashlight
            flashLight.enabled = Random.value > 0.5f;
            
            float flickerTime = Random.Range(minFlickerTime, maxFlickerTime);
            yield return new WaitForSeconds(flickerTime);
        }
    }
    void Start()
    {
        flashLight = GetComponent<Light>();
        
            if (flashLight == null)
            {
                flashLight = GetComponent<Light>(); // Get the Light component attached to the GameObject
            }

            StartCoroutine(Flicker());
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            flashLight.enabled = !flashLight.enabled;
        
    }
    
}
