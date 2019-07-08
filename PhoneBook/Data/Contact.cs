using System;
using PhoneBook.Utils;

namespace PhoneBook.Data {
    public class Contact {
        const int maxNameLength = 50; //Counting in number of characters here
        
        string name;
        string phoneNumber;

        public Contact(string contactName, string phoneNumber) {
            SetName(contactName);
            SetPhoneNumber(phoneNumber);
        }

        public string GetName() {
            //We assume that any input givem to the class is correctly formatted by the setter method thus there is
            //no need to format it again in the getters
            return name;
        }

        public string GetPhoneNumber() {
            return phoneNumber;
        }
        
        public void SetName(string nameToSet) {
            name = GetFormattedContactName(nameToSet);
        }

        static string GetFormattedContactName(string nameToFormat) {
            var formattedContactName = StringUtil.ClampStringAtLimits(nameToFormat, 0, maxNameLength);
            return formattedContactName.Trim();
        }

        public void SetPhoneNumber(string numberToSet) {
            phoneNumber = GetFormattedPhoneNumber(numberToSet);
        }

        static string GetFormattedPhoneNumber(string phoneNumberToFormat) {
            string formattedPhoneNumber = StringUtil.RemoveAllSpaces(phoneNumberToFormat);
            if (StringUtil.IsANumber(formattedPhoneNumber)) 
                return formattedPhoneNumber;

            throw new ArgumentException("No phone number can contain any characters");
        }
    }
}