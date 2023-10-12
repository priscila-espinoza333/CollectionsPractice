﻿// 1.-Crear matriz para contener los valores enteros entre 0 a 9
int[] Valores = new int[10]{0,1,2,3,4,5,6,7,8,9};

for(int j = 0; j< Valores.Length; j++){
    Console.WriteLine(Valores[j]);
}


Console.WriteLine("--------------------------");
// 2.-Crear una matriz con los nombres TIM, MARTIN, NIKKI y SARA

string[] nombres = new string[5];
nombres[0] = "Tim";
nombres[1] = "Martin";
nombres[2] = "Nikki";
nombres[3] = "Sara";

Console.WriteLine(nombres);

for(int i = 0; i < nombres.Length; i++){
    Console.WriteLine(nombres[i]);
}

Console.WriteLine("--------------------------");

//3.-Crea una matriz con longitud 10 que alterne entre los valores true and false empezando por true
bool[] VerdaderoFalso = new bool[10];
for(int x = 0; x < VerdaderoFalso.Length; x++){
    VerdaderoFalso[x] = x % 2 == 0;
}
foreach (bool valor in VerdaderoFalso){
    Console.WriteLine(valor);
}

                // Lista de sabores 
Console.WriteLine("------------Lista--------------");

//Crea una lista de sabores de helados con almenos 5 sabores diferentes

List<string> listaHelado = new List<string>();
listaHelado.Add("Chocolate");
listaHelado.Add("Frutos del bosque");
listaHelado.Add("Lucuma");
listaHelado.Add("Chocolate Brownie");
listaHelado.Add("Platano");
listaHelado.Add("Chocolate Blanco");
listaHelado.Add("Mora Crema");

for(int h = 0; h < listaHelado.Count; h++){
     Console.WriteLine(listaHelado[h]);
}
Console.WriteLine("------------------");

Console.WriteLine(listaHelado[3]);
Console.WriteLine("------------------");

listaHelado.RemoveAt(3);

for(int h = 0; h < listaHelado.Count; h++){
     Console.WriteLine(listaHelado[h]);
}

                //Diccionario
Console.WriteLine("------------Diccionario--------------");

Dictionary<string, string> usuario = new Dictionary<string, string>();

usuario.Add("Tim","chocolate");
usuario.Add("Martin","platano");
usuario.Add("Nikki","frutos del bosque");
usuario.Add("Sara","lucuama");

foreach(KeyValuePair<string, string> renglon in usuario){
    Console.WriteLine(renglon.Key + " - " + renglon.Value);
}







