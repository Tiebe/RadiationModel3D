
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium69 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium69";
        public override double halfLife { get; } = 140580.0d;
        public override double atomicWeight { get; } = 68.92796d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium69() } },

        };
    }
}
    
    