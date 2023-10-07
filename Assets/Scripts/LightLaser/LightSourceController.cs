using UnityEngine;

public class LightSourceController : MonoBehaviour
{
    public float minActivationTime = 2.0f;
    public float maxActivationTime = 5.0f;

    private bool isActive = false;
    private float nextActivationTime;
    private Renderer objectRenderer;

    private void Start()
    {
        SetNextActivationTime();
        objectRenderer = GetComponent<Renderer>();
        objectRenderer.enabled = false;
    }

    private void Update()
    {
        if (Time.time >= nextActivationTime)
        {
            isActive = !isActive;
            SetNextActivationTime();

            objectRenderer.enabled = isActive;
        }
    }

    private void SetNextActivationTime()
    {
        nextActivationTime = Time.time + Random.Range(minActivationTime, maxActivationTime);
    }

    public bool IsLightActive()
    {
        return isActive;
    }
}