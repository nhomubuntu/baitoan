/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappybird;

import java.awt.Color;
import java.awt.Font;
import static java.awt.Font.BOLD;
import java.awt.Graphics;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JPanel;

/**
 *
 * @author Duong Thanh Hoang
 */
public class TapVe extends JPanel implements Runnable{
    
    public ConChim conchimT=new ConChim();
    public OngNuoc ongnuocT=new OngNuoc();
    public KiemTra kiemtraT=new KiemTra();
    public DiemSo diemsoT=new DiemSo();
    //public int getDiem=diemsoT.getDiem();
    public static boolean bl = false;
    
    public Thread threadT;
    
    public TapVe(){
        threadT= new Thread( this);
        threadT.start();//khi goi lenh nay se duoc chuyen den phuong thuc run() phia duoi
    }
    public void paint(Graphics g){
        //ve nen (background) cho game  
        g.setColor(Color.cyan);
        g.fillRect(0, 0,getWidth(),getHeight());
        //them ong nuoc vao nen game
        ongnuocT.paint(g);
        
        g.setColor(Color.green);
        g.fillRect(0, 400, getWidth(), getHeight());
        g.setColor(Color.orange);
        g.fillRect(0, 410, getWidth(), getHeight());
        conchimT.paint(g);
        
        g.setColor(Color.BLACK);//mau chu
        g.setFont(new Font("Arial",Font.BOLD,20)); //font, type, size
        g.drawString("Điểm:"+ diemsoT.getDiem() , 10, 20);
        
    }
  
    public void run(){
        //1 vong lap khong bao h dung
        while(true){
            repaint();//goi lai paint
            ongnuocT.giamX();//goi den phuong thuc cua class ongnuoc
            try {
                Thread.sleep(15);//chuong trinh dung lai 5 ms
            } catch (InterruptedException ex) {
                Logger.getLogger(TapVe.class.getName()).log(Level.SEVERE, null, ex);
            }
            
            ongnuocT.laplaiX();//goi den phuong thuc ....cua class ong nuoc
            conchimT.tangY();
            diemsoT.congdiem();
            if(kiemtraT.chet()==true){
                bl = true;
                repaint();
                threadT.stop();
            }
            //System.out.println(diemsoT.getDiem());
        }
    }
    
    
}
