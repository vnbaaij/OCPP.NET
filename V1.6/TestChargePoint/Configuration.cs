using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OCPP.V16.Core;

namespace TestChargePoint
{
    public class Configuration
    {
        public List<KeyValue> Core { get; set; }
        //public List<KeyValue> FirmwareManagement { get; set; }
        public List<KeyValue> ListManagement { get; set; }
        //public List<KeyValue> RemoteTrigger { get; set; }
        public List<KeyValue> Reservation { get; set; }
        public List<KeyValue> SmartCharging { get; set; }

        //For optional Configuration Keys with a boolean type, the following rules apply for the configuration key in the
        //response to a GetConfiguration.req without a list of keys:
        //• If the key is present, the Charge Point provides the functionality that is configured by the key, and it can be
        //enabled or disabled by setting the value for the key.
        //• If the key is not present, the Charge Point does not provide the functionality that can be configured by the
        //key.
        //The "Accessibility" property shows if the value for a certain configuration key is read-only ("R") or read-write
        //("RW"). In case the key is read-only, the Central System can read the value for the key using GetConfiguration, but
        //not write it.In case the accessibility is read-write, the Central System can also write the value for the key using
        //ChangeConfiguration.

        public Configuration()
        {
            Core.AddRange(new List<KeyValue> {
                new KeyValue<bool>("AllowOfflineTxForUnknownId", false, false, true),
                new KeyValue<bool>("AuthorizationCacheEnabled", false, false, true),
                new KeyValue<bool>("AuthorizeRemoteTxRequests", true, false, true),
                new KeyValue<int>("BlinkRepeat", false, false, 5),
                new KeyValue<int>("ClockAlignedDataInterval", true, false, 900),
                new KeyValue<int>("ConnectionTimeOut", true, false, 180),
                new KeyValue<string>("ConnectorPhaseRotation", true, false, " 0.RST,1.RST,2.RTS"),
                new KeyValue<int>("ConnectorPhaseRotationMaxLength", false, true, 3),
                new KeyValue<int>("GetConfigurationMaxKeys", true, true, 256),
                new KeyValue<int>("HeartbeatInterval", true, false, 300),
                new KeyValue<int>("LightIntensity", false, false, 80),
                new KeyValue<bool>("LocalAuthorizeOffline", true, false, true),
                new KeyValue<bool>("LocalPreAuthorize", true, false, true),
                new KeyValue<int>("MaxEnergyOnInvalidId", false, false, 11000),
                new KeyValue<string>("MeterValuesAlignedData", true, false, ""),
                new KeyValue<int>("MeterValuesAlignedDataMaxLength", false, true, 10),
                new KeyValue<string>("MeterValuesSampledData", true, false, ""),
                new KeyValue<int>("MeterValuesSampledDataMaxLength", false, true, 10),
                new KeyValue<int>("MeterValueSampleInterval", true, false, 60),
                new KeyValue<int>("MinimumStatusDuration", false, false, 90),
                new KeyValue<int>("NumberOfConnectors", true, true, 2),
                new KeyValue<int>("ResetRetries", true, false, 5),
                new KeyValue<bool>("StopTransactionOnEVSideDisconnect", true, false, true),
                new KeyValue<bool>("StopTransactionOnInvalidId", true, false, true),
                new KeyValue<string>("StopTxnAlignedData", true, false, ""),
                new KeyValue<int>("StopTxnAlignedDataMaxLength", false, true, 10),
                new KeyValue<string>("StopTxnSampledData", true, false, ""),
                new KeyValue<int>("StopTxnSampledDataMaxLength", false, true, 10),
                new KeyValue<string>("SupportedFeatureProfiles", true, false, ""),
                new KeyValue<int>("SupportedFeatureProfilesMaxLength", false, true, 256),
                new KeyValue<int>("TransactionMessageAttempts", true, false, 3),
                new KeyValue<int>("TransactionMessageRetryInterval", true, false, 30),
                new KeyValue<bool>("UnlockConnectorOnEVSideDisconnect", false, false, true),
                new KeyValue<int>("WebSocketPingInterval", false, false, 0),
            });

            ListManagement.AddRange(new List<KeyValue>
            {
                new KeyValue<bool>("LocalAuthListEnabled", true, false, true),
                new KeyValue<int>("LocalAuthListMaxLength", true, true, 256),
                new KeyValue<int>("SendLocalListMaxLength", true, true, 256)
                
            });

            Reservation.AddRange(new List<KeyValue>
            {
                new KeyValue<bool>("ReserveConnectorZeroSupported", false, true, true)
            });
            
            SmartCharging.AddRange(new List<KeyValue>
            {
                new KeyValue<int>("ChargeProfileMaxStackLevel", true, true, 10),
                new KeyValue<string>("ChargingScheduleAllowedChargingRateUnit", false, true, ""),
                new KeyValue<int>("ChargingScheduleMaxPeriods", true, true, 30),
                new KeyValue<bool>("ConnectorSwitch3to1PhaseSupported", false, true, true),
                new KeyValue<int>("MaxChargingProfilesInstalled", true, true, 15)
            });
        }

        public static T GetConfigurationValue<T>(List<KeyValue> list, string name)
        {
            T result;
            KeyValue<T> setting = (KeyValue<T>)list.Single(s => s.Name.Equals(name));
            result = setting.Value;

            return result;
        }
    }
}
