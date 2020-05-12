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
        private int width;
        private int depth;
        private int drawers;
        //      private string material;
        public DesktopMaterial material;

        private int area;
        protected int MIN_WIDTH { get; set; } = 24;
        protected int MAX_WIDTH { get; set; } = 96;
        protected int MIN_DEPTH { get; set; } = 12;
        protected int MAX_DEPTH { get; set; } = 48;

        public int Width { get { return width; } set { width = value; } }
        public int Depth { get { return depth; } set { depth = value; } }
        public int Drawers { get { return drawers; } set { drawers = value; } }
        //        public string Material { get { return material; } set { material = value; } }
        //        public DesktopMaterial Material; 

        public int Area { get { return area; } set { area = value; } }

        public Desk(int depth, int width, int drawers, string material)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            //            this.material = material;
            this.material = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), material);
            this.area = CalcArea();

        }

        public bool CheckWidth()
        {
            if (this.width >= MIN_WIDTH && this.width <= MAX_WIDTH)
            {
                return true;
            }
            else { return false; }
        }

        public bool CheckDepth()
        {
            if (this.depth >= MIN_DEPTH && this.depth <= MAX_DEPTH)
            {
                return true;
            }
            else { return false; }
        }

        public int CalcArea()
        {
            int area = this.width * this.depth;
            return area;
        }
    }
}
