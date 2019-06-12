using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    class KinnectController
    {
        private KinectSensor sensor;
        private bool ocupado = false;
        private Form1 window;
        public KinnectController(Form1 windowParam)
        {
            window = windowParam;
        }

        public void startThread()
        {
            Thread.Sleep(2000);
            var sensorStatus = new KinectSensorChooser();
            sensorStatus.KinectChanged += KinectSensorChooserKinectChanged;
            //kinectChooser.KinectSensorChooser = sensorStatus;
            sensorStatus.Start();
            while (true)
            {
                //
            }
        }

        private void KinectSensorChooserKinectChanged(object sender, KinectChangedEventArgs e)
        {
            if (sensor != null) { sensor.SkeletonFrameReady -= KinectSkeletonFrameReady; };
            sensor = e.NewSensor;
            if (sensor == null) return;
            Console.Write(Convert.ToString(e.NewSensor.Status));
            sensor.SkeletonStream.Enable();
            sensor.SkeletonFrameReady += KinectSkeletonFrameReady;
        }

        private void KinectSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            var skeletons = new Skeleton[0];
            using (var skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                }
            }

            if (skeletons.Length == 0) { return; }

            var skel = skeletons.FirstOrDefault(x => x.TrackingState == SkeletonTrackingState.Tracked);

            if (skel == null) { return; }
            var rightHand = skel.Joints[JointType.WristRight];
            var leftHand = skel.Joints[JointType.WristLeft];

            if (!ocupado && rightHand.Position.X < -0.22)
            {
                int selectedTabIndex = window.getSelectedTabIndex();
                window.setSelectedTabIndex(selectedTabIndex + 1);
                Console.WriteLine("Pestaña siguiente");
                ocupado = true;
                Thread.Sleep(1000);
            }
            else if (!ocupado && leftHand.Position.X > 0.22)
            {
                int selectedTabIndex = window.getSelectedTabIndex();
                window.setSelectedTabIndex(selectedTabIndex - 1);
                Console.WriteLine("Pestaña anterior");
                ocupado = true;
                Thread.Sleep(1000);
            }

            if (leftHand.Position.X > -0.2 && rightHand.Position.X < 0.2)
            {
                ocupado = false;
            }
        }
    }
}