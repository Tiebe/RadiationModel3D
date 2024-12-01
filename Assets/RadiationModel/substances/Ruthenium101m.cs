using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ruthenium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium101m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 100.90614d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium101()), new(0.827064d, new GammaParticle(220700.0, 0.00562)), new(0.9845999999999999d, new GammaParticle(306600.0, 0.00404)), new(0.00788953658868d, new GammaParticle(2737.0, 0.45299)), new(0.034967560426921646d, new GammaParticle(19150.0, 0.06474)), new(0.06635210707195757d, new GammaParticle(19279.0, 0.06431)), new(0.01783121514932943d, new GammaParticle(21736.0, 0.05704)), new(0.0207198720035208d, new GammaParticle(21875.0, 0.05668)), new(0.0028886568541913677d, new GammaParticle(22072.0, 0.05617)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    