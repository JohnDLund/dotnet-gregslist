-- CREATE TABLE cars (
--     id INT NOT NULL AUTO_INCREMENT,
--     make VARCHAR(255) NOT NULL,
--     model VARCHAR(255) NOT NULL,
--     year INT,
--     imgUrl VARCHAR(255) NOT NULL,
--     price INT,
--     description VARCHAR(255),
--     userId VARCHAR(255) NOT NULL,
--     PRIMARY KEY(id)
-- );



-- INSERT INTO cars
-- (make, model, year, price, imgUrl, description, userId)
-- VALUES
-- ("Chevy", "Tracker", 1989, 2000, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQiEdhq7a4aHGvv8FxjKUpAg_godVfcyLzHSg&usqp=CAU", "Itsa trackin", "D$SUPERSECRETUSERID")

-- SELECT * FROM cars


-- CREATE TABLE houses (
--     id INT NOT NULL AUTO_INCREMENT,
--     level INT,
--     year INT,
--     imgUrl VARCHAR(255) NOT NULL,
--     price INT,
--     userId VARCHAR(255) NOT NULL,
--     PRIMARY KEY(id)
-- );



INSERT INTO houses
(level, year, price, imgUrl, userId)
VALUES
(2, 2020, 210000, "https://i.ytimg.com/vi/XBorGWlgIkQ/maxresdefault.jpg", "JohnIsTheUser" )