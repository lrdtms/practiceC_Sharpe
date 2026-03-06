// See https://aka.ms/new-console-template for more information
string studentName = "Sophia Johnson";
decimal englishGrade = 4.00m;
decimal algebraGrade = 3.00m;
decimal biologyGrade = 3.00m;
decimal computerScienceGrade = 3.00m;
decimal psychologyGrade = 4.00m;
int englishCredits = 3;
int algebraCredits = 3;
int biologyCredits = 4;
int computerScienceCredits = 4;
int psychologyCredits = 3;
decimal gpa = (biologyGrade + computerScienceGrade + englishGrade + algebraGrade + psychologyGrade) / 5;
 Console.WriteLine($@"Student Name: {studentName}
 Course             Grade  Credit Hours
 English 101         {(int)englishGrade}         {englishCredits}
 Algebra 101         {(int)algebraGrade}         {algebraCredits}
 Biology 101         {(int)biologyGrade}         {biologyCredits}
 Computer Science I  {(int)computerScienceGrade}         {computerScienceCredits}
 Psychology 101      {(int)psychologyGrade}         {psychologyCredits}

 Final GPA:          {gpa}");