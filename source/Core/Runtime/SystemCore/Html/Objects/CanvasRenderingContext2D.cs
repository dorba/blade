using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public abstract class CanvasRenderingContext2D  : ICanvasRenderingContext
    {
        private CanvasRenderingContext2D()
        {
        }

        [ScriptField]
        public double globalAlpha { get; set; }

        [ScriptField]
        public string globalCompositeOperation { get; set; }

        [ScriptField]
        public object fillStyle { get; set; }

        [ScriptField]
        public string font { get; set; }

        [ScriptField]
        public string lineCap { get; set; }

        [ScriptField]
        public string lineJoin { get; set; }

        [ScriptField]
        public double lineWidth { get; set; }

        [ScriptField]
        public int miterLimit { get; set; }

        [ScriptField]
        public double shadowBlur { get; set; }

        [ScriptField]
        public string shadowColor { get; set; }

        [ScriptField]
        public double shadowOffsetX { get; set; }

        [ScriptField]
        public double shadowOffsetY { get; set; }

        [ScriptField]
        public object strokeStyle { get; set; }

        [ScriptField]
        public string textAlign { get; set; }

        [ScriptField]
        public string textBaseline { get; set; }

        public abstract void arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise);

        public abstract void arcTo(double x1, double y1, double x2, double y2, double radius);

        public abstract void beginPath();

        public abstract void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y);

        public abstract void clearRect(double x, double y, double w, double h);

        public abstract void clip();

        public abstract void closePath();

        public abstract CanvasGradient createLinearGradient(double x0, double y0, double x1, double y1);

        public abstract CanvasGradient createRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1);

        public abstract ImageData createImageData(double sw, double sh);

        public abstract ImageData createImageData(ImageData imagedata);

        public abstract CanvasPattern createPattern(HTMLCanvasElement canvas, string repetition);

        public abstract CanvasPattern createPattern(HTMLImageElement image, string repetition);

        public abstract void drawImage(HTMLImageElement image, double dx, double dy);

        public abstract void drawImage(HTMLImageElement image, double dx, double dy, double dw, double dh);

        public abstract void drawImage(HTMLImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);

        public abstract void drawImage(HTMLCanvasElement image, double dx, double dy);

        public abstract void drawImage(HTMLCanvasElement image, double dx, double dy, double dw, double dh);

        public abstract void drawImage(HTMLCanvasElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh);

        public abstract void fill();

        public abstract void fillRect(double x, double y, double w, double h);

        public abstract void fillText(string text, double x, double y);

        public abstract void fillText(string text, double x, double y, double maxWidth);

        public abstract ImageData getImageData(double sx, double sy, double sw, double sh);

        public abstract bool isPointInPath(double x, double y);

        public abstract void lineTo(double x, double y);

        public abstract TextMetrics measureText(string text);

        public abstract void moveTo(double x, double y);

        public abstract void putImageData(ImageData imagedata, double dx, double dy);

        public abstract void putImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight);

        public abstract void quadraticCurveTo(double cpx, double cpy, double x, double y);

        public abstract void rect(double x, double y, double w, double h);

        public abstract void restore();

        public abstract void rotate(double angle);

        public abstract void save();

        public abstract void scale(double x, double y);

        public abstract void setTransform(double m11, double m12, double m21, double m22, double dx, double dy);

        public abstract void stroke();

        public abstract void strokeRect(double x, double y, double w, double h);

        public abstract void strokeText(string text, double x, double y);

        public abstract void strokeText(string text, double x, double y, double maxWidth);

        public abstract void transform(double m11, double m12, double m21, double m22, double dx, double dy);

        public abstract void translate(double x, double y);
    }
}
