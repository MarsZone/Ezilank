package mainGodFrame;

import javax.swing.JFrame;
import javax.swing.UIManager;

import mainGodFrame.dataBase.ConnectToDB;
import mainGodFrame.vo.FrameConfig;

import java.awt.*;
import java.awt.event.*;


public class MainFrame extends JFrame{
	private ViewPanel vp;
	public  MainFrame()
	{
		super("MainFrame.");
		vp=new ViewPanel();
		Container c=this.getContentPane();
		c.add(vp);
		addWindowListener(new WindowAdapter(){
			public void windowClosing(WindowEvent e)
			{
				System.exit(0);
			}
		});
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setSize(FrameConfig.FrameWidth, FrameConfig.FrameHeight);
		this.setVisible(true);
		this.setLocationRelativeTo(null);
	}
	public static void main(String[] args)
	{
		try{
			UIManager.setLookAndFeel(UIManager.getCrossPlatformLookAndFeelClassName());
		}catch(Exception e){
			e.printStackTrace();
		}
		MainFrame mf=new MainFrame();
		
	}
}

