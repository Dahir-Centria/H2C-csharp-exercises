using System.Collections.Generic;
using System;
public class GradeRegister
{
    private List<int> examPoints;
    private List<int> grades;

    public GradeRegister()
    {
        this.grades = new List<int>();
        examPoints = new List<int>();
    }

    public void AddGradeBasedOnPoints(int points)
    {
        examPoints.Add(points);
        this.grades.Add(PointsToGrades(points));
    }

    public int NumberOfGrades(int grade)
    {
        int count = 0;
        foreach (int received in this.grades)
        {
            if (received == grade)
            {
                count++;
            }
        }
        return count;
    }

    public static int PointsToGrades(int points)
    {
        int grade = 0;
        if (points < 50)
        {
            grade = 0;
        }
        else if (points < 60)
        {
            grade = 1;
        }
        else if (points < 70)
        {
            grade = 2;
        }
        else if (points < 80)
        {
            grade = 3;
        }
        else if (points < 90)
        {
            grade = 4;
        }
        else
        {
            grade = 5;
        }
        return grade;
    }

    public double AverageOfGrades()
    {
        double result = 0;
        if (grades.Count < 1)
        {
            return -1;
        }
        foreach (int grade in grades)
        {
            result += grade;
        }

        result = Math.Round(result / grades.Count, 2);

        return result;
    }

    public double AverageOfPoints()
    {
        double result = 0;
        if (examPoints.Count < 1)
        {
            return -1;
        }
        foreach (int p in examPoints)
        {
            result += p;
        }

        result = Math.Round(result / examPoints.Count, 2);

        return result;
    }
}