using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{
    public class kartPd : MonoBehaviour
    {
        public LibPdInstance pdPatch;
        public GameObject kart;

        ArcadeKart arcadeKart;

      
        void Awake()
        {
            arcadeKart = GetComponentInParent<ArcadeKart>();
        }

 
        
            void Update()
        {


            float kartSpeed = 0.0f;
            if (arcadeKart != null)
            {
                kartSpeed = arcadeKart.LocalSpeed();

            }
            pdPatch.SendFloat("currentSpeed", kartSpeed);

       
              
            

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
}