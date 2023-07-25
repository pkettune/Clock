using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Clock : MonoBehaviour
{
	[SerializeField]
	private GameObject secondsHandle, minutesHandle, hoursHandle;
	private float secondsMultiplier = 1f;
	private int inGameSeconds;
	private int timeAtStart = 1;

    // Update is called once per frame
    void Update()
    {
        inGameSeconds = Mathf.RoundToInt(Time.time * secondsMultiplier) + timeAtStart;
		secondsHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 60, 0);
		minutesHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 3600, 0);
		hoursHandle.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 43200, 0);
    }

}
