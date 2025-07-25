﻿using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace Recorder
{ 
    class AudioRecorder
    {
        private WaveInEvent waveIn;
        private MemoryStream memoryStream;

    public AudioRecorder()
        {

            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
            memoryStream = new MemoryStream();

            // Create a new WaveInEvent to record audio

            // Create a new WaveFileWriter to save the audio
        }
        public void StartRecording()
        {
            // Check if the specified folder exists
            // Start recording
            waveIn.StartRecording();
        }

        public void StopRecording(string fileAddr)
        {
            // Stop recording and dispose of the WaveInEvent and WaveFileWriter
            waveIn.StopRecording();
            waveIn.Dispose();
            WaveFileWriter writer = new WaveFileWriter(fileAddr, waveIn.WaveFormat);
            writer.Write(memoryStream.ToArray(),0,(int)memoryStream.Length);
            writer.Close();
            memoryStream.Dispose();
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            // Write the recorded audio data to the WaveFileWriter            
            memoryStream.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            // Dispose of the WaveInEvent and WaveFileWriter
            waveIn.Dispose();
        }
    }
}
