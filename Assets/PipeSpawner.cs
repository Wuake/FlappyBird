using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime;
    public float height;
    public GameObject pipe;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 pos = transform.position + new Vector3(0, Random.Range(-height, height));
        GameObject pipeInstance = Instantiate(pipe, pos, Quaternion.identity);

        Destroy(pipeInstance, 10f);
    }
}
