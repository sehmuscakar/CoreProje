using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {

        IWriterMessageDal writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            this.writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return writerMessageDal.GetbyFilter(x => x.Receiver == p); //amaç gelen mesajları almak 
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return writerMessageDal.GetbyFilter(x => x.Sender == p);//amaç gelen mesajları almak 
        }

        public void TAdd(WriterMessage t)
        {
            writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            writerMessageDal.Delete(t);
        }

        public WriterMessage TGetByID(int id)
        {
            return writerMessageDal.GetByID(id);//id den gelen verileri buraya getir 
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

   
        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
