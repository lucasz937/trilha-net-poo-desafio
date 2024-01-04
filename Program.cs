using DesafioPOO.Models;
using System;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia (numero:"128289129", modelo : "Modelo N1", imei: "8192192", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("edX");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero : "28182183", modelo: "Modelo X", imei: "37173721", memoria: "256");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
