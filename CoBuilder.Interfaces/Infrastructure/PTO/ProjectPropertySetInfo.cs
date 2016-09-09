using System;

namespace CoBuilder.Service.Infrastructure.PTO
{
    public class ProjectPropertySetInfo : PropertySetInfo
    {
        public string WorkplaceName
        {
            get
            {
                return Properties.ContainsKey(Constants.Identifiers.Properties.WorkplaceName)
                    ? Properties[Constants.Identifiers.Properties.WorkplaceName].Value
                    : null;
            }
            set
            {
                Properties[Constants.Identifiers.Properties.WorkplaceName] = new PropertyInfo
                {
                    DisplayName = "Workplace Name",
                    Identifier = Constants.Identifiers.Properties.WorkplaceName,
                    Value = value
                };
            }
        }

        public int WorkplaceId
        {
            get
            {
                if (!Properties.ContainsKey(Constants.Identifiers.Properties.WorkplaceId)) return default(int);
                int id;
                return int.TryParse(Properties[Constants.Identifiers.Properties.WorkplaceId].Value, out id)
                    ? id
                    : default(int);
            }
            set
            {
                Properties[Constants.Identifiers.Properties.WorkplaceId] = new PropertyInfo
                {
                    DisplayName = "Workplace Id",
                    Identifier = Constants.Identifiers.Properties.WorkplaceId,
                    Value = value.ToString()
                };

            }
        }
    }
}