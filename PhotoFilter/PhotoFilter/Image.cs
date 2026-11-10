using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PhotoFilter
{
    // Base Image class to store image properties
    internal class Image
    {
        // Basic properties with default neutral values
        public double Brightness { get; set; } = 0.5;
        public double Contrast { get; set; } = 0.5;
        public double Saturation { get; set; } = 0.5;

        // Helper methods for creating test images
        public static Image CreateDarkImage() =>
          new Image { Brightness = 0.1 };

        public static Image CreateBrightImage() =>
          new Image { Brightness = 0.9 };

        // Override ToString for testing output
        public override string ToString() =>
          $"Image[B:{Brightness:F2}, C:{Contrast:F2}, S:{Saturation:F2}]";

        // Task 1: Basic expression-bodied method
        public Image CreateBrighterVersion() => this.AddBrightness(Brightness * 0.2);

        // Task 2: Method chaining with multiple adjustments
        public Image AddBrightness(double brightAmount) =>
          new Image
          {
              Brightness = this.Brightness + brightAmount,
              Contrast = this.Contrast,
              Saturation = this.Saturation
          };

        public Image AddSaturation(double satAmount) =>
          new Image
          {
              Brightness = this.Brightness,
              Contrast = this.Contrast,
              Saturation = this.Saturation + satAmount
          };

        public Image BrightenThenSaturate(double brightAmount, double satAmount) => AddBrightness(brightAmount).AddSaturation(satAmount);

        public Image TransformBrightness(Func<double, double> transformation) => new Image { Brightness = transformation(Brightness) };
    }
}
