                        SELECT e.Id, e.FirstName, e.LastName, e.DepartmentId, e.IsSupervisor,
                            d.Name AS DepartmentName,
							c.Manufacturer, c.Make, c.Id AS ComputerId
                        FROM Employee e
                        LEFT JOIN Department d on d.Id = e.DepartmentId
						LEFT JOIN ComputerEmployee ce on ce.ComputerId = e.Id
						LEFT JOIN Computer c on ce.ComputerId = c.Id
						WHERE e.Id = 42