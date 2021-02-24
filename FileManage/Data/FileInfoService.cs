using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileManage.Data
{
    public class FileInfoService
    {
        public Task<FileInfoData[]> GetForecastAsync(string softName)
        {
            return Task.Factory.StartNew(() =>
            {
                List<FileInfoData> fileInfoDatas = new List<FileInfoData>();

                string path = Environment.CurrentDirectory + "//Resouses//" + softName;

                if(!Directory.Exists(path))
                    return fileInfoDatas.ToArray();
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    FileInfo info = new FileInfo(file);
                    FileInfoData fileInfo = new FileInfoData
                    {
                        Date = info.CreationTime,
                        Name = info.Name,
                        FilePath = $"Resouses/{softName}/{info.Name}"
                    };
                    fileInfoDatas.Add(fileInfo);
                }

                return fileInfoDatas.ToArray();
            });
        }
    }
}