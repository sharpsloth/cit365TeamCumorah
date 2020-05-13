using System;

namespace MegaDesk_Mendenhall
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    class Desk
    {
//        private int width;
//        private int depth;
//        private int drawers;
        //      private string material;
        public DesktopMaterial material;

//        private int area;
        protected int MIN_WIDTH { get; set; } = 24;
        protected int MAX_WIDTH { get; set; } = 96;
        protected int MIN_DEPTH { get; set; } = 12;
        protected int MAX_DEPTH { get; set; } = 48;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        //        public string Material { get { return material; } set { material = value; } }
        //        public DesktopMaterial Material; 

        public int Area { get; set; }

        public Desk(int depth, int width, int drawers, string material)
        {
            this.Width = width;
            this.Depth = depth;
            this.Drawers = drawers;
            //            this.material = material;
            this.material = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), material);
            this.Area = CalcArea();

        }

        public bool CheckWidth()
        {
            if (this.Width >= MIN_WIDTH && this.Width <= MAX_WIDTH)
            {
                return true;
            }
            else { return false; }
        }

        public bool CheckDepth()
        {
            if (this.Depth >= MIN_DEPTH && this.Depth <= MAX_DEPTH)
            {
                return true;
            }
            else { return false; }
        }

        public int CalcArea()
        {
            int area = this.Width * this.Depth;
            return area;
        }
    }
}
