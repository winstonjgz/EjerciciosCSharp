using System;

//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentsScores = new int[10];

// initialize variables - graded assignments 
int examAssignments = 5;
/*int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };*/

//Con estos otros datos asignamos nuevas unidades de credito a los alumnos

/* int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 }; */

//Se agregan nuevos estudiantes
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };


string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");
foreach (string studentName in studentNames)
{
    string currentStudent = studentName;
    if (studentName == "Sophia")
    {
        studentsScores = sophiaScores;
    }
    else if (studentName == "Andrew")
    {
        studentsScores = andrewScores;
    }
    else if (studentName == "Emma")
    {
        studentsScores = emmaScores;
    }
    else if (studentName == "Logan")
    {
        studentsScores = loganScores;
    }
    else if (currentStudent == "Becky")
        studentsScores = beckyScores;
    else if (currentStudent == "Chris")
        studentsScores = chrisScores;
    else if (currentStudent == "Eric")
        studentsScores = ericScores;
    else if (currentStudent == "Gregor")
        studentsScores = gregorScores;
    else
        continue;
        
    //Console.WriteLine($"{studentName}");
        int sumAssignmentScores = 0;
        decimal currentStudentGrade;
        // initialize/reset a counter for the number of assignments
        int gradedAssignments = 0;
        foreach (int score in studentsScores)
        {
                // increment the assignment counter
            gradedAssignments += 1;

            if (gradedAssignments <= examAssignments)
                // add the exam score to the sum
                sumAssignmentScores += score;

            else
                // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                sumAssignmentScores += score / 10;
        }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{studentName}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");



}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
