using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187m";
        public override double halfLife { get; } = 15.6d;
        public override double atomicWeight { get; } = 186.97626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0015d, new List<RadioactiveSubstance> { new AlphaParticle(6677002.09), new Gold183() } },

        };
    }
}
    
    