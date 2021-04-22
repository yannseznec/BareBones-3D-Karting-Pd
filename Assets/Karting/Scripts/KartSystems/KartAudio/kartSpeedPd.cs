using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{

    public class kartSpeedPd : MonoBehaviour
    {
        public LibPdInstance pdPatch;
        ArcadeKart arcadeKart;

        // Start is called before the first frame update
        void Awake()
        {
            arcadeKart = GetComponentInParent<ArcadeKart>();
        }

        // Update is called once per frame
        void Update()
        {
            float kartSpeed = 0.0f;
            if (arcadeKart != null)
            {
                kartSpeed = arcadeKart.LocalSpeed();

            }
       //     print(kartSpeed);
            pdPatch.SendFloat("currentSpeed", kartSpeed);

        }
    }

}