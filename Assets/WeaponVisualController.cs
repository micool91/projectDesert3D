using UnityEngine;

public class WeaponVisualController : MonoBehaviour
{
    [SerializeField] private Transform[] gunTransforms;

    [SerializeField] private Transform pistol;
    [SerializeField] private Transform revolver;
    [SerializeField] private Transform autoRifle;
    [SerializeField] private Transform shotgun;
    [SerializeField] private Transform rifle;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
            SwitchOn(pistol);

        if (Input.GetKeyUp(KeyCode.Alpha2))
            SwitchOn(revolver);

        if (Input.GetKeyUp(KeyCode.Alpha3))
            SwitchOn(autoRifle);

        if (Input.GetKeyUp(KeyCode.Alpha4))
            SwitchOn(shotgun);

        if (Input.GetKeyUp(KeyCode.Alpha5))
            SwitchOn(rifle);
    }

    private void SwitchOn(Transform gunTransform)
    {
        SwitchOffGuns();
        gunTransform.gameObject.SetActive(true);
    }

    private void SwitchOffGuns()
    {
        for (int i = 0; i < gunTransforms.Length; i++)
        {
            gunTransforms[i].gameObject.SetActive(false);
        }
    }
}
