﻿using System;

public class CSharpExam : Exam
{
    private int score;
    public CSharpExam(int score)
    {


        this.Score = score;
    }

    public int Score
    {
        get { return this.score; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Score is a negative number");
            }
            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException("Score is  not in the range 1-100!");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
