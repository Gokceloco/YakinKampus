using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Material ballMaterial;
    private void OnCollisionEnter(Collision collision)
    {
        ballMaterial.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }
}
