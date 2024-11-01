using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject[] cameras;

    [SerializeField]
    private Vector3[] offsets = new Vector3[]
    {
        new Vector3(0, 5.43f, -8.73f),
        new Vector3(0, 2.47f, 0.5f)
    };

    private int currentCameraIndex = 0;
    private int offsetIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);

            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

            // Offset the camera behind the player by adding to the player's position
            offsetIndex = (offsetIndex + 1) % offsets.Length;
            cameras[currentCameraIndex].gameObject.SetActive(true);

        }

        cameras[currentCameraIndex].gameObject.transform.position = player.transform.position + offsets[offsetIndex];
        cameras[currentCameraIndex].gameObject.transform.rotation = player.transform.rotation;

    }
}
