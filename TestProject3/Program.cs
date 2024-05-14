/*
    This app take the grade add, average and find a equivalent letter grade
*/
int examAssignments = 5;
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };


Console.WriteLine("Student\t\tGrade\n");

foreach (string studentName in studentNames)
{
    int[] studentScores = new int[10];
    int studentScoreSum = 0;

    if (studentName == "Sophia")
        studentScores = sophiaScores;

    else if (studentName == "Andrew")
        studentScores = andrewScores;

    else if (studentName == "Emma")
        studentScores = emmaScores;

    else if (studentName == "Logan")
        studentScores = loganScores;

    else if (studentName == "Becky")
        studentScores = beckyScores;

    else if (studentName == "Chris")
        studentScores = chrisScores;

    else if (studentName == "Eric")
        studentScores = ericScores;

    else if (studentName == "Gregor")
        studentScores = gregorScores;

    else
        continue;
    int gradedAssigments = 0;
    // Loop thru the grade of the student and add it all
    foreach (int score in studentScores)
    {
        // If more than the exam assignment make it 10% before add to studentScoreSum
        if (examAssignments <= gradedAssigments)
            studentScoreSum += score / 10;

        else
            studentScoreSum += score;

        gradedAssigments++;
    }

    //Console.WriteLine(extraCreditAssigment);
    decimal currentStudentGrade = (decimal)studentScoreSum / examAssignments;
    string letterGrade;

    if (currentStudentGrade >= 97)
        letterGrade = "A+";

    else if (currentStudentGrade >= 93)
        letterGrade = "A";

    else if (currentStudentGrade >= 90)
        letterGrade = "A-";

    else if (currentStudentGrade >= 87)
        letterGrade = "B+";

    else if (currentStudentGrade >= 83)
        letterGrade = "B";

    else if (currentStudentGrade >= 80)
        letterGrade = "B-";

    else if (currentStudentGrade >= 77)
        letterGrade = "C+";

    else if (currentStudentGrade >= 73)
        letterGrade = "C";

    else if (currentStudentGrade >= 70)
        letterGrade = "C-";

    else if (currentStudentGrade >= 67)
        letterGrade = "D+";

    else if (currentStudentGrade >= 63)
        letterGrade = "D";

    else if (currentStudentGrade >= 60)
        letterGrade = "D-";

    else
        letterGrade = "F";

    Console.WriteLine($"{studentName}:\t\t{currentStudentGrade}\t{letterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
