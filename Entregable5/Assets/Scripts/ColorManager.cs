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
        return new Color(RandomRange(0f, 1f), RandomRange(0f, 1f), RandomRange(0f, 1f));
    }

    public Vector3 RandomScale()
    {
        return new Vector3(RandomRange(-1f, 1f), RandomRange(-1f, 1f), RandomRange(-1f, 1f));
    }

    public Vector3 RandomPosition()
    {
        return new Vector3(RandomRange(-5f, 5f), RandomRange(-5f, 5f), 0);
    }

    private void OnMouseDown()
    {
        transform.localScaler += RandomScale();
        transform.position += RandomPosition();
        colorMat = RandomColor();
        GetComponent<MeshRenderer>().material.color = colorMat;
    }
}
