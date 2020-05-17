using System;

public static class GameVariables
{
    public static int Rows = 12;
    public static int Cols = 8;

    public static float AnimationDuration = 0.3f;
    public static float MoveAnimationDuration = 0.5f;
    public static float ExplosionAnimationDuration = 0.3f;

    public static float WaitBeforePotentialMatchesCheck = 2f;
    public static float OpacityAnimationDelay = 0.05f;

    public static int MinimumMatches = 3;
    public static int MinimumMatchesForBonus = 4;

    public static int Match3Score = 100;
    public static int SubsequelMatchScore = 1000;
}
