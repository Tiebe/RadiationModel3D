
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth189 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth189";
        public override double halfLife { get; } = 0.688d;
        public override double atomicWeight { get; } = 188.98919d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium185() } },

        };
    }
}
    
    