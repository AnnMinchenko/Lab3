using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Vector
    {
        private float coordX;
        private float coordY;
        private float coordZ;

        public Vector(float coordX, float coordY, float coordZ)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.coordZ = coordZ;
        }

        public static Vector operator +(Vector vectorA, Vector vectorB)
        {
            var resCoordX = vectorA.coordX + vectorB.coordX;
            var resCoordY = vectorA.coordY + vectorB.coordY;
            var resCoordZ = vectorA.coordZ + vectorB.coordZ;

            var vectorC = new Vector(resCoordX, resCoordY, resCoordZ);

            return vectorC;
        }

        public static Vector operator -(Vector vectorA, Vector vectorB)
        {
            var resCoordX = vectorA.coordX - vectorB.coordX;
            var resCoordY = vectorA.coordY - vectorB.coordY;
            var resCoordZ = vectorA.coordZ - vectorB.coordZ;

            var vectorC = new Vector(resCoordX, resCoordY, resCoordZ);

            return vectorC;
        }

        public static Vector operator *(Vector vectorA, Vector vectorB)
        {
            var resCoordX = vectorA.coordX * vectorB.coordX;
            var resCoordY = vectorA.coordY * vectorB.coordY;
            var resCoordZ = vectorA.coordZ * vectorB.coordZ;

            var vectorC = new Vector(resCoordX, resCoordY, resCoordZ);

            return vectorC;
        }

        public static double Length (Vector vectorA)
        {
            var length = Math.Sqrt(Math.Pow(vectorA.coordX, 2) + Math.Pow(vectorA.coordY, 2) + Math.Pow(vectorA.coordZ, 2));
            return length;
        }

        public static Vector operator &(Vector vectorA, Vector vectorB)
        {
            var resCoordX = vectorA.coordY * vectorB.coordZ - vectorA.coordZ * vectorB.coordY;
            var resCoordY = vectorA.coordZ * vectorB.coordX - vectorA.coordX * vectorB.coordZ;
            var resCoordZ = vectorA.coordX * vectorB.coordY - vectorA.coordY * vectorB.coordX;

            var vectorC = new Vector(resCoordX, resCoordY, resCoordZ);

            return vectorC;
        }


        public string Verbose()
        {
            return String.Format("{0} {1} {2}", this.coordX, this.coordY, this.coordZ);
        }
    }
}






















/*
            string[] strCords = new string[3];
            strCords[0] = coordX.ToString();
            strCords[1] = coordY.ToString();
            strCords[2] = coordZ.ToString();
            return strCords;
            */