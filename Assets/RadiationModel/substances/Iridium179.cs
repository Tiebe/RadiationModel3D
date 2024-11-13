
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium179";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 178.95912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium179() } },

        };
    }
}
    
    