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
    public InputField generationSize;

    private gaIndividualCollection[] population;

    /*
    GENETIC ALGORITHM APPROACH

    caclulate a fittnessvalue
    breed at a certain threshold,
    use similar and mate, use non-similar in beginning
    give respons if the solution is exakt or not.
    if individual have exact solution, add to solutions?
    able to add a placehold number and get a new approch number
    being able to save each bridge
    */

    void Start()
    {
        //set default numbers and texts
        startNumber.text = "543210";
        endNumber.text = "102343";
        populationSize.text = "20";
        generationSize.text = "200";
        clearOutputWindow("Output window");
    }

    public void goButtonPressed()
    {
        //clear output window
        clearOutputWindow();

        //create initial population
        createPopulation();

        //evaluate individual and their fitnessvalue

        //top half breed new population
    }
    
    private void createPopulation()
    {
        //initiate population

        //take first number and cut up in pieces, ordered, could be user defined or random like genetic code

        //bread population with individuals
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
