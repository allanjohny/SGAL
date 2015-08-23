using System;
using System.Text.RegularExpressions;

namespace SGAL.Util
{
    public class Funcoes
    {
        public static int DigitoModulo11(long intNumero)
        {
            int[] intPesos = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };
            string strText = intNumero.ToString();
            if (strText.Length > 16)
                throw new Exception("Número não suportado pela função!");
            int intSoma = 0;
            int intIdx = 0;
            for (int intPos = strText.Length - 1; intPos >= 0; intPos--)
            {
                intSoma += Convert.ToInt32(strText[intPos].ToString()) * intPesos[intIdx];
                intIdx++;
            }
            int intResto = (intSoma * 10) % 11;
            int intDigito = intResto;
            if (intDigito >= 10)
                intDigito = 0;
            return intDigito;
        }
    
        public static string getMD5Hash(string input)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    
        public static bool ValidarCnpj(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;

            int resto;

            string digito;

            string tempCnpj;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)

                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);

        }

        public static string mesextenso(string mes, bool abreviado, bool maiusculo)
        {
            string mesdescrito = string.Empty;
            switch (mes)
            {
                case "1":
                    {
                        mesdescrito = "Janeiro";
                        break;
                    }

                case "2":
                    {
                        mesdescrito = "Fevereiro";
                        break;
                    }
                case "3":
                    {
                        mesdescrito = "Março";
                        break;
                    }
                case "4":
                    {
                        mesdescrito = "Abril";
                        break;
                    }
                case "5":
                    {
                        mesdescrito = "Maio";
                        break;
                    }

                case "6":
                    {
                        mesdescrito = "Junho";
                        break;
                    }
                case "7":
                    {
                        mesdescrito = "Julho";
                        break;
                    }

                case "8":
                    {
                        mesdescrito = "Agosto";
                        break;
                    }

                case "9":
                    {
                        mesdescrito = "Setembro";
                        break;
                    }
                case "10":
                    {
                        mesdescrito = "Outubro";
                        break;
                    }
                case "11":
                    {
                        mesdescrito = "Novembro";
                        break;
                    }
                case "12":
                    {
                        mesdescrito = "Dezembro";
                        break;
                    }
                default:
                    break;
            }

            if (maiusculo)
                mesdescrito = mesdescrito.ToUpper();

            if (abreviado)
                mesdescrito = mesdescrito.Substring(0, 3);

            return mesdescrito;

        }

        public static Int32 mesnumero(string mes)
        {
            Int32 mesnumero = 0;
            mes = mes.ToLower();

            switch (mes)
            {
                case "janeiro":
                    {
                        mesnumero = 1;
                        break;
                    }

                case "fevereiro":
                    {
                        mesnumero = 2;
                        break;
                    }
                case "março":
                    {
                        mesnumero = 3;
                        break;
                    }
                case "abril":
                    {
                        mesnumero = 4;
                        break;
                    }
                case "maio":
                    {
                        mesnumero = 5;
                        break;
                    }

                case "junho":
                    {
                        mesnumero = 6;
                        break;
                    }
                case "julho":
                    {
                        mesnumero = 7;
                        break;
                    }

                case "agosto":
                    {
                        mesnumero = 8;
                        break;
                    }

                case "setembro":
                    {
                        mesnumero = 9;
                        break;
                    }
                case "outubro":
                    {
                        mesnumero = 10;
                        break;
                    }
                case "novembro":
                    {
                        mesnumero = 11;
                        break;
                    }
                case "dezembro":
                    {
                        mesnumero = 12;
                        break;
                    }
                default:
                    break;
            }

            return mesnumero;
        }

        public static bool validarCpfCnpj(string sNumero)
        {
            try
            {
                string tempCpfCnpj;
                string digito;
                int soma;
                int resto;
                int[] multiplicador1;
                int[] multiplicador2;

                sNumero = sNumero.apenasNumeros();

                #region Validar CPF
                multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                sNumero = sNumero.PadLeft(14, '0');

                if (sNumero.Substring(3, 11).Equals("00000000000") || sNumero.Substring(3, 11).Equals("11111111111") ||
                        sNumero.Substring(3, 11).Equals("22222222222") || sNumero.Substring(3, 11).Equals("33333333333") ||
                        sNumero.Substring(3, 11).Equals("44444444444") || sNumero.Substring(3, 11).Equals("55555555555") ||
                        sNumero.Substring(3, 11).Equals("66666666666") || sNumero.Substring(3, 11).Equals("77777777777") ||
                        sNumero.Substring(3, 11).Equals("88888888888") || sNumero.Substring(3, 11).Equals("99999999999"))
                    return false;


                tempCpfCnpj = sNumero.Substring(3, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpfCnpj[i].ToString()) * multiplicador1[i];

                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCpfCnpj = tempCpfCnpj + digito;
                soma = 0;

                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpfCnpj[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();
                if (sNumero.EndsWith(digito))
                    return true;
                #endregion

                #region Validar CNPJ
                multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                if (sNumero.Length != 14)
                    return false;

                if (sNumero.Substring(0, 8).Equals("00000000") || sNumero.Substring(0, 8).Equals("11111111") ||
                    sNumero.Substring(0, 8).Equals("22222222") || sNumero.Substring(0, 8).Equals("33333333") ||
                    sNumero.Substring(0, 8).Equals("44444444") || sNumero.Substring(0, 8).Equals("55555555") ||
                    sNumero.Substring(0, 8).Equals("66666666") || sNumero.Substring(0, 8).Equals("77777777") ||
                    sNumero.Substring(0, 8).Equals("88888888") || sNumero.Substring(0, 8).Equals("99999999"))
                    return false;

                tempCpfCnpj = sNumero.Substring(0, 12);
                soma = 0;

                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCpfCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();
                tempCpfCnpj = tempCpfCnpj + digito;

                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCpfCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return sNumero.EndsWith(digito);

                #endregion
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static int retornaDiferencaMeses(DateTime dmenor, DateTime dmaior)
        {
            if (dmenor > dmaior)
            {
                DateTime daux = dmaior;
                dmaior = dmenor;
                dmenor = daux;
            }

            int mesesmenor = (dmenor.Year * 12) + dmenor.Month;
            int mesesmaior = (dmaior.Year * 12) + dmaior.Month;

            return mesesmaior - mesesmenor;

        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string FormatarStrToMoney(string valor)
        {
            return "R$ " + valor.Substring(0, valor.Length - 2).StrToDecimal().DecimalToStr() + "," + valor.Substring(valor.Length - 2, 2);
        }

        //Função capta os erros da modelState e cria uma lista de chave e valor para mandar via Json
        //public static List<KeyValuePair<string, string>> ExtrairErrosModelState(ModelStateDictionary modelState)
        //{
        //    int count = 0;
        //    return modelState.Values
        //        .SelectMany(x => x.Errors)
        //        .Select(
        //        modelError =>
        //            new KeyValuePair<string, string>(
        //                count++.ToString(), modelError.ErrorMessage
        //                )).ToList();
        //}

        //Função que já renderiza uma lista em html com os Erros. 
        //public static string GerarAlertaDeErrosDaModelState(ModelStateDictionary modelState)
        //{
        //    var listaDeErros = ExtrairErrosModelState(modelState);
        //    var sb = new StringBuilder();
        //    sb.Append("<ul>");
        //    foreach (var keyValuePair in listaDeErros)
        //    {
        //        sb.Append("<li>" + keyValuePair.Value + "</li>");
        //    }
        //    sb.Append("</ul>");

        //    return sb.ToString();
        //}

        //Função que já gera uma lista com os Erros. 
        //public static string GerarListaDeErrosDaModelState(ModelStateDictionary modelState)
        //{
        //    var listaDeErros = ExtrairErrosModelState(modelState);
        //    var sb = new StringBuilder();
        //    foreach (var keyValuePair in listaDeErros)
        //    {
        //        sb.Append(Environment.NewLine + "- " + keyValuePair.Value);
        //    }
        //    return sb.ToString();
        //}

        //public static void AdicionarErrosModelState(Dictionary<string, string> listaErros, ModelStateDictionary ModelState)
        //{
        //    foreach (var listaErro in listaErros)
        //    {
        //        ModelState.AddModelError(listaErro.Key, listaErro.Value);
        //    }
        //}

        //public static void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        //{
        //    //options
        //    object matchCase = false;
        //    object matchWholeWord = true;
        //    object matchWildCards = false;
        //    object matchSoundsLike = false;
        //    object matchAllWordForms = false;
        //    object forward = true;
        //    object format = false;
        //    object matchKashida = false;
        //    object matchDiacritics = false;
        //    object matchAlefHamza = false;
        //    object matchControl = false;
        //    object replace = 2;
        //    object wrap = 1;

        //    //execute find and replace
        //    doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
        //        ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
        //        ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        //}

        /// <summary>
        /// Função criada para validar se a String informada é um e-mail válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>True(se válido) ou False</returns>
        public static bool ValidaEmail(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return true;
            var regEx = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", RegexOptions.IgnoreCase);
            return regEx.IsMatch(valor);
        }

        //public static string ExtrairConteudoPDF(string caminhoArquivo)
        //{
        //    try
        //    {
        //        // Create Bytescout.PDFExtractor.TextExtractor instance
        //        Bytescout.PDFExtractor.TextExtractor extractor = new Bytescout.PDFExtractor.TextExtractor();
        //        extractor.RegistrationName = "demo";
        //        extractor.RegistrationKey = "demo";

        //        // Load sample PDF document
        //        extractor.LoadDocumentFromFile(caminhoArquivo);

        //        // Save extracted text to file
        //        var serverpath = System.Configuration.ConfigurationManager.AppSettings["CaminhoDocumentosPadrao"];
        //        var ticks = DateTime.Now.Ticks.ToString();
        //        extractor.SaveTextToFile(serverpath + "output_" + ticks + ".txt");
        //        using (System.IO.StreamReader sr = new System.IO.StreamReader(serverpath + "output_" + ticks + ".txt"))
        //        {
        //            var line = sr.ReadToEnd();
        //            return line;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return "ERRO AO TENTAR EXTRAIR CONTEÚDO DO ARQUIVO.";
        //    }
        //}
    }
}
