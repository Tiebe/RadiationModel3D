
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury175 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury175";
        public override double halfLife { get; } = 0.0102d;
        public override double atomicWeight { get; } = 174.99144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Platinum171() } },

        };
    }
}
    
    