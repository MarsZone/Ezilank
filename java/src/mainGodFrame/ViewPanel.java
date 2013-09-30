package mainGodFrame;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.FlowLayout;

import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import mainGodFrame.dataBase.ConnectToDB;
import mainGodFrame.vo.*;

public class ViewPanel extends JPanel{
	
	public ViewPanel()
	{
		this.setLayout(new FlowLayout());
		
		try {
			new ConnectToDB();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		TableModel model=new TableModel();
		JTable table=new JTable(model);
		table.setPreferredScrollableViewportSize(new Dimension(400,200));
		JScrollPane scrollPanel=new JScrollPane(table);
		add(scrollPanel,BorderLayout.CENTER);
//		JButton button=new JButton("Test");
//		this.add(button);
	}
}
