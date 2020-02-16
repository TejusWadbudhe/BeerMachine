using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSphere : MonoBehaviour
{
    private void onBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
