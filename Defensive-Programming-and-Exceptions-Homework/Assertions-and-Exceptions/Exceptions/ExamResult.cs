﻿using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get { return this.grade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("grade","Grade can not be negative number!");
            }
            this.grade = value;
        }
    }

    public int MinGrade
    {
        get { return this.minGrade; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("minGrade", "Min Grade can not be negative number!");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get { return this.maxGrade; }
        private set
        {
            if ( value<= minGrade)
            {
                throw new ArgumentOutOfRangeException("maxGrade", "Max Grade can not be greater than Min Grade!");
            }
            this.maxGrade = value;

        }
    }

    public string Comments
    {
        get { return this.comments; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("comments", "There are no comments!");
            }
            this.comments = value;
        }
    }
}
