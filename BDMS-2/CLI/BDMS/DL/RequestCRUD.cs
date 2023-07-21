using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BDMS.BL;
using System.IO;
namespace BDMS.DL
{
    public class RequestCRUD
    {
        private static List<string> RequestBG = new List<string>();

        private static string path = "Request.txt";
        public static List<string> GetRequest()
        {
            return RequestBG;
        }
        public static void AddRequest(string BG)
        {
            RequestBG.Add(BG);
        }
        public static void DeleteRequest(string BG)
        {
            RequestBG.Remove(BG);
        }
        public static void CheckReq()
        {
            for (int i = 0; i < RequestBG.Count; i++)
            {
                if (PersonCRUD.SearchBG(RequestBG[i]))
                {
                    string ID = PersonCRUD.SearchBGPerson(RequestBG[i]);
                    DeleteRequest(RequestBG[i]);
                    PersonCRUD.DeletePersonToListByID(ID);
                    PersonCRUD.DeletePersonToEmployeeList(ID);
                }
            }
            UpdateRequestToFile();
        }
        public static bool LoadRequests()
        {
            StreamReader requestData = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = requestData.ReadLine()) != null)
                {
                    RequestBG.Add(record);
                }
                requestData.Close();
                return true;
            }
            return false;
        }
        public static void RequestToFile(string BG)
        {
            StreamWriter reqData = new StreamWriter(path, true);
            reqData.WriteLine(BG);
            reqData.Flush();
            reqData.Close();
        }
        public static void UpdateRequestToFile()
        {
            StreamWriter reqData = new StreamWriter(path);
            for (int i = 0; i < RequestBG.Count; i++)
            {
                reqData.WriteLine(RequestBG[i]);
            }
            reqData.Flush();
            reqData.Close();
        }
        public static List<Request> CountRequest()
        {
            List<Request> requests = RequestBG.GroupBy(x => x)
                      .Select(g => new Request { Value = g.Key, Count = g.Count() })
                      .OrderByDescending(x => x.Count)
                      .ToList();
            return requests;
        }
    }
}
