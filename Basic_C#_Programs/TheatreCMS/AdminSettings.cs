        public BugReportTab BugReport { get; set; }

        [JsonIgnore]
        public static string filepath = HttpContext.Current.Server.MapPath("~/AdminSettings.json");

        /// <summary>This method collects information from the Json file.</summary>
        /// <returns>A deserialized AdminSettings object variable</returns>
        public static AdminSettings GetCurrentSettings()
        {
            string result = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                result = r.ReadToEnd();
            }
            AdminSettings currentSettings = JsonConvert.DeserializeObject<AdminSettings>(result);
            return currentSettings;
        }

        /// <summary> This method takes in a string (a serialized reperesentation of an AdminSettings Object) and writes it to Json file.</summary>
        /// <param name="SerializedAdminObject">A serialized AdminSettings object</param>
        /// <return>There is no return for this method</return>
        public static void SetAdminSettings(string SerializedAdminObject)
        {
            using (StreamWriter r = new StreamWriter(filepath))
            {
                r.Write(SerializedAdminObject);
            }
        }

        /// <summary>This method takes in an AdminObject, converts it to a serialzied string, and writes it to Json file.</summary>
        /// <param name="AdminObject">A (non-serialized) AdminSettings object</param>
        /// <return>There is no return for this method</return>
        public static void SetAdminSettings(AdminSettings AdminObject)
        {
            string SerializedAdminObject = JsonConvert.SerializeObject(AdminObject);
            SetAdminSettings(SerializedAdminObject);
        }
    }
