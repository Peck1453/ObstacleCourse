using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    new Rigidbody rigidbody;
    [SerializeField]
    float timeToUpdate = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log($"{Time.time} elapsed");

         if(Time.time > timeToUpdate)
         {
   //         Debug.Log($"{Time.time} Seconds have elapsed"); 
             StartGravity();
         }
    }

        void StartGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<MeshRenderer>().enabled = true;  
    }


}
