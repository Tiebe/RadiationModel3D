using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium159m";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 158.92794d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium159()), new(2.394e-06d, new GammaParticle(39500.0, 0.03139)), new(0.052268999999999996d, new GammaParticle(166000.0, 0.00747)), new(0.39899999999999997d, new GammaParticle(205900.0, 0.00602)), new(0.098040934896786d, new GammaParticle(7656.0, 0.16194)), new(0.05360043328698274d, new GammaParticle(46700.0, 0.02655)), new(0.09545936471412776d, new GammaParticle(47547.0, 0.02608)), new(0.030841182014991676d, new GammaParticle(53982.0, 0.02297)), new(0.038859889338889515d, new GammaParticle(54577.0, 0.02272)), new(0.008018707323897836d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    