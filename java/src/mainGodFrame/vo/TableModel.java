package mainGodFrame.vo;

import javax.swing.AbstractAction;
import javax.swing.JOptionPane;
import javax.swing.table.AbstractTableModel;

import mainGodFrame.ViewPanel;

import java.sql.*;
public  class TableModel extends AbstractTableModel{
	final String[] columnNames={"ID","Name","Level","Alive"};
	final Object[][] data={
			{"1001","撒必死",new Integer(20),new Boolean(true)},
			{"1002","时空猎人",new Integer(16),new Boolean(false)},
			{"1003","水雷",new Integer(11),new Boolean(false)}
	};
	public TableModel( )
	{
		
	}
	public int getColumnCount()
	{
		return columnNames.length;
	}
	
	public int getRowCount()
	{
		return data.length;
	}
	
	public String getColumnName(int col)
	{
		return columnNames[col];
	}
	
	public Class getColumnClass(int c)
	{
		return getValueAt(0,c).getClass();
	}
	
	@Override
	public Object getValueAt(int row, int col) {
		// TODO Auto-generated method stub
		return data[row][col];
	}
	
	public boolean isCellEditable(int row,int col)
	{
		if(col<2)
		{
			return false;
		}else
		{
			return true;
		}
	}
	
	public void setValueAt(Object value,int row, int col)
	{
		if(data[0][col] instanceof Integer && !(value instanceof Integer))
		{
			try{
			data[row][col]=new Integer(value.toString());
			fireTableCellUpdated(row, col);
			}catch(NumberFormatException e){
				JOptionPane.showMessageDialog(null, "The \"" + getColumnName(col)+"\"本列只接受整形数据");
			}
		}else{
			data[row][col]=value;
			fireTableCellUpdated(row, col);
		}
	}
}
