using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTileNumber0Loader : CTrackTileLoader
{

    protected override TilePaths InitTilePaths()
    {
        TilePaths paths = new TilePaths();

        paths.PathStartTrack = "Prefabs/Number0/PFStartTrack";
        paths.PathVerticalTrack = "Prefabs/Number0/PFVerticalTrack";
        paths.PathHorizontalTrack = "Prefabs/Number0/PFHorizontalTrack";
        paths.PathUpLeftTrack = "Prefabs/Number0/PFUpLeftTrack";
        paths.PathUpRightTrack = "Prefabs/Number0/PFUpRightTrack";
        paths.PathLeftUpTrack = "Prefabs/Number0/PFLeftUpTrack";
        paths.PathRightUpTrack = "Prefabs/Number0/PFRightUpTrack";

        return paths;
    }
}
