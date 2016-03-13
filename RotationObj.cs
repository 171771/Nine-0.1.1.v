using UnityEngine;
using System.Collections;

public class RotationObj : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    public float turnSpeed = 50f;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        Vector3 euler = transform.rotation.eulerAngles;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                if (hit.collider.tag == "MIRROR")
                {
                    // euler.y += Input.GetAxis("Oculus_GearVR_LIndexTrigger") *  * 3.25f;
                    transform.Rotate(new Vector3 (Input.GetAxis("Oculus_GearVR_LIndexTrigger") + Time.deltaTime * 10, 0, 0));
                    Debug.Log("hi");
                }
            }
            else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
            {
                if (hit.collider.tag == "MIRROR")
                {
                    // euler.y += Input.GetAxis("Oculus_GearVR_LIndexTrigger") *  * 3.25f;
                    transform.Rotate(new Vector3(Input.GetAxis("Oculus_GearVR_LIndexTrigger") + Time.deltaTime * 10, 0, 0));
                    Debug.Log("hi");
                }
            }
        }
    }
}
