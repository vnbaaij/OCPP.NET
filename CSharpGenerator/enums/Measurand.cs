namespace OCPP
{
    /// <summary>Sampled_ Value. Measurand. Measurand_ Code
    /// urn:x-oca:ocpp:uid:1:569263
    /// Type of measurement. Default = "Energy.Active.Import.Register"
    /// </summary>

    public enum Measurand
    {

        Current_Export = 0,


        Current_Import = 1,


        Current_Offered = 2,


        Energy_Active_Export_Register = 3,


        Energy_Active_Import_Register = 4,


        Energy_Reactive_Export_Register = 5,


        Energy_Reactive_Import_Register = 6,


        Energy_Active_Export_Interval = 7,


        Energy_Active_Import_Interval = 8,


        Energy_Active_Net = 9,


        Energy_Reactive_Export_Interval = 10,


        Energy_Reactive_Import_Interval = 11,


        Energy_Reactive_Net = 12,


        Energy_Apparent_Net = 13,


        Energy_Apparent_Import = 14,


        Energy_Apparent_Export = 15,


        Frequency = 16,


        Power_Active_Export = 17,


        Power_Active_Import = 18,


        Power_Factor = 19,


        Power_Offered = 20,


        Power_Reactive_Export = 21,


        Power_Reactive_Import = 22,


        SoC = 23,


        Voltage = 24,

    }
}