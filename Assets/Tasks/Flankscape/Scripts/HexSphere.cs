using UnityEngine;

public class HexSphere : MonoBehaviour
{

    [SerializeField] private Material myMat;
    private void Start()
    {
        myMat.SetVector("_SphereCenter", new Vector4(0.0f,0.0f,-1.0f,0.0f));
    }
}
