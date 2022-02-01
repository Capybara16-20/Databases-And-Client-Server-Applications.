using System;
using System.Collections.Generic;
using Entities;
using Storage;

namespace Actions
{
    public class BusinessLogic
    {
        private const string connection = @"Data Source=DESKTOP-UM6EJNQ\SQLEXPRESS;Initial Catalog="
            + "Студия тату" + ";Integrated Security=True";

        private readonly SketchDAOdb sketch = new SketchDAOdb(connection);
        private readonly ServiceRecordDAOdb serviceRecord = new ServiceRecordDAOdb(connection);
        private readonly SessionRecordDAOdb sessionRecord = new SessionRecordDAOdb(connection);
        private readonly StyleDAOdb style = new StyleDAOdb(connection);
        private readonly SizeDAOdb size = new SizeDAOdb(connection);
        private readonly MasterDAOdb master = new MasterDAOdb(connection);
        private readonly ClientDAOdb client = new ClientDAOdb(connection);
        private readonly WorkTypeDAOdb workType = new WorkTypeDAOdb(connection);
        private readonly ServiceTypeDAOdb serviceType = new ServiceTypeDAOdb(connection);

        public List<Sketch> GetSketches()
        {
            return sketch.GetSketches();
        }

        public void AddSketch(Style style, Size size)
        {
            sketch.AddSketch(style.ID, size.ID);
        }

        public void EditSketch(int id, Style style, Size size)
        {
            sketch.EditSketch(id, style.ID, size.ID);
        }

        public void DeleteSketch(int id, out string errorMessage)
        {
            sketch.DeleteSketch(id, out errorMessage);
        }

        public List<SessionRecord> GetSessionRecords()
        {
            return sessionRecord.GetRecords();
        }

        public void AddSessionRecord(Master master, Client client, Sketch sketch, 
            WorkType workType, DateTime dateTime)
        {
            sessionRecord.AddRecord(master.ID, client.ID, (int)sketch.ID, workType.ID, dateTime);
        }

        public void EditSessionRecord(int id, Master master, Client client, Sketch sketch, 
            WorkType workType, DateTime dateTime)
        {
            sessionRecord.EditRecord(id, master.ID, client.ID, (int)sketch.ID, workType.ID, dateTime);
        }

        public void DeleteSessionRecord(int id)
        {
            sessionRecord.DeleteRecord(id);
        }

        public List<ServiceRecord> GetServiceRecords()
        {
            return serviceRecord.GetRecords();
        }

        public void AddServiceRecord(Master master, Client client, ServiceType serviceType, DateTime dateTime)
        {
            serviceRecord.AddRecord(master.ID, client.ID, serviceType.ID, dateTime);
        }

        public void EditServiceRecord(int id, Master master, Client client, ServiceType serviceType, DateTime dateTime)
        {
            serviceRecord.EditRecord(id, master.ID, client.ID, serviceType.ID, dateTime);
        }

        public void DeleteServiceRecord(int id)
        {
            serviceRecord.DeleteRecord(id);
        }

        public List<Style> GetStyles()
        {
            return style.GetStyles();
        }

        public List<Size> GetSizes()
        {
            return size.GetSizes();
        }

        public List<Master> GetMasters()
        {
            return master.GetMasters();
        }

        public List<Client> GetClients()
        {
            return client.GetClients();
        }

        public List<WorkType> GetWorkTypes()
        {
            return workType.GetTypes();
        }

        public List<ServiceType> GetServiceTypes()
        {
            return serviceType.GetTypes();
        }
    }
}
