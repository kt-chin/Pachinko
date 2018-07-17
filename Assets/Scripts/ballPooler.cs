using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPooler : MonoBehaviour {
    public static ballPooler sharedInstance;
    public List<GameObject> pooledBalls;
    public GameObject ballObjectPool;
    public int poolAmount;
	// Use this for initialization
	void Awake () {
        sharedInstance = this;
	}
    void Start()
    {
        pooledBalls = new List<GameObject>();
        for (int i = 0; i< poolAmount; i++)
        {
            GameObject ballObj = Instantiate(ballObjectPool);
            ballObj.SetActive(false);
            pooledBalls.Add(ballObj);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
    public GameObject GetPooledBall()
    {
        for (int i = 0; i < pooledBalls.Count; i++)
        {
            if (!pooledBalls[i].activeInHierarchy)
            {
                return pooledBalls[i];
            }
        }
        return null;
    }
}
