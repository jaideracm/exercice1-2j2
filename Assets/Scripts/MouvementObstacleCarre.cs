using UnityEngine;
using UnityEngine.UIElements;

public class MouvementObstacleCarre : MonoBehaviour
{
    public bool peutBouger;
    public float vitesse;
    public float positionDepartY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       float positionXAleatoire = Random.Range(-5f, 5f);

       transform.position = new Vector2(positionXAleatoire, positionDepartY);
    }

    // Update is called once per frame
    void Update()
    {
        float nouvellePositionX = transform.position.x;
        float nouvellePositionY = transform.position.y - vitesse;

        transform.position = new Vector2 (nouvellePositionX, nouvellePositionY);
        if(transform.position.y <= -9f)
        {
            float positionXAleatoire = Random.Range(-5f, 5f);
            transform.position = new Vector2 (positionXAleatoire, positionDepartY);
        }else if(transform.position.y >= 9f)
        {
            float positionXAleatoire = Random.Range(-5f, 5f);
            transform.position = new Vector2 (positionXAleatoire, positionDepartY);
        }
    }
}
