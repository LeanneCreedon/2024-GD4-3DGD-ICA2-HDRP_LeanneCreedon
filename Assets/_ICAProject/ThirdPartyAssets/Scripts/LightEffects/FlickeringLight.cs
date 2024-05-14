using System.Collections;
using UnityEngine;
/// <summary>
/// Resource: HOW TO MAKE FLICKERING LIGHTS IN UNITY WITH C# TUTORIAL
/// https://www.youtube.com/watch?v=DNMdu3kylec
/// Accessed: 14-05-24
/// </summary>
public class FlickeringLight : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;

    private void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLightEffect());
        }
    }

    IEnumerator FlickeringLightEffect()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
