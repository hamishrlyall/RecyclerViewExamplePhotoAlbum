using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using RecyclerView_Example;

namespace RecyclerViewer
{
    // Photo Class containing ID and Caption
    public class Photo
    {
        public int mPhotoID;
        public string mCaption;

        public int PhotoID
        {
            get { return mPhotoID; }
        }
        public string Caption
        {
            get { return mCaption; }
        }
    }

    // Photo album: holds all image IDs and Captions
    public class PhotoAlbum
    {
        static Photo[] mBuiltInPhotos = {
            new Photo { mPhotoID = Resource.Drawable.AbstractBlocks,
                        mCaption = "Abstract Blocks" },
            new Photo { mPhotoID = Resource.Drawable.AdventureTimeRainbow,
                        mCaption = "Adventure Time Rainbow" },
            new Photo { mPhotoID = Resource.Drawable.BetterCallSaul,
                        mCaption = "Better Call Saul"},
            new Photo { mPhotoID = Resource.Drawable.BreakingBad,
                        mCaption = "Breaking Bad"},
            new Photo { mPhotoID = Resource.Drawable.CalvinAndHobbes,
                        mCaption = "Calvin and Hobbes"},
            new Photo { mPhotoID = Resource.Drawable.CityNight,
                        mCaption = "City at Night"},
            new Photo { mPhotoID = Resource.Drawable.CloudyOcean,
                        mCaption = "Cloudy Ocean"},
            new Photo { mPhotoID = Resource.Drawable.FrogOnLeaf,
                        mCaption = "Frog on a Leaf"},
            new Photo { mPhotoID = Resource.Drawable.GreenForest,
                        mCaption = "Green Forest"},
            new Photo { mPhotoID = Resource.Drawable.GreenLeaves,
                        mCaption = "GreenLeaves"},
            new Photo { mPhotoID = Resource.Drawable.LizardJesus,
                        mCaption = "Lizard Jesus"},
            new Photo { mPhotoID = Resource.Drawable.LowResPokemon,
                        mCaption = "32 Bit Pokemon"},
            new Photo { mPhotoID = Resource.Drawable.Pier,
                        mCaption = "Pier"},
            new Photo { mPhotoID = Resource.Drawable.PlanetsAlign,
                        mCaption = "Planets Align"},
            new Photo { mPhotoID = Resource.Drawable.PlanetsAlignIllustrated,
                        mCaption = "Planets Align Illustrated"},
            new Photo { mPhotoID = Resource.Drawable.Rapture,
                        mCaption = "Rapture Bioshock"},
            new Photo { mPhotoID = Resource.Drawable.RoundHallway,
                        mCaption = "Round Hallway"},
            new Photo { mPhotoID = Resource.Drawable.SeaAndRocks,
                        mCaption = "Sea and Rocks"},
            new Photo { mPhotoID = Resource.Drawable.SkeletonJesus,
                        mCaption = "Skeleton Jesus"},
            new Photo { mPhotoID = Resource.Drawable.SnowyForest,
                        mCaption = "Snowy Forest"},
            new Photo { mPhotoID = Resource.Drawable.SnowyLandscape,
                        mCaption = "Snowy Landscape"},
            new Photo { mPhotoID = Resource.Drawable.SnowyMountain,
                        mCaption = "Snowy Mountain"},
            new Photo { mPhotoID = Resource.Drawable.SpaceCats,
                        mCaption = "Space Cats"},
            new Photo { mPhotoID = Resource.Drawable.TrainSmoke,
                        mCaption = "Train Smoke"},
            new Photo { mPhotoID = Resource.Drawable.TreeOnLake,
                        mCaption = "Tree on Lake"},
            new Photo { mPhotoID = Resource.Drawable.UprightBear,
                        mCaption = "Grizzly Bear"},
            new Photo { mPhotoID = Resource.Drawable.WinnieThePooh,
                        mCaption = "Winnie The Pooh"},
            new Photo { mPhotoID = Resource.Drawable.YellowBrickRoad,
                        mCaption = "Yellow Brick Road"},
            };

        // Array of photos to make up album
        private Photo[] mPhotos;
        // Create an instance copy of the built-in photo list and
        public PhotoAlbum()
        {
            mPhotos = mBuiltInPhotos;
        }

        // Returns the number of photos in the photo album:
        public int NumPhotos
        {
            get { return mPhotos.Length; }
        }

        //// Indexer for accessing a photo:
        public Photo this[int i]
        {
            get { return mPhotos[i]; }
        }
    }
}
