                        SELECT d.Id, d.Name, d.Budget,
                            e.FirstName, e.LastName
                        FROM Department d
                        LEFT JOIN Employee e on d.Id = e.DepartmentId