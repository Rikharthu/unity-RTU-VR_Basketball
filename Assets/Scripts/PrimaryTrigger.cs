using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** When ball triggers this primary collider, we need to tell the secondary collider, 
 * which is under the primary colldier, to expect that ball to trigger it (exactly that instance) */
public class PrimaryTrigger : MonoBehaviour {

    
    private SecondaryTrigger secondaryTrigger;

    void Start()
    {
        // get reference to the CHILD SecondaryTrigger
        secondaryTrigger = GetComponentInChildren<SecondaryTrigger>();
    }

    void OnTriggerEnter(Collider collider)
    {
        // tell secondary collider to expect exactly that collider instance to score a point
        secondaryTrigger.ExpectCollider(collider);
    }
}
