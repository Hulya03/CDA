using CL_Expression;

Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
double resutat = exp1.Evalue();

Console.WriteLine(resutat);

Expression exp2 = new Addition(new Nombre(33), exp1);
double resutat2 = exp2.Evalue();

Console.WriteLine(resutat2);

Console.WriteLine(exp1.ToString());

Expression exp3 = new Addition(new Soustraction(new Nombre(33), new Nombre(33)), new Nombre(33));
double resutat3 = exp3.Evalue();
Console.WriteLine(resutat3);


Console.WriteLine(exp3.Formate());
