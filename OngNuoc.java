/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappybird;

import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;
import javax.swing.JPanel;

/**
 *
 * @author Duong Thanh Hoang
 */
public class OngNuoc extends JPanel{
    
    public static int x1 = 500, x2 = x1 + 140, x3 = x2 + 140, x4 = x3 + 140;
    public static int h1,h2,h3,h4;
    public static boolean bl1=false;
    public static boolean bl2=false;
    public static boolean bl3=false;
    public static boolean bl4=false;

    public  int getX1() {
        return x1;
    }

    public  int getX2() {
        return x2;
    }

    public  int getX3() {
        return x3;
    }

    public int getX4() {
        return x4;
    }

    public int getH1() {
        return h1;
    }

    public int getH2() {
        return h2;
    }

    public int getH3() {
        return h3;
    }

    public int getH4() {
        return h4;
    }
    
    
    
    // chieu dai ngau nhien cua mot ong nuoc
    public void ngaunhienH(){
         Random rd=new Random();
         if(bl1==false){
            h1=rd.nextInt(200);//h1 se bang mot so ngau nhien tu 0-199
            bl1=true;
         }
        if(bl2==false){
            h2=rd.nextInt(200);//h1 se bang mot so ngau nhien tu 0-199
            bl2=true;
        }
        if(bl3==false){
            h3=rd.nextInt(200);//h1 se bang mot so ngau nhien tu 0-199
            bl3=true;
        }
        if(bl4==false){
            h4=rd.nextInt(200);//h1 se bang mot so ngau nhien tu 0-199
            bl4=true;
        }
    }
    public void paint(Graphics g){
        
       ngaunhienH();
        
        //ong nuoc phia tren
        g.setColor(Color.green);
        g.fillRect(x1, 0, 65, h1);
        //ong nuoc phia duoi
        g.setColor(Color.green);
        g.fillRect(x1, h1+100, 45, 500);
        //ong nuoc phia tren
        g.setColor(Color.green);
        g.fillRect(x2, 0, 65, h2);
        //ong nuoc phia duoi
        g.setColor(Color.green);
        g.fillRect(x2, h2+100, 45, 500);
        //ong nuoc phia tren
        g.setColor(Color.green);
        g.fillRect(x3, 0, 65, h3);
        //ong nuoc phia duoi
        g.setColor(Color.green);
        g.fillRect(x3, h3+100, 45, 500);
        //ong nuoc phia tren
        g.setColor(Color.green);
        g.fillRect(x4, 0, 65, h4);
        //ong nuoc phia duoi
        g.setColor(Color.green);
        g.fillRect(x4, h4+100, 45, 500);
    }
    public void giamX(){
        //x=x-1;
        x1--;
        x2--;
        x3--;
        x4--;
    }
    public void laplaiX(){
        if(x1 == -65){
            x1 =500;
            bl1=false;
        }
        if(x2 == -65){
            x2 =500;
            bl2=false;
        }
        if(x3 == -65){
            x3 =500;
            bl3=false;
        }
        if(x4 == -65){
            x4 =500;
            bl4=false;
        }
        
    }
}
