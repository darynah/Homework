using System;

namespace ArrayX0
{
  class Program
  {
 public enum Mark
 {
   Empty,
   Cross,
   Circle
 }

 public enum GameResult
 {
   CrossWin,
   CircleWin,
   Draw
 }

 public static void Main()
 {
   Check("XXX OO. ...");
   //Check("OXO XO. .XO");
   //Check("OXO XOX OX.");
   //Check("XOX OXO OXO");
   //Check("... ... ...");
   //Check("XXX OOO ...");
 }

 private static void Check(string description)
 {
   //Console.WriteLine(description.Replace(" ", "\r\n"));
   Console.WriteLine(GetGameResult(CreateFromString(description)));
   //Console.WriteLine();
   Console.ReadLine();
 }

 private static Mark IdentifyMark(char chr)
 {
   if (chr == 'X')
  return Mark.Cross;
   if (chr == 'O')
  return Mark.Circle;

   return Mark.Empty;
 }

 public static Mark[,] CreateFromString(string str)
 {
   var splt = str.Split(' ');
   return new[,]
   {
  {IdentifyMark(splt[0][0]), IdentifyMark(splt[0][1]), IdentifyMark(splt[0][2])},
  {IdentifyMark(splt[1][0]), IdentifyMark(splt[1][1]), IdentifyMark(splt[1][2])},
  {IdentifyMark(splt[2][0]), IdentifyMark(splt[2][1]), IdentifyMark(splt[2][2])}
   };
 }

 public static bool HasWinSequence(Mark[] combination)
 {
   var array = new int [3];
   bool a = false;
   for (int i = 0; i < array.Length; i++)
   {
  if ((array[i] == array[i]))
  a = true;
  else a = false;
   }
   return a;
 }


 public static GameResult GetGameResult(Mark[,] field)
 { 
   HasWinSequence(new[] { field[0, 0], field[0, 1], field[0, 2]});
   HasWinSequence(new[] { field[1, 0], field[1, 1], field[1, 2] });
   HasWinSequence(new[] { field[2, 0], field[2, 1], field[2, 2] });
   HasWinSequence(new[] { field[0, 0], field[1, 0], field[2, 0] });
   return GameResult.CrossWin;
 }
  }
}
