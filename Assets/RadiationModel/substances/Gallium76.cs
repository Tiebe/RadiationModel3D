
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium76 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium76";
        public override double halfLife { get; } = 30.6d;
        public override double atomicWeight { get; } = 75.92883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Germanium76() } },

        };
    }
}
    
    