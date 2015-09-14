namespace GameLauncher
{
    public class JsonGameInfo
    {
        public string name { get; set; }
        public string startExe { get; set; }
        public string image { get; set; }
        public string dir { get; set; }

        public override string ToString()
        {
            return "name: " + name + "\n" + 
                   "startExe: " + startExe + "\n" + 
                   "image: " + image + "\n" + 
                   "dir: " + dir;
        }
    }
}
