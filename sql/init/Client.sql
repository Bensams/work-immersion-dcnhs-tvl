--Payment Method
CREATE TABLE IF NOT EXISTS PaymentMethod (
	paymentID INT NOT NULL,
	walkInID INT NOT NULL,
	
	PRIMARY KEY (PaymentID),
	FOREGIN KEY (WalkInID) REFERENCES Reservation(id)
);

CREATE TABLE IF NOT EXISTS Card (
	id INT NOT NULL,
	cardType TEXT,
	cardNum TEXT NOT NULL,
	auth TEXT NOT NULL,
	expDate DATE NOT NULL,
	cardHolder TEXT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);

CREATE TABLE IF NOT EXISTS Cash (
	id INT NOT NULL,
	amount INT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);

CREATE TABLE IF NOT EXISTS GCash (
	id INT NOT NULL,
	
	GCashNum = TEXT,
	name TEXT,
	QR TEXT,
	Amount INT NOT NULL,
	
	FOREIGN KEY (id) REFERENCES PaymentMethod(PaymentID)
);


-- Client
CREATE TABLE IF NOT EXISTS Client (
	clientID INT NOT NULL AUTO_INCREMENT,
	
	clientType TEXT NOT NULL,
	clientTitle TEXT,
	firstName TEXT NOT NULL,
	lastName TEXT NOT NULL,
	
	streetAd TEXT NOT NULL,
	cityAd TEXT NOT NULL,
	provinceAd TEXT NOT NULL,
	countryAd TEXT NOT NULL,
	zipCode TEXT NOT NULL,
	
	telephone TEXT,
	mobile TEXT NOT NULL,
	email TEXT,
	
	acceptEmail BOOLEAN,
	opTCmpgn BOOLEAN,
	VIP BOOLEAN,
	
	srcOfBusiness TEXT,
	guestNote TEXT NOT NULL,
	resNote TEXT NOT NULL,
	
	postDepo BOOLEAN,
	amount INT,
	
	paymentID INT NOT NULL,
	
	vehicleBrand TEXT,
	vehicleModel TEXT,
	license TEXT,
	
	PRIMARY KEY (ClientID),
	FOREIGN KEY (PaymentID) REFERENCES PaymentMethod(PaymentID)
); 
