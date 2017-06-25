/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappybird;

import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JFrame;

/**
 *
 * @author Duong Thanh Hoang
 */
public class ManHinh extends JFrame{
    
    private TapVe tapveM =new TapVe();
    private ConChim conchimM =new ConChim(); 
    public ManHinh(){
        setSize(500, 500);
        setVisible(true);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocation(400, 100);
        //setResizable(false);
        add(tapveM);
        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent ke) {
                if (conchimM.getY() >= 0) {
                    conchimM.giamY();
                }
            }         
});
        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent me) {
                //khi click chuot se lam gi?
                if (conchimM.getY() >= 0) {
                    conchimM.giamY();
                }
            }      
        });
        
    }
    public static void main(String[] args){
        ManHinh mh=new ManHinh();
    }
    
}
