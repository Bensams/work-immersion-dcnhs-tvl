CREATE TABLE IF NOT EXISTS Services (
    id INT NOT NULL AUTO_INCREMENT,
    
	servicesGroup TEXT NOT NULL,
	serviceName TEXT NOT NULL,
	rate DOUBLE NOT NULL,
	quantity INT NOT NULL,
	
	PRIMARY KEY (id)
);