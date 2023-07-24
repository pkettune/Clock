using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Update is called once per frame

	public bool rotate;
    void Update()
    {
		if (rotate)
			transform.localRotation = Quaternion.Euler(0, Time.time * 60, 0);
    }
}
