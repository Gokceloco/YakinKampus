using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name);
    }
}
