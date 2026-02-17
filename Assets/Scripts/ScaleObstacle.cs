using UnityEngine;

public class ScaleObstacle : MonoBehaviour
{
    public float tailleMin = 1f;
    public float tailleMax = 3f;
    public float tauxReduction = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float nouvelleTaille = transform.localScale.x - tauxReduction;

        if (nouvelleTaille < 1 || nouvelleTaille > 3)
        {
            tauxReduction *= -1;
        }
        transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);
    }
}
 