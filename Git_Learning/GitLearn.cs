class GitLearn
{
    public GitLearn(int daysLearning)
    {
        DaysLearning = daysLearning;
    }

    public int DaysLearning { get; protected set;}
    public void IncreaseDays(int days)
    {
        DaysLearning += days;
    }
}