
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium191 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium191";
        public override double halfLife { get; } = 588.0d;
        public override double atomicWeight { get; } = 190.96312d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium191() } },

        };
    }
}
    
    