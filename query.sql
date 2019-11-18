                        SELECT d.Id, d.Name, d.Budget,
						e.Id, e.FirstName, e.LastName, e.IsSupervisor
                        FROM Department d
						LEFT JOIN Employee e on e.DepartmentId = d.Id
                        WHERE d.Id = 2