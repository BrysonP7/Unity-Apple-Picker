using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Inscribed")]
    
    public GameObject basketPrefab;

    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    public List<GameObject> basketList;

    void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0; i < numBaskets; i++){
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (i*basketSpacingY);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleMissed(){
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject apple in appleArray){
            Destroy(apple);
        }
        
        if(basketList.Count > 0){
            Destroy(basketList[0]);
            basketList.RemoveAt(0);
        }
        if(basketList.Count <= 0){
            SceneManager.LoadScene("SampleScene");
            
        }
    }
}
