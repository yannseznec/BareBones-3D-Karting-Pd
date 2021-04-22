using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartPositionPd : MonoBehaviour
{
    public LibPdInstance pdPatch;
    public GameObject kart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loc_x = kart.transform.position.x;
        float loc_y = kart.transform.position.y;
        float loc_z = kart.transform.position.z;

        pdPatch.SendFloat("locationX", loc_x);
        pdPatch.SendFloat("locationY", loc_y);
        pdPatch.SendFloat("locationZ", loc_z);

        float rot_x = kart.transform.localEulerAngles.x;
        float rot_y = kart.transform.localEulerAngles.y;
        float rot_z = kart.transform.localEulerAngles.z;

        pdPatch.SendFloat("rotationX", rot_x);
        pdPatch.SendFloat("rotationY", rot_y);
        pdPatch.SendFloat("rotationZ", rot_z);
    }
}
