using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CTrackTileLoader : CResourceLoader
{
    public struct TilePaths
    {
        public string PathStartTrack;
        public string PathVerticalTrack;
        public string PathHorizontalTrack;
        public string PathUpLeftTrack;
        public string PathUpRightTrack;
        public string PathLeftUpTrack;
        public string PathRightUpTrack;
    }


    private CTrackTile PFStartTrack = null;
    private CTrackTile PFVerticalTrack = null;
    private CTrackTile PFHorizontalTrack = null;
    private CTrackTile PFUpLeftTrack = null;
    private CTrackTile PFUpRightTrack = null;
    private CTrackTile PFLeftUpTrack = null;
    private CTrackTile PFRightUpTrack = null;

    protected abstract TilePaths InitTilePaths();

    public override void Load()
    {
        TilePaths paths = InitTilePaths();

        PFStartTrack = Resources.Load<CTrackTile>(paths.PathStartTrack);
      
    }
}
