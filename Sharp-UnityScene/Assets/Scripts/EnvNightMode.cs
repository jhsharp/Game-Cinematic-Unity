using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvNightMode : MonoBehaviour
{
    public bool isParent = false;
    public bool nightMode = false;
    public GameObject dayObj;
    public GameObject dayObj2;
    public GameObject nightObj;
    public bool select = false;

    // Start is called before the first frame update
    void Start()
    {
        if (dayObj2 == null)
        {
            dayObj2 = dayObj;
        }

        dayObj.SetActive(false);
        dayObj2.SetActive(false);
        nightObj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (!isParent)
        {
            if (transform.parent.gameObject.GetComponent<EnvNightMode>().nightMode)
            {
                dayObj.SetActive(false);
                dayObj2.SetActive(false);
                nightObj.SetActive(true);
            }
            else
            {
                if (transform.parent.gameObject.GetComponent<EnvNightMode>().select) dayObj.SetActive(true);
                else dayObj2.SetActive(true);
                nightObj.SetActive(false);
            }
            transform.parent.gameObject.GetComponent<EnvNightMode>().select = !transform.parent.gameObject.GetComponent<EnvNightMode>().select;
        }
    }
}
