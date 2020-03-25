using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{
    public float distanceToSee;
    RaycastHit whatIHit;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("I toched " + whatIHit.collider.gameObject.name);
                if (whatIHit.collider.tag == "Beds")
                {
                    if (whatIHit.collider.gameObject.GetComponent<Bed>().whatBedAmI == Bed.Beds.bed1)
                    {
                        
                    }
                }
            }
        }
    }
}
