using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
private enum States {Forks, Spoons, Knives};
private States Utensils;


	// Use this for initialization
	void Start () {
	Utensils=States.Forks;
	}
	
	void Forks () {
	print ("You've been forked!");
	if 	(Input.GetKeyDown (KeyCode.F)) {Utensils=States.Forks;}
	else if (Input.GetKeyDown (KeyCode.S)) {Utensils=States.Spoons;}
	else if (Input.GetKeyDown (KeyCode.K)) {Utensils=States.Knives;}
	}
	
	void Spoons () {
	print ("Spoons are not special.");
	if 	(Input.GetKeyDown (KeyCode.F)) {Utensils=States.Forks;}
	else if (Input.GetKeyDown (KeyCode.S)) {Utensils=States.Spoons;}
	else if (Input.GetKeyDown (KeyCode.K)) {Utensils=States.Knives;}
	}
	
	void Knives () {
	print ("Knives cut things...");
	if 	(Input.GetKeyDown (KeyCode.F)) {Utensils=States.Forks;}
	else if (Input.GetKeyDown (KeyCode.S)) {Utensils=States.Spoons;}
	else if (Input.GetKeyDown (KeyCode.K)) {Utensils=States.Knives;}
	}
	
	// Update is called once per frame
	void Update () {
	if 	(Utensils==States.Forks) {Forks ();}
	else if (Utensils==States.Spoons) {Spoons ();}
	else if (Utensils==States.Knives) {Knives ();}
	}
}
