namespace Web.Models.Patient
{
	public class PatientMainVM
	{
		public PatientMainVM()
		{
		}

		public PatientMainVM(string id)
		{
			PatientUuid = id;		
		}

		public string PatientUuid { get; set; }

		public string PatientInfoTabId { get { return "jq-patient-information-tab-id";  } }

		public string DiseaseTabId { get { return "jq-patient-disease-tab-id"; } }

	}
}
