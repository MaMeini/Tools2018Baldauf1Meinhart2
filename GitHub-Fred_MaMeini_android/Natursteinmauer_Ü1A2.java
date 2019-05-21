
public class Natursteinmauer_Ü1A2 {

	public static void main(String[] args) {

		Out.print("Abmessungen Segment (l, h1, h2 - in cm): ");

		int l = In.readInt();
		int h1 = In.readInt();
		int h2 = In.readInt();
		int Acm = l * h1 - ((h1-h2) * l / 200);
		int Am = Acm / 10000;
		Out.println("---- Kosten für das Segment ----");
		Out.println("wowow”);
		Out.println("Länge: " + l + " cm, Mittlere Höhe: " + (h1+h2)/2 + " cm");
		Out.println("Fläche: " + Am + "."+((Acm+50)%10000)/100 +" m2");
		Out.println("Preis für das Segment: " + Acm * 96/10000 + "."+Acm*96%10000/1000 + Acm*96%1000/100+" EUR");

		public void thisIsANewMethod(){
				Out.println("wow")
		    int ex = -3;
		    Out.println("Manfred du “ + ex);
				String i = "fetter Bugfix";
		 }

=======


>>>>>>> 7d06b63e52b6c870b56f372b40c1c8a9e65a9938
	}

}
