namespace TheElm.Url {
    public static partial class UriHelper {
        /// <summary>
        /// Create a new <see cref="T:System.UriBuilder"/> using the <see cref="T:System.Net.Http.HttpClient"/> BaseAddress
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static UriBuilder UriBuilder( this HttpClient client )
            => client.BaseAddress is not null ? new UriBuilder(client.BaseAddress) : new UriBuilder();
    }
}
