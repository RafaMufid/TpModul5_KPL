﻿// See https://aka.ms/new-console-template for more information

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class Program
{
    public static void Main()
    {
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300061");
        dataNIM.PrintData();
    }
}
