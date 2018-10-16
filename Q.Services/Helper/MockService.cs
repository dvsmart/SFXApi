using System;

namespace SFX.Services.Helper
{
    public abstract class MockService
    {
        public abstract string GetDataIdConfiguration(string entityType);
    }

    public static class DataIdGenerationService
    {
        public static string GenerateDataId(int? id,string dataIdPrefix, string customDataId = "")
        {
            return GetDataId(id, dataIdPrefix);
        }

        private static string GetDataId(this int? id, string dataIdPrefix)
        {
            string returnValue;
            var currentDataId = id.HasValue ? Convert.ToString(id.Value) : null;
            if (!string.IsNullOrEmpty(currentDataId))
            {
                var intPart = currentDataId.Replace(dataIdPrefix, "");

                if (!int.TryParse(intPart, out var incrementedValue))
                {
                    returnValue = string.Concat(dataIdPrefix, 1);
                }
                else
                {
                    incrementedValue = incrementedValue + 1;
                    returnValue = string.Concat(dataIdPrefix, incrementedValue);
                }
            }
            else
            {
                returnValue = string.Concat(dataIdPrefix, 1);
            }

            return returnValue;
        }
    }
}
