using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.Core
{
    public record ChargingProfile(int ChargingProfileId, int StackLevel, ChargingProfilePurposeType ChargingProfilePurpose, ChargingProfileKindType ChargingProfileKind, ChargingSchedule ChargingSchedule, int? TransactionId = null, RecurrencyKindType? RecurrencyKind = null, DateTime? ValidFrom = null, DateTime? ValidTo = null);
    public record ChargingSchedule(ChargingRateUnitType ChargingRateUnit, ICollection<ChargingSchedulePeriod> ChargingSchedulePeriod, int Duration, DateTime StartSchedule, double MinChargingRate);
    public record ChargingSchedulePeriod(int StartPeriod, double Limit, int? NumberPhases = null);
    public record IdTagInfo(AuthorizationStatus Status, DateTime? ExpiryDate = null, string ParentIdTag = null);
    public record MeterValue(DateTime Timestamp, ICollection<SampledValue> SampledValue);
    public record SampledValue(string Value, ReadingContext? Context = null, ValueFormat? Format = null, Measurand? Measurand = null, Phase? Phase = null, Location? Location = null, UnitOfMeasure? Unit = null);


    public record KeyValue(string Name, bool Required, bool ReadOnly);
    public record KeyValue<T>(string Name, bool Required, bool Readonly, T Value) : KeyValue(Name, Required, Readonly)
    {
        public Type Type
        {
            get
            {
                return typeof(T);
            }
        }
    }
}
