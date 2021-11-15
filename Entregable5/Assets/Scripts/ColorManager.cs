using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Color RandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public Vector3 RandomScale()
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
    }

    private void OnMouseDown()
    {
        transform.localScale = RandomScale();
        transform.position = RandomPosition();
        GetComponent<MeshRenderer>().material.color = RandomColor();
    }
}
