using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium170";
        public override double halfLife { get; } = 7.37d;
        public override double atomicWeight { get; } = 169.96358d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.905d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten170()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.095d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten166()), new(1.0d, new AlphaParticle(6558002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    