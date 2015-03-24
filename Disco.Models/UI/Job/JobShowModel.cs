﻿using Disco.Models.BI.Job;
using Disco.Models.Services.Jobs.JobLists;
using System;
using System.Collections.Generic;

namespace Disco.Models.UI.Job
{
    public interface JobShowModel : BaseUIModel
    {
        Repository.Job Job { get; set; }
        TimeSpan? LongRunning { get; set; }
        List<Repository.DocumentTemplate> AvailableDocumentTemplates { get; set; }
        List<Repository.JobSubType> UpdatableJobSubTypes { get; set; }
        List<Repository.JobQueue> AvailableQueues { get; set; }

        LocationModes LocationMode { get; set; }
        List<JobLocationReference> LocationOptions { get; set; }
    }
}
