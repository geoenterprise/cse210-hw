using System;
using System.Collections.Generic;

public class GradingSystem
{
    // Method to calculate total grade
    public double CalculateFinalGrade(double knowledgeGrade, double skillsGrade, double personalDevelopmentGrade)
    {
        return (knowledgeGrade + skillsGrade + personalDevelopmentGrade) / 3.0;
    }

    // Method to calculate GPA
    public double CalculateGPA(double totalGrade)
    {
        
        if (totalGrade >= 90)
            return 4.0;
        else if (totalGrade >= 80)
            return 3.0;
        else if (totalGrade >= 70)
            return 2.0;
        else if (totalGrade >= 60)
            return 1.0;
        else
            return 0.0;
    }
}