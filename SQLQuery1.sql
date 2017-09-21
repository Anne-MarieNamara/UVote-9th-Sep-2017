CREATE PROC uspGetCampaigns
AS
SELECT CampaignID, RoleTitle, CampaignStart, CampaignEnd
FROM Campaign
WHERE CampaignStart > CAST (GETDATE() AS DATE)

 
 exec uspGetCampaigns
