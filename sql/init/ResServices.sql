CREATE TABLE IF NOT EXISTS Services (
    	id INT NOT NULL AUTO_INCREMENT,
    
	servicesType TEXT NOT NULL,
	serviceName TEXT NOT NULL,
	price DOUBLE NOT NULL,
	qty INT NOT NULL,
	
	PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS ResServices (
	id INT NOT NULL AUTO_INCREMENT,
	
	serviceID INT NOT NULL,
	walkInID INT NOT NULL,
	resDate DATE NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (ServiceID) REFERENCES Services(id),
	FOREIGN KEY (WalkInID) REFERENCES Reservation(id)
);
	
