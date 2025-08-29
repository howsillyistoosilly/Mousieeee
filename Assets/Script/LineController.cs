using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer lineRenderer;

    private Transform[] points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    public void SetupLine(Transform[] points)
    {
        lineRenderer.positionCount = points.Length;
        this.points = points;
    }
    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
