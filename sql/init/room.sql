CREATE TABLE IF NOT EXISTS Room (
	id INT NOT NULL AUTO_INCREMENT,
	-- TODO: implement supplemental data
	roomNumber TEXT NOT NULL,
	roomType TEXT NOT NULL,
	rate INT NOT NULL,
	capacity INT NOT NULL,
	
	PRIMARY KEY (id)
);
