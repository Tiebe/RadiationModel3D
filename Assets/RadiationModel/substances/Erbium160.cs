using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium160";
        public override double halfLife { get; } = 102888.0d;
        public override double atomicWeight { get; } = 159.92908d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium160()), new(0.054299999999999994d, new GammaParticle(7133.0, 0.17382)), new(0.00082d, new GammaParticle(59980.0, 0.02067)), new(0.07d, new GammaParticle(108500.0, 0.01143)), new(0.29221433238372d, new GammaParticle(7656.0, 0.16194)), new(0.2111708131766145d, new GammaParticle(46700.0, 0.02655)), new(0.37608337164134376d, new GammaParticle(47547.0, 0.02608)), new(0.12150568728733471d, new GammaParticle(53982.0, 0.02297)), new(0.15309716598204173d, new GammaParticle(54577.0, 0.02272)), new(0.03159147869470703d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    