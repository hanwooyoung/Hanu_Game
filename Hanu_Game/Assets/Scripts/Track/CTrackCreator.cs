using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTrackCreator
{
    public const int TRACK_SIZE = 1;

    public enum TrackKind
    {
        START = 0,
        VERTICAL = 1,
        HORIZONTAL = 2,
        UPLEFT = 3,
        UPRIGHT = 4,
        LEFTUP = 5,
        RIGHTUP = 6,
    }

    public Dictionary<TrackKind, List<TrackKind>> NextTrackKind = null;


    /// <summary>
    /// 현재트랙에서 다음 트랙타일이 나올 수 있는지를 담는 리스트 정보 메소드
    /// </summary>
    public void CreateNextTrackKind()
    {
        NextTrackKind = new Dictionary<TrackKind, List<TrackKind>>();

        NextTrackKind.Add(TrackKind.START, new List<TrackKind>() { TrackKind.VERTICAL });
        NextTrackKind.Add(TrackKind.VERTICAL, new List<TrackKind>() { TrackKind.VERTICAL, TrackKind.UPLEFT, TrackKind.UPRIGHT });
        NextTrackKind.Add(TrackKind.HORIZONTAL, new List<TrackKind>() { TrackKind.HORIZONTAL, TrackKind.LEFTUP, TrackKind.RIGHTUP });

        NextTrackKind.Add(TrackKind.UPLEFT, new List<TrackKind>() { TrackKind.HORIZONTAL, TrackKind.LEFTUP });
        NextTrackKind.Add(TrackKind.LEFTUP, new List<TrackKind>() { TrackKind.VERTICAL, TrackKind.UPLEFT, TrackKind.UPRIGHT });
        NextTrackKind.Add(TrackKind.UPRIGHT, new List<TrackKind>() { TrackKind.HORIZONTAL, TrackKind.RIGHTUP });
        NextTrackKind.Add(TrackKind.RIGHTUP, new List<TrackKind>() { TrackKind.VERTICAL, TrackKind.UPLEFT, TrackKind.UPRIGHT });
    }

}
