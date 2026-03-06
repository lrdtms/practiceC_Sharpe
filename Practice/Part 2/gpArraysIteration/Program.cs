// See https://aka.ms/new-console-template for more information
/*
string[] gradingScale = { "A", "B", "C", "D", "F" };

string A = gradingScale[0];
string B = gradingScale[1];
string C = gradingScale[2];
string D = gradingScale[3];
string F = gradingScale[4];

int[] sophiaMarks = {90, 85, 92, 88, 95};
int[] andrewMarks = {92, 88, 90, 91, 89};
int[] emmaMarks = {90, 85, 44, 88, 95};
int[] loganMarks = {85, 90, 92, 88, 91};

int sophiaTotal = 0;
int andrewTotal = 0;
int emmaTotal = 0;  
int loganTotal = 0;

decimal sophiaAvg = 0;
decimal andrewAvg = 0;  
decimal emmaAvg = 0;
decimal loganAvg = 0;

string sophiaGrade = "";
string andrewGrade = "";
string emmaGrade = "";
string loganGrade = "";

int numOfGrades = sophiaMarks.Length;

int markCounter = 0;

foreach (int sophiaMark in sophiaMarks)
{    
    markCounter++;
    sophiaTotal += sophiaMark;
    
}

foreach (int andrewMark in andrewMarks)
{    
    
    andrewTotal += andrewMark;
}
foreach (int emmaMark in emmaMarks)
{    
    emmaTotal += emmaMark;
}
foreach (int loganMark in loganMarks)
{    
    loganTotal += loganMark;
}

if (markCounter == numOfGrades)
    {
        sophiaAvg += (decimal)sophiaTotal / numOfGrades;
        andrewAvg += (decimal)andrewTotal / numOfGrades;
        emmaAvg += (decimal)emmaTotal / numOfGrades;
        loganAvg += (decimal)loganTotal / numOfGrades;
        
    }

if (sophiaAvg >= 90 || andrewAvg >= 90 || emmaAvg >= 90 || loganAvg >= 90)
{
    sophiaGrade = A;
    andrewGrade = A;
    emmaGrade = A;
    loganGrade = A;
}
else if (sophiaAvg >= 80 || andrewAvg >= 80 || emmaAvg >= 80 || loganAvg >= 80)
{
    sophiaGrade = B;
    andrewGrade = B;
    emmaGrade = B;
    loganGrade = B;
}
else if (sophiaAvg >= 70 || andrewAvg >= 70 || emmaAvg >= 70 || loganAvg >= 70)
{
    sophiaGrade = C;
    andrewGrade = C;
    emmaGrade = C;
    loganGrade = C;
}
else if (sophiaAvg >= 60 || andrewAvg >= 60 || emmaAvg >= 60 || loganAvg >= 60)
{
    sophiaGrade = D;
    andrewGrade = D;
    emmaGrade = D;
    loganGrade = D;
}
else
{
    sophiaGrade = F;
    andrewGrade = F;
    emmaGrade = F;
    loganGrade = F;
}    


Console.WriteLine($@"Student         Grade

Sophia:         {sophiaAvg}     {sophiaGrade}
Andrew:         {andrewAvg}     {andrewGrade}
Emma:           {emmaAvg}   {emmaGrade}
Logan:          {loganAvg}   {loganGrade}");
*/
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

int sophiaAvg = 0;
int andrewAvg = 0;
int emmaAvg = 0;
int loganAvg = 0;   

int avg = 0;

string grade = "";

Console.WriteLine($@"Student         Grade");
foreach (string name in studentNames)
{
   if (name == "Sophia")
   {
   sophiaAvg += (int)sophiaMarks.Average();
   avg = sophiaAvg;
   }
   else if (name == "Andrew")
   {
   andrewAvg += (int)andrewMarks.Average();
   avg = andrewAvg;
   }
   else if (name == "Emma")
   {    
   emmaAvg += (int)emmaMarks.Average();
   avg = emmaAvg;
    }

   else if (name == "Logan")
    {
   loganAvg += (int)loganMarks.Average();
   avg = loganAvg;
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
   Console.WriteLine($"{name}\t\t{avg}\t{grade}");
   //Console.WriteLine($@"         {avg}     {grade}");
   
   Console.ReadLine();
}