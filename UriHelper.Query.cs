using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Primitives;

namespace TheElm.Url {
    public static partial class UriHelper {
        public static UriBuilder WithQuery( this UriBuilder builder, string? queryString ) {
            builder.Query = queryString;
            return builder;
        }
        
        public static UriBuilder WithQuery( this UriBuilder builder, QueryBuilder? queryString )
            => builder.WithQuery(queryString?.ToString());
        
        public static UriBuilder WithQuery( this UriBuilder builder, IEnumerable<KeyValuePair<string, string>> parameters )
            => builder.WithQuery(new QueryBuilder(parameters));
        
        public static UriBuilder WithQuery( this UriBuilder builder, IEnumerable<KeyValuePair<string, StringValues>> parameters )
            => builder.WithQuery(new QueryBuilder(parameters));
    }
}
