
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium268";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 268.13865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bohrium264() } },

        };
    }
}
    
    