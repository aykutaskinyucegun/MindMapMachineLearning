using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindMapMachineLearning.Models
{
    class MlInput
    {
        [ColumnName("Airlines"), LoadColumn(0)]
        public float Airlines { get; set; }

        [ColumnName("Architecture"), LoadColumn(1)]
        public float Architecture { get; set; }

        [ColumnName("Art & Museums"), LoadColumn(2)]
        public float ArtAndMuseums { get; set; }

        [ColumnName("Automotive"), LoadColumn(3)]
        public float Automotive { get; set; }

        [ColumnName("Banking & Financial"), LoadColumn(4)]
        public float BankingAndFinancial { get; set; }

        [ColumnName("Cannabis"), LoadColumn(5)]
        public float Cannabis { get; set; }

        [ColumnName("Casinos & Lottery"), LoadColumn(6)]
        public float CasinosAndLottery { get; set; }

        [ColumnName("Charities"), LoadColumn(7)]
        public float Charities { get; set; }

        [ColumnName("Education & Training"), LoadColumn(8)]
        public float EducationAndTraining { get; set; }

        [ColumnName("Education (K-12)"), LoadColumn(9)]
        public float EducationK12 { get; set; }

        [ColumnName("Emergency Response"), LoadColumn(10)]
        public float EmergencyResponse { get; set; }

        [ColumnName("Health & Medical"), LoadColumn(11)]
        public float HealthAndMedical { get; set; }

        [ColumnName("Industrial"), LoadColumn(12)]
        public float Industrial { get; set; }

        [ColumnName("Legal & Insurance"), LoadColumn(13)]
        public float LegalAndInsurance { get; set; }

        [ColumnName("Media & News & Entertainment"), LoadColumn(14)]
        public float MediaAndNewsAndEntertainment { get; set; }

        [ColumnName("Military"), LoadColumn(15)]
        public float Military { get; set; }

        [ColumnName("Music"), LoadColumn(16)]
        public float Music { get; set; }

        [ColumnName("Real Estate"), LoadColumn(17)]
        public float RealEstate { get; set; }

        [ColumnName("Restaurant & Food"), LoadColumn(18)]
        public float RestaurantAndFood { get; set; }

        [ColumnName("Retail"), LoadColumn(19)]
        public float Retail { get; set; }

        [ColumnName("Sales & Marketing"), LoadColumn(20)]
        public float SalesAndMarketing { get; set; }

        [ColumnName("Sports"), LoadColumn(21)]
        public float Sports { get; set; }

        [ColumnName("Telecommunications"), LoadColumn(22)]
        public float Telecommunications { get; set; }

        [ColumnName("Travel & Tourism"), LoadColumn(23)]
        public float TravelAndTourism { get; set; }

        [ColumnName("Collaboration & Social"), LoadColumn(24)]
        public float CollaborationAndSocial { get; set; }

        [ColumnName("Communications"), LoadColumn(25)]
        public float Communications { get; set; }

        [ColumnName("Data Analytics"), LoadColumn(26)]
        public float DataAnalytics { get; set; }

        [ColumnName("Design"), LoadColumn(27)]
        public float Design { get; set; }

        [ColumnName("Gaming"), LoadColumn(28)]
        public float Gaming { get; set; }

        [ColumnName("General Training"), LoadColumn(29)]
        public float GeneralTraining { get; set; }

        [ColumnName("Health & Safety"), LoadColumn(30)]
        public float HealthAndSafety { get; set; }

        [ColumnName("LBE"), LoadColumn(31)]
        public float LBE { get; set; }

        [ColumnName("Leadership"), LoadColumn(32)]
        public float Leadership { get; set; }

        [ColumnName("Marketing"), LoadColumn(33)]
        public float Marketing { get; set; }

        [ColumnName("Rehabilitation"), LoadColumn(34)]
        public float Rehabilitation { get; set; }

        [ColumnName("Simulation"), LoadColumn(35)]
        public float Simulation { get; set; }

        [ColumnName("Tools"), LoadColumn(36)]
        public float Tools { get; set; }

        [ColumnName("Training: Hands On"), LoadColumn(37)]
        public float TrainingHandsOn { get; set; }

        [ColumnName("Training: Hard Skills"), LoadColumn(38)]
        public float TrainingHardSkills { get; set; }

        [ColumnName("Training: Soft Skills"), LoadColumn(39)]
        public float TrainingSoftSkills { get; set; }

        [ColumnName("360 Photo/Video"), LoadColumn(40)]
        public bool ThreeSixtyPhoto { get; set; }

        [ColumnName("3D Environments"), LoadColumn(41)]
        public bool ThreeDEnvironments { get; set; }

        [ColumnName("3D Modelling"), LoadColumn(42)]
        public bool ThreeDModelling { get; set; }

        [ColumnName("AR"), LoadColumn(43)]
        public bool AR { get; set; }

        [ColumnName("AR Authoring"), LoadColumn(44)]
        public bool ARAuthoring { get; set; }

        [ColumnName("AR Cloud"), LoadColumn(45)]
        public bool ARCloud { get; set; }

        [ColumnName("AR Headsets"), LoadColumn(46)]
        public bool ARHeadsets { get; set; }

        [ColumnName("AR Kit"), LoadColumn(47)]
        public bool ARKit { get; set; }

        [ColumnName("AR: Hololens"), LoadColumn(48)]
        public bool ARHololens { get; set; }

        [ColumnName("AR: Magic Leap"), LoadColumn(49)]
        public bool ARMagicLeap { get; set; }

        [ColumnName("ARCore"), LoadColumn(50)]
        public bool ARCore { get; set; }

        [ColumnName("Avatar Creation"), LoadColumn(51)]
        public bool AvatarCreation { get; set; }

        [ColumnName("Distribution & Device Management"), LoadColumn(52)]
        public bool DistributionAndDeviceManagement { get; set; }

        [ColumnName("Eye Tracking"), LoadColumn(53)]
        public bool EyeTracking { get; set; }

        [ColumnName("Haptics & Peripherals"), LoadColumn(54)]
        public bool HapticsAndPeripherals { get; set; }

        [ColumnName("Motion Capture"), LoadColumn(55)]
        public bool MotionCapture { get; set; }

        [ColumnName("Motion Simulators"), LoadColumn(56)]
        public bool MotionSimulators { get; set; }

        [ColumnName("Networking"), LoadColumn(57)]
        public bool Networking { get; set; }

        [ColumnName("Photogrammetry"), LoadColumn(58)]
        public bool Photogrammetry { get; set; }

        [ColumnName("Spatial Audio"), LoadColumn(59)]
        public bool SpatialAudio { get; set; }

        [ColumnName("Unity"), LoadColumn(60)]
        public bool Unity { get; set; }

        [ColumnName("Unreal"), LoadColumn(61)]
        public bool Unreal { get; set; }

        [ColumnName("VR"), LoadColumn(62)]
        public bool VR { get; set; }

        [ColumnName("VR Authoring"), LoadColumn(63)]
        public bool VRAuthoring { get; set; }

        [ColumnName("VR Headsets"), LoadColumn(64)]
        public bool VRHeadsets { get; set; }

        [ColumnName("VR: Mobile"), LoadColumn(65)]
        public bool VRMobile { get; set; }

        [ColumnName("VR: PC"), LoadColumn(66)]
        public bool VRPC { get; set; }

        [ColumnName("Volumetric Capture"), LoadColumn(67)]
        public bool VolumetricCapture { get; set; }

        [ColumnName("Web XR"), LoadColumn(68)]
        public bool WebXR { get; set; }



    }
}
