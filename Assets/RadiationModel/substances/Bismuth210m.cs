using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth210m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth210m";
        public override double halfLife { get; } = 95933054962759.69d;
        public override double atomicWeight { get; } = 209.98441d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium206()), new(1.0d, new AlphaParticle(6329702.09)), new(0.51d, new GammaParticle(265600.0, 0.00467)), new(0.2805d, new GammaParticle(304600.0, 0.00407)), new(0.0066300000000000005d, new GammaParticle(329600.0, 0.00376)), new(0.00714d, new GammaParticle(344300.0, 0.0036)), new(0.0066300000000000005d, new GammaParticle(368900.0, 0.00336)), new(5.61e-05d, new GammaParticle(384000.0, 0.00323)), new(0.00255d, new GammaParticle(535500.0, 0.00232)), new(0.00010200000000000001d, new GammaParticle(634300.0, 0.00195)), new(0.03417d, new GammaParticle(649600.0, 0.00191)), new(6.12e-05d, new GammaParticle(686000.0, 0.00181)), new(0.056832758600923586d, new GammaParticle(12148.0, 0.10206)), new(0.03819374875272903d, new GammaParticle(70832.0, 0.0175)), new(0.06447290471426237d, new GammaParticle(72874.0, 0.01701)), new(0.021926494225409886d, new GammaParticle(82629.0, 0.015)), new(0.02843866301035662d, new GammaParticle(83631.0, 0.01483)), new(0.0065121687849467366d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    