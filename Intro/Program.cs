// See https://aka.ms/new-console-template for more information
using System;

namespace Intro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CharactersProblem();
            Console.WriteLine(FishTankVolumeProblem(10, 10, 10));
            Console.WriteLine(MicroscopyProblem());
            Console.WriteLine(CarpetCostProblem(7, 6, 17));
            Console.WriteLine(EnergyBillProblem(10,15,39.3));
            Console.WriteLine(CirclePropertiesProblem(2, 90));
            Console.WriteLine(BallPitProblem(1, 0.2, 0.05));
        }

        static void CharactersProblem()
        {
            Console.WriteLine("The digits are: 0123456789");
            Console.WriteLine("The characters are: abcdABCD@#!£");
            Console.WriteLine("The alphanumberics are: 0123456789 abcdABCD@#!£");
        }

        static double FishTankVolumeProblem(double length, double height, double depth) // calc volume of a fish tank from 3 dimensions
        {
            
            return (length * depth * height) / 1000;

        }

        static double MicroscopyProblem() // calc magnification of microscope from actua size of sample and measured size
        {
            double actualSize = 80; //micrometers
            double measurement = 4; //cm
            double actualMicro = measurement * 10000; //actual size in micrometers
            double magnification = actualMicro / actualSize;
            return magnification;

        }

        static string CarpetCostProblem(double width, double length, double pricePM2) // calculate cost to carpet a room by adding all individual costs
        {
            double area = width * length; 
            double underlay = area * 3; //price of underlay

            double areaPrice = area * pricePM2;
            double gripperCost = width * 2 + length * 2;

            double tPrice = underlay + areaPrice + gripperCost + 50;

            decimal value = 0.00M;
            value = Convert.ToDecimal(tPrice);     

            return value.ToString("C"); //return total cost
        }

        static double EnergyBillProblem(double prevReading, double currReading, double calorValue) // calc energy price from 2 readings and the calorific value
        {
            double unitsUsed = currReading;
            double kWh = unitsUsed * 1.022 * (calorValue / 3.6);

            double price = (kWh / 2.84) * 100; //convert from pence to pounds

            return price;
                     
        }


        static string CirclePropertiesProblem(double diameter, double arcAngle) // calculate various circle proporties from the diameter and arc angle of an arc
        {
            double radius = diameter / 2;

            double area = 3.14 * Math.Pow(radius, 2);

            double circumference = 3.14 * diameter;

            double arcLength = (circumference * arcAngle) / 360;

            return $"radius: {radius} area: {area} circumference: {circumference} arc length: {arcLength}";

        }

        static double CalcBallVolume(double ballR) // calculate volume of a single ball for following problem
        {
            double ballVolume = (4 / 3) * 3.14 * Math.Pow(ballR, 3);

            return ballVolume;
        }

        static double BallPitProblem(double ballPitR, double ballPitH, double ballRadius) // calculate number of balls required to fill a ball pit
        {

            double packingDensity = 0.75;

            double ballPitVolume = 3.14 * ballPitH * Math.Pow(ballPitR, 2);

            double numBalls = ballPitVolume / CalcBallVolume(ballRadius) * packingDensity;

            return Math.Ceiling(numBalls); //integer balls required is ceil of float
        }
    }
}