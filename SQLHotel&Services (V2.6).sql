use master
ALTER DATABASE HotelManagement SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE HotelManagement;

Create database HotelManagement
Use HotelManagement

-- Khách
CREATE TABLE Guests (
    GuestID Char(10) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    PhoneNumber VARCHAR(15) NOT NULL,
    Address NVARCHAR(100)
);

-- Bảng chức vụ (Cho nhân viên)
CREATE TABLE Positions (
    PositionID Char(10) PRIMARY KEY,
    Title VARCHAR(50) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL Check (Salary >= 0),
    Description NVARCHAR(100)
);

-- Nhân viên
CREATE TABLE Employees (
    EmployeeID Char(10) PRIMARY KEY,
	PositionID Char(10) NOT NULL References Positions(PositionID),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
	Sex Char(1) Check (Sex In ('M', 'F')),
	DateOfBirth DATE NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

CREATE TABLE Towers (
	TowerID Char(10) Primary Key,
	TowerName NVARCHAR(50),
	Location NVarchar(100),
	ManagerID CHAR(10) NOT NULL REFERENCES Employees(EmployeeID)
);

-- Kiểu phòng (standard, economy, VIP, ...)
CREATE TABLE RoomTypes (
	RoomTypeID Char(10) Primary Key,
	RoomTypeName VARCHAR(50) NOT NULL,
	Price DECIMAL(10, 2) NOT NULL,
	MaxCapacity Int NOT NULL Check (MaxCapacity > 0),
	Notes NVARCHAR(100) -- Phòng có wifi, balcony, minibar, ...
);

-- Phòng
CREATE TABLE Rooms (
    RoomID Char(10) PRIMARY KEY,
    RoomTypeID CHAR(10) NOT NULL References RoomTypes(RoomTypeID),
	TowerID Char(10) NOT NULL References Towers(TowerID),
	RoomNumber VARCHAR(10) NOT NULL,
	RoomFloor VARCHAR(3) NOT NULL, -- Vài tầng có số lạ như 12A để bỏ qua số 13
    IsUnderMaintenance Char(1) NOT NULL Default 'N' Check (IsUnderMaintenance IN ('Y','N'))
);

-- Đặt trước
CREATE TABLE Reservations (
    ReserID Char(10) PRIMARY KEY,
    GuestID Char(10) NOT NULL REFERENCES Guests(GuestID),
    RoomID Char(10) NOT NULL REFERENCES Rooms(RoomID),
    CheckInDate DATETIME NOT NULL,
    CheckOutDate DATETIME NOT NULL,
	PaymentStatus VARCHAR(9) Default 'Pending' Check (PaymentStatus in ('Pending', 'Paid', 'Cancelled')),
	CONSTRAINT Check_CheckOutDate CHECK (CheckOutDate >= CheckInDate) 
);

-- Dịch vụ
CREATE TABLE Services (
    ServiceID Char(10) PRIMARY KEY,
    ServiceName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
	Description NVARCHAR(100)
);

-- Khách đặt dịch vụ
CREATE TABLE ServiceOrders (
    ServiceOrderID Int Identity(1,1) PRIMARY KEY,
    GuestID Char(10) NOT NULL REFERENCES Guests(GuestID),
    ServiceID Char(10) NOT NULL REFERENCES Services(ServiceID),
	EmployeeID Char(10) References Employees(EmployeeID), --Can be NULL if there's a self-service thing
    OrderDate DATETIME NOT NULL
);

-- Tính tiền để khách trả (sau check-out, không điền trực tiếp vì có proc làm hộ)
CREATE TABLE Payments (
    PaymentID Int Identity(1,1) PRIMARY KEY,
	ReserID Char(10) NOT NULL References Reservations(ReserID),
    Amount DECIMAL(10, 2) NOT NULL
);

-- Kho
CREATE TABLE Inventory (
    ItemID Char(10) PRIMARY KEY,
    ItemName VARCHAR(100) NOT NULL,
    InStock Decimal(10,2) NOT NULL Check (InStock >= 0),
	Unit VARCHAR(10) NOT NULL, -- Kg, bottles, litres, etc..
    PricePerUnit DECIMAL(10, 2) NOT NULL,
	LastChange DATETIME
);

CREATE TABLE InventoryChanges (
	ChangeID Int Identity(1,1) PRIMARY KEY,
	ChangeDate DATETIME NOT NULL,
	ChangeType Char(8) CHECK (ChangeType IN ('Addition', 'Removal')),
	EmployeeID Char(10) NOT NULL References Employees(EmployeeID),
	ItemID Char(10) NOT NULL References Inventory(ItemID),
	Quantity Decimal(10,2) NOT NULL Check (Quantity >= 0),
	Notes NVarChar(100)
);

Create Table Accounts(
	AccountID Int Identity(1,1) PRIMARY KEY,
	Username VARCHAR(50),
	Pass VARCHAR(50),
	LinkedID Char(10) 
);
Go

Select * FROM Payments

CREATE TRIGGER InvenChange ON InventoryChanges AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- DELETE
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        UPDATE Inventory
        SET LastChange = changes.MaxChangeDate,
            InStock = Inventory.InStock + changes.Removals - changes.Additions
        FROM Inventory, (
            SELECT ItemID, 
                   MAX(ChangeDate) AS MaxChangeDate,
                   SUM(CASE WHEN ChangeType = 'Removal' THEN Quantity ELSE 0 END) AS Removals,
                   SUM(CASE WHEN ChangeType = 'Addition' THEN Quantity ELSE 0 END) AS Additions
            FROM deleted
            GROUP BY ItemID
        ) changes
        Where Inventory.ItemID = changes.ItemID;
    END
    
    -- INSERT 
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        UPDATE Inventory
        SET LastChange = changes.MaxChangeDate,
            InStock = Inventory.InStock + changes.Additions - changes.Removals
        FROM Inventory, (
            SELECT ItemID, 
                   MAX(ChangeDate) AS MaxChangeDate,
                   SUM(CASE WHEN ChangeType = 'Addition' THEN Quantity ELSE 0 END) AS Additions,
                   SUM(CASE WHEN ChangeType = 'Removal' THEN Quantity ELSE 0 END) AS Removals
            FROM inserted
            GROUP BY ItemID
        ) changes
        Where Inventory.ItemID = changes.ItemID;
    END
END;
GO

-- thêm dữ liệu
INSERT INTO Positions (PositionID, Title, Salary, Description) VALUES
('P001', 'General Manager', 50000000, N'Quản lý toàn bộ hoạt động khách sạn'),
('P002', 'Front Desk Manager', 20000000, N'Quản lý lễ tân và dịch vụ khách hàng'),
('P003', 'Housekeeping Supervisor', 15000000, N'Giám sát đội ngũ dọn dẹp'),
('P004', 'Receptionist', 10000000, N'Tiếp nhận và hỗ trợ khách đăng ký'),
('P005', 'Housekeeper', 8000000, N'Dọn dẹp và bảo trì phòng');


INSERT INTO Employees (EmployeeID, PositionID, FirstName, LastName, Sex, DateOfBirth, PhoneNumber, Email) VALUES
('E001', 'P001', N'Nguyễn', N'Văn An', 'M', '1970-01-01', '0987654321', 'vana@gmail.com'),
('E002', 'P002', N'Trần', N'Thị Bình', 'F', '1980-02-02', '0987654322', 'thib@gmail.com'),
('E003', 'P003', N'Lê', N'Văn Cường', 'M', '1985-03-03', '0987654323', 'vanc@gmail.com'),
('E004', 'P004', N'Phạm', N'Thị Dung', 'F', '1990-04-04', '0987654324', 'thid@gmail.com'),
('E005', 'P005', N'Hoàng', N'Văn Em', 'M', '1992-05-05', '0987654325', 'vane@gmail.com'),
('E006', 'P001', N'Nguyễn', N'Thị Giang', 'F', '1975-06-06', '0987654326', 'ntgiang@gmail.com'),
('E007', 'P002', N'Trần', N'Văn Hùng', 'M', '1982-07-07', '0987654327', 'tvhung@gmail.com'),
('E008', 'P003', N'Lê', N'Thị Hà', 'F', '1987-08-08', '0987654328', 'ltha@gmail.com'),
('E009', 'P004', N'Phạm', N'Văn Ích', 'M', '1991-09-09', '0987654329', 'pvich@gmail.com'),
('E010', 'P005', N'Hoàng', N'Thị Kim', 'F', '1993-10-10', '0987654330', 'htkim@gmail.com'),
('E011', 'P001', N'Nguyễn', N'Văn Long', 'M', '1978-11-11', '0987654331', 'nvlong@gmail.com'),
('E012', 'P002', N'Trần', N'Thị Mai', 'F', '1983-12-12', '0987654332', 'ttmai@gmail.com'),
('E013', 'P003', N'Lê', N'Văn Nam', 'M', '1989-01-13', '0987654333', 'lvnam@gmail.com'),
('E014', 'P004', N'Phạm', N'Thị Oanh', 'F', '1994-02-14', '0987654334', 'ptoanh@gmail.com'),
('E015', 'P005', N'Hoàng', N'Văn Phát', 'M', '1986-03-15', '0987654335', 'hvphat@gmail.com'),
('E016', 'P001', N'Nguyễn', N'Thị Quỳnh', 'F', '1979-04-16', '0987654336', 'ntquynh@gmail.com'),
('E017', 'P002', N'Trần', N'Văn Sơn', 'M', '1984-05-17', '0987654337', 'tvson@gmail.com'),
('E018', 'P003', N'Lê', N'Thị Thu', 'F', '1988-06-18', '0987654338', 'ltthu@gmail.com'),
('E019', 'P004', N'Phạm', N'Văn Tâm', 'M', '1995-07-19', '0987654339', 'pvtam@gmail.com'),
('E020', 'P005', N'Hoàng', N'Thị Uyên', 'F', '1996-08-20', '0987654340', 'htuyen@gmail.com');

INSERT INTO Towers (TowerID, TowerName, Location, ManagerID) VALUES
('T001', N'Mường Thanh Grand Hanoi Centre Hotel', N'Quận Hoàn Kiếm', 'E001'),
('T002', N'Mường Thanh Grand Ha Noi Hotel', N'Quận Hoàng Mai', 'E002'),
('T003', N'Mường Thanh Grand Xa La Hotel', N'Quận Hà Đông', 'E003');

INSERT INTO RoomTypes (RoomTypeID, RoomTypeName, Price, MaxCapacity, Notes) VALUES
('RT001', 'Deluxe Double Room', 1000000, 2, N'Phòng Deluxe với giường đôi, view thành phố'),
('RT002', 'Deluxe Twin Room', 1000000, 2, N'Phòng Deluxe với hai giường đơn'),
('RT003', 'Suite', 2000000, 2, N'Suite rộng rãi với khu vực tiếp khách'),
('RT004', 'Family Room', 1500000, 4, N'Phòng gia đình với hai giường đôi'),
('RT005', 'Executive Room', 1800000, 2, N'Phòng Executive với tiện nghi cao cấp');

INSERT INTO Rooms (RoomID, RoomTypeID, TowerID, RoomNumber, RoomFloor) VALUES
-- Tower T001
('R001', 'RT001', 'T001', '101', '1'),
('R002', 'RT002', 'T001', '102', '1'),
('R003', 'RT003', 'T001', '201', '2'),
('R004', 'RT004', 'T001', '202', '2'),
('R005', 'RT005', 'T001', '301', '3'),
('R006', 'RT001', 'T001', '302', '3'),
('R007', 'RT002', 'T001', '303', '3'),

-- Tower T002
('R008', 'RT001', 'T002', '101', '1'),
('R009', 'RT002', 'T002', '102', '1'),
('R010', 'RT003', 'T002', '201', '2'),
('R011', 'RT004', 'T002', '202', '2'),
('R012', 'RT005', 'T002', '301', '3'),
('R013', 'RT001', 'T002', '302', '3'),

-- Tower T003
('R014', 'RT002', 'T003', '101', '1'),
('R015', 'RT003', 'T003', '102', '1'),
('R016', 'RT004', 'T003', '201', '2'),
('R017', 'RT005', 'T003', '202', '2'),
('R018', 'RT001', 'T003', '301', '3'),
('R019', 'RT002', 'T003', '302', '3'),
('R020', 'RT005', 'T003', '303', '3');

INSERT INTO Services (ServiceID, ServiceName, Price, Description) VALUES
('S001', 'Room Service', 200000, N'Giao đồ ăn và thức uống đến phòng'),
('S002', 'Laundry', 50000, N'Giặt và ủi đồ'),
('S003', 'Spa Treatment', 1000000, N'Dịch vụ massage và chăm sóc sức khỏe'),
('S004', 'Airport Transfer', 300000, N'Đưa đón sân bay'),
('S005', 'City Tour', 500000, N'Tour tham quan Hà Nội có hướng dẫn');

INSERT INTO Guests (GuestID, FirstName, LastName, Email, PhoneNumber, Address) VALUES
('G001', N'Lý', N'Thị Hoa', 'lthoa@gmail.com', '0912345678', N'Hà Nội'),
('G002', N'Vũ', N'Văn Khánh', 'vvkhanh@gmail.com', '0987654321', N'Hồ Chí Minh'),
('G003', N'Đặng', N'Thị Lan', 'dtlan@gmail.com', '0901234567', N'Đà Nẵng'),
('G004', N'Bùi', N'Văn Minh', 'bvminh@gmail.com', '0932145678', N'Hà Nội'),
('G005', N'Đỗ', N'Thị Nga', 'dtnga@gmail.com', '0971234567', N'Hải Phòng'),
('G006', N'Phan', N'Văn Quang', 'pvquang@gmail.com', '0923456789', N'Hà Nội'),
('G007', N'Hồ', N'Thị Phương', 'htphuong@gmail.com', '0945678901', N'Hồ Chí Minh'),
('G008', N'Ngô', N'Văn Sơn', 'nvson@gmail.com', '0967890123', N'Đà Nẵng'),
('G009', N'Đinh', N'Thị Thảo', 'dtthao@gmail.com', '0913456789', N'Hà Nội'),
('G010', N'Trịnh', N'Văn Tuấn', 'tvtuan@gmail.com', '0989012345', N'Hải Phòng'),
('G011', N'Mai', N'Thị Uyên', 'mtuyen@gmail.com', '0902345678', N'Hà Nội'),
('G012', N'Lương', N'Văn Vinh', 'lvvinh@gmail.com', '0934567890', N'Hồ Chí Minh'),
('G013', N'Chu', N'Thị Xuân', 'ctxuan@gmail.com', '0956789012', N'Đà Nẵng'),
('G014', N'Tô', N'Văn Yên', 'tvyen@gmail.com', '0978901234', N'Hà Nội'),
('G015', N'Hà', N'Thị Ánh', 'htanh@gmail.com', '0915678901', N'Hải Phòng'),
('G016', N'Dương', N'Văn Bảo', 'dvbao@gmail.com', '0941234567', N'Hà Nội'),
('G017', N'Kiều', N'Thị Cẩm', 'ktcam@gmail.com', '0963456789', N'Hồ Chí Minh'),
('G018', N'Lâm', N'Văn Đức', 'lvduc@gmail.com', '0985678901', N'Đà Nẵng'),
('G019', N'Nguyễn', N'Thị Hương', 'nthuong@gmail.com', '0907890123', N'Hà Nội'),
('G020', N'Trương', N'Văn Khôi', 'tvkhoi@gmail.com', '0929012345', N'Hải Phòng');

INSERT INTO Reservations (ReserID, GuestID, RoomID, CheckInDate, CheckOutDate) VALUES
('RES001', 'G001', 'R001', '2026-01-01 14:00:00', '2026-01-05 12:00:00'),
('RES002', 'G002', 'R002', '2026-01-02 15:00:00', '2026-01-06 11:00:00'),
('RES003', 'G003', 'R003', '2026-01-03 16:00:00', '2026-01-07 10:00:00'),
('RES004', 'G004', 'R004', '2026-01-04 14:00:00', '2026-01-08 12:00:00'),
('RES005', 'G005', 'R005', '2026-01-05 15:00:00', '2026-01-09 11:00:00'),
('RES006', 'G006', 'R006', '2026-02-01 14:00:00', '2026-02-05 12:00:00'),
('RES007', 'G007', 'R007', '2026-02-02 15:00:00', '2026-02-06 11:00:00'),
('RES008', 'G008', 'R008', '2026-02-03 16:00:00', '2026-02-07 10:00:00'),
('RES009', 'G009', 'R009', '2026-02-04 14:00:00', '2026-02-08 12:00:00'),
('RES010', 'G010', 'R010', '2026-02-05 15:00:00', '2026-02-09 11:00:00'),
('RES011', 'G011', 'R011', '2026-03-01 14:00:00', '2026-03-05 12:00:00'),
('RES012', 'G012', 'R012', '2026-03-02 15:00:00', '2026-03-06 11:00:00'),
('RES013', 'G013', 'R013', '2026-03-03 16:00:00', '2026-03-07 10:00:00'),
('RES014', 'G014', 'R014', '2026-03-04 14:00:00', '2026-03-08 12:00:00'),
('RES015', 'G015', 'R015', '2026-03-05 15:00:00', '2026-03-09 11:00:00'),
('RES016', 'G016', 'R016', '2026-04-01 14:00:00', '2026-04-05 12:00:00'),
('RES017', 'G017', 'R017', '2026-04-02 15:00:00', '2026-04-06 11:00:00'),
('RES018', 'G018', 'R018', '2026-04-03 16:00:00', '2026-04-07 10:00:00'),
('RES019', 'G019', 'R019', '2026-04-04 14:00:00', '2026-04-08 12:00:00'),
('RES020', 'G020', 'R020', '2026-04-05 15:00:00', '2026-04-09 11:00:00');


INSERT INTO ServiceOrders (GuestID, ServiceID, EmployeeID, OrderDate) VALUES
('G001', 'S001', 'E004', '2026-01-02 18:00:00'),
('G002', 'S002', 'E005', '2026-01-03 09:00:00'),
('G003', 'S003', 'E005', '2026-01-04 14:00:00'),
('G004', 'S004', 'E004', '2026-01-05 07:00:00'),
('G005', 'S005', 'E010', '2026-01-06 10:00:00'),
('G006', 'S001', 'E004', '2026-02-02 18:00:00'),
('G007', 'S002', 'E015', '2026-02-03 09:00:00'),
('G008', 'S003', 'E005', '2026-02-04 14:00:00'),
('G009', 'S004', 'E004', '2026-02-05 07:00:00'),
('G010', 'S005', 'E020', '2026-02-06 10:00:00'),
('G011', 'S001', 'E004', '2026-03-02 18:00:00'),
('G012', 'S002', 'E005', '2026-03-03 09:00:00'),
('G013', 'S003', 'E005', '2026-03-04 14:00:00'),
('G014', 'S004', 'E004', '2026-03-05 07:00:00'),
('G015', 'S005', 'E010', '2026-03-06 10:00:00'),
('G016', 'S001', 'E004', '2026-04-02 18:00:00'),
('G017', 'S002', 'E015', '2026-04-03 09:00:00'),
('G018', 'S003', 'E005', '2026-04-04 14:00:00'),
('G019', 'S004', 'E004', '2026-04-05 07:00:00'),
('G020', 'S005', 'E020', '2026-04-06 10:00:00');

INSERT INTO Inventory (ItemID, ItemName, InStock, Unit, PricePerUnit) VALUES
('I001', 'Toilet Paper', 100, 'rolls', 5000),
('I002', 'Shampoo Bottles', 50, 'bottles', 20000),
('I003', 'Towels', 200, 'pieces', 50000),
('I004', 'Bed Sheets', 150, 'sets', 100000),
('I005', 'Water Bottles', 500, 'bottles', 5000);
Go

INSERT INTO InventoryChanges (ChangeDate, ChangeType, EmployeeID, ItemID, Quantity, Notes) VALUES
('2024-10-01 09:00:00', 'Addition', 'E005', 'I001', 50, N'Nhập thêm giấy vệ sinh'),
('2024-10-02 10:00:00', 'Removal', 'E005', 'I002', 10, N'Dùng cho phòng'),
('2024-10-03 11:00:00', 'Addition', 'E005', 'I003', 20, N'Nhập khăn mới'),
('2024-10-04 12:00:00', 'Removal', 'E005', 'I004', 5, N'Thay cho phòng'),
('2024-10-05 13:00:00', 'Addition', 'E005', 'I005', 100, N'Nhập thêm nước uống');
Go

INSERT INTO Accounts (Username, Pass, LinkedID) VALUES
('e', 'p', 'E017'),
('g', 'p', 'E008');

--Tạo danh sách những phòng trống trong một khoảng thời gian nhất định. (Mục đích: hỗ trợ bộ phận lễ tân giải quyết việc đặt phòng)
--RoomTypeName is an optional argument, if it's not provided, then every room that isn't occupied will be shown.
create proc CheckAvailableRooms @CheckInDate DATETIME, @Duration Float, @RoomTypeName VarChar(50) = '*'
As
Begin
	If (@Duration <= 0)
		Begin
			Print 'Error: Duration must be greater than 0.'; Return;
		End

	Declare @CheckOutDate DateTime = DATEADD(Day, @Duration, @CheckInDate)
	Select
		TowerName, RoomFloor, RoomNumber, RoomTypeName
	From
		RoomTypes, Rooms, Reservations, Towers
	Where RoomTypes.RoomTypeID = Rooms.RoomTypeID
	  And Rooms.RoomID = Reservations.RoomID
	  And Rooms.TowerID = Towers.TowerID
	  And (@RoomTypeName = '*' OR RoomTypes.RoomTypeName LIKE '%' + @RoomTypeName + '%')
	  And Reservations.ReserID NOT IN
	  (
		Select ReserID From Reservations 
		Where CheckOutDate > @CheckInDate
		  And CheckInDate < @CheckOutDate
		  And PaymentStatus != 'Cancelled'
	  )
End
Go

Exec CheckAvailableRooms '2026-02-02 06:00:00', 8.5, 'Deluxe'

--These rooms are occupied during the timeframe above (I used this to debug the CheckAvailableRooms proc)
Select * From Rooms, Reservations
	Where Rooms.RoomID = Reservations.RoomID 
	  And CheckOutDate > '2026-02-02 06:00:00'
	  And CheckInDate < '2026-02-10 18:00:00'
	  And PaymentStatus != 'Cancelled'



go
create procedure CalcPayment @reserID Char(10)
As
Begin
	if (not exists (Select * from Reservations where ReserID = @reserID And PaymentStatus = 'Pending'))
		Print 'Reservation ID does not exist in database, or the reservation has already been paid/ cancelled.'
	else
		begin
			DECLARE @amount decimal(10,2) = 0, @roomPrice decimal(10,2) = 0, @servicesCost decimal(10,2) = 0;
			DECLARE @numDays INT = 0;
			declare @guestID CHAR(10);
			declare @cinDate DATETIME, @coutDate DATETIME;
			
			-- How long did this person stay in the hotel?
			Select 
				@numDays = DATEDIFF(Day, CheckInDate, CheckOutDate),
				@roomPrice = RoomTypes.Price,
				@guestID = Reservations.GuestID,
				@cinDate = Reservations.CheckInDate,
				@coutDate = Reservations.CheckOutDate
			From Reservations, Rooms, RoomTypes
			Where Reservations.RoomID = Rooms.RoomID 
			  And Rooms.RoomTypeID = RoomTypes.RoomTypeID 
			  And Reservations.ReserID = @reserID
			  And PaymentStatus = 'Pending';
			
			-- Any fees incurred by using services?
			SELECT 
				@servicesCost = ISNULL(SUM(Services.Price), 0)
			FROM ServiceOrders, Services
			Where ServiceOrders.ServiceID = Services.ServiceID 
			  And ServiceOrders.GuestID = @guestID
			  And ServiceOrders.OrderDate Between @cinDate AND @coutDate;

			-- Calculate and insert results into table
			Set @amount = (@roomPrice * @numDays) + @servicesCost;

			Insert into Payments (ReserID, Amount)
			Values (@reserID, @amount);

			-- Payment complete, update the reservations table to mark the end of their stay
			UPDATE Reservations
			SET PaymentStatus = 'Paid'
			WHERE ReserID = @reserID AND PaymentStatus = 'Pending';

			Print 'Payment summary for reservation ID: ' + @reserID + CHAR(10)
			    + 'Guest ID: ' + @guestID + CHAR(10)
				+ 'Amount due: ' + CAST(@amount AS VARCHAR);
		end
End
go

exec CalcPayment 'RES014'
Select * From Payments
Select * From Rooms
Select * FROM Reservations
Select * FROM Inventory
Select * FROM InventoryChanges

--thu tuc cap nhat trang thai bao tri phong
CREATE PROCEDURE UpdRoomMaintenance
	@RoomID Char(10),
	@IsUnderMaintenance CHAR(1)
AS
BEGIN
	IF(NOT EXISTS(SELECT* FROM ROOMS WHERE ROOMID=@ROOMID))
		PRINT 'PHONG KHONG TON TAI'
	ELSE
		Begin
			If (@IsUnderMaintenance IN ('Y', 'N'))
				UPDATE ROOMS SET IsUnderMaintenance = @IsUnderMaintenance
				WHERE ROOMID = @ROOMID
			Else
				Print 'Invalid Maintanence Status. It must be either "Y" or "N".'
		End
END

EXEC UpdRoomMaintenance 'R002', 'Y'
Select * from Rooms

--Thutuc them reservation
CREATE PROCEDURE SP_THEMRESER
	@ReserID Char(10),
    @GuestID Char(10),
    @RoomID Char(10),
    @CheckInDate DATETIME,
    @CheckOutDate DATETIME,
	@PaymentStatus varchar(9) = 'Pending'
AS
BEGIN
	IF(EXISTS (SELECT * FROM Reservations WHERE RESERID = @RESERID))
		PRINT 'DA TON TAI RESERVATION'
	Else IF(NOT EXISTS (SELECT * FROM Guests WHERE GuestID=@GuestID))
		PRINT 'KHACH HANG KHONG TON TAI'
	Else IF(NOT EXISTS (SELECT * FROM Rooms WHERE RoomID=@RoomID))
		PRINT 'PHONG KHONG TON TAI'
	else if (@CheckInDate >= @CheckOutDate)
		Print 'Invalid check-in date: Check in date is greater or equal to check out date.'
	ELSE If (exists
				(
				Select * from Reservations
				Where RoomID = @RoomID
				And CheckOutDate > @CheckInDate
				And CheckInDate < @CheckOutDate
				And PaymentStatus != 'Cancelled'
				)
			)
		PRINT 'Error: The new reservation overlaps with an existing reservation for the specified room. Please choose a different date range.';
	else
		INSERT INTO Reservations VALUES(@ReserID,@GuestID,@RoomID,@CheckInDate,@CheckOutDate,@PaymentStatus)
END

EXEC SP_THEMRESER @ReserID='RES100',@GuestID='G002',@RoomID='R001',@CheckInDate='2026-04-12',@CheckOutDate='2026-04-13'

--thu tuc them InventoryChanges
CREATE PROCEDURE SP_THEMINVENCHANGE
	@ChangeDate DATETIME,
	@ChangeType Char(8),
	@EmployeeID Char(10),
	@ItemID Char(10),
	@Quantity Decimal(10,2),
	@Notes NVarChar(100) = null
AS
BEGIN
	IF(NOT EXISTS (SELECT* FROM Employees WHERE EmployeeID=@EmployeeID))
		PRINT'NHAN VIEN KHONG TON TAI'
	else IF(NOT EXISTS (SELECT * FROM Inventory WHERE ItemID=@ItemID ))
		PRINT'KHONG TON TAI ITEM'
	else if((Select InStock from Inventory Where ItemID=@ItemID) < @Quantity AND @ChangeType = 'Removal')
		Print 'Error: Quantity removed exceeds the In Stock value of the item.'
	ELSE
		INSERT INTO InventoryChanges VALUES(@ChangeDate,@ChangeType,@EmployeeID,@ItemID,@Quantity,@Notes)
END

SELECT * FROM InventoryChanges
EXEC SP_THEMINVENCHANGE @ChangeDate='2026-04-12',@ChangeType='ADDITION',@EmployeeID='E004',@ItemID='I001',@Quantity='50',@Notes='NHAP THEM GIAY VE SINH'
EXEC SP_THEMINVENCHANGE @ChangeDate='2026-04-13',@ChangeType='Removal',@EmployeeID='E004',@ItemID='I002',@Quantity='50'
Go

-- Mỗi dịch vụ có doanh thu là bao nhiêu?
CREATE VIEW ServiceRevenue AS
SELECT 
    Services.ServiceID, ServiceName, SUM(Price) AS TotalRevenue
FROM 
    ServiceOrders, Services
Where
	ServiceOrders.ServiceID = Services.ServiceID
GROUP BY 
    Services.ServiceID, Services.ServiceName;
Go
Select * From ServiceRevenue Order By TotalRevenue Desc
Go

-- Chi tiết hóa đơn đặt phòng
CREATE or alter VIEW ReservationInvoiceDetails AS
SELECT 
    ReserID, 
    Guests.GuestID, 
    CONCAT(FirstName, ' ', LastName) AS GuestName,
    Reservations.RoomID, 
    RoomTypeName, 
    RoomTypes.Price AS RoomPricePerDay,
    DATEDIFF(DAY, CheckInDate, CheckOutDate) AS StayDuration,
    (DATEDIFF(DAY, CheckInDate, CheckOutDate) * RoomTypes.Price) AS RoomCost,
    ISNULL(SUM(Services.Price), 0) AS ServiceCost,
    (DATEDIFF(DAY, CheckInDate, CheckOutDate) * RoomTypes.Price + ISNULL(SUM(Services.Price), 0)) AS TotalCost,
	Reservations.PaymentStatus
FROM 
    Reservations, Guests, Rooms, RoomTypes, ServiceOrders, Services
WHERE 
    Reservations.GuestID = Guests.GuestID
    AND Reservations.RoomID = Rooms.RoomID
    AND Rooms.RoomTypeID = RoomTypes.RoomTypeID
    AND ServiceOrders.GuestID = Guests.GuestID
    AND ServiceOrders.OrderDate BETWEEN Reservations.CheckInDate AND Reservations.CheckOutDate
    AND ServiceOrders.ServiceID = Services.ServiceID
GROUP BY 
    ReserID, Guests.GuestID, FirstName, LastName, Reservations.RoomID, 
    RoomTypeName, RoomTypes.Price, CheckInDate, CheckOutDate, PaymentStatus;
Go
Select * from ReservationInvoiceDetails

--Tổng số dịch vụ đã được nhân viên xử lý trong tháng qua? (Mục đích: đánh giá hiệu quả công việc của từng nhân viên)
CREATE VIEW EmployeeService AS
	SELECT EmployeeID, COUNT(ServiceOrderID) AS ServicesHandled
	FROM ServiceOrders
	WHERE OrderDate >= DATEADD(MONTH, -1, GETDATE())
	GROUP BY EmployeeID;
GO

--Tháng qua một khách trung bình ở khách sạn bao lâu? (Mục đích: phân tích hành vi khách để tối ưu giá phòng)
Create view AverageGuestStayLength As
	SELECT AVG(DATEDIFF(DAY, CheckInDate, CheckOutDate)) AS AverageStayLength
	FROM Reservations
	WHERE CheckInDate >= DATEADD(MONTH, -1, GETDATE());
Go

--Năm qua có khách nào ở khách sạn hơn 30 ngày không? (Mục đích: xác định khách hàng thân thiết để đề xuất chương trình ưu đãi)
Create View LoyalGuests As
	SELECT 
		Guests.GuestID, 
		CONCAT(FirstName, ' ', LastName) AS GuestName, 
		PhoneNumber, Email, 
		SUM(DATEDIFF(DAY, CheckInDate, CheckOutDate)) AS TotalDaysStayed
	FROM 
		Reservations, Guests
	WHERE 
		Reservations.GuestID = Guests.GuestID 
		AND CheckInDate >= DATEADD(YEAR, -1, GETDATE())
	GROUP BY 
		Guests.GuestID, FirstName, LastName, PhoneNumber, Email
	HAVING 
		SUM(DATEDIFF(DAY, CheckInDate, CheckOutDate)) > 30;


		select * from ServiceRevenue	




CREATE VIEW GuestServiceDetails AS
SELECT 
    ServiceOrders.ServiceOrderID,
    ServiceOrders.GuestID,
    CONCAT(Guests.FirstName, ' ', Guests.LastName) AS GuestName,
    Services.ServiceID,
    Services.ServiceName,
    ServiceOrders.EmployeeID,
    ServiceOrders.OrderDate,
    Services.Price
FROM 
    ServiceOrders
    JOIN Services ON ServiceOrders.ServiceID = Services.ServiceID
    JOIN Guests   ON ServiceOrders.GuestID   = Guests.GuestID;
GO

-- Test thử với G001
SELECT * FROM GuestServiceDetails WHERE GuestID = 'G001'

go
CREATE VIEW RevenueByMonth AS
SELECT
    MONTH(Reservations.CheckInDate) AS Month,
    YEAR(Reservations.CheckInDate) AS Year,
    SUM(Payments.Amount) AS RoomRevenue,
    ISNULL((
        SELECT SUM(Services.Price)
        FROM ServiceOrders
        JOIN Services ON ServiceOrders.ServiceID = Services.ServiceID
        WHERE MONTH(ServiceOrders.OrderDate) = MONTH(Reservations.CheckInDate)
          AND YEAR(ServiceOrders.OrderDate) = YEAR(Reservations.CheckInDate)
    ), 0) AS ServiceRevenue,
    SUM(Payments.Amount) + ISNULL((
        SELECT SUM(Services.Price)
        FROM ServiceOrders
        JOIN Services ON ServiceOrders.ServiceID = Services.ServiceID
        WHERE MONTH(ServiceOrders.OrderDate) = MONTH(Reservations.CheckInDate)
          AND YEAR(ServiceOrders.OrderDate) = YEAR(Reservations.CheckInDate)
    ), 0) AS TotalRevenue
FROM
    Payments
    JOIN Reservations ON Payments.ReserID = Reservations.ReserID
GROUP BY
    YEAR(Reservations.CheckInDate),
    MONTH(Reservations.CheckInDate);
GO

SELECT * FROM RevenueByMonth ORDER BY Year, Month;

go
CREATE VIEW RoomOccupancyRate AS
SELECT
    Towers.TowerID,
    Towers.TowerName,
    COUNT(DISTINCT Rooms.RoomID) AS TotalRooms,
    COUNT(DISTINCT CASE 
        WHEN Reservations.PaymentStatus != 'Cancelled'
        AND GETDATE() BETWEEN Reservations.CheckInDate AND Reservations.CheckOutDate
        THEN Rooms.RoomID 
    END) AS OccupiedRooms,
    COUNT(DISTINCT Rooms.RoomID) - COUNT(DISTINCT CASE 
        WHEN Reservations.PaymentStatus != 'Cancelled'
        AND GETDATE() BETWEEN Reservations.CheckInDate AND Reservations.CheckOutDate
        THEN Rooms.RoomID 
    END) AS AvailableRooms,
    CAST(
        COUNT(DISTINCT CASE 
            WHEN Reservations.PaymentStatus != 'Cancelled'
            AND GETDATE() BETWEEN Reservations.CheckInDate AND Reservations.CheckOutDate
            THEN Rooms.RoomID 
        END) * 100.0 / COUNT(DISTINCT Rooms.RoomID) 
    AS DECIMAL(5,2)) AS OccupancyRate
FROM
    Towers
    JOIN Rooms ON Towers.TowerID = Rooms.TowerID
    LEFT JOIN Reservations ON Rooms.RoomID = Reservations.RoomID
GROUP BY
    Towers.TowerID,
    Towers.TowerName;
GO

SELECT * FROM RoomOccupancyRate;