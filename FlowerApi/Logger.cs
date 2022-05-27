namespace FlowerApi
{
    public abstract class LogBase
    {
        public abstract void Log(string message);
    }

    //TODO: make logs in DB.
    public class Logger:LogBase
    {
        private string filePath = "../../FlowerLog.log";

        public override void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, append: true))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
        public void Flush() 
        {

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine("");
                streamWriter.Close();
            }

        }
    }

}
