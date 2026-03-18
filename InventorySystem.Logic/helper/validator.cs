using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventorySystem.Logic.helper
{
    public class Validator
    { //helper class to prevent redundancy 
        
        public bool ValidateMinMaxValues(int min, int max, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (max < 0)
            {
                errorMessage = "Max should not be less than zero.";
                return false;
            }
            if (min < 0)
            {
                errorMessage = "Min should not be less than zero.";
                return false;
            }
            if (min > max)
            {
                errorMessage = "Min should be less than or equal to Max.";
                return false;
            }

            return true;
        }

        public bool ValidateMachineID(string machineIDText, out int? machineID, out string errorMessage)
        {
            machineID = null;
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(machineIDText))
            {
                errorMessage = "Machine ID cannot be empty.";
                return false;
            }
            if (machineIDText.Any(char.IsWhiteSpace))
            {
                errorMessage = "Machine ID should not contain spaces.";
                return false;
            }
            if (!int.TryParse(machineIDText, out int parsedMachineID))
            {

                errorMessage = "Machine ID must be a valid integer.";
                return false;
            }
            if (parsedMachineID < 0)
            {
                errorMessage = "Machine ID should not be less than zero.";
                return false;
            }
            machineID = parsedMachineID;
            return true;
        }

        public bool ValidateCompanyName(string companyNameInput, out string? validatedName, out string errorMessage)
        {
            validatedName = null;
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(companyNameInput))
            {
                errorMessage = "Company Name cannot be empty.";
                return false;
            }

            companyNameInput = companyNameInput.Trim(); // trimps whitespace from the beginning and end of the string

            if (companyNameInput.Any(char.IsDigit))
            {
                errorMessage = "Company Name should not contain numbers.";
                return false;
            }

            if (companyNameInput.Length > 100)
            {
                errorMessage = "Company Name should not exceed 100 characters.";
                return false;
            }
            if (companyNameInput.Length < 5)
            {
                errorMessage = "Company Name should be at least 5 characters long.";
                return false;
            }
            validatedName = companyNameInput;
            return true;

        }


    }
}

