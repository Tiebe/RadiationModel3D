
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus30 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus30";
        public override double halfLife { get; } = 150.0d;
        public override double atomicWeight { get; } = 29.97831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon30() } },

        };
    }
}
    
    