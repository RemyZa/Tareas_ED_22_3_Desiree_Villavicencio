using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Casas : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "G.Gryffindor  S.Slytherin  R.Ravenclaw  H.Hufflepuff";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {texto.text = "¡Gryffindor! Donde habitan los valientes.    Su osadia, temple y caballerosidad ponen aparte a los Gryffindor";
         }

        if (Input.GetKeyDown(KeyCode.S))
        {texto.text = "¡Slytherin! Donde haras tus verdaderos amigos.    Esa gente astuta utiliza cualquier medio para lograr sus fines";
         }
        if (Input.GetKeyDown(KeyCode.R))
        {texto.text = "¡Ravenclaw! Una mente mu dispuesta.     Porque los de inteligencia y erudicion siempre encontraran ahi a sus semejantes";
         }
        if (Input.GetKeyDown(KeyCode.H))
        {texto.text = "¡Hufflepuf! Donde son justos y leales.     Esos perseverantes Hufflepuf, de verdad no temen al trabajo pesado";
         }
    }
}
