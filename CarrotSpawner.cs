using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{
    public GameObject carrot;
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        spawnCarrot();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
       {
           timer += Time.deltaTime;
       }
       else
       {
           spawnCarrot();
           timer = 0;
       }

    }
    void spawnCarrot()
   {
       float lowestPoint = transform.position.y - heightOffset;
       float highestPoint = transform.position.y + heightOffset;

       Instantiate(carrot, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
      
   }
    
}
