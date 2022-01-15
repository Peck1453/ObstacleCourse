using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    float xSpin = 0;
    [SerializeField]
    float ySpin = 0;
    [SerializeField]
    float zSpin = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
    }
}
