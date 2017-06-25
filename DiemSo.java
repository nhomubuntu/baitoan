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
public class DiemSo {
    public static int diem=0;
    public ConChim conchimD=new ConChim();
    public OngNuoc ongnuocD=new OngNuoc();
    private static boolean bl1 = false;
    private static boolean bl2 = false;
    private static boolean bl3 = false;
    private static boolean bl4 = false;
    
    public int getDiem(){
        return diem;
    }
    
    //cong diem khi qua moi ong nuoc
    public void congdiem(){
        //------------
        //diem++;
        if(conchimD.getX()+45 > ongnuocD.getX1() && conchimD.getX()<ongnuocD.getX1()+65){
            bl1 =true;
        }
        if(bl1 == true &&conchimD.getX()>ongnuocD.getX1()+65)
        {
            diem++;
            bl1 = false;
        }
        //-----------------
        if(conchimD.getX()+45 > ongnuocD.getX2() && conchimD.getX()<ongnuocD.getX2()+65){
            bl2 =true;
        }
        if(bl2 == true &&conchimD.getX()>ongnuocD.getX2()+65)
        {
            diem++;
            bl2 = false;
        }
        //-----------------
        if(conchimD.getX()+45 > ongnuocD.getX3() && conchimD.getX()<ongnuocD.getX3()+65){
            bl3 =true;
        }
        if(bl3 == true &&conchimD.getX()>ongnuocD.getX3()+65)
        {
            diem++;
            bl3 = false;
        }
        //------------------
        if(conchimD.getX()+45 > ongnuocD.getX4() && conchimD.getX()<ongnuocD.getX4()+65){
            bl4 =true;
        }
        if(bl4 == true &&conchimD.getX()>ongnuocD.getX4()+65)
        {
            diem++;
            bl4 = false;
        }
    }
}
