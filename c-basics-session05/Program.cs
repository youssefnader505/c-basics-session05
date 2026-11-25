using library.cs;
#region Q1
book b = new book();
// Console.WriteLine(b.password); inaccessible due to private access modifier
#endregion

#region Q2
book1 copies = new book1();
Console.WriteLine(copies.copiesInStock);
#endregion

#region Q3
book2 title = new book2();
title.title= "C#";
Console.WriteLine(title.title);
#endregion

#region Q4
book3 myGenre = new book3();
myGenre.Genre = EGenre.Science;
Console.WriteLine(myGenre.Genre);
#endregion

#region Q5
Console.WriteLine((int)EGenre.Fiction);
Console.WriteLine((int)EGenre.NonFiction);
Console.WriteLine((int)EGenre.Science);
#endregion

#region Q6
int genreNumber = 1;

EGenre genreValue = (EGenre)genreNumber;

Console.WriteLine(genreValue);
#endregion

#region Q7
EGenre genreName = EGenre.Fiction;
string genreString = genreName.ToString();
Console.WriteLine(genreString);
#endregion

#region Q8
string genreText = "Science";
EGenre parseGenre;
//
#endregion