using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleTime.Domain.Entities
{
    [Table("schedule")]
    public class Schedule
    {
        public string IDTransaction { get; init; } = Guid.NewGuid().ToString();
        public long Id { get; private set; }
        public DateTime ScheduledTime { get; private set; }
        public DateTime CurrentDate { get; private set; }

        public Schedule(DateTime scheduledTime, DateTime currentDate)
        {
            ValidateSchedule(scheduledTime, currentDate);
        }

        private void ValidateSchedule(DateTime scheduleTime, DateTime currentTime)
        {
            if (scheduleTime <= currentTime)
            {
                ScheduledTime = scheduleTime;
                CurrentDate = currentTime;
            }
        }
    }
}
