
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium102";
        public override double halfLife { get; } = 5.28d;
        public override double atomicWeight { get; } = 101.90921d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium102() } },

        };
    }
}
    
    