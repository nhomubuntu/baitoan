/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flappybird;

/**
 *
 * @author Duong Thanh Hoang
 */
public class KiemTra {
    
    private ConChim conchimK=new ConChim();
    private OngNuoc ongnuocK= new OngNuoc();
    
    public boolean chet(){
        //khi con chim cham dat
        if(conchimK.gety() +45>=400){
            return true;
        }
        //Khi con chim cham ong nuoc 1
        if(conchimK.gety() <= ongnuocK.getH1()&&(((conchimK.getX()+45) >= ongnuocK.getX1()))&&conchimK.getX() <= (ongnuocK.getX1()+65)){
        return true;
        }
        if((conchimK.gety()+45) >=(ongnuocK.getH1() +100)&&((conchimK.getX()+45)>=ongnuocK.getX1()&&conchimK.getX()<=(ongnuocK.getX1() +65))){
            return true;
        }
        
        //-----------------------
        if(conchimK.gety() <= ongnuocK.getH2()&&(((conchimK.getX()+45) >= ongnuocK.getX2()))&&conchimK.getX() <= (ongnuocK.getX2()+65)){
        return true;
        }
        if((conchimK.gety()+45) >=(ongnuocK.getH2() +100)&&((conchimK.getX()+45)>=ongnuocK.getX2()&&conchimK.getX()<=(ongnuocK.getX2() +65))){
            return true;
        }
        //----------------------------
        if(conchimK.gety() <= ongnuocK.getH3()&&(((conchimK.getX()+45) >= ongnuocK.getX3()))&&conchimK.getX() <= (ongnuocK.getX3()+65)){
        return true;
        }
        if((conchimK.gety()+45) >=(ongnuocK.getH3() +100)&&((conchimK.getX()+45)>=ongnuocK.getX3()&&conchimK.getX()<=(ongnuocK.getX3() +65))){
            return true;
        }
        //---------------------------------
        if(conchimK.gety() <= ongnuocK.getH4()&&(((conchimK.getX()+45) >= ongnuocK.getX4()))&&conchimK.getX() <= (ongnuocK.getX4()+65)){
        return true;
        }
        if((conchimK.gety()+45) >=(ongnuocK.getH4() +100)&&((conchimK.getX()+45)>=ongnuocK.getX4()&&conchimK.getX()<=(ongnuocK.getX4() +65))){
            return true;
        }
    return false;
    }
}
