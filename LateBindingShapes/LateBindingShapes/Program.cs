using System;
using System.Collections.Generic;
namespace LateBindingShapes
{
	public class Shapes{
		public virtual void Draw(){
			Console.WriteLine("from base class");
		}
	}
	class Circle:Shapes{
		public override void Draw ()
		{
			Console.WriteLine ("Drawing Circle");
			base.Draw ();
		}
	}
	class Rectangle:Shapes{
		public override void Draw ()
		{
			Console.WriteLine ("Drawing Rectangle");
			base.Draw ();
		}
	}
	class Triangle:Shapes{
		public override void Draw ()
		{
			Console.WriteLine ("Drawing Triangle");
			base.Draw ();
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Shapes> shapes = new List<Shapes> ();
			shapes.Add (new Circle ());
			shapes.Add (new Rectangle ());
			shapes.Add (new Triangle ());

			foreach(Shapes shape in shapes)
			{
				shape.Draw ();
			}
		}
	}
}
