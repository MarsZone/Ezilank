package mainGodFrame.dataBase;
import java.sql.*;
public class ConnectToDB {
	public ConnectToDB() throws Exception
	{
		Class.forName("com.mysql.jdbc.Driver");
		String url="jdbc:mysql://127.0.0.1:3306/ezilank";
		Connection conn = DriverManager.getConnection(url,"root","3323656");
		if(conn!=null)
		{
			System.out.println("connection success!");
			conn.close();
		}
	}
}
