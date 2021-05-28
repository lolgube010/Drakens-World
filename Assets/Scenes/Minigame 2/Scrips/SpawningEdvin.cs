using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEdvin : MonoBehaviour
{
    public int RandomX;
    public int RandomStudent;
    public Transform Student;
    public float TimeBTWSpawn = 1;
    public GameObject[] Students;
    // Start is called before the first frame update
    void Start()
    {
        Students = Resources.LoadAll<GameObject>("Students");
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
            RandomStudent = Random.Range(0, Students.Length);
            yield return new WaitForSeconds(TimeBTWSpawn);
            Instantiate(Students[RandomStudent], new Vector3(RandomX, transform.position.y, 0), Quaternion.identity);
        }
 
    }
}
