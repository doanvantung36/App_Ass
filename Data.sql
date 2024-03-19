Drop database AssKTNC
Create database AssKTNC

CREATE TABLE Employees (
    employee_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_name VARCHAR(100),
    employee_username VARCHAR(50) UNIQUE,
    employee_password VARCHAR(100)
);
-- Tạo bảng Users
CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) UNIQUE,
    password VARCHAR(100),
    role varchar(20)
);


CREATE TABLE Products (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    category VARCHAR(50),
    size VARCHAR(20),
    price DECIMAL(10, 2),
    quantity INT,
    employee_id INT,
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);

-- Tạo bảng giỏ hàng
CREATE TABLE ShoppingCart (
    cart_id INT IDENTITY(1,1) PRIMARY KEY,
    product_id INT,
    quantity INT,
    price DECIMAL(10, 2),
    total_price DECIMAL(10, 2),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Chèn dữ liệu vào bảng giỏ hàng
INSERT INTO ShoppingCart (product_id, quantity, price, total_price)
VALUES 
(1, 2, 25.99, 51.98),  -- Áo sơ mi trắng, 2 cái, giá 25.99/cái, tổng tiền 51.98
(3, 1, 59.99, 59.99);  -- Áo khoác dù xanh, 1 cái, giá 59.99/cái, tổng tiền 59.99

CREATE TABLE CartDetail (
    detail_id INT IDENTITY(1,1) PRIMARY KEY,
    cart_id INT,
    product_name VARCHAR(100),
    total_price DECIMAL(10, 2),
    shipping_unit VARCHAR(50),
    FOREIGN KEY (cart_id) REFERENCES ShoppingCart(cart_id)
);

INSERT INTO CartDetail (cart_id, product_name, total_price, shipping_unit)
VALUES 
(1, 'Áo sơ mi trắng', 51.98, 'EMS'),
(2, 'Áo khoác dù xanh', 59.99, 'FedEx');

-- Chèn dữ liệu mẫu vào bảng Users
INSERT INTO Users (username, password, role) 
VALUES 
('admin', 'admin_password', 'admin'),
('user1', 'user1_password', 'user'),
('user2', 'user2_password', 'user');

-- Chèn dữ liệu mẫu vào bảng Employees
INSERT INTO Employees (employee_name, employee_username, employee_password)
VALUES 
('Employee 1', 'employee1', 'employee1_password'),
('Employee 2', 'employee2', 'employee2_password');

-- Chèn dữ liệu mẫu vào bảng Products
INSERT INTO Products (name, category, size, price, quantity, employee_id)
VALUES 
('Áo sơ mi trắng', 'Áo sơ mi', 'M', 25.99, 50, 1),
('Quần jeans đen', 'Quần jeans', 'L', 39.99, 30, 2),
('Áo khoác dù xanh', 'Áo khoác', 'XL', 59.99, 20, 1),
('Váy hoa đỏ', 'Váy', 'S', 29.99, 40, 2);


