// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Adapter;

Console.WriteLine("Hello, World!");


var task = new MyTask(new LegacyClass());



var adaptor = new AdapterClass(new LegacyClass());

var task2 = adaptor.DoNewWork();