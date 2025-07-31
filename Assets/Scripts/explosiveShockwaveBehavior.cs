using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosiveShockwaveBehavior : MonoBehaviour
{
    [SerializeField] private GameObject shock_wave;
    private Vector3 scaleChange;
    public float scaleRate;
    //public float scaleLimit;
    private float scaleLimitNumber;
    private Vector3 scaleLimit;
    public bool shockWaveDestroy = false;
    // Start is called before the first frame update
    
    void Awake()
    {
        scaleLimitNumber = 7;
        scaleLimit = new Vector3(scaleLimitNumber,scaleLimitNumber,scaleLimitNumber);
        scaleRate = 0.1f;
        scaleChange = new Vector3(scaleRate,scaleRate,scaleRate);
    }

    // Update is called once per frame
    void Update()
    {
        shock_wave.transform.localScale += scaleChange;
        if (transform.localScale==scaleLimit)
        {
            Debug.Log("Kaboom!");
            Destroy(shock_wave);
            shockWaveDestroy = true;
        }
    }
}
