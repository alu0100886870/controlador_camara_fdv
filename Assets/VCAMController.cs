using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VCAMController : MonoBehaviour
{
    public List<CinemachineVirtualCamera> camaras;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            desactivarCamaras();
            activarCamara(0);
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
            desactivarCamaras();
            activarCamara(1);
        }

        if (Input.GetKey(KeyCode.Keypad2))
        {
            desactivarCamaras();
            activarCamara(2);
        }

        if (Input.GetKey(KeyCode.Keypad3))
        {
            desactivarCamaras();
            activarCamara(3);
        }
    }

    private void desactivarCamaras()
    {
        for (int i = 0; i < camaras.Count; i++)
        {
            CinemachineVirtualCamera cam = camaras[i];
            cam.enabled = false;
        }
    }
    private void activarCamara(int i)
    {
        if (camaras.Count >= i)
            camaras[i].enabled = true;
    }
}
