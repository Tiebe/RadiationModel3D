using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium48 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium48";
        public override double halfLife { get; } = 9.15150853263168e+26d;
        public override double atomicWeight { get; } = 47.95252d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium48()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.74d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Titanium48()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium48()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    