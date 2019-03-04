using System;

namespace AgroClinic.Infra.CrossCutting.Shared.Utils.BaseClient
{
    public interface IErrorLogger
    {
        void LogError(Exception ex, string infoMessage);
    }
    public class ErrorLogger : IErrorLogger
    {
        public void LogError(Exception ex, string infoMessage)
        {
            //TODO: Log the error to your error database
        }
    }
}
