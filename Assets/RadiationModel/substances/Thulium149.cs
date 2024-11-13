
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium149";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 148.95283d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Erbium149() } },

        };
    }
}
    
    