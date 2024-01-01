namespace CSServer.Models {
    public static class Repository {
        private static List<MyProjects> responses = new();

        public static IEnumerable<MyProjects> Responses => responses;

        public static void AddResponse(MyProjects response) {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}