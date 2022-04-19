// Расстояние между точками в 3D пространстве
int x1 = 5;
int y1 = 17;
int z1 = 8;
int x2 = 15;
int y2 = 24;
int z2 = 73;
double Length = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.Write(Length);
