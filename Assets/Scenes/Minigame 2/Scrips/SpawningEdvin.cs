using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEdvin : MonoBehaviour
{
    public int RandomX;
    public Transform Student;
    public float TimeBTWSpawn = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            RandomX = Random.Range(-9, 10);
            yield return new WaitForSeconds(TimeBTWSpawn);
            Instantiate(Student, new Vector3(RandomX, 6.26f, 0), Quaternion.identity);
        }
 
    }
}
