
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium203 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium203";
        public override double halfLife { get; } = 0.55d;
        public override double atomicWeight { get; } = 203.00094d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine199() } },

        };
    }
}
    
    