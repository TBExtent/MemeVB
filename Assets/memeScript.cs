using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memeScript : MonoBehaviour
{
    public int minX, maxX, minY, maxY, minZ, maxZ;
    public float minScaleX, maxScaleX, minScaleY, maxScaleY;
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Memes");
        if (sprites.Length == 0) Debug.LogError("No memes found");
        else {
            int memePos = Mathf.FloorToInt(Random.value * sprites.Length);
            while (memePos == sprites.Length) memePos = Mathf.FloorToInt(Random.value * sprites.Length);
            GetComponent<SpriteRenderer>().sprite = sprites[memePos];
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
            transform.rotation = Random.rotation;
            transform.localScale = new Vector3(Random.Range(minScaleX, maxScaleX), Random.Range(minScaleY, maxScaleY), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
