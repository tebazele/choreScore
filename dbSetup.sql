CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    chores(
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        name VARCHAR(50) NOT NULL,
        difficulty INT NOT NULL DEFAULT 5,
        done BOOLEAN NOT NULL DEFAULT false,
        location VARCHAR(20),
        creatorId VARCHAR(255) NOT NULL,
        FOREIGN KEY (creatorId) REFERENCES accounts (id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';

DROP TABLE chores;

INSERT INTO
    chores (
        name,
        difficulty,
        done,
        location,
        `creatorId`
    )
VALUES (
        'Dishes',
        8,
        false,
        "Kitchen",
        "6387da8669f9a7aa48a68fd7"
    );

INSERT INTO
    chores (
        name,
        difficulty,
        done,
        location,
        `creatorId`
    )
VALUES (
        'Laundry',
        6,
        false,
        "LaundryRoom",
        "6387da8669f9a7aa48a68fd7"
    )