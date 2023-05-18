using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPlants : MonoBehaviour
{
    public List<MeshRenderer> growMeshes;
    public float timeToGrow = 5;
    public float refreshRate = 0.05f;
    [Range(0, 1)]
    public float minGrow = 0;
    [Range(0,1)]
    public float maxGrow = 1;

    private List<Material> growMaterials = new List<Material>();
    private bool fullyGrown;

    void Start()
    {
        for (int i=0; i<growMeshes.Count; i++)
        {
            for (int j=0; j< growMeshes[i].materials.Length; j++)
            {
                if (growMeshes[i].materials[j].HasProperty("Grow_"))
                {
                    growMeshes[i].materials[j].SetFloat("Grow_", minGrow);
                    growMaterials.Add(growMeshes[i].materials[j]);
                }
            }
            
        }
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i=0; i<growMaterials.Count; i++)
            {
                StartCoroutine(GrowVines(growMaterials[i]));
            }
        }
    }

    IEnumerator GrowVines (Material mat)
    {
        float growValue = mat.GetFloat("Grow_");

        if (!fullyGrown)
        {
            while (growValue < maxGrow)
            {
                growValue += 1 /(timeToGrow / refreshRate);
                mat.SetFloat("Grow_", growValue);

                yield return new WaitForSeconds (refreshRate);
            }
        }
        else
        {
            while (growValue > minGrow)
            {
                growValue -= 1 / (timeToGrow / refreshRate);
                mat.SetFloat("Grow_", growValue);

                yield return new WaitForSeconds (refreshRate);
            }
        }

        if(growValue >= maxGrow)
        {
            fullyGrown = true;
        }
        else
        {
            fullyGrown = false;
        }
    }
}
