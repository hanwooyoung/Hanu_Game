using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTrackTile : MonoBehaviour {

    public CTrackCreator TrackCreater = null;
    public Vector3 Direction;
    public CTrackCreator.TrackKind Kind;

    private int mIndex;
    public int Index
    {
        get
        {
            return mIndex;
        }
        set
        {
            mIndex = value;
        }
    }

    public void SetTrackCreater(CTrackCreator tTrackCreater)
    {
        TrackCreater = tTrackCreater;
    }

   public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
