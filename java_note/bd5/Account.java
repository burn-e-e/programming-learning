package bd5;

import OOP.Getters_Setters;

abstract class Account implements B, C {
     private int id;
     private double remaining;
     private double PRT;

     Account(int id, int remaining) {
          this.id = id;
          this.remaining = remaining;
     }
     public double getRemaining() {
          return remaining;
     }
     public void setRemaining(Double remaining) {
          this.remaining = remaining;
     }
     public abstract void calculateInterest();
     public double getPRT() {
          return PRT;
     }
}
