using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum156 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum156";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 155.97209d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.71d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium155()), new(1.0d, new ProtonParticle()) } },
            { 0.29d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    