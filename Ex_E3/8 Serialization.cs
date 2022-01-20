using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    //Serializable attribute 붙여줘야함

    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            //FileStream이 Stream을 상속받은 클래스이므로 그냥 Stream 써도 됨 
            BinaryFormatter serializer = new BinaryFormatter();
            //

            NameCard nc = new NameCard();
            nc.Name = "박상현";
            nc.Phone = "010-123-4567";
            nc.Age = 33;

            serializer.Serialize(ws, nc);
            //ws filestream에다가 nc obj를 seralize에서 저장해라
            ws.Close();


            //역직렬화
            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();


            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);

            //역직렬화는 obj를 return하니까, 원래형으로 unboxing해줘야함
            rs.Close();

            Console.WriteLine("Name:  {0}", nc2.Name);
            Console.WriteLine("Phone: {0}", nc2.Phone);
            Console.WriteLine("Age:   {0}", nc2.Age);
        }
    }
}
