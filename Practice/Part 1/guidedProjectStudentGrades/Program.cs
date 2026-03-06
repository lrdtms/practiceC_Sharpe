// See https://aka.ms/new-console-template for more information

/*Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah:   84, 96, 73, 85, 79

Jeong:  90, 92, 98, 100, 97*/

float sophiaEng = 93;
float sophiaMath = 87;
float sophiaSci = 98;
float sophiaHist = 95;
float sophiaPE = 100;
float nicholasEng = 80;
float nicholasMath = 83;  
float nicholasSci = 82;
float nicholasHist = 88;
float nicholasPE = 85;
float zahirahEng = 84;
float zahirahMath = 96;
float zahirahSci = 73;
float zahirahHist = 85;
float zahirahPE = 79;    
float jeongEng = 90;
float jeongMath = 92;
float jeongSci = 98;
float jeongHist = 100;
float jeongPE = 97;
float sophiaTotal = (sophiaEng + sophiaMath + sophiaSci + sophiaHist + sophiaPE) / 5 ;
float nicholasTotal = (nicholasEng + nicholasMath + nicholasSci + nicholasHist + nicholasPE) / 5 ;
float zahirahTotal = (zahirahEng + zahirahMath + zahirahSci + zahirahHist + zahirahPE) / 5 ;
float jeongTotal = (jeongEng + jeongMath + jeongSci + jeongHist + jeongPE) / 5 ;

Console.WriteLine($@"Student   Grade
Sophia    {sophiaTotal} A
Nicholas  {nicholasTotal} B
Zahirah   {zahirahTotal} B
Jeong     {jeongTotal} A");
