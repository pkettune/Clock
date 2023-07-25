using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicators : MonoBehaviour
{
  [SerializeField]
    private GameObject indicPrefab, smallIndicPrefab, clock;
    private float indicOffset = 2.3f;
    private float smallIndicOffset = 2.3f;
    private void Start()
    {
        indicOffset = (clock.transform.localScale.x / 2 - indicPrefab.transform.localScale.y / 2 * clock.transform.localScale.x) * 0.9f;
        smallIndicOffset = (clock.transform.localScale.x / 2 - smallIndicPrefab.transform.localScale.y / 2 * clock.transform.localScale.x) * 0.9f;
        float angle;
        for(int i = 0; i < 60; i++)//Cannot use the sign in the description
        {
            angle = 6 * i;
            GameObject indicator;
            if(angle % 30 == 0)
            {
                indicator = Instantiate(indicPrefab, indicPrefab.transform.position, Quaternion.identity, transform);
                indicator.transform.localPosition = new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), 0, Mathf.Cos(angle * Mathf.Deg2Rad)) * indicOffset;
            }  
            else
            {
                indicator = Instantiate(smallIndicPrefab, smallIndicPrefab.transform.position, Quaternion.identity, transform);
                indicator.transform.localPosition = new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), 0, Mathf.Cos(angle * Mathf.Deg2Rad)) * smallIndicOffset;
            }
            indicator.transform.localRotation = Quaternion.Euler(0, angle, 0);
		}
	}
}
