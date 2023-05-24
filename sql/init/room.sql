
CREATE TABLE IF NOT EXISTS Room (
	id INT NOT NULL,
	-- TODO: implement supplemental data
	RoomNumber INT NOT NULL,
	RoomType TEXT NOT NULL,
	Rate INT NOT NULL,
	Capacity INT NOT NULL
	PRIMARY KEY (id)
);
