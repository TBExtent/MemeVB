using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemeControlScript : MonoBehaviour
{
    public GameObject meme;
    public int memeCount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < memeCount; i++) {
            Instantiate(meme);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
