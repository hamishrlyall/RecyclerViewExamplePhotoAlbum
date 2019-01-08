using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using RecyclerViewer;

namespace RecyclerView_Example
{
    [Activity(Label = "WallpaperApp", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //Instances of components required to display the album in activityMain
        //RecyclerView instance displays the album while the LayoutManager lays out each card in the RecyclerView
        //PhotoAlbumAdapter that accesses and manages the PhotoAlbum
        RecyclerView mRecyclerView;
        RecyclerView.LayoutManager mLayoutManager;
        PhotoAlbumAdapter mAdapter;
        PhotoAlbum mPhotoAlbum;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Instantiates PhotoAlbum, Sets view to "activityMain", gets RecyclerView layout
            mPhotoAlbum = new PhotoAlbum();
            SetContentView(Resource.Layout.activity_main);
            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            //Plugs the layout manager into the RecyclerView
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            //Creates the PhotAlbumAdapter for the RecyclerView and passes the PhotoAlbum for it to manage
            mAdapter = new PhotoAlbumAdapter(mPhotoAlbum);
            mRecyclerView.SetAdapter(mAdapter);

        }
    }
    // ViewHolder
    public class PhotoViewHolder : RecyclerView.ViewHolder
    {
        //References to ImageView and Textview to be displayed within the CardView in each row of the RecyclerView
        public ImageView Image { get; private set; }
        public TextView Caption { get; private set; }

        //References the imageView and textView defined in CardView layout
        public PhotoViewHolder(View itemView) : base(itemView)
        {
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            Caption = itemView.FindViewById<TextView>(Resource.Id.textView);
        }
    }
    // Adapter
    public class PhotoAlbumAdapter : RecyclerView.Adapter
    {
        //Instantiates PhotoAlbum into PhotoAlbumAdapter
        public PhotoAlbum mPhotoAlbum;
        // Loads the PhotoAlbumAdapter with the PhotoAlbum
        public PhotoAlbumAdapter (PhotoAlbum photoAlbum)
        {
            mPhotoAlbum = photoAlbum;
        }

        //Using the LayoutManager, Creates a new photo in the CardView
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //Inflates the CardView for the photo
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.PhotoCardView, parent, false);
            //Create a ViewHolder to find and hold these view references
            PhotoViewHolder vh = new PhotoViewHolder(itemView);
            return vh;
        }

        //Using the LayoutManager, fills the contents of the photo card
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            PhotoViewHolder vh = holder as PhotoViewHolder;
            // Load the photo image resource from the photo album:
            vh.Image.SetImageResource(mPhotoAlbum[position].PhotoID);
            // Load the photo caption from the photo album:
            vh.Caption.Text = mPhotoAlbum[position].Caption;
        }

        //Returns number of the photos in PhotoAlbum
        public override int ItemCount
        {
            get { return mPhotoAlbum.NumPhotos; }
        }
    }
}