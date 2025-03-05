namespace TheElm.Url {
    public static partial class UriHelper {
        public static HttpRequestMessage Request( this UriBuilder builder, HttpMethod method )
            => new(method, builder.Build());
    }
}
