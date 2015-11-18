using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitchellClaimWSClient.MitchellClaimWSReference;

namespace MitchellClaimWSClient
{
    class Program
    {
        static string strCreateClaimXml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                            <cla:MitchellClaim xmlns:cla=""http://www.mitchell.com/examples/claim"">
                              <cla:ClaimNumber>1</cla:ClaimNumber>
                              <cla:ClaimantFirstName>George</cla:ClaimantFirstName>
                              <cla:ClaimantLastName>Washington</cla:ClaimantLastName>
                              <cla:Status>OPEN</cla:Status>
                              <cla:LossDate>2014-07-09T17:19:13.631-07:00</cla:LossDate>
                              <cla:LossInfo>
                                <cla:CauseOfLoss>Collision</cla:CauseOfLoss>
                                <cla:ReportedDate>2014-07-10T17:19:13.676-07:00</cla:ReportedDate>
                                <cla:LossDescription>Crashed into an apple tree.</cla:LossDescription>
                              </cla:LossInfo>
                              <cla:AssignedAdjusterID>12345</cla:AssignedAdjusterID>
                              <cla:Vehicles>
                                <cla:VehicleDetails>
                                  <cla:ModelYear>2015</cla:ModelYear>
                                  <cla:MakeDescription>Ford</cla:MakeDescription>
                                  <cla:ModelDescription>Mustang</cla:ModelDescription>
                                  <cla:EngineDescription>EcoBoost</cla:EngineDescription>
                                  <cla:ExteriorColor>Deep Impact Blue</cla:ExteriorColor>
                                  <cla:Vin>1M8GDM9AXKP042788</cla:Vin>
                                  <cla:LicPlate>NO1PRES</cla:LicPlate>
                                  <cla:LicPlateState>VA</cla:LicPlateState>
                                  <cla:LicPlateExpDate>2015-03-10-07:00</cla:LicPlateExpDate>
                                  <cla:DamageDescription>Front end smashed in. Apple dents in roof.</cla:DamageDescription>
                                  <cla:Mileage>1776</cla:Mileage>
                                </cla:VehicleDetails>
                              </cla:Vehicles>
                            </cla:MitchellClaim>";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Mitchell Claim WS's Client: ");
                // Creating the reference
                ClaimServiceClient ClaimWSClient = new ClaimServiceClient();
                Console.WriteLine("Adding new claim with the following details:");
                Console.WriteLine(strCreateClaimXml);
                Console.WriteLine("Please wait while Processing your request...");
                // Creating a new claim
                Console.WriteLine(ClaimWSClient.CreateClaim(strCreateClaimXml)? "Claim added successfully": "Error adding claim");
                Console.WriteLine("----------");
                Console.WriteLine("Getting this claim from backing store with claim number ");
                Console.WriteLine(ClaimWSClient.GetClaimByClaimNumber("1").claimNumberField);
                Console.WriteLine("----------");
                Console.WriteLine("Getting list of claims falling between dates 2014-07-09T17:19:13.631-07:00 and 2015-07-09T17:19:13.631-07:00 ");
                Console.WriteLine(ClaimWSClient.GetClaimsBetweenDates(Convert.ToDateTime("2014-07-09T17:19:13.631-07:00"), Convert.ToDateTime("2015-07-09T17:19:13.631-07:00")).Length + " Claims Found");
            }
            catch
            {
                Console.WriteLine(" Error in getting data from the Claim Service");
            }
        }
    }
}
