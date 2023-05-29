
CREATE TABLE IF NOT EXISTS UserInfo (
	id INT NOT NULL AUTO_INCREMENT,
	firstName TEXT NOT NULL,
	lastName TEXT NOT NULL,
	userType TEXT NOT NULL,
	userName TEXT NOT NULL,
	password TEXT NOT NULL,
	
	PRIMARY KEY (id)
);
