
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium45";
        public override double halfLife { get; } = 14049504.0d;
        public override double atomicWeight { get; } = 44.95619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium45() } },

        };
    }
}
    
    