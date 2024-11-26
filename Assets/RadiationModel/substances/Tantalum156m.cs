using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum156m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum156m";
        public override double halfLife { get; } = 0.36d;
        public override double atomicWeight { get; } = 155.97218d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.958d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium156()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.042d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium155()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    