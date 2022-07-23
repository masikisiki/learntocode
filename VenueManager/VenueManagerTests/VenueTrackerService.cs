using System;

namespace VenueManagerTests
{
    internal class VenueTrackerService
    {
        private readonly TrackerRepository  _trackerRepository;
        public VenueTrackerService(TrackerRepository trackerRepository)
        {
            _trackerRepository = trackerRepository;
        }

        internal void StudentIn(Student student)
        {
            _trackerRepository.Add(student);
        }
    }
}