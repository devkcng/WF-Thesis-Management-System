-- Creating the Student table
CREATE TABLE Student (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(50),
    student_age INT,
    student_grade VARCHAR(10)
);

-- Inserting data into Student table
INSERT INTO Student (student_id, student_name, student_age, student_grade) 
VALUES 
(1, 'John Smith', 17, '12th'),
(2, 'Emily Johnson', 16, '11th'),
(3, 'Michael Williams', 18, '12th'),
(4, 'Sophia Brown', 17, '12th'),
(5, 'Emma Jones', 16, '11th');

-- Creating the StudentAccount table
CREATE TABLE StudentAccount (
    student_account_id INT PRIMARY KEY,
    student_id INT,
    student_username VARCHAR(50) UNIQUE,
    student_password VARCHAR(50),
    FOREIGN KEY (student_id) REFERENCES Student(student_id)
);

-- Inserting data into StudentAccount table
INSERT INTO StudentAccount (student_account_id, student_id, student_username, student_password) 
VALUES 
(1, 1, 'johnsmith123', 'password1'),
(2, 2, 'emilyj22', 'password2'),
(3, 3, 'michaelw98', 'password3'),
(4, 4, 'sophiabrown123', 'password4'),
(5, 5, 'emmaj', 'password5');

-- Creating the Teacher table
CREATE TABLE Teacher (
    teacher_id INT PRIMARY KEY,
    teacher_name VARCHAR(50),
    subject_taught VARCHAR(50)
);

-- Inserting data into Teacher table
INSERT INTO Teacher (teacher_id, teacher_name, subject_taught) 
VALUES 
(1, 'Mr. Anderson', 'Mathematics'),
(2, 'Ms. Davis', 'Science'),
(3, 'Mrs. Wilson', 'English');

-- Creating the TeacherAccount table
CREATE TABLE TeacherAccount (
    teacher_account_id INT PRIMARY KEY,
    teacher_id INT,
    teacher_username VARCHAR(50) UNIQUE,
    teacher_password VARCHAR(50),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id)
);

-- Inserting data into TeacherAccount table
INSERT INTO TeacherAccount (teacher_account_id, teacher_id, teacher_username, teacher_password) 
VALUES 
(1, 1, 'mr_anderson', 'teacherpass1'),
(2, 2, 'ms_davis', 'teacherpass2'),
(3, 3, 'mrs_wilson', 'teacherpass3');

-- Creating the Topics table
CREATE TABLE Topics (
    topic_id INT PRIMARY KEY,
    topic_name VARCHAR(100),
    topic_description TEXT
);

-- Inserting data into Topics table
INSERT INTO Topics (topic_id, topic_name, topic_description) 
VALUES 
(1, 'Algebra', 'Basic algebraic operations and equations'),
(2, 'Chemical Reactions', 'Chemical reactions and stoichiometry'),
(3, 'Shakespearean Literature', 'Works of William Shakespeare');

-- Creating the Student_Group table
CREATE TABLE Student_Group (
    group_id INT PRIMARY KEY,
    group_name VARCHAR(50),
    topic_id INT,
    student_id INT,
    FOREIGN KEY (topic_id) REFERENCES Topics(topic_id),
    FOREIGN KEY (student_id) REFERENCES Student(student_id),
    UNIQUE(group_name, topic_id, student_id)
);

-- Inserting data into Student_Group table
INSERT INTO Student_Group (group_id, group_name, topic_id, student_id) 
VALUES 
(1, 'Math Club', 1, 1),
(2, 'Chemistry Society', 2, 2),
(3, 'Literature Circle', 3, 4),
(4, 'Math Club', 1, 3),
(5, 'Chemistry Society', 2, 5);
