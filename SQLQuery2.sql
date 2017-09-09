CREATE PROC uspInsertCandidate
@candidateId varchar(8),
@firstName varchar (50),
@lastName varchar (50),
@manifesto varchar(250),
@imageUrl varchar (100),
@previousHistory text,
@campaignId int,
@employeeId varchar (8)
AS
INSERT INTO Candidate VALUES (
@candidateId, @firstName, @lastName, @manifesto, @imageUrl, @previousHistory, @campaignId, @employeeId)
GO

