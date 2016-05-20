public class Rectangle {

    private float length;
    private float width;

    public Rectangle(float l = 1, float w = 1) {
        Length = l;
        Width = w;
    }

    public float Length {
        get {
            return length;
        }
        set {
            if (value > 0.0 && value < 20.0) {
                length = value;
            }
        }
    }

    public float Width {
        get {
            return width;
        }
        set {
            if (value > 0.0 && value < 20.0) {
                width = value;
            }
        }
    }

    public float Perimeter {
        get {
            return 2 * (Length + Width);
        }
    }

    public float Area {
        get {
            return Length * Width;
        }
    }

}