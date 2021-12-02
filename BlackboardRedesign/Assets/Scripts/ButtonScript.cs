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
    public GameObject Announce1GO;
    public GameObject Announce2GO;
    public GameObject Announce3GO;
    public GameObject PostReplyGO;
    public GameObject TEXTPostReplyGO;
    public GameObject TEXTSubmitGO;
    public GameObject TEXTJacobGO;
    public GameObject TEXTPostDBGO;

    public GameObject TEXTHelp;
    public GameObject TEXTProfile;

    public GameObject PostJacobScreenGO;
    public GameObject SillybusGO;
    public GameObject Assign5GO;
    public GameObject ContactGO;
    public GameObject disableME;

    public void Start()
    {
        disableME.SetActive(false);
    }
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
        Assign5GO.SetActive(false);
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
        ContactGO.SetActive(false);
        Assign5GO.SetActive(false);
        SillybusGO.SetActive(false);
        PostJacobScreenGO.SetActive(false);
        Assignment5GO.SetActive(false);
        QuizGO.SetActive(false);
        Announce1GO.SetActive(false);
        Announce2GO.SetActive(false);
        Announce3GO.SetActive(false);
        PostReplyGO.SetActive(false);
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

    //HELP BUTTON
    public void LoadHelp() //multiple uses
    {
        //show the help text
        TEXTHelp.SetActive(true);

        //trun off the help text
        Invoke("HideTextPost", 3f);

    }

    //PROFILE BUTTON
    public void LoadProfile()
    {
        //show the text
        TEXTProfile.SetActive(true);
        //hide in a few seconds
        Invoke("HideTextPost", 3f);
    }

    //DB SCREEN
    public void LoadDB() //multiple uses
    {
        DBNewGO.SetActive(false);
        PostReplyGO.SetActive(false);
        PostJacobScreenGO.SetActive(false);

        DBMainGO.SetActive(false);
        DBGO.SetActive(true);
    }

    //DB #1 

    public void BacktoDBMain() //multiple uses
    {
        DBNewGO.SetActive(false);
        PostReplyGO.SetActive(false);
        PostJacobScreenGO.SetActive(false);

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
        Assign5GO.SetActive(false);

        QuizGO.SetActive(false);
        Assignment5GO.SetActive(false);
        UploadGO.SetActive(false);
        SubmitGO.SetActive(true);
    }
    //load anouncements
    public void LoadAnn1() 
    {
        CourseGO.SetActive(false);
        Announce1GO.SetActive(true);
    }
    public void LoadAnn2()
    {
        CourseGO.SetActive(false);
        Announce2GO.SetActive(true);
    }
    public void LoadAnn3()
    {
        CourseGO.SetActive(false);
        Announce3GO.SetActive(true);
    }

    //post reply to thread in DB
    public void LoadPostReply()
    {
        DBGO.SetActive(false);
        PostReplyGO.SetActive(true);
    }

    //show text
    public void ShowTextPost()
    {
        TEXTPostDBGO.SetActive(true);
        TEXTPostReplyGO.SetActive(true);
        TEXTSubmitGO.SetActive(true);
        TEXTJacobGO.SetActive(true);
        Invoke("HideTextPost", 3f);
    }
    public void HideTextPost()
    {
        TEXTPostReplyGO.SetActive(false);
        TEXTSubmitGO.SetActive(false);
        TEXTJacobGO.SetActive(false);
        TEXTPostDBGO.SetActive(false);
        TEXTHelp.SetActive(false);
        TEXTProfile.SetActive(false);
    }

    //load JocobPost
    public void LoadJacobPost()
    {
        DBGO.SetActive(false);
        PostJacobScreenGO.SetActive(true);
    }

    //load assignment 5
    public void LoadAssign5()
    {
        CourseGO.SetActive(false);
        Assign5GO.SetActive(true);
    }

    //load quiz
    public void LoadQuiz()
    {
        CourseGO.SetActive(false);
        QuizGO.SetActive(true);
    }

    //load sillybus
    public void LoadSillness()
    {
        CourseGO.SetActive(false);
        SillybusGO.SetActive(true);
    }

    //load  contact info
    public void LoadContact()
    {
        CourseGO.SetActive(false);
        ContactGO.SetActive(true);
    }

}

