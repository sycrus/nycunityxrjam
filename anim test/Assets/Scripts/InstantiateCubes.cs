using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;

    // Start is called before the first frame update
    void Start()
    {
 
        for (int i = 0; i < 512; i++)
        {
            GameObject _instantSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instantSampleCube.transform.position = this.transform.position;
            _instantSampleCube.transform.parent = this.transform;
            _instantSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instantSampleCube.transform.position = Vector3.forward * 100;
            _sampleCube[i] = _instantSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (_sampleCube !=null)
            {
                //Debug.Log(FindObjectOfType<AudioSpec>()._samples[i]);
                _sampleCube[i].transform.localScale = new Vector3 (10, (FindObjectOfType<AudioSpec>()._samples [i] * _maxScale) + 2, 10);
            }
        }
    }
}
