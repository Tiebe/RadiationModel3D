using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium204";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 204.00651d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8658002.09), new Radon200() } },

        };
    }
}
    
    