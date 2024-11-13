
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium254";
        public override double halfLife { get; } = 23820480.0d;
        public override double atomicWeight { get; } = 254.08802d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Berkelium250() } },

            { 1.74e-06d, new List<RadioactiveSubstance> { new BetaParticle(), new Fermium254() } },

            { 3.0000000000000004e-08d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    