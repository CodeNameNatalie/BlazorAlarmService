using System;
using System.Linq;
using System.Threading.Tasks;

namespace Alarms.Data
{
    public class AlarmService
    {
        private static readonly string[] EquipmentTypes = new[]
        {
            "Conveyor","Tug","Tank","Door"
        };

        private static readonly string[] AlarmTypes = new[]
        {
            "Over Light", "Fire", "Under Pulse", "Breakdown", "Over Heat"
        };

        public Task<EachAlarm[]> GetAlarmAsync(DateTime startTime)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 4).Select(index => new EachAlarm
            {
                Time = startTime.AddDays(index),
                Alarm = AlarmTypes[rng.Next(AlarmTypes.Length)],
                Equipment = EquipmentTypes[rng.Next(EquipmentTypes.Length)]
            }).ToArray());
        }
    }
}