using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
namespace Recorder
{ 
    class AudioRecorder2
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        public void StartRecording(string fileName, string folder)
        {
            // Check if the specified folder exists
            if (!Directory.Exists(folder))
            {
                MessageBox.Show("The specified folder does not exist.");
                return;
            }
            // Create a new WaveInEvent to record audio
            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
            // Create a new WaveFileWriter to save the audio
            string filePath = Path.Combine(folder, fileName);
            writer = new WaveFileWriter(filePath, waveIn.WaveFormat);
            // Start recording
            waveIn.StartRecording();
        }
        public void StopRecording()
        {
            // Stop recording and dispose of the WaveInEvent and WaveFileWriter
            waveIn.StopRecording();
            waveIn.Dispose();
            waveIn = null;
            writer.Dispose();
            writer = null;
        }
        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            // Write the recorded audio data to the WaveFileWriter
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
        private void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            // Dispose of the WaveInEvent and WaveFileWriter
        }
    }
}

