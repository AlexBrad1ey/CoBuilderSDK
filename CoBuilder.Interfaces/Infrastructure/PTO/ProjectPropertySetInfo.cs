using System;

namespace CoBuilder.Service.Infrastructure.PTO
{
    public class ProjectPropertySetInfo : PropertySetInfo
    {
        public string Username
        {
            get { return Properties.ContainsKey("CBProject.Username") ? Properties["CBProject.Username"].Value : null; }
            set
            {
                Properties["CBProject.Username"] = new PropertyInfo
                {
                    DisplayName = "Username",
                    Identifier = "CBProject.Username",
                    Value = value
                };
            }
        }

        /// <summary>
        /// Gets or sets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public Guid ContactId
        {
            get
            {
                return Properties.ContainsKey("CBProject.ContactId")
                    ? new Guid(Properties["CBProject.ContactId"].Value)
                    : new Guid();
            }
            set
            {
                Properties["CBProject.ContactId"] = new PropertyInfo
                {
                    DisplayName = "ContactId",
                    Identifier = "CBProject.ContactId",
                    Value = value.ToString()
                };
            }
        }

        /// <summary>
        /// Gets or sets the name of the workplace.
        /// </summary>
        /// <value>The name of the workplace.</value>
        public string WorkplaceName
        {
            get
            {
                return Properties.ContainsKey("CBProject.WorkplaceId") ? Properties["CBProject.WorkplaceId"].Value : null;
            }
            set
            {
                Properties["CBProject.WorkplaceId"] = new PropertyInfo
                {
                    DisplayName = "Workplace",
                    Identifier = "CBProject.Workplace",
                    Value = value
                };
            }
        }
    }
}