using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main : MonoBehaviour
{

    public InputField startNumber;
    public InputField endNumber;
    public InputField OutputTextField;
    public InputField populationSize;

    /*
    GENETIC ALGORITHM APPROACH

    take first number and cut up in pieces, ordered, could be user defined or random like genetic code

    set up first population
    caclulate a fittnessvalue

    breed at a certain threshold,
    use similar and mate, use non-similar in beginning

    give respons if the solution is exakt or not.
    
    able to add a placehold number and get a new approch number

    being able to save each bridge

    */

    void Start()
    {
        //set default numbers and texts
        startNumber.text = "543210";
        endNumber.text = "102343";
        clearOutputWindow("Output window");
    }

    public void goButtonPressed()
    {
        //clear output window
        clearOutputWindow();

        //create initial population
        //get startnumber and chop up in pieces
    }

    private void clearOutputWindow(string str = "")
    {
        OutputTextField.text = str;
    }

    public void addTextToOutputWindow(string txt)
    {
        OutputTextField.text += txt + "\n";
    }

}
