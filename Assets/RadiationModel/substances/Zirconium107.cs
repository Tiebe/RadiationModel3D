using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium107";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 106.94201d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium107()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.23d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium107()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    