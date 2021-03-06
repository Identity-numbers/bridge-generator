﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public InputField startNumber;
    public InputField endNumber;
    public InputField OutputTextField;
    public InputField populationSize;
    public InputField popStartPieces;
    public InputField generationSize;

    //TODO these are not used, remove?
    public List<gaIndividualCollection> gaIndPopulation_List = new List<gaIndividualCollection>();
    public List<gaIndividual> gaIndividual_List = new List<gaIndividual>();
    public List<gaIndividualPiece> gaIndividualPiece_List = new List<gaIndividualPiece>();

    public GameObject gaIndividualCollection_GameObject;
    public GameObject gaIndividual_GameObject;
    public GameObject gaIndividualPiece_GameObject;

    //linked in editor
    public cutUpPieces cutUpPieces;

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

    //initialized before scene opens up
    void Start()
    {
        //set default numbers and texts
        startNumber.text = "543210";
        endNumber.text = "102343";
        populationSize.text = "20";
        generationSize.text = "200";
        popStartPieces.text = "20";
    }

    public void goButtonPressed()
    {
        Debug.Log("go pressed");
        //clear output window
        clearOutputWindow();

        //cutUpNumbers to pieces, set class up
        cutUpNumberToPieces();

        //create initial population
        createPopulation();

        //evaluate individual and their fitnessvalue
        setFittnessValue();

        //top half breed new population, this is the iteration process,
    }

    public void setFittnessValue()
    {
        //TODO
    }

    private void cutUpNumberToPieces()
    {
        // cut up number to full set of pieces
        cutUpPieces.startNumber = int.Parse(startNumber.text);
        cutUpPieces.cutItUp();
    }

    private void createPopulation()
    {
        //initiate population
        int pSize = int.Parse(populationSize.text);
        int popPiecesSize = int.Parse(popStartPieces.text);

        gaIndividualCollection pop = Instantiate(gaIndividualCollection_GameObject.GetComponent<gaIndividualCollection>());

        //create individuals
        for (int i = 0; i < pSize; i++)
        {
            gaIndividual popInd = Instantiate(gaIndividual_GameObject.GetComponent<gaIndividual>());
            popInd.gameObject.transform.parent = pop.gameObject.transform;

            List<gaIndividual> gaIndList = new List<gaIndividual>();

            //create pieces for each individual
            for (int j = 0; j < popPiecesSize; j++)
            {
                gaIndividualPiece popIndPieces = Instantiate(gaIndividualPiece_GameObject.GetComponent<gaIndividualPiece>());
                popIndPieces.gameObject.transform.parent = popInd.gameObject.transform;

                //modify gap
                //TODO

                //list of parts added to individual
                popInd.indPiecesList.Add(popIndPieces);
            }

            //list of individuals added to population
            pop.gaCollectionArr.Add(popInd);
        }

        //bread population with individuals
        //get startnumber and chop up in pieces
    }

    private void clearOutputWindow(string str = "Window cleared!\n")
    {
        OutputTextField.text = str;
    }

    public void addTextToOutputWindow(string txt)
    {
        OutputTextField.text += txt + "\n";
    }
}
