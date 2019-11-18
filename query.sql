SELECT tp.Id, tp.Name, tp.StartDate, tp.MaxAttendees
FROM TrainingProgram tp
LEFT JOIN EmployeeTraining et ON et.TrainingProgramId = tp.Id
WHERE et.EmployeeId = @id


