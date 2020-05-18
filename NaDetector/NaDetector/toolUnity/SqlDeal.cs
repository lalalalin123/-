using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using PetDetector.classUnity;
using NaDetector.classUnity;
using System.Windows.Forms;


namespace PetDetector
{
    class SqlDeal
    {

        public static bool checkNumberExist(string hospitalNumber)
        {
            string sql = "select * from patient where hospitalnumber = '" + hospitalNumber + "'";
            try
            {
                using (MySqlDataReader reader = SQLHelper.ExecuteReader(sql, CommandType.Text, null))
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool ifChecked(string hospitalnumber)
        {
            try
            {
                string sql = "select * from patient where hospitalnumber = ?hospitalnumber and ifchecked = true";
                MySqlParameter pas = new MySqlParameter("?hospitalnumber", MySqlDbType.Int32);
                pas.Value = int.Parse(hospitalnumber);
                MySqlDataReader reader = SQLHelper.ExecuteReader(sql, CommandType.Text, pas);
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }               
            }
            catch
            {
                return false;
            }
        }

        public static bool saveData(Patient p)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("insert into patient (name,age,sex,hospitalnumber,category,bednumber,time,ifchecked,remark) values(?name,?age,?sex,?hospitalnumber,?category,?bednumber,?time,?ifchecked,?remark)");
                MySqlParameter[] pas = {
                    new MySqlParameter ("?name",MySqlDbType.VarChar),
                    new MySqlParameter ("?age",MySqlDbType.Int32 ),
                    new MySqlParameter ("?sex",MySqlDbType.VarChar),
                    new MySqlParameter ("?hospitalnumber",MySqlDbType.VarChar),
                    new MySqlParameter ("?category",MySqlDbType.VarChar),
                    new MySqlParameter ("?bednumber",MySqlDbType.VarChar),
                    new MySqlParameter ("?time",MySqlDbType.DateTime),
                    new MySqlParameter ("?ifchecked",p.ifChecked),
                    new MySqlParameter ("?remark",MySqlDbType.VarChar),
                };
                pas[0].Value = p.name;
                pas[1].Value = p.age;
                pas[2].Value = p.sex;
                pas[3].Value = p.hostipalNumber;
                pas[4].Value = p.cateGory;
                pas[5].Value = p.bedNumber;
                pas[6].Value = p.dateTime;
                pas[8].Value = p.remark;
                SQLHelper.ExecuteNonQuery(sql.ToString(), CommandType.Text, pas);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateData(Patient p)
        {
            try
            {
                string sql = "update patient set time = ?time, picturepath = ?picturepath, receivedata = ?receivedata, sequence = ?sequence, coordinate = ?coordinate, ifchecked = ?ifchecked, jingshi = ?jingshi ,remark = ?remark where hospitalnumber = ?hospitalnumber";
                MySqlParameter[] pas =
                {
                    new MySqlParameter ("?time",MySqlDbType.DateTime),
                    new MySqlParameter ("?picturepath",MySqlDbType.String),
                    new MySqlParameter ("?receivedata",MySqlDbType.Blob),
                    new MySqlParameter ("?sequence",MySqlDbType.Blob),
                    new MySqlParameter ("?coordinate",MySqlDbType.Blob),
                    new MySqlParameter ("?ifchecked",p.ifChecked),
                    new MySqlParameter ("?jingshi",MySqlDbType.Double),
                    new MySqlParameter ("?remark",MySqlDbType.String),
                    new MySqlParameter ("?hospitalnumber",MySqlDbType.VarChar),
                };
                pas[0].Value = p.dateTime;
                pas[1].Value = p.picturePath;
                pas[2].Value = toolUnity.Tool.doubleToByte(p.receiveData);
                pas[3].Value = toolUnity.Tool.intToByte(p.sequence);
                pas[4].Value = toolUnity.Tool.pointToByte(p.coordinate);
                pas[6].Value = p.jingshi;
                pas[7].Value = p.remark;
                pas[8].Value = p.hostipalNumber;
                SQLHelper.ExecuteNonQuery(sql, CommandType.Text, pas);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public static DataTable getAllPatientsMessage()
        {
            string sql = "select * from patient";
            try
            {
                DataSet set = SQLHelper.GetDataSet(sql, CommandType.Text, null);
                return set.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public static DataTable getPatientByHospitalNumber(string hospitalnumber)
        {
            string sql = "select * from patient where hospitalnumber = ?hospitalnumber";
            MySqlParameter pas = new MySqlParameter("?hospitalnumber", MySqlDbType.VarChar);
            pas.Value = hospitalnumber;

            try
            {
                DataSet ds = SQLHelper.GetDataSet(sql, CommandType.Text, pas);
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public static DataTable getPatientsByParameters(QueryParameter queryParameter)
        {
            string sql = "select * from patient where 1 = 1 ";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(sql);
            List<MySqlParameter> pas = new List<MySqlParameter>();
            if (!String.IsNullOrEmpty(queryParameter.name))
            {
                stringBuilder.Append("and name = ?name ");
                MySqlParameter parameter = new MySqlParameter("?name", MySqlDbType.VarChar);
                parameter.Value = queryParameter.name;
                pas.Add(parameter);
            }
            if (!String.IsNullOrEmpty(queryParameter.hospitalNumber))
            {
                stringBuilder.Append("and hospitalnumber = ?hospitalnumber ");
                MySqlParameter parameter = new MySqlParameter("?hospitalnumber", MySqlDbType.VarChar);
                parameter.Value = queryParameter.hospitalNumber;
                pas.Add(parameter);
            }
            if (queryParameter.byTime)
            {
                stringBuilder.Append("and time between ?starttime and ?endtime ");
                MySqlParameter parameter1 = new MySqlParameter("?starttime", MySqlDbType.DateTime);
                parameter1.Value = queryParameter.startTime;
                MySqlParameter parameter2 = new MySqlParameter("?endtime", MySqlDbType.DateTime);
                parameter2.Value = queryParameter.endTime;
                pas.Add(parameter1);
                pas.Add(parameter2);
            }
            if(queryParameter.sorted)
            {
                stringBuilder.Append("order by time desc ");
            }
            sql = stringBuilder.ToString();
            try
            {
                DataSet ds = SQLHelper.GetDataSet(sql, CommandType.Text, pas.ToArray());
                return ds.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public static void deleteItem(string hospitalnumber)
        {
            string sql = "delete from patient where hospitalnumber='" + hospitalnumber + "'";
            try
            {
                SQLHelper.ExecuteNonQuery(sql, CommandType.Text, null);
            }
            catch
            {
                
            }
        }

        public static bool ifTableExist()
        {
            string sql = "select table_name from information_schema.tables where table_name = 'product_id'";
            try
            {
                MySqlDataReader reader = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
                if (reader.HasRows)
                    return true;
                else
                    return false;
            }
            catch
            {
                return true;
            }
        }

        public static void createTable()
        {
            string sql = "create table product_id ( id int(255) not null ); insert into product_id values(0)";
            try
            {
                SQLHelper.ExecuteNonQuery(sql, CommandType.Text, null);
            }
            catch
            {

            }
        }

        public static int getID()
        {
            string sql = "select id from product_id ";
            int id = 200;
            try
            {
                MySqlDataReader reader = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
                if (reader.HasRows)
                {
                    reader.Read();
                    id = int.Parse(reader["id"].ToString());
                    return id;
                }
                else
                    return id;
            }
            catch
            {
                return id;
            }
        }

        public static void setID(int id)
        {
            string sql = "update product_id set id = ?id";
            MySqlParameter pas = new MySqlParameter("?id", MySqlDbType.Int32);
            pas.Value = id;
            try
            {
                SQLHelper.ExecuteNonQuery(sql, CommandType.Text, pas);
            }
            catch
            {

            }
        }

        //public static bool ifBaseExist()
        //{
        //    bool temp = false;
        //    string sql = "SELECT DISTINCT t.table_name, n.SCHEMA_NAME FROM information_schema.TABLES t, information_schema.SCHEMATA n WHERE t.table_name = 'pet' AND n.SCHEMA_NAME = 'petdetector'";
        //    try
        //    {
        //        MySqlDataReader reader = SQLHelper.ExecuteReader(sql, CommandType.Text, null);
        //        if (reader.HasRows)
        //        {
        //            reader.Read();
        //            string a = reader["SCHEMA_NAME"].ToString();
        //            if (a.Trim() == "petdetector")
        //                temp = true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return temp;
        //}

//        public static void addDataBase()
//        {
//            //创建数据库
//            string cd = "Create Database If Not Exists `petdetector` Character Set UTF8;";
//            //checkposition数据结构
//            string a = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; DROP TABLE IF EXISTS `checkposition`;" + "CREATE TABLE `checkposition` (" + "`checkid` int(11) NOT NULL AUTO_INCREMENT," 
//                + "`checkname` varchar(255) DEFAULT NULL," + "PRIMARY KEY(`checkid`)) ENGINE = InnoDB AUTO_INCREMENT = 7 DEFAULT CHARSET = utf8; ";
//            //checkposition数值
//            string a1 = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; INSERT INTO `checkposition` VALUES('1', '头');" + "INSERT INTO `checkposition` VALUES('2', '左前肢'); " +"INSERT INTO `checkposition` VALUES('3', '右前肢'); " +
//            "INSERT INTO `checkposition` VALUES('4', '左后肢'); " +"INSERT INTO `checkposition` VALUES('5', '右后肢'); " +"INSERT INTO `checkposition` VALUES('6', '其它'); ";
//            //pet数值
//            string b = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; DROP TABLE IF EXISTS `pet`;" +
//            "CREATE TABLE `pet` (" +
// " `id` int(11) NOT NULL, " +
//  "`petname` varchar(255) DEFAULT NULL, " +
// " `pettype` int(255) NOT NULL, " +
// " `petsex` varchar(255) NOT NULL, " +
// " `petage` int(11) DEFAULT NULL, " +
// " `testlocation` int(255) NOT NULL, " +
// " `hostname` varchar(255) DEFAULT NULL, " +
// " `hostphone` varchar(255) DEFAULT NULL, " +
// " `doctorname` varchar(255) DEFAULT NULL, " +
// " `doctorphone` varchar(255) DEFAULT NULL, " +
// " `remark` varchar(255) DEFAULT NULL, " +
// " `ifchecked` tinyint(4) DEFAULT NULL, " +
// " `receivedata` blob, " +
// " `picturepath` varchar(255) DEFAULT NULL, " +
// " `time` datetime DEFAULT NULL, " +
// " PRIMARY KEY(`id`), " +
// " KEY `b` (`testlocation`)," +
// " KEY `a` (`pettype`)," +
// " CONSTRAINT `pet_ibfk_1` FOREIGN KEY (`pettype`) REFERENCES `pettype` (`typeid`)," +
// " CONSTRAINT `pet_ibfk_2` FOREIGN KEY (`testlocation`) REFERENCES `checkposition` (`checkid`)" +
//") ENGINE = InnoDB DEFAULT CHARSET = utf8; ";

//            //pettype数据结构
//            string c = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; DROP TABLE IF EXISTS `pettype`;CREATE TABLE `pettype` (`typeid` int(11) NOT NULL AUTO_INCREMENT,`typename` varchar(255) DEFAULT NULL,PRIMARY KEY(`typeid`)) ENGINE = InnoDB AUTO_INCREMENT = 4 DEFAULT CHARSET = utf8; ";
//            //pettype数值
//            string c1 = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; INSERT INTO `pettype` VALUES ('1', '狗');INSERT INTO `pettype` VALUES('2', '猫');INSERT INTO `pettype` VALUES('3', '其它'); ";
//            //user数据结构
//            string d = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; DROP TABLE IF EXISTS `user`;CREATE TABLE `user` (`id` int(11) NOT NULL AUTO_INCREMENT,`name` varchar(255) DEFAULT NULL,`password` varchar(255) DEFAULT NULL,PRIMARY KEY(`id`)) ENGINE = InnoDB AUTO_INCREMENT = 2 DEFAULT CHARSET = utf8; ";
//            //user数值
//            string d1 = "use `petdetector`; SET FOREIGN_KEY_CHECKS=0; INSERT INTO `user` VALUES('1', 'sa', '123456')";
//            try
//            {
//                SQLHelper.ExecuteNonQuery(cd, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(a, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(a1, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(b, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(c, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(c1, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(d, CommandType.Text, null);
//                SQLHelper.ExecuteNonQuery(d1, CommandType.Text, null);
//            }
//            catch(MySqlException e1)
//            {
//                throw e1;
//            }
//        }
    }
}
