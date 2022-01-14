using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Document_Confirmer.documents;

namespace Document_Confirmer.formwork
{
    class CorrectnessWorker : FormWorker
    {
        int [] error_code = { 0, 0, 0, 0 }; //[0]Пустые поля; [1]Цифра вместо буквы [2]Заглавная буква в слове(не в начале) [3]Буква вместо цифры
        int[] lenghtsChecker = { 0, 0, 0, 0, 0 };

        private void CheckLetters(string line)
        {
            int lenght;

            if (line != "" && line != null)
            {
                lenght = line.Length;

                if (Char.IsDigit(line[0]))
                    error_code[1] = 1;
                for (int i = 1; i < lenght; i++)
                {
                    if (Char.IsDigit(line[i]))
                        error_code[1] = 1;
                    if (Char.IsUpper(line[i]))
                        error_code[2] = 1;
                    if (error_code[1] == 1 && error_code[2] == 1)
                        break;
                }
            }
            else
                error_code[0] = 1;
        }
        private void CheckNumbers(string line)
        {
            int lenght;

            if (line != "" && line != null)
            {
                lenght = line.Length;

                for (int i = 0; i < lenght; i++)
                {
                    if (!Char.IsDigit(line[i]))
                    {
                        error_code[3] = 1;
                        break;
                    }
                }
            }
            else
                error_code[0] = 1;
        }

        public void SetErrorsToNull()
        {
            for (int i = 0; i < error_code.Length; i++)
                error_code[i] = 0;
        }
        public string GetErrorMessage()
        {
            string errorMessage = "";
            if (error_code[0] == 1)
                errorMessage += "Ошибка 101: все поля должны быть заполнены!\n";
            if (error_code[1] == 1)
                errorMessage += "Ошибка 201: неуместн(ая/ые) цифр(а/ы) в пол(е/ях)\n";
            if (error_code[2] == 1)
                errorMessage += "Ошибка 202: неверный регистр в пол(е/ях)\n";
            if (error_code[3] == 1)
                errorMessage += "Ошибка 203: неуместн(ая/ые) букв(а/ы) в пол(е/ях)\n";
            return errorMessage;
        }
        public int[] GetLenghtsErrors()
        {
            return lenghtsChecker;
        }

        public void CheckForm(CitizenCard verifiable_citizen)
        {
            CheckLetters(verifiable_citizen.first_name);
            CheckLetters(verifiable_citizen.second_name);
        }
        public void CheckForm(Passport verifiable_passport)
        {
            for (int i = 0; i < lenghtsChecker.Length; i++)
                lenghtsChecker[i] = 0;

            CheckLetters(verifiable_passport.extradition_city);
            CheckNumbers(verifiable_passport.number);
            CheckNumbers(verifiable_passport.subdivisions_code);

            if (verifiable_passport.number.Length < 10)
                lenghtsChecker[0] = 1;
            if (verifiable_passport.subdivisions_code.Length < 6)
                lenghtsChecker[1] = 1;
        }
        public void CheckForm(INN verifiable_inn)
        {
            CheckNumbers(verifiable_inn.number);
            CheckNumbers(verifiable_inn.region_code);

            if (verifiable_inn.number.Length < 10)
                lenghtsChecker[2] = 1;
            if (verifiable_inn.region_code.Length < 4)
                lenghtsChecker[3] = 1;
        }
        public void CheckForm(Policy verifiable_policy)
        {
            CheckNumbers(verifiable_policy.number);

            if (verifiable_policy.number.Length < 16)
                lenghtsChecker[4] = 1;
        }
    }
}
