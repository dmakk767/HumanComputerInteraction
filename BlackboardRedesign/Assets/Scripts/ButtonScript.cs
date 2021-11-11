using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject LoginGO;
    public GameObject CoursesGO;
    public GameObject CourseGO;
    public GameObject CourseContentGO;
    public GameObject DBMainGO;
    public GameObject DBGO;
    public GameObject DBNewGO;
    public GameObject GradesGO;
    public GameObject AssignmentsGO;
    public GameObject UploadGO;
    public GameObject SubmitGO;
    public GameObject Assignment5GO;
    public GameObject QuizGO;

    //handles button presses

    //LOGIN SCREEN
    public void LoadCoursesScreen()
    {
        LoginGO.SetActive(false);
        CoursesGO.SetActive(true);
    }

    //COURSES SCREEN
    public void Course1()
    {
        CoursesGO.SetActive(false);
        CourseGO.SetActive(true);
    }

    //COURSE 1 SCREEN
    public void Content() { 
    
        CourseGO.SetActive(false);
        CourseContentGO.SetActive(true);
    }
    public void BackToCourses() 
    {
       
        CourseGO.SetActive(false);
        CoursesGO.SetActive(true);
    }
    public void LoadDBMain()
    {
        CourseGO.SetActive(false);
        DBMainGO.SetActive(true);
    }
    public void LoadGrades()
    {
        CourseGO.SetActive(false);
        GradesGO.SetActive(true);
    }
    public void LoadAssignments()
    {
        Assignment5GO.SetActive(false);
        QuizGO.SetActive(false);

        UploadGO.SetActive(false);
        SubmitGO.SetActive(false);
        CourseGO.SetActive(false);
        AssignmentsGO.SetActive(true);
    }
    public void LoadUpload()
    {
        SubmitGO.SetActive(false);
        AssignmentsGO.SetActive(false);
        CourseGO.SetActive(false);
        UploadGO.SetActive(true);
    }

    /// <summary>
    /// ///////
    /// </summary>
    //BACK TO MAIN COURSE SCREEN
    public void BackToCourse() //multiple uses
    {
        Assignment5GO.SetActive(false);
        QuizGO.SetActive(false);

        UploadGO.SetActive(false);
        SubmitGO.SetActive(false);
        AssignmentsGO.SetActive(false);
        GradesGO.SetActive(false);
        DBNewGO.SetActive(false);
        DBGO.SetActive(false);
        CourseContentGO.SetActive(false);
        DBMainGO.SetActive(false);
        CourseGO.SetActive(true);
    }


    //DB SCREEN
    public void LoadDB() //multiple uses
    {
        DBNewGO.SetActive(false);

        DBMainGO.SetActive(false);
        DBGO.SetActive(true);
    }

    //DB #1 

    public void BacktoDBMain() //multiple uses
    {
        DBNewGO.SetActive(false);

        DBGO.SetActive(false);
        DBMainGO.SetActive(true);
    }
    public void LoadNewPost() //multiple uses
    {
        DBGO.SetActive(false);
        DBNewGO.SetActive(true);
    }

    //assignments
    public void UploadAssignment() //multiple uses
    {
        QuizGO.SetActive(false);
        Assignment5GO.SetActive(false);
        UploadGO.SetActive(false);
        SubmitGO.SetActive(true);
    }


}
