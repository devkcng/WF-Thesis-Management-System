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
