using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine;

public class Randomness : MonoBehaviour
{
    public Volume volume;
    public ColorAdjustments colorAdjustments;
    public float[] randomHueShitf;

    private void Awake()
    {
        volume = GetComponent<Volume>();
    }
    void Start()
    {
        //volume = GetComponent<Volume>();
        volume.profile.TryGet(out colorAdjustments);
        colorAdjustments.hueShift.value = randomHueShitf[Random.Range(0, randomHueShitf.Length)];
    }
}
