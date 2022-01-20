namespace Platform {

    public static class Responses {

        public static string DefaultResponse = @"
        <!DOCTYPE html>
            <html lang=""en"">
            <head>
                <link rel=""stylesheet"" 
                   href=""/lib/bootstrap/css/bootstrap.min.css"" />
                <title>Error</title>
            </head>
            <body class=""text-center"">
                <h3 class=""p-2"">Error {0}</h3>
                <h6>
                    You can go back to the <a href=""/"">homepage</a> and try again
                </h6>
            </body>
        </html>";
    }
}
