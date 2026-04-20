
CREATE DATABASE IF NOT EXISTS gyümölcs;
USE gyümölcs;

DROP TABLE IF EXISTS adatok;
CREATE TABLE adatok (
    TAzon INT AUTO_INCREMENT PRIMARY KEY,
    TNév VARCHAR(30) NOT NULL,
    Magyar TINYINT(1) DEFAULT 0,
    ÉrkIdő DATE DEFAULT (CURRENT_DATE),
    Szavatosság INT DEFAULT 30,
    Ar INT,
    Mennyiség INT
);

INSERT INTO adatok (TNév, Magyar, ÉrkIdő, Szavatosság, Ar, Mennyiség) VALUES 
('Alma', 1, CURDATE(), 60, 200, 20),

('Banán', 0, DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH), 30, 300, 10),

('Citrom', 0, CURDATE(), 20, 150, 5),

('Körte', 1, DATE_SUB(DATE_FORMAT(CURDATE(), '%Y-%m-30'), INTERVAL 1 MONTH), 30, 180, 15),

('Szőlő', 1, CURDATE(), 15, 400, 9);