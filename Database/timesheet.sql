-- ---------------------------------------------------------------------------
-- Sample database for the Timesheet application.
--
-- Creates the `timesheet` schema, every table and stored procedure the
-- application calls, and a small set of sample data.
--
-- WARNING: this script drops and recreates the `timesheet` database.
--
-- Usage:  mysql -u root -p < timesheet.sql
-- ---------------------------------------------------------------------------

DROP DATABASE IF EXISTS timesheet;
CREATE DATABASE timesheet DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE timesheet;

-- ---------------------------------------------------------------------------
-- Tables
-- ---------------------------------------------------------------------------

CREATE TABLE Employee (
    EmpId         INT          NOT NULL AUTO_INCREMENT,
    FirstName     VARCHAR(45)  NOT NULL,
    LastName      VARCHAR(45)  NOT NULL,
    SSN           CHAR(9)      NULL,                -- digits only, the form strips the dashes
    Email         VARCHAR(100) NULL,
    StreetAddress VARCHAR(100) NULL,
    City          VARCHAR(45)  NULL,
    State         CHAR(2)      NULL,
    Zip           CHAR(5)      NULL,
    Password      VARCHAR(45)  CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
    EmployeeType  VARCHAR(20)  NOT NULL DEFAULT 'Standard',  -- Standard, HR, Manager, Admin
    Department    VARCHAR(45)  NULL,
    -- 1 = employed, 0 = no longer employed. Deliberately not TINYINT(1): Connector/NET
    -- maps that to a boolean, and the application parses this column as an integer.
    Status        INT          NOT NULL DEFAULT 1,
    Title         VARCHAR(45)  NULL,
    PRIMARY KEY (EmpId)
) ENGINE = InnoDB;

CREATE TABLE Project (
    ProjectId          INT          NOT NULL AUTO_INCREMENT,
    ProjectName        VARCHAR(45)  NOT NULL,
    ProjectDescription VARCHAR(255) NULL,
    PRIMARY KEY (ProjectId)
) ENGINE = InnoDB;

CREATE TABLE Client (
    ClientId          INT          NOT NULL AUTO_INCREMENT,
    ClientName        VARCHAR(45)  NOT NULL,
    ClientDescription VARCHAR(255) NULL,
    Project_ProjectId INT          NOT NULL,
    PRIMARY KEY (ClientId),
    INDEX fk_Client_Project_idx (Project_ProjectId),
    CONSTRAINT fk_Client_Project
        FOREIGN KEY (Project_ProjectId) REFERENCES Project (ProjectId)
) ENGINE = InnoDB;

CREATE TABLE Task (
    TaskId                   INT          NOT NULL AUTO_INCREMENT,
    TaskName                 VARCHAR(45)  NOT NULL,
    TaskDescription          VARCHAR(255) NULL,
    Client_ClientId          INT          NOT NULL,
    Client_Project_ProjectId INT          NOT NULL,
    PRIMARY KEY (TaskId),
    INDEX fk_Task_Client_idx (Client_ClientId),
    INDEX fk_Task_Project_idx (Client_Project_ProjectId),
    CONSTRAINT fk_Task_Client
        FOREIGN KEY (Client_ClientId) REFERENCES Client (ClientId),
    CONSTRAINT fk_Task_Project
        FOREIGN KEY (Client_Project_ProjectId) REFERENCES Project (ProjectId)
) ENGINE = InnoDB;

CREATE TABLE Employee_Has_Project (
    Employee_EmpId    INT NOT NULL,
    Project_ProjectId INT NOT NULL,
    PRIMARY KEY (Employee_EmpId, Project_ProjectId),
    INDEX fk_Employee_Has_Project_Project_idx (Project_ProjectId),
    CONSTRAINT fk_Employee_Has_Project_Employee
        FOREIGN KEY (Employee_EmpId) REFERENCES Employee (EmpId) ON DELETE CASCADE,
    CONSTRAINT fk_Employee_Has_Project_Project
        FOREIGN KEY (Project_ProjectId) REFERENCES Project (ProjectId) ON DELETE CASCADE
) ENGINE = InnoDB;

CREATE TABLE Timesheet (
    TimesheetId       INT           NOT NULL AUTO_INCREMENT,
    Date              DATE          NOT NULL,
    Hours             DECIMAL(4, 2) NOT NULL,
    Employee_EmpId    INT           NOT NULL,
    Project_ProjectId INT           NOT NULL,
    Client_ClientId   INT           NOT NULL,
    Task_TaskId       INT           NOT NULL,
    PRIMARY KEY (TimesheetId),
    INDEX fk_Timesheet_Employee_idx (Employee_EmpId),
    INDEX fk_Timesheet_Project_idx (Project_ProjectId),
    INDEX fk_Timesheet_Client_idx (Client_ClientId),
    INDEX fk_Timesheet_Task_idx (Task_TaskId),
    CONSTRAINT fk_Timesheet_Employee
        FOREIGN KEY (Employee_EmpId) REFERENCES Employee (EmpId),
    CONSTRAINT fk_Timesheet_Project
        FOREIGN KEY (Project_ProjectId) REFERENCES Project (ProjectId),
    CONSTRAINT fk_Timesheet_Client
        FOREIGN KEY (Client_ClientId) REFERENCES Client (ClientId),
    CONSTRAINT fk_Timesheet_Task
        FOREIGN KEY (Task_TaskId) REFERENCES Task (TaskId)
) ENGINE = InnoDB;

-- ---------------------------------------------------------------------------
-- Stored procedures
-- ---------------------------------------------------------------------------

DELIMITER $$

-- ----- Employees -----------------------------------------------------------

CREATE PROCEDURE Auth_User (IN p_EmpId INT, IN p_Password VARCHAR(45))
BEGIN
    SELECT EmpId, FirstName, LastName, SSN, Email, StreetAddress, City, State, Zip,
           Password, EmployeeType, Department, Status, Title
    FROM Employee
    WHERE EmpId = p_EmpId
      AND Password = p_Password;
END$$

CREATE PROCEDURE Load_Employees ()
BEGIN
    SELECT EmpId, FirstName, LastName, SSN, Email, StreetAddress, City, State, Zip,
           Password, EmployeeType, Department, Status, Title
    FROM Employee
    ORDER BY EmpId;
END$$

CREATE PROCEDURE Add_Employee (
    IN p_FirstName     VARCHAR(45),
    IN p_LastName      VARCHAR(45),
    IN p_SSN           VARCHAR(9),
    IN p_Email         VARCHAR(100),
    IN p_StreetAddress VARCHAR(100),
    IN p_City          VARCHAR(45),
    IN p_State         VARCHAR(2),
    IN p_Zip           INT,
    IN p_Password      VARCHAR(45),
    IN p_EmployeeType  VARCHAR(20),
    IN p_Department    VARCHAR(45),
    IN p_Status        INT,
    IN p_Title         VARCHAR(45)
)
BEGIN
    INSERT INTO Employee (FirstName, LastName, SSN, Email, StreetAddress, City, State, Zip,
                          Password, EmployeeType, Department, Status, Title)
    VALUES (p_FirstName, p_LastName, p_SSN, p_Email, p_StreetAddress, p_City, p_State,
            LPAD(p_Zip, 5, '0'), p_Password, p_EmployeeType, p_Department, p_Status, p_Title);
END$$

CREATE PROCEDURE Update_Employee (
    IN p_EmpId         INT,
    IN p_FirstName     VARCHAR(45),
    IN p_LastName      VARCHAR(45),
    IN p_SSN           VARCHAR(9),
    IN p_Email         VARCHAR(100),
    IN p_StreetAddress VARCHAR(100),
    IN p_City          VARCHAR(45),
    IN p_State         VARCHAR(2),
    IN p_Zip           INT,
    IN p_Password      VARCHAR(45),
    IN p_EmployeeType  VARCHAR(20),
    IN p_Department    VARCHAR(45),
    IN p_Status        INT,
    IN p_Title         VARCHAR(45)
)
BEGIN
    UPDATE Employee
    SET FirstName     = p_FirstName,
        LastName      = p_LastName,
        SSN           = p_SSN,
        Email         = p_Email,
        StreetAddress = p_StreetAddress,
        City          = p_City,
        State         = p_State,
        Zip           = LPAD(p_Zip, 5, '0'),
        Password      = p_Password,
        EmployeeType  = p_EmployeeType,
        Department    = p_Department,
        Status        = p_Status,
        Title         = p_Title
    WHERE EmpId = p_EmpId;
END$$

-- Deletes an employee along with their timesheet entries and project assignments.
CREATE PROCEDURE Delete_Employee (IN p_EmpId INT)
BEGIN
    DELETE FROM Timesheet WHERE Employee_EmpId = p_EmpId;
    DELETE FROM Employee_Has_Project WHERE Employee_EmpId = p_EmpId;
    DELETE FROM Employee WHERE EmpId = p_EmpId;
END$$

-- ----- Projects ------------------------------------------------------------

CREATE PROCEDURE Load_Projects ()
BEGIN
    SELECT ProjectId, ProjectName, ProjectDescription
    FROM Project
    ORDER BY ProjectId;
END$$

CREATE PROCEDURE Add_Project (IN p_ProjectName VARCHAR(45), IN p_ProjectDescription VARCHAR(255))
BEGIN
    INSERT INTO Project (ProjectName, ProjectDescription)
    VALUES (p_ProjectName, p_ProjectDescription);
END$$

CREATE PROCEDURE Update_Project (
    IN p_ProjectId          INT,
    IN p_ProjectName        VARCHAR(45),
    IN p_ProjectDescription VARCHAR(255)
)
BEGIN
    UPDATE Project
    SET ProjectName        = p_ProjectName,
        ProjectDescription = p_ProjectDescription
    WHERE ProjectId = p_ProjectId;
END$$

-- Deletes a project along with anything still referencing it.
CREATE PROCEDURE Delete_Project (IN p_ProjectId INT)
BEGIN
    DELETE FROM Timesheet WHERE Project_ProjectId = p_ProjectId;
    DELETE FROM Task WHERE Client_Project_ProjectId = p_ProjectId;
    DELETE FROM Client WHERE Project_ProjectId = p_ProjectId;
    DELETE FROM Employee_Has_Project WHERE Project_ProjectId = p_ProjectId;
    DELETE FROM Project WHERE ProjectId = p_ProjectId;
END$$

-- ----- Project employees ---------------------------------------------------

-- The projects a given employee is assigned to.
CREATE PROCEDURE Load_Employee_Projects (IN p_EmpId INT)
BEGIN
    SELECT p.ProjectId, p.ProjectName, p.ProjectDescription
    FROM Project p
    INNER JOIN Employee_Has_Project ehp ON ehp.Project_ProjectId = p.ProjectId
    WHERE ehp.Employee_EmpId = p_EmpId
    ORDER BY p.ProjectId;
END$$

-- The employees assigned to a given project.
CREATE PROCEDURE Load_Project_Employees (IN p_ProjectId INT)
BEGIN
    SELECT e.EmpId, e.FirstName, e.LastName
    FROM Employee e
    INNER JOIN Employee_Has_Project ehp ON ehp.Employee_EmpId = e.EmpId
    WHERE ehp.Project_ProjectId = p_ProjectId
    ORDER BY e.LastName, e.FirstName;
END$$

-- The current employees that are not yet assigned to a given project.
CREATE PROCEDURE Load_Non_Project_Employees (IN p_ProjectId INT)
BEGIN
    SELECT e.EmpId, e.FirstName, e.LastName
    FROM Employee e
    WHERE e.Status = 1
      AND NOT EXISTS (SELECT 1
                      FROM Employee_Has_Project ehp
                      WHERE ehp.Employee_EmpId = e.EmpId
                        AND ehp.Project_ProjectId = p_ProjectId)
    ORDER BY e.LastName, e.FirstName;
END$$

CREATE PROCEDURE Add_Project_Employee (IN p_EmpId INT, IN p_ProjectId INT)
BEGIN
    INSERT IGNORE INTO Employee_Has_Project (Employee_EmpId, Project_ProjectId)
    VALUES (p_EmpId, p_ProjectId);
END$$

CREATE PROCEDURE Delete_Project_Employee (IN p_EmpId INT, IN p_ProjectId INT)
BEGIN
    DELETE FROM Employee_Has_Project
    WHERE Employee_EmpId = p_EmpId
      AND Project_ProjectId = p_ProjectId;
END$$

-- ----- Clients -------------------------------------------------------------

CREATE PROCEDURE Load_Clients ()
BEGIN
    SELECT c.ClientId, c.ClientName, c.ClientDescription, p.ProjectId, p.ProjectName
    FROM Client c
    INNER JOIN Project p ON p.ProjectId = c.Project_ProjectId
    ORDER BY c.ClientId;
END$$

CREATE PROCEDURE Add_Client (
    IN p_ClientName        VARCHAR(45),
    IN p_ClientDescription VARCHAR(255),
    IN p_ProjectId         INT
)
BEGIN
    INSERT INTO Client (ClientName, ClientDescription, Project_ProjectId)
    VALUES (p_ClientName, p_ClientDescription, p_ProjectId);
END$$

-- Moving a client to another project takes its tasks and timesheet entries with it.
CREATE PROCEDURE Update_Client (
    IN p_ClientId          INT,
    IN p_ClientName        VARCHAR(45),
    IN p_ClientDescription VARCHAR(255),
    IN p_ProjectId         INT
)
BEGIN
    UPDATE Client
    SET ClientName        = p_ClientName,
        ClientDescription = p_ClientDescription,
        Project_ProjectId = p_ProjectId
    WHERE ClientId = p_ClientId;

    UPDATE Task SET Client_Project_ProjectId = p_ProjectId WHERE Client_ClientId = p_ClientId;
    UPDATE Timesheet SET Project_ProjectId = p_ProjectId WHERE Client_ClientId = p_ClientId;
END$$

-- Deletes a client along with anything still referencing it.
CREATE PROCEDURE Delete_Client (IN p_ClientId INT)
BEGIN
    DELETE FROM Timesheet WHERE Client_ClientId = p_ClientId;
    DELETE FROM Task WHERE Client_ClientId = p_ClientId;
    DELETE FROM Client WHERE ClientId = p_ClientId;
END$$

-- ----- Tasks ---------------------------------------------------------------

CREATE PROCEDURE Load_Tasks ()
BEGIN
    SELECT t.TaskId, t.TaskName, t.TaskDescription,
           c.ClientId, c.ClientName, p.ProjectId, p.ProjectName
    FROM Task t
    INNER JOIN Client c ON c.ClientId = t.Client_ClientId
    INNER JOIN Project p ON p.ProjectId = t.Client_Project_ProjectId
    ORDER BY t.TaskId;
END$$

CREATE PROCEDURE Add_Task (
    IN p_TaskName        VARCHAR(45),
    IN p_TaskDescription VARCHAR(255),
    IN p_ProjectId       INT,
    IN p_ClientId        INT
)
BEGIN
    INSERT INTO Task (TaskName, TaskDescription, Client_ClientId, Client_Project_ProjectId)
    VALUES (p_TaskName, p_TaskDescription, p_ClientId, p_ProjectId);
END$$

-- Moving a task to another client or project takes its timesheet entries with it.
CREATE PROCEDURE Update_Task (
    IN p_TaskId          INT,
    IN p_TaskName        VARCHAR(45),
    IN p_TaskDescription VARCHAR(255),
    IN p_ProjectId       INT,
    IN p_ClientId        INT
)
BEGIN
    UPDATE Task
    SET TaskName                 = p_TaskName,
        TaskDescription          = p_TaskDescription,
        Client_ClientId          = p_ClientId,
        Client_Project_ProjectId = p_ProjectId
    WHERE TaskId = p_TaskId;

    UPDATE Timesheet
    SET Client_ClientId   = p_ClientId,
        Project_ProjectId = p_ProjectId
    WHERE Task_TaskId = p_TaskId;
END$$

-- Deletes a task along with its timesheet entries.
CREATE PROCEDURE Delete_Task (IN p_TaskId INT)
BEGIN
    DELETE FROM Timesheet WHERE Task_TaskId = p_TaskId;
    DELETE FROM Task WHERE TaskId = p_TaskId;
END$$

-- ----- Timesheet -----------------------------------------------------------

CREATE PROCEDURE Load_Timesheet (IN p_EmpId INT)
BEGIN
    SELECT ts.TimesheetId, ts.Date, ts.Hours, p.ProjectName, c.ClientName, t.TaskName
    FROM Timesheet ts
    INNER JOIN Project p ON p.ProjectId = ts.Project_ProjectId
    INNER JOIN Client c ON c.ClientId = ts.Client_ClientId
    INNER JOIN Task t ON t.TaskId = ts.Task_TaskId
    WHERE ts.Employee_EmpId = p_EmpId
    ORDER BY ts.Date DESC, ts.TimesheetId DESC;
END$$

CREATE PROCEDURE Add_Timesheet (
    IN p_Date      DATE,
    IN p_Hours     DECIMAL(4, 2),
    IN p_ProjectId INT,
    IN p_ClientId  INT,
    IN p_TaskId    INT,
    IN p_EmpId     INT
)
BEGIN
    INSERT INTO Timesheet (Date, Hours, Employee_EmpId, Project_ProjectId, Client_ClientId, Task_TaskId)
    VALUES (p_Date, p_Hours, p_EmpId, p_ProjectId, p_ClientId, p_TaskId);
END$$

CREATE PROCEDURE Delete_Timesheet (IN p_TimesheetId INT)
BEGIN
    DELETE FROM Timesheet WHERE TimesheetId = p_TimesheetId;
END$$

DELIMITER ;

-- ---------------------------------------------------------------------------
-- Sample data
--
-- Log in with an Employee ID and password from the table below, for example
-- 1 / admin123. Employee 6 is marked as no longer employed and cannot log in.
-- ---------------------------------------------------------------------------

INSERT INTO Employee (EmpId, FirstName, LastName, SSN, Email, StreetAddress, City, State, Zip,
                      Password, EmployeeType, Department, Status, Title)
VALUES
    (1, 'Dana',   'Whitfield', '900010001', 'dana.whitfield@example.com', '412 Maple Street',    'Columbus',  'OH', '43215', 'admin123',   'Admin',    'IT',          1, 'IT Director'),
    (2, 'Marcus', 'Bell',      '900010002', 'marcus.bell@example.com',    '87 Harbor Avenue',    'Cleveland', 'OH', '44113', 'manager123', 'Manager',  'Development', 1, 'Team Lead'),
    (3, 'Priya',  'Nair',      '900010003', 'priya.nair@example.com',     '1550 Linden Court',   'Dublin',    'OH', '43017', 'hr123',      'HR',       'HR',          1, 'HR Generalist'),
    (4, 'Tom',    'Alvarez',   '900010004', 'tom.alvarez@example.com',    '23 Juniper Lane',     'Boston',    'MA', '02134', 'tom123',     'Standard', 'Development', 1, 'Developer'),
    (5, 'Jenna',  'Kowalski',  '900010005', 'jenna.kowalski@example.com', '9 Birchwood Drive',   'Akron',     'OH', '44308', 'jenna123',   'Standard', 'QA',          1, 'QA Analyst'),
    (6, 'Sam',    'Otieno',    '900010006', 'sam.otieno@example.com',     '640 Prospect Road',   'Toledo',    'OH', '43604', 'sam123',     'Standard', 'Design',      0, 'Designer');

INSERT INTO Project (ProjectId, ProjectName, ProjectDescription)
VALUES
    (1, 'Website Redesign', 'Redesign and relaunch of client marketing websites.'),
    (2, 'Mobile App',       'Native mobile applications for client customers.'),
    (3, 'Internal Tools',   'Tooling and infrastructure used inside the company.');

INSERT INTO Client (ClientId, ClientName, ClientDescription, Project_ProjectId)
VALUES
    (1, 'Acme Corp',       'Manufacturing company refreshing its public site.', 1),
    (2, 'Globex',          'Logistics firm consolidating three regional sites.', 1),
    (3, 'Initech',         'Software vendor building a customer portal app.',    2),
    (4, 'Umbrella Health', 'Clinic network building an appointment app.',        2),
    (5, 'In-House',        'Work done for our own teams.',                       3);

INSERT INTO Task (TaskId, TaskName, TaskDescription, Client_ClientId, Client_Project_ProjectId)
VALUES
    (1,  'Wireframes',               'Page layouts and navigation mockups.',           1, 1),
    (2,  'Frontend Development',     'Build out the approved page templates.',         1, 1),
    (3,  'Content Migration',        'Move existing content into the new site.',       2, 1),
    (4,  'SEO Audit',                'Review redirects, metadata, and page speed.',    2, 1),
    (5,  'API Design',               'Define the endpoints the app will consume.',     3, 2),
    (6,  'iOS Build',                'Implement the iOS client.',                      3, 2),
    (7,  'QA Testing',               'Manual and automated test passes.',              4, 2),
    (8,  'Requirements Gathering',   'Stakeholder interviews and feature list.',       4, 2),
    (9,  'Build Server Maintenance', 'Keep the build and deploy pipeline healthy.',    5, 3),
    (10, 'Reporting Dashboard',      'Internal dashboard for project hours.',          5, 3);

INSERT INTO Employee_Has_Project (Employee_EmpId, Project_ProjectId)
VALUES
    (1, 1), (1, 2), (1, 3),
    (2, 1), (2, 2),
    (3, 3),
    (4, 1), (4, 3),
    (5, 2),
    (6, 1);

-- Timesheet entries are dated relative to today so the sample data always looks recent.
-- The client and project are taken from the task so every entry is consistent.
INSERT INTO Timesheet (Date, Hours, Employee_EmpId, Project_ProjectId, Client_ClientId, Task_TaskId)
SELECT CURDATE() - INTERVAL s.DaysAgo DAY, s.Hours, s.EmpId,
       t.Client_Project_ProjectId, t.Client_ClientId, t.TaskId
FROM (
              SELECT 1 AS DaysAgo, 2.50 AS Hours, 1 AS EmpId, 9 AS TaskId
    UNION ALL SELECT 1,  4.00, 1, 10
    UNION ALL SELECT 2,  1.50, 1, 5
    UNION ALL SELECT 3,  6.00, 1, 9
    UNION ALL SELECT 6,  3.25, 1, 2
    UNION ALL SELECT 8,  2.00, 1, 10

    UNION ALL SELECT 1,  5.00, 2, 5
    UNION ALL SELECT 1,  3.00, 2, 1
    UNION ALL SELECT 2,  8.00, 2, 6
    UNION ALL SELECT 3,  4.50, 2, 8
    UNION ALL SELECT 6,  2.75, 2, 3
    UNION ALL SELECT 7,  7.00, 2, 6

    UNION ALL SELECT 1,  3.00, 3, 10
    UNION ALL SELECT 4,  1.25, 3, 10
    UNION ALL SELECT 9,  2.00, 3, 9

    UNION ALL SELECT 1,  8.00, 4, 2
    UNION ALL SELECT 2,  6.50, 4, 2
    UNION ALL SELECT 2,  1.50, 4, 9
    UNION ALL SELECT 3,  7.75, 4, 3
    UNION ALL SELECT 6,  4.00, 4, 4
    UNION ALL SELECT 7,  8.00, 4, 2
    UNION ALL SELECT 8,  5.25, 4, 10

    UNION ALL SELECT 1,  7.50, 5, 7
    UNION ALL SELECT 2,  8.00, 5, 7
    UNION ALL SELECT 3,  2.00, 5, 8
    UNION ALL SELECT 6,  6.00, 5, 6
    UNION ALL SELECT 7,  4.25, 5, 5

    UNION ALL SELECT 40, 8.00, 6, 1
    UNION ALL SELECT 41, 6.50, 6, 1
    UNION ALL SELECT 42, 3.00, 6, 4
) s
INNER JOIN Task t ON t.TaskId = s.TaskId
ORDER BY s.DaysAgo DESC, s.EmpId;
