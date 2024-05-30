using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EffectSelector : MonoBehaviour
{
    [SerializeField] private GameObject[] effectPrefabs;
    private int currentEffect;

    private void Awake()
    {
        foreach (GameObject prefab in effectPrefabs)
        {
            prefab.SetActive(false);
        }
    }

    public void SelectEffect(int effect)
    {
        currentEffect = effect;
    }

    public void IsolateAndPlayEffect()
    {
        if (currentEffect < 0 || currentEffect > effectPrefabs.Length - 1) return;

        for(int i = 0; i < effectPrefabs.Length; i++) 
        {
            if(i == currentEffect)
            {
                effectPrefabs[i].SetActive(true);
                effectPrefabs[i].GetComponentInChildren<PlayableDirector>().Play();
            }
            else
            {
                effectPrefabs[i].SetActive(false);
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
