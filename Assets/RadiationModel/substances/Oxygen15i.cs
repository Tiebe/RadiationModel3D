using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Oxygen15i : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen15i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.01505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Nitrogen14() } },

        };
    }
}
    
    