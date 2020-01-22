using UnityEngine.Playables;

public static class TimelineExtensions
{
    public static void PauseTimeline(this PlayableDirector director)
    {
        director.playableGraph.GetRootPlayable(0).SetSpeed(0d);
    }

    public static void ResumeTimeline(this PlayableDirector director)
    {
        director.playableGraph.GetRootPlayable(0).SetSpeed(1d);
    }
}