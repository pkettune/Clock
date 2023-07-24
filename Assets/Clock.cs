using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
	[SerializeField]
	private GameObject SecondsArmPivot, MinutesArmPivot, HoursArmPivot;
	private float secondsMultiplier = 1f;
	private int inGameSeconds;
	private int timeAtStart = 20000;

    // Update is called once per frame
    void Update()
    {
        inGameSeconds = Mathf.RoundToInt(Time.time * secondsMultiplier) + timeAtStart;
		SecondsArmPivot.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 60, 0);
		MinutesArmPivot.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 3600, 0);
		HoursArmPivot.transform.localRotation = Quaternion.Euler(0, inGameSeconds * 360 / 43200, 0);
    }
}
