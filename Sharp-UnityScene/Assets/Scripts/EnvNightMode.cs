using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvNightMode : MonoBehaviour
{
    public bool isParent = false;
    public bool nightMode = false;
    public GameObject dayObj;
    public GameObject nightObj;

    // Start is called before the first frame update
    void Start()
    {
        if (!isParent)
        {
            if (transform.parent.gameObject.GetComponent<EnvNightMode>().nightMode)
            {
                dayObj.SetActive(false);
                nightObj.SetActive(true);
            }
            else
            {
                dayObj.SetActive(true);
                nightObj.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
