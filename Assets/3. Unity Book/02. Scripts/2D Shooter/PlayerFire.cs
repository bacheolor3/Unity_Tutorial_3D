using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    private GameObject bulletFactory;
    public GameObject firePosition;

    private void Start()
    {
        bulletFactory = Resources.Load<GameObject>("Bullet"); // load bullet prefab from resources folder
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position; // position set
            // bullet.transform.rotation = firePosition.transform.rotation; // rotation set

            // bullet.transform.SetPositionAndRotation(position, rotation); // pos and rot are double set
            // bullet.transform.parent = parent;
            // bullet.transform.SetParent(parent); // set parent object
        }
    }
}
