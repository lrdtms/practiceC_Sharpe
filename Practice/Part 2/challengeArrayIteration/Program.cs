// See https://aka.ms/new-console-template for more information
string[] gradingScale = { "A", "B", "C", "D", "F" };

string A = gradingScale[0];
string B = gradingScale[1];
string C = gradingScale[2];
string D = gradingScale[3];
string F = gradingScale[4];

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaMarks = {90, 85, 92, 88, 95, 100, 89};
int[] andrewMarks = {92, 88, 90, 91, 89};
int[] emmaMarks = {90, 85, 44, 88, 95, 100, 89};
int[] loganMarks = {85, 90, 92, 88, 91};

int[] sophiaExams = {90, 85, 92, 88, 95};
int[] andrewExams = {92, 88, 90, 91, 89};
int[] emmaExams = {90, 85, 44, 88, 95};
int[] loganExams = {85, 90, 92, 88, 91};

int sophiaAvg = 0;
int andrewAvg = 0;
int emmaAvg = 0;
int loganAvg = 0;

int sophiaExamAvg = 0;
int andrewExamAvg = 0;
int emmaExamAvg = 0;
int loganExamAvg = 0;

int sophiaExtraCredit = 0;
int andrewExtraCredit = 0;
int emmaExtraCredit = 0;
int loganExtraCredit = 0;

int avg = 0;
int exam = 0;
int extraCredit = 0;
decimal points = 0;

string grade = "";

Console.WriteLine($"Student\t\tExam score\t\tOverall Grade\t\tExtra Credit");
foreach (string name in studentNames)
{
   if (name == "Sophia")
   {
   sophiaAvg += (int)sophiaMarks.Average();
   sophiaExamAvg += (int)sophiaExams.Average();
   avg = sophiaAvg;
   exam = sophiaExamAvg;
   sophiaExtraCredit = sophiaExams.Last();
   extraCredit = sophiaExtraCredit;
   points = ((decimal)extraCredit / 100) * 10;
   }
   else if (name == "Andrew")
   {
   andrewAvg += (int)andrewMarks.Average();
   andrewExamAvg += (int)andrewExams.Average();
   avg = andrewAvg;
   exam = andrewExamAvg;
   andrewExtraCredit = andrewExams.Last();
   extraCredit = andrewExtraCredit;
   points = ((decimal)extraCredit / 100) * 10;
   }
   else if (name == "Emma")
   {    
   emmaAvg += (int)emmaMarks.Average();
   emmaExamAvg += (int)emmaExams.Average();
   avg = emmaAvg;
   exam = emmaExamAvg;
   emmaExtraCredit = emmaExams.Last();
   extraCredit = emmaExtraCredit;
   points = ((decimal)extraCredit / 100) * 10;
    }

   else if (name == "Logan")
    {
   loganAvg += (int)loganMarks.Average();
   loganExamAvg += (int)loganExams.Average();
   avg = loganAvg;
   exam = loganExamAvg;
   loganExtraCredit = loganExams.Last();
    extraCredit = loganExtraCredit;
    points = ((decimal)extraCredit / 100) * 10;
    }

    if (avg >= 90)
    {
        grade = A;
    }
    else if (avg >= 80)
    {
        grade = B;
    }
    else if (avg >= 70)
    {
        grade = C;
    }
    else if (avg >= 60)
    {
        grade = D;
    }
    else
    {
        grade = F;
    }
   Console.Write($"{name}\t\t{exam}\t\t\t{avg}\t{grade}\t\t{extraCredit} ({points} pts)");
   
   
   Console.ReadLine();
}
