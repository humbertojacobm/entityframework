select * from Entity

--insert into Entity (Name) values
--('value 1'),
--('value 2'),
--('value 3'),
--('value 4')

create table dbo.Student(
	ID int identity not null,
	LastName varchar(50),
	FirstMidName varchar(50),
	EnrollmentDate date,
	constraint PK_Student primary key(ID)
)

create table dbo.Course(
	CourseID int identity not null,
	Title varchar(50),
	Credits int,
	constraint PK_Course primary key(CourseID)
)

create table dbo.Enrollment(
	EnrollmentID int identity not null,
	CourseID int,
	StudentID int,
	Grade int,
	constraint PK_Enrollment primary key(EnrollmentID),
	constraint FK_Enrollment_Course foreign key(CourseID) references dbo.Course(CourseID),
	constraint FK_Enrollment_Student foreign key(StudentID) references dbo.Student(ID),
)

/*

drop table dbo.Enrollment
drop table dbo.Course
drop table dbo.Student

*/

/*
insert into Student(LastName, FirstMidName, EnrollmentDate) values
('Gamarra','Vanessa','06/30/2021'),
('Gamarra','Emmy','06/30/2021'),
('Gamarra','Wendy','06/30/2021'),
('Serrano','Javier','06/30/2021'),
('Gonsalez','Adrian','06/30/2021')

insert into Course(Title, Credits) values
('math','5'),
('Phisics','4'),
('Computing Science','4'),
('Database','3')

insert into Enrollment(CourseID, StudentID, Grade) values
(1,1,1),
(1,2,1),
(2,2,1),
(2,3,2),
(3,3,2),
(3,4,2)

*/

select * from Student
select * from Course
select * from Enrollment

