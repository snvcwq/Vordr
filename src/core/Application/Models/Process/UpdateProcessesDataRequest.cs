﻿using Vordr.Domain.Entities;

namespace Vordr.Application.Models.Process;

public record UpdateProcessesDataRequest(IList<ProcessData> NewProcesses, IList<ProcessData> UpdatedProcesses);
