using System.Collections;
using UnityEngine;

public class FlickeringLightEmission : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;

    private void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLightEmissionEffect());
        }
    }

    IEnumerator FlickeringLightEmissionEffect()
    {
        isFlickering = true;
        this.gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
        this.gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.yellow);
        timeDelay = Random.Range(0.01f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        timeDelay = Random.Range(0.01f, 0.8f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
