﻿using aula_03;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int idade = 19;

Televisao tvSala = new Televisao(22);
Console.WriteLine($"O tamanho da tv é: {tvSala.Tamanho}");


Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();
tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();



