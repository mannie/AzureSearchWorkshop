using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var output = new Dictionary<string, object>();

    dynamic data = await req.Content.ReadAsAsync<object>();
    
    var keys = new string[] {
         "RowKey", "Allergies", "ChiefComplaint", "FamilyHistory", "HistoryOfPresentIllness",
         "Informants", "MedicalHistory", "Medications", "Name", "PhysicalExamination", "Plan", 
         "SocialHistory", "HealthMaintainance", "LabData", "PertinentDiagnosticTests", 
         "ReviewOfSystems", "Assessment", "SurgicalHistory", "ProblemList", "Discussion" 
    };

    foreach (var key in keys) 
    {
        dynamic value = data[key];

        if (value != null && value != "") {
            if (key == "RowKey")
                output["id"] = value;
            else
                output[key] = value;
        }
    }

    return output.Count == 0
        ? req.CreateResponse(HttpStatusCode.BadRequest, "Unexpected body")
        : req.CreateResponse(HttpStatusCode.OK, output);
}
