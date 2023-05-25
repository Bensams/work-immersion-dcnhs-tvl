
--string -> TEXT NOT NULL, string? -> TEXT
--PK: id int -> id INT NOT NULL AUTO_INCREMENT, ... PRIMARY KEY (id)

CREATE TABLE IF NOT EXISTS Reservation (
	id INT NOT NULL AUTO_INCREMENT,
	clientType TEXT NOT NULL, -- FIXME?: Create a client type table
	roomChargeCode TEXT NOT NULL, -- FIXME?: Create a room charge table
	arrival DATE NOT NULL,
	-- From spec, "nights" can be calculated in the client not in the database
	departure DATE NOT NULL,
	checkOutTime TIME NOT NULL,
	adultCount INT NOT NULL,
	childCount INT NOT NULL,
	issuer INT NOT NULL,
	issuedDate DATE NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (issuer) REFERENCES UserInfo(id)
);

-- Interface table to associate a Reservation to a Room

CREATE TABLE IF NOT EXISTS ReservationRoom (
	id INT NOT NULL AUTO_INCREMENT,
	reservationId INT NOT NULL,
	roomId TEXT NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (reservationId) REFERENCES Reservation(id),
	FOREIGN KEY (roomId) REFERENCES Room(id)
);

-- Travel Agent
	
CREATE TABLE IF NOT EXISTS TravelAgent (
	id INT NOT NULL,
	walkInID INT NOT NULL,
	
	travelAgent TEXT NOT NULL,
	contact TEXT NOT NULL,
	overrideCom DOUBLE,
	
	PRIMARY KEY (id),
	FOREIGN KEY (WalkInID) REFERENCES Reservation(id)
);
	
--Guest Share
	
CREATE TABLE IF NOT EXISTS GuestShare (
	-- need validation
	walkInID INT NOT NULL,
	
	firstName TEXT NOT NULL,
	lastName TEXT NOT NULL,
	useFolio BOOLEAN,
	storeAsGuest BOOLEAN,
	-- (SRCE) split room charges equally
	SRCE BOOLEAN,
	
	FOREIGN KEY (WalkInID) REFERENCES Reservation(id)
);
	
-- Routing

CREATE TABLE IF NOT EXISTS Routing (
	-- need validation
	walkInID INT NOT NULL,
	
	transactGroup TEXT,
	transactCode TEXT,
	folioNum INT NOT NULL,
	routeSameBook BOOLEAN,
	
	resRoom INT NOT NULL,
	name TEXT NOT NULL,
	filteredBy TEXT,
	
	FOREIGN KEY (WalkInID) REFERENCES Reservation(id)
	FOREIGN KEY (ResRoom) REFERENCES ResRoom(id)
);
 	
