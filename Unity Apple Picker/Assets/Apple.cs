using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update

    public static float bottomY = -20f;

    public static float maxHorizontalSpeed = 4f;
    public static float minHorizontalSpeed = 1f;
    public float HorizontalSpeed = 0f;

     void Start()
    {
        if(Random.value < 0.5){
            HorizontalSpeed = Random.Range(minHorizontalSpeed, maxHorizontalSpeed);
        }else{
            HorizontalSpeed = Random.Range(-maxHorizontalSpeed, -minHorizontalSpeed);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += HorizontalSpeed*Time.deltaTime;
        transform.position = pos;
        if(transform.position.y < bottomY){
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleMissed();
        }

        
    }
    
}
