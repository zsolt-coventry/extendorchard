using Orchard.UI.Resources;

namespace ExtendOrchard.MediaPlus
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("jCrop").SetUrl("jquery.Jcrop.min.js").SetDependencies("jQuery");
        }
    }
}
