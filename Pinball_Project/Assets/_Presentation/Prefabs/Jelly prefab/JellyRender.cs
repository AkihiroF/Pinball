using UnityEngine;

public class JellyRender : MonoBehaviour
{
    public static JellyRender Instance;

    public GameObject[] Bones;

    public Vector3 Center;

    public SkinnedMeshRenderer SMRenderer;
    public Mesh jellyBakedMesh;

    Vector3 vel;

    void Awake()
    {
        Instance = this;
    }

    void FixedUpdate()
    {
        for (int i = 0; i < Bones.Length; i++)
        {
            Center += Bones[i].transform.position;
        }

        Center /= Bones.Length;

        transform.position = Center;
        Center = Vector3.zero;

        JellyBakeMeshToCollider();
    }

    void JellyBakeMeshToCollider()
    {
        SMRenderer.BakeMesh(jellyBakedMesh);
        gameObject.GetComponent<MeshCollider>().sharedMesh = jellyBakedMesh;
    }
}
