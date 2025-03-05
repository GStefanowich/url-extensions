namespace TheElm.Url {
    public static partial class UriHelper {
        public static UriBuilder WithScheme( this UriBuilder builder, string scheme ) {
            builder.Scheme = scheme;
            return builder;
        }
        
        public static UriBuilder WithUsername( this UriBuilder builder, string username ) {
            builder.UserName = username;
            return builder;
        }
        
        public static UriBuilder WithPassword( this UriBuilder builder, string password ) {
            builder.Password = password;
            return builder;
        }
        
        public static UriBuilder WithHost( this UriBuilder builder, string host ) {
            builder.Host = host;
            return builder;
        }
        
        public static UriBuilder WithPort( this UriBuilder builder, int port ) {
            builder.Port = port;
            return builder;
        }
        
        public static UriBuilder WithFragment( this UriBuilder builder, string fragment ) {
            builder.Fragment = fragment;
            return builder;
        }
        
        /// <summary>
        /// Method for simply returning the Uri from the Uri Builder, without looking out of place
        /// The most unnecessary method
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static Uri Build( this UriBuilder builder )
            => builder.Uri;
    }
}
