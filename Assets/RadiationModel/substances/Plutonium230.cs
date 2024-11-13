
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium230";
        public override double halfLife { get; } = 105.0d;
        public override double atomicWeight { get; } = 230.03965d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Uranium226() } },

        };
    }
}
    
    