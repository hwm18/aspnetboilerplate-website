using System.IO;
using Ionic.Zip;

namespace AbpWebSite.Templates
{
    public class ProjectCreator
    {
        private readonly string _templateFolder;
        private readonly string _downloadFolder;

        public ProjectCreator(string rootPath)
        {
            _templateFolder = Path.Combine(rootPath, @"ProjectTemplates");
            _downloadFolder = Path.Combine(rootPath, @"ProjectTemplates_Downloads");
        }

        public byte[] Create(string templateZipFileName, string projectName)
        {
            var temporaryZipFilePath = CreateTemporaryZippedTemplate(templateZipFileName);
            var temporaryRenamingFolder = Path.Combine(_downloadFolder, Path.GetFileNameWithoutExtension(temporaryZipFilePath));

            using (var zipFile = ZipFile.Read(temporaryZipFilePath))
            {
                zipFile.ExtractAll(temporaryRenamingFolder);
            }

            File.Delete(temporaryZipFilePath);

            var renamer = new SolutionRenamer(temporaryRenamingFolder, templateZipFileName, projectName);
            renamer.Rename();

            using (var zipFile = new ZipFile())
            {
                zipFile.AddDirectory(Path.Combine(temporaryRenamingFolder, projectName));
                zipFile.Save(Path.Combine(_downloadFolder, Path.GetFileNameWithoutExtension(temporaryZipFilePath) + ".zip"));
            }

            Directory.Delete(temporaryRenamingFolder, true);

            var bytes = File.ReadAllBytes(temporaryZipFilePath);

            File.Delete(temporaryZipFilePath);

            return bytes;
        }

        private string CreateTemporaryZippedTemplate(string templateZipFileName)
        {
            var templateZipFilePath = Path.Combine(_templateFolder, templateZipFileName + ".zip");
            var temporaryZipFilePath = Path.Combine(_downloadFolder, RandomCodeGenerator.Generate(16) + ".zip");
            File.Copy(templateZipFilePath, temporaryZipFilePath, true);
            return temporaryZipFilePath;
        }
    }
}