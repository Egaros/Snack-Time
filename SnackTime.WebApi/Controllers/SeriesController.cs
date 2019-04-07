﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SnackTime.Core.Series;
using SnackTime.WebApi.Helpers;
using SonarrSharp;

namespace SnackTime.WebApi.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class Series : ControllerBase
    {
        private readonly SeriesProvider _seriesProvider;

        public Series(SonarrClient client)
        {
            _seriesProvider = new SeriesProvider(client);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetSeries()
        {
            var series = await _seriesProvider.GetSeries();
            return Ok(ApiResponseFactory.CreateSuccess(series));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetSeriesById(int id)
        {
            var series = await _seriesProvider.GetSeriesById(id);
            return Ok(ApiResponseFactory.CreateSuccess(series));
        }

        [HttpGet("url")]
        public async Task<ActionResult> GetUrl()
        {
            var basePath = @"C:\Users\desktop\Desktop\ffmpeg-4.1.1-win64-static\bin";
            var outputPath = basePath + @"\output.mp4";
            var inputPath = basePath + @"\test.mkv";
            var ffmpegPath = basePath + @"\ffmpeg.exe";

            var cmd =  $"-i {inputPath} -ss 00:00:07.000 -t 00:00:12.0 -vf scale=320:-1 -c:v libx264 -preset fast -c:a aac {outputPath} -hide_banner";

            var process = new Process();
            var startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = ffmpegPath;
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            var bytes = await System.IO.File.ReadAllBytesAsync(outputPath);
            return File(bytes, "video/mp4");
        }
    }

}