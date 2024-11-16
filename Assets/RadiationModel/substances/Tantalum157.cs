using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum157 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157";
        public override double halfLife { get; } = 0.0101d;
        public override double atomicWeight { get; } = 156.96822d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.966d, new List<RadioactiveSubstance> { new AlphaParticle(7377002.09), new Lutetium153() } },
            { 0.034d, new List<RadioactiveSubstance> { new ProtonParticle(), new Hafnium156() } },

        };
    }
}
    
    