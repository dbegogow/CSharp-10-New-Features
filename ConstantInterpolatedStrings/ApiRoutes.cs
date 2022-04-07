namespace ConstantInterpolatedStrings
{
    public static class ApiRoutes
    {
        private const string ApiBase = "/api";

        public static class Library
        {
            private const string Base = ApiBase + "/library";

            public const string GetById = $"{Base}/{{id:guid}}";

            public const string GetAll = Base;

            public const string Add = Base + "/{id:guid}";
        }
    }
}
