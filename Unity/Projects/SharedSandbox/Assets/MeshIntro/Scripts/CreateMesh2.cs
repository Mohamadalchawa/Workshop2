using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMesh2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        var filter = GetComponent<MeshFilter>();

        filter.sharedMesh = CreateQuad();
        //filter.sharedMesh = CreateTri();
    }

    Mesh CreateQuad()
    {
        Mesh mesh = new Mesh();

        //create vertwx attru=ibutes
        //positions
        //colors
        //colors?
        //normals??
        //uv coordinates


        //1 create verstex attribute


        Vector3[] positions = new Vector3[4];

        positions[0] = new Vector3(0f, 0f, 0f);
        positions[1] = new Vector3(1f, 0f, 0f);
        positions[2] = new Vector3(0f, 1f, 0f);
        positions[3] = new Vector3(1f, 1f, 0f);



        Color[] colors = new Color[4];
        colors[0] = new Color(1f, 0f, 0.5f, 1);
        colors[1] = new Color(1f, 1f, 0.5f, 1);
        colors[2] = new Color(0f, 1f, 0.5f, 1);
        colors[3] = new Color(0f, 0f, 0.5f, 1);

        //Vector3[] positions2 = new Vector3[4]
        //{
        //    new Vector3(0f, 0f, 0f),
        //    new Vector3(0f, 0f, 0f),
        //    new Vector3(0f, 0f, 0f),
        //    new Vector3(0f, 0f, 0f),
        //};
        //2 create indices

        int[] tris = new int[]
        {
            0,1,2,
            1,3,2

        };


        //assign to mesh

        mesh.vertices = positions;
        mesh.colors = colors;

        mesh.SetTriangles(tris, 0);

        return mesh;


    }

    //Mesh CreateTri()
    //{
    //    Mesh mesh = new Mesh();

    //    create vertwx attru = ibutes
    //    positions
    //    colors
    //    colors?
    //    normals ??
    //    uv coordinates


    //    1 create verstex attribute


    //    Vector3[] positions = new Vector3[3];

    //    positions[0] = new Vector3(0f, 0f, 0f);
    //    positions[1] = new Vector3(1f, 0f, 0f);
    //    positions[2] = new Vector3(0f, 1f, 0f);

    //    Vector2[] texCoords = new Vector2[3];

    //    texCoords[0] = new Vector2(0f, 0f);
    //    texCoords[1] = new Vector2(1f, 0f);
    //    texCoords[2] = new Vector2(0f, 1f);





    //    Vector3[] positions2 = new Vector3[4]
    //    {
    //        new Vector3(0f, 0f, 0f),
    //        new Vector3(0f, 0f, 0f),
    //        new Vector3(0f, 0f, 0f),
    //        new Vector3(0f, 0f, 0f),
    //    };
    //    2 create indices

    //    int[] tris = new int[]
    //    {
    //        0,1,2

    //    };


    //    assign to mesh

    //    mesh.vertices = positions;
    //    mesh.uv = texCoords;
    //    mesh.SetTriangles(tris, 0);

    //    return mesh;


    //}

    ////CHALLANGE
    //Mesh CreateTetra()
    //{

    //    Vector3[] positions = new Vector3[]
    //    {
    //        new Vector3(0f,0f,0f),
    //        new Vector3(1f,0f,1f),
    //        new Vector3(1f,1f,0f),
    //        new Vector3(0f,1f,1f)

    //    };

    //    Color[] colors = new Color[]
    //    {
    //        new Color(0f,0f,0.5f),
    //        new Color(1f,0f,0.5f),
    //        new Color(0f,1f,0.5f),
    //        new Color(1f,1f,0.5f)
    //    };


    //    var tris = new int[] 
    //    {
    //        0,1,3,
    //        2,1,0,
    //        2,0,3,
    //        3,1,2 
    //    };

    //    Mesh tetra = new Mesh();

    //    tetra.vertices = positions;
    //    tetra.SetTriangles(tris,0);
    //    tetra.colors = colors;
    //    return tetra;
    //}

    /// <summary>
    /// creates a colorful unit quadrilateral
    /// </summary>
    Mesh CreateGrid(int faceX, int faceY)
    {
        
        var verts = new Vector3[]
        {
            
        };




        Mesh grid = new Mesh();
        return grid;


    }

    
    
    //
    ///
    /// 
    /// 
    // Update is called once per frame
    void Update ()
    {
		
	}
}
