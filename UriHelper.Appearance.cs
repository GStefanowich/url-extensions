using TheElm.Literals;

namespace TheElm.Url {
    public static partial class UriHelper {
        public static string HideTrailingSlash( this Uri uri )
            => uri.ToString().TrimEnd('/');
        
        public static string ToSimpleString( this Uri uri ) {
            string str = uri.HideTrailingSlash();
            string[] schemes = [ Uri.UriSchemeHttp, Uri.UriSchemeHttps ];
            
            return schemes.Aggregate(str, (current, scheme) => current.TrimStart($"{scheme}://"));
        }
    }
}
