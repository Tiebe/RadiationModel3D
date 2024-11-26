using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium160m";
        public override double halfLife { get; } = 18072.0d;
        public override double atomicWeight { get; } = 159.9288d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.762d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium160()), new(0.00082d, new GammaParticle(59980.0, 0.02067)), new(0.11785057638372001d, new GammaParticle(7656.0, 0.16194)), new(0.0004310833999104076d, new GammaParticle(46700.0, 0.02655)), new(0.0007677353515768613d, new GammaParticle(47547.0, 0.02608)), new(0.0002480413083434373d, new GammaParticle(53982.0, 0.02297)), new(0.000312532048512731d, new GammaParticle(54577.0, 0.02272)), new(6.44907401692937e-05d, new GammaParticle(55293.0, 0.02242)) } },
            { 0.23800000000000002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium160()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    