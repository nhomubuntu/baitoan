/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappybird;

import java.awt.Color;
import java.awt.Graphics;
import javax.swing.JPanel;

/**
 *
 * @author Duong Thanh Hoang
 */
public class ConChim extends JPanel{
    private static int y=200;
     private static int x=100;
     
     //lay ra gia tri y
    public static int gety(){
        return y;
    }
     public static int getx(){
        return x;
    }
     
     
     
     
    public void paint(Graphics g){
        g.setColor(Color.red);
        g.fillRect(x, y, 45, 45);
        
    }
    
    //con chim roi xuong dat
    public void tangY(){
        y++;
    }
    //con chim bay len troi
    public void giamY(){
        //y--;
        y-=30;
    }
}   
    

