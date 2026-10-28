using UnityEngine;
public class PillerMover : MonoBehaviour
{
    public float pillerSpeed = 3f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(pillerSpeed*Time.deltaTime*Vector2.left);
    }
}
