-- Client
CREATE TABLE IF NOT EXISTS PaymentMethod(
	PaymentID INT NOT NULL AUTO_INCREMENT,
	CardType TEXT,
	CardNum TEXT NOT NULL,
	Auth TEXT NOT NULL,
	ExpDate DATE NOT NULL,
	CardHolder TEXT NOT NULL,
	
	PRIMARY KEY (PaymentID)
);


CREATE TABLE IF NOT EXISTS Client (
	ClientID INT NOT NULL AUTO_INCREMENT,
	
	ClientType TEXT NOT NULL,
	ClientTitle TEXT,
	FirstName TEXT NOT NULL,
	LastName TEXT NOT NULL,
	
	StreetAd TEXT NOT NULL,
	CityAd TEXT NOT NULL,
	ProvinceAd TEXT NOT NULL,
	CountryAd TEXT NOT NULL,
	ZipCode TEXT NOT NULL,
	
	Telephone TEXT,
	Mobile TEXT NOT NULL,
	Email TEXT,
	
	AcceptEmail BOOLEAN,
	OpTCmpgn BOOLEAN,
	VIP BOOLEAN,
	
	SrcOfBusiness TEXT,
	GuestNote TEXT NOT NULL,
	ResNote TEXT NOT NULL,
	
	PostDepo BOOLEAN,
	Amount INT,
	
	PaymentID INT NOT NULL,
	
	VehicleBrand TEXT,
	VehicleModel TEXT,
	License TEXT,
	
	PRIMARY KEY (ClientID),
	FOREIGN KEY (PaymentID) REFERENCES PaymentMethod(PaymentID)
); 
