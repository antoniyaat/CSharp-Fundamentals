﻿/*============================================================================
    File:		Lab.sln

    Summary:	This document defines the exercises for "C# OOP Advanced" course at Software University. 
                You can check the solution here: https://judge.softuni.bg/Contests/Practice/Index/706

                THIS SCRIPT IS PART OF LECTURE: 
                Generics - Lab

    Date:		29.03.2018

    .NET Version: 2.1.4
------------------------------------------------------------------------------*/

public class StartUp
{
    public static void Main()
    {
        string[] strings = ArrayCreator.Create(5, "Pesho");
        int[] integers = ArrayCreator.Create(10, 33);
    }
}