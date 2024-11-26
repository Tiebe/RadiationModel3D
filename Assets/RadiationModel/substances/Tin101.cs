using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin101 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin101";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 100.93525d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium101()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.26d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium100()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    