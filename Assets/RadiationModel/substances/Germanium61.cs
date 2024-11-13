
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium61";
        public override double halfLife { get; } = 0.0407d;
        public override double atomicWeight { get; } = 60.96372d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium61() } },

        };
    }
}
    
    