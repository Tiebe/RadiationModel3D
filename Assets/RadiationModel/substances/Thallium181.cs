
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium181 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium181";
        public override double halfLife { get; } = 2.9d;
        public override double atomicWeight { get; } = 180.98626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.086d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gold177() } },

        };
    }
}
    
    