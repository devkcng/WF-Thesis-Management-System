-- Creating Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'ThesisManagement')
BEGIN
    CREATE DATABASE ThesisManagement;
END
GO

-- Using the newly created database
USE ThesisManagement;
GO


-- Creating the Teachers table
CREATE TABLE Teachers (
    teacher_id INT PRIMARY KEY,
    teacher_name VARCHAR(50) NOT NULL,
    teacher_age INT,
    teacher_email VARCHAR(255),
    subject_taught VARCHAR(50)
);

-- Creating the Topics table
CREATE TABLE Topics (
    topic_id INT PRIMARY KEY,
    topic_name VARCHAR(100),
    topic_description TEXT,
    topic_technology VARCHAR(100),
    topic_requirement TEXT,
    topic_category VARCHAR(100),
    max_members INT,
    teacher_id INT,
    FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id)
);


-- Creating the Student_Group table
CREATE TABLE StudentGroup (
    group_id INT PRIMARY KEY,
    group_name VARCHAR(50),
    topic_id INT,
    number_of_students INT,
    group_points FLOAT DEFAULT 0,
    FOREIGN KEY (topic_id) REFERENCES Topics(topic_id),
    UNIQUE(group_name, topic_id)
);

-- Creating the Students table
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(50) NOT NULL,
    student_age INT,
    student_email VARCHAR(255),
    student_grade VARCHAR(10),
    group_id INT,
    FOREIGN KEY (group_id) REFERENCES StudentGroup(group_id)
);

CREATE TABLE RegisterQueue (
    student_id INT PRIMARY KEY,
    group_id INT,
    topic_id INT,
    accepted BIT DEFAULT 0,
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (group_id) REFERENCES StudentGroup(group_id),
    FOREIGN KEY (topic_id) REFERENCES Topics(topic_id)
);

-- Creating Task table
CREATE TABLE Tasks (
    task_id INT PRIMARY KEY,
    task_name VARCHAR(100),
    task_description TEXT,
    open_day DATE,
    due_date DATE,
    submit_day DATE,
    group_id INT,
    FOREIGN KEY (group_id) REFERENCES StudentGroup(group_id)
);

-- Creating SubTask table
CREATE TABLE SubTasks (
    subtask_id INT PRIMARY KEY,
    subtask_name VARCHAR(100),
    subtask_description TEXT,
    open_day DATE,
    due_date DATE,
    submit_day DATE,
    student_id INT,
    task_id INT,
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (task_id) REFERENCES Tasks(task_id)
);

-- Creating the StudentAccount table
CREATE TABLE StudentAccount (
    student_username VARCHAR(50) PRIMARY KEY,
    student_password VARCHAR(50),
    student_id INT ,
    FOREIGN KEY (student_id) REFERENCES Students(student_id)
);

-- Creating the TeacherAccount table
CREATE TABLE TeacherAccount (
    teacher_username VARCHAR(50) PRIMARY KEY,
    teacher_password VARCHAR(50),
    teacher_id INT,
    FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id)
);

CREATE TABLE PointSheetRecord (
    id INT PRIMARY KEY,
    student_id INT,
    topic_id INT,
    point FLOAT,
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (topic_id) REFERENCES Topics(topic_id)
);

CREATE TABLE RejectList (
    list_id INT PRIMARY KEY,
    student_id INT,
    topic_id INT,
    reason TEXT,
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (topic_id) REFERENCES Topics(topic_id)
);

-- Inserting data into Teachers table
INSERT INTO Teachers (teacher_id, teacher_name, teacher_age, teacher_email, subject_taught) VALUES
(1811001, 'John Smith', 35, 'john.smith@example.com', 'Web Development'),
(1811002, 'Emily Johnson', 40, 'emily.johnson@example.com', 'Mobile App Development'),
(1811003, 'Michael Brown', 45, 'michael.brown@example.com', 'Database Management');

-- Inserting data into Topics table
INSERT INTO Topics (topic_id, topic_name, topic_description, topic_technology, topic_requirement, topic_category, max_members, teacher_id) VALUES
(123, 'Building a Responsive Website', 'Learn how to design and develop responsive websites using HTML, CSS, and JavaScript.', 'HTML, CSS, JavaScript', 'Basic understanding of web development concepts', 'Web Development', 5, 1811001),
(222, 'Creating a Cross-Platform Mobile App', 'Explore cross-platform mobile app development using frameworks like React Native or Flutter.', 'React Native, Flutter', 'Familiarity with JavaScript or Dart', 'Mobile App Development', 4, 1811002),
(333, 'Database Design and Management', 'Learn about database design principles and SQL for creating and managing databases.', 'SQL, Database Management Systems', 'Understanding of relational databases', 'Database Management', 3, 1811003);

-- Inserting data into StudentGroup table
-- INSERT INTO StudentGroup (group_id, group_name, topic_id, number_of_students, group_points) VALUES
-- (1, 'Web Development Team', 123, 4, 0),
-- (2, 'Mobile App Development Team', 222, 4, 0),
-- (3, 'Database Management Team', 333, 3, 0);

-- Inserting data into Students table
INSERT INTO Students (student_id, student_name, student_age, student_email, student_grade, group_id) VALUES
(2211001, 'Alice Green', 20, 'alice.green@example.com', 'Senior', NULL),
(2211002, 'Bob White', 22, 'bob.white@example.com', 'Junior', NULL),
(2211003, 'Charlie Black', 21, 'charlie.black@example.com', 'Senior', NULL),
(2211004, 'David Brown', 19, 'david.brown@example.com', 'Sophomore', NULL),
(2211005, 'Emma Grey', 23, 'emma.grey@example.com', 'Senior', NULL),
(2211006, 'Frank Blue', 24, 'frank.blue@example.com', 'Graduate', NULL),
(2211007, 'Grace Red', 20, 'grace.red@example.com', 'Junior', NULL),
(2211008, 'Hannah Orange', 21, 'hannah.orange@example.com', 'Senior', NULL),
(2211009, 'Isaac Yellow', 22, 'isaac.yellow@example.com', 'Junior', NULL),
(2211010, 'Jessica Violet', 20, 'jessica.violet@example.com', 'Senior', NULL),
(2211011, 'Kevin Indigo', 24, 'kevin.indigo@example.com', 'Graduate', NULL),
(2211012, 'Lily Cyan', 23, 'lily.cyan@example.com', 'Senior', NULL);

-- Inserting data into StudentAccount table
INSERT INTO StudentAccount (student_id, student_username, student_password) VALUES
(2211001, 'student', '123'),
(2211002, 'student2', '456'),
(2211003, 'student3', '123'),
(2211004, 'student4', '123'),
(2211005, 'student5', '123'),
(2211006, 'frankblue', 'password789'),
(2211007, 'gracered', 'password123'),
(2211008, 'hannahorange', 'password456'),
(2211009, 'isaacyellow', 'password789'),
(2211010, 'jessicaviolet', 'password123'),
(2211011, 'kevinindigo', 'password456'),
(2211012, 'lilycyan', 'password789');

-- Inserting data into TeacherAccount table
INSERT INTO TeacherAccount (teacher_id, teacher_username, teacher_password) VALUES
(1811001, 'teacher', '123'),
(1811002, 'emilyjohnson', 'password456'),
(1811003, 'michaelbrown', 'password789');

-- Corrected example data for RegisterQueue table
-- INSERT INTO RegisterQueue (student_id, group_id, topic_id, accepted) VALUES
-- (2211006, 2, 222, 0), -- Frank Blue registered but not yet accepted into Mobile App Development Team
-- (2211009, 2, 222, 1), -- Isaac Yellow registered and accepted into Mobile App Development Team
-- (2211010, 3, 333, 1); -- Jessica Violet registered and accepted into Database Management Team
