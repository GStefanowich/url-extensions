using TheElm.Literals;

namespace TheElm.Url {
    public static partial class UriHelper {
        public static UriBuilder WithPath( this UriBuilder builder, string? path ) {
            builder.Path = path ?? string.Empty;
            return builder;
        }
        
        public static UriBuilder WithPath( this UriBuilder builder, object?[] path ) {
            builder.Path = UriHelper.Join(path);
            return builder;
        }
        
        public static UriBuilder WithPath( this UriBuilder builder, string? start, params object?[] more )
            => builder.WithPath([ start, ..more ]);
        
        public static UriBuilder AddPath( this UriBuilder builder, string? path )
            => builder.AddPath([ path ]);
        
        public static UriBuilder AddPath( this UriBuilder builder, object?[] path )
            => builder.WithPath(builder.Path, path);
        
        private static string Join( object?[] values )
            => values.Select(value => UriHelper.RemoveSlashes(value as string ?? value?.ToString()))
                .OfType<string>()
                .Join('/');
        
        private static string? RemoveSlashes( string? input ) {
            // Don't join empty slashes
            if ( input is null or "/" )
                return null;
            
            // Remove '/' from the start so we don't get host.com//path
            if ( input.StartsWith('/') ) {
                input = input[1..];
            }
            
            // Remove '/' from the end so we don't get host.com/path//
            if ( input.EndsWith('/') ) {
                input = input[..^1];
            }
            
            // If blank, return null so we don't join to '//'
            return input is "" ? null : input;
        }
    }
}
