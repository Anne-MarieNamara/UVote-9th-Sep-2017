CREATE PROC uspInsertCampaign
@roleTitle varchar (50),
@roleDetails varchar (50),
@officeTerm varchar (50),
@campaignStart DATE,
@CampaignEnd DATE,
@EmployeeId varchar (8)
AS
INSERT INTO Campaign VALUES (
@roleTitle, @roleDetails, @officeTerm, @campaignStart, @campaignEnd, @employeeId
)